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
using DevExpress.Utils;

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
                    gridControl1.DataSource = products;
                    gridView1.RefreshData();


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
                var input = new ProductDto

                {
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

        private async void barSaveProduct_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (await InsertNewProduct())
            {
                // Clear all the user controls and disable
                Clear();
                // EnableProductButtons(false);
                await LoadProducts();
            }
        }

        private void gridView1_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            var selected = gridView1.GetSelectedRows();
            if (selected != null && selected.Any())
            {
                var selectedProduct = products?.ElementAt(selected[0]);
                if (selectedProduct != null)
                {
                    txtproductId.EditValue = selectedProduct.ProductId;
                    luaProductTitle.EditValue = selectedProduct.ProductDescription;
                    txtSupplier.EditValue = selectedProduct.SupplierId;
                    txtProductCode.EditValue = selectedProduct.ProductCode;
                    txtProductPrice.EditValue = selectedProduct.SellingPrice;
                    txtStock.EditValue = selectedProduct.Stock.Quantity;

                    EnableProductButtons(true);
                }
            }
        }

        private void barExitForm_ItemClick(object sender, ItemClickEventArgs e) => this.Close();

        private async Task<bool> DeleteProduct(Product selectedProduct)
        {
            try
            {
                if (products != null)
                {
                    if (await Program.ApiSdk.DeleteProduct(selectedProduct.ProductId))
                    {
                        XtraMessageBox.Show("Product removed successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return true;
                    }
                    else
                    {
                        XtraMessageBox.Show("Error during cancellation.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    XtraMessageBox.Show("No product selected.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return false;
        }

        private async void barDeleteProduct_ItemClick(object sender, ItemClickEventArgs e)
        {

            var selected = gridView1.GetSelectedRows();
            if (selected != null && selected.Any())
            {
                var selectedProducts = products?.ElementAt(selected[0]);
                if (await DeleteProduct(selectedProducts))
                {
                    Clear();
                    EnableProductButtons(false);
                    await LoadProducts();
                }
            }

        }

        private void barButtonItem6_ItemClick(object sender, ItemClickEventArgs e)
        {

        }
    }
}