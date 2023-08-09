using BSMS.Winforms.GenericUtils;
using DevExpress.XtraBars;
using System.Data;
using BeautyHall.Api.SDK.Responses;
using BSMS;
using BSMS.Winforms.Models;
using BeautyHall.Api.SDK.Requests;
using DevExpress.XtraEditors;
using DevExpress.XtraReports.Native;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace BSMS.Winforms.Forms
{
    public partial class ProductForm : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        private IEnumerable<Product>? products;
        public ProductForm()
        {
            InitializeComponent();
        }

        private void EnableProductButtons(bool enable)
        {
            ProductHeaderPanel.Enabled = enable;
            barCancelProduct.Enabled = enable;
            barDeleteProduct.Enabled = enable;
            barSaveProduct.Enabled = enable;
            barExitForm.Enabled = enable;
        }
    
        private async void ProductForm_Load(object sender, EventArgs e)
        {
            EnableProductButtons(false);
            try
            {
                dateEdit1.DateTime = DateTime.Now;
                await LoadProducts();
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private async Task LoadProducts()
        {
            try
            {
                products = await Program.ApiSdk.GetAllProducts();
                if (products != null)
                {
                    var product = products.Where(x => x.ProductId == 0).Select(x => new Product
                    {
                        ProductId = x.ProductId,
                        ProductCode = x.ProductCode,
                        ProductDescription = x.ProductDescription,
                        SellingPrice = x.SellingPrice,
                        Supplier = x.Supplier
                    });

                    gridControl1.DataSource = product;
                }
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.Message);
            }
        }

        private void barAddProduct_ItemClick(object sender, ItemClickEventArgs e)
        {
            Clear();
            EnableProductButtons(true);
        }

        private void Clear()
        {
           txtproductId.Text = "";
           txtProductCode.Text = "";
           txtProductPrice.Text = "";
           txtSupplier.Text = "";
           luaProductTitle.Text = "";
           dateEdit1.DateTime = DateTime.Now;
        }

        private async Task<bool> InsertNewProduct()
        {
            try
            {
                
                var productsId = Functions.NullToInt(txtproductId.EditValue);
                var sellingPrice = Functions.NullToDecimal(txtProductPrice.EditValue);
                var input = new ProductDto {
                        //ProductId = productsId,
                        ProductDescription = luaProductTitle.Text,
                        ProductCode = txtProductCode.Text,
                        SellingPrice = sellingPrice
                };
                bool result = await Program.ApiSdk.UpsertProduct(input);

                if (result)
                {
                    XtraMessageBox.Show(productsId == 0 ? "New product is register!" : "Product updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return true;
                }
                else
                {
                    XtraMessageBox.Show("Error durig registration.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return false;
        }
        
    }
}