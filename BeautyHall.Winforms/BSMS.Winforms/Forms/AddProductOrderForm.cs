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
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void lookUpEdit1_EditValueChanged(object sender, EventArgs e)
        {
            var selectedProduct = Products?.Where(x => x.ProductId == Convert.ToInt32(lookUpEdit1.EditValue)).FirstOrDefault();

            // TO DO (for armando)
            // set the values of the textedits and the spinEdit max value
            spinEdit1.Properties.MaxValue = selectedProduct?.Stock?.Quantity ?? 0; // check if this works
            textEdit1.EditValue = $"{selectedProduct?.ProductCode}";
            textEdit2.EditValue = $"{selectedProduct?.ProductDescription}";
            textEdit3.EditValue = $"{selectedProduct?.Stock}";
            textEdit4.EditValue = selectedProduct?.SellingPrice;


            // selectedProduct is an object of the class Product (from the SDK)
            // access to its properties (Code, Description, ..) to value the controls
            // i leave it for now ok!!!!

        }
    }
}