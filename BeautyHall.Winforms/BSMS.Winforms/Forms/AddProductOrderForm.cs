using BeautyHall.Api.SDK.Requests;
using BeautyHall.Api.SDK.Responses;
using BSMS;
using DevExpress.XtraEditors;

namespace BSMS.Winforms.Forms
{
    public partial class AddProductOrderForm : XtraForm
    {
        private IEnumerable<Product>? Products { get; set; }
        public Product? SelectedProduct { get; set; } = null;
        public decimal SelectedQuantity { get; set; } = 0;
        public AddProductOrderForm(IEnumerable<Product>? products)
        {
            InitializeComponent();
            Products = products;
        }

        private void AddProductOrderForm_Load(object sender, EventArgs e)
        {
            lookUpEdit1.Properties.DisplayMember = "ProductCode";
            lookUpEdit1.Properties.ValueMember = "ProductId";
            lookUpEdit1.Properties.DataSource = Products;
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            SelectedProduct = Products?.Where(x => x.ProductId == Convert.ToInt32(lookUpEdit1.EditValue)).FirstOrDefault();
            SelectedQuantity = GenericUtils.Functions.NullToDecimal(spinEdit1.EditValue);
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void lookUpEdit1_EditValueChanged(object sender, EventArgs e)
        {
            var selectedProduct = Products?.Where(x => x.ProductId == Convert.ToInt32(lookUpEdit1.EditValue)).FirstOrDefault();

            spinEdit1.Enabled = selectedProduct?.Stock?.Quantity > 0;
            simpleButton2.Enabled = selectedProduct?.Stock?.Quantity > 0;
            spinEdit1.Properties.MaxValue = selectedProduct?.Stock?.Quantity ?? 0;
            textEdit1.EditValue = $"{selectedProduct?.ProductCode}";
            textEdit2.EditValue = $"{selectedProduct?.ProductDescription}";
            textEdit3.EditValue = selectedProduct?.Stock?.Quantity.ToString("0.##");
            textEdit4.EditValue = selectedProduct?.SellingPrice;
        }
    }
}