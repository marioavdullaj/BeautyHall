using BeautyHall.Api.SDK.Requests;
using BeautyHall.Api.SDK.Responses;
using Demo;
using DevExpress.XtraEditors;

namespace BSMS.Winforms.Forms
{
    public partial class PaymentSummaryForm : XtraForm
    {
        private readonly int MAXPERCENTAGE = 55;
        private List<int> discountPercentages;
        private PaymentSummary PaymentSummary { get; set; }
        public PaymentSummaryForm(Order? order)
        {
            InitializeComponent();
            discountPercentages = new();
            PaymentSummary = new()
            {
                Order = order,
                OrderId = order?.OrderId ?? 0
            };
        }

        private void PaymentSummaryForm_Load(object sender, EventArgs e)
        {
            for (int i = 0; i <= MAXPERCENTAGE; i += 5)
                discountPercentages.Add(i);

            comboBoxEdit1.Properties.Items.AddRange(discountPercentages);

            PaymentSummary.TotalPrice = GenericUtils.Functions.NullToDecimal(PaymentSummary.Order?.OrderServices?.Sum(x => x.ServicePrice));
            textEdit2.EditValue = PaymentSummary.TotalPrice;
            PaymentSummary.PaymentDate = DateTime.Now;
            labelControl1.Text = $"ORDER_{PaymentSummary.OrderId} - {PaymentSummary.PaymentDate?.ToString("dd/MM/yyyy")}";
            textEdit1.Text = $"{PaymentSummary.Order?.Customer?.SubjectName} {PaymentSummary.Order?.Customer?.SubjectLastName}";

            comboBoxEdit1.EditValue = 0;
            textEdit3.EditValue = textEdit2.EditValue;
            spinEdit1.Value = PaymentSummary.TotalPrice;
        }

        private void comboBoxEdit1_SelectedIndexChanged(object sender, EventArgs e)
        {
            var selectedPercentage = GenericUtils.Functions.NullToInt(comboBoxEdit1.EditValue);
            var discountedPrice = PaymentSummary.TotalPrice * (1 - (decimal)selectedPercentage / 100);

            textEdit3.EditValueChanged -= textEdit3_EditValueChanged;
            textEdit3.EditValue = discountedPrice;
            textEdit3.EditValueChanged += textEdit3_EditValueChanged;
            UpdateCashPos(scaleFromCashFirst: true);
        }

        private void textEdit3_EditValueChanged(object sender, EventArgs e)
        {
            var discountedPrice = GenericUtils.Functions.NullToDecimal(textEdit3.EditValue);
            var calculatedPercentage = discountedPrice / PaymentSummary.TotalPrice;
            comboBoxEdit1.EditValue = (int)((1 - calculatedPercentage) * 100);
            UpdateCashPos(scaleFromCashFirst: true);
        }
        private async void simpleButton1_Click(object sender, EventArgs e)
        {
            try
            {
                PaymentSummaryDto paymentSummaryDto = new()
                {
                    OrderId = PaymentSummary.OrderId,
                    TotalPrice = PaymentSummary.TotalPrice,
                    TotalCash = spinEdit1.Value,
                    TotalPOS = spinEdit2.Value,
                    DiscountedPrice = GenericUtils.Functions.NullToDecimal(textEdit3.EditValue)
                };

                if (await Program.ApiSdk.UpsertPayment(paymentSummaryDto))
                {
                    XtraMessageBox.Show("Payment registered successfully!", "Payment", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
                else
                {
                    XtraMessageBox.Show("An error occured during the saving of the payment. Please contact the administration", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void textEdit3_EditValueChanging(object sender, DevExpress.XtraEditors.Controls.ChangingEventArgs e)
        {
            decimal newValue;
            if (!decimal.TryParse(e.NewValue.ToString(), out newValue))
                return;

            if (newValue > PaymentSummary.TotalPrice)
            {
                textEdit3.EditValue = PaymentSummary.TotalPrice;
            }
        }

        private void spinEdit2_EditValueChanged(object sender, EventArgs e)
        {
            UpdateCashPos(scaleFromCashFirst: true);
        }

        private void spinEdit1_EditValueChanged(object sender, EventArgs e)
        {
            UpdateCashPos(scaleFromCashFirst: false);
        }

        private void UpdateCashPos(bool scaleFromCashFirst)
        {
            var discountedPrice = GenericUtils.Functions.NullToDecimal(textEdit3.EditValue);
            var currentCash = spinEdit1.Value;
            var currentPos = spinEdit2.Value;

            var delta = discountedPrice - (currentCash + currentPos);

            if (scaleFromCashFirst)
            {
                currentCash += delta;
                if (currentCash < 0)
                {
                    currentPos += currentCash;
                    currentCash = 0;
                }
                if (currentPos < 0)
                    currentPos = 0;
            }
            else
            {
                currentPos += delta;
                if (currentPos < 0)
                {
                    currentCash += currentPos;
                    currentPos = 0;
                }
                if (currentCash < 0)
                    currentCash = 0;
            }

            if (discountedPrice < currentCash + currentPos)
            {
                if (!scaleFromCashFirst)
                {
                    if (currentPos > discountedPrice)
                        currentPos = discountedPrice;
                    currentCash = discountedPrice - currentPos;
                }
                else
                {
                    if (currentCash > discountedPrice)
                        currentCash = discountedPrice;
                    currentPos = discountedPrice - currentCash;
                }
            }

            spinEdit1.EditValueChanged -= spinEdit1_EditValueChanged;
            spinEdit2.EditValueChanged -= spinEdit2_EditValueChanged;
            spinEdit1.Value = currentCash;
            spinEdit2.Value = currentPos;
            spinEdit1.EditValueChanged += spinEdit1_EditValueChanged;
            spinEdit2.EditValueChanged += spinEdit2_EditValueChanged;
        }
    }
}