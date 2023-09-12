using DevExpress.XtraBars;
using BeautyHall.Api.SDK.Responses;
using DevExpress.XtraEditors;
using BeautyHall.Api.SDK.Requests;
using BeautyHall.Api.SDK.Interfaces;
using DevExpress.Utils.Frames;
using System.Security.Cryptography.X509Certificates;
using BSMS.Winforms.Models;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Menu;

namespace BSMS.Winforms.Forms
{
    public partial class StockProductForm : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        private readonly IBeautyHallApiSDK _apiSdk;

        public IEnumerable<Product> products; // Add a property to store products
        public int selectedProductId; // Add a property to store the selected product ID
        public StockProductForm()
        {
            InitializeComponent();
        }

        private void barExitbtn_ItemClick(object sender, ItemClickEventArgs e)
        {
            this.Close();
        }

        private async void StockProduct_Load(object sender, EventArgs e)
        {
            //await LoadStocks();
            await LoadProducts();
        }

        private async Task LoadStocks()
        {
            try
            {
                products = await Program.ApiSdk.GetAllProducts();
                gridControl1.DataSource = products;
                gridControl1.Refresh(); // Ensure the grid updates its display
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async Task LoadProducts()
        {


            try
            {
                products = await Program.ApiSdk.GetAllProducts();


                {

                    if (products != null)
                    {
                        var product = products.Where(x => x.ProductId == 0).Select(x => new Product
                        {
                            ProductId = x.ProductId,
                            ProductDescription = x.ProductDescription,
                            ProductCode = x.ProductCode,
                            Stock = x.Stock
                        });
                        lookUpEdit1.Properties.DataSource = products;
                        lookUpEdit1.Properties.DisplayMember = "ProductDescription"; // Adjust property name as needed
                        lookUpEdit1.Properties.ValueMember = "ProductId";
                    }

                    gridControl1.DataSource = products;
                    gridView1.RefreshData();
                }
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.Message);
            }
        }


        private async void barButtonItem2_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (await InsertOrUpdateStock())
            {
                ClearUserControls();
                await LoadProducts();
            }
        }

        private async Task<bool> InsertOrUpdateStock()
        {
            try
            {
                // Retrieve the selected product and quantity from your controls
                int productId = GetSelectedProductId(); // Implement this method
                int quantity = GetQuantity(); // Implement this method

                // Call your API or service to insert/update stock
                bool result = await Program.ApiSdk.UpsertStock(new StockDto
                {
                    ProductId = productId,
                    Quantity = quantity
                });

                if (result)
                {
                    // Stock update was successful
                    MessageBox.Show("Stock updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return true;
                }
                else
                {
                    // Stock update failed
                    MessageBox.Show("Error during stock update.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return false;

        }

        private void lookUpEdit1_EditValueChanged(object sender, EventArgs e)
        {
            selectedProductId = (int)lookUpEdit1.EditValue;
            if (products != null)
            {
                // Assuming grOrders is the name of your GridView control
                gridControl1.DataSource = products;
                var selectedProduct = products?.FirstOrDefault(x => x.ProductId == selectedProductId);
                if (selectedProduct != null)
                {
                    Text = $"{selectedProduct.ProductDescription} {selectedProduct.ProductDescription} |";
                    textEdit1.EditValue = selectedProduct.ProductId.ToString();
                    textEdit3.EditValue = selectedProduct.ProductCode;
                    txtStock.EditValue = selectedProduct.Stock.Quantity.ToString();
                }
            }
        }
        private int GetSelectedProductId()
        {
            // Get the selected product ID from the lookUpEdit control
            if (lookUpEdit1.EditValue != null && int.TryParse(lookUpEdit1.EditValue.ToString(), out int selectedProductId))
            {
                return selectedProductId;
            }

            // If no product is selected or the selection is invalid, return a default value or handle it as needed.
            return -1; // You can change this default value according to your requirements.
        }


        private int GetQuantity()
        {
            int quantity = 0; // Default quantity value

            // Assuming you have a control named quantityTextEdit for input
            if (int.TryParse(textEdit2.Text, out int parsedQuantity))
            {
                quantity = parsedQuantity; // Use the parsed quantity if parsing is successful
            }
            else
            {
                // Handle the case where parsing fails, e.g., show an error message or set a default value.
                // You can also throw an exception if needed.
            }

            return quantity;
        }

        private void ClearUserControls()
        {
            // Clear or reset your user controls here
            textEdit1.EditValue = null;
            textEdit2.EditValue = null;
            textEdit3.EditValue = null;
            txtStock.EditValue = null;
            // Clear any other controls as needed
        }

        // Implement method to load the updated list of products


    }
}