using BeautyHall.Api.SDK.Requests;
using BeautyHall.Api.SDK.Responses;
using Demo;
using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BSMS.Winforms.Forms
{
    public partial class PaymentSummaryForm : DevExpress.XtraEditors.XtraForm
    {
        private List<decimal> discountPercentages;
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
            for (decimal i = 0; i <= (decimal)0.55; i += (decimal)0.05)
                discountPercentages.Add(i);
            comboBoxEdit1.Properties.Items.AddRange(discountPercentages);

            PaymentSummary.TotalPrice = GenericUtils.Functions.NullToDecimal(PaymentSummary.Order?.OrderServices?.Sum(x => x.ServicePrice));
            textEdit2.EditValue = PaymentSummary.TotalPrice;
            PaymentSummary.PaymentDate = DateTime.Now;
            labelControl1.Text = $"ORDER_{PaymentSummary.OrderId} - {PaymentSummary.PaymentDate?.ToString("dd/MM/yyyy")}";
            textEdit1.Text = $"{PaymentSummary.Order?.Customer?.SubjectName} {PaymentSummary.Order?.Customer?.SubjectLastName}";

            comboBoxEdit1.EditValue = 0;
        }

        private void comboBoxEdit1_SelectedIndexChanged(object sender, EventArgs e)
        {
            var selectedPercentage = GenericUtils.Functions.NullToDecimal(comboBoxEdit1.EditValue);
            var discountedPrice = PaymentSummary.TotalPrice * (1 - selectedPercentage);

            textEdit3.EditValueChanged -= textEdit3_EditValueChanged;
            textEdit3.EditValue = discountedPrice;
            textEdit3.EditValueChanged += textEdit3_EditValueChanged;
        }

        private void textEdit3_EditValueChanged(object sender, EventArgs e)
        {
            var discountedPrice = GenericUtils.Functions.NullToDecimal(textEdit3.EditValue);
            var calculatedPercentage = discountedPrice / PaymentSummary.TotalPrice;
            comboBoxEdit1.EditValue = 1 - calculatedPercentage;

            var currentCash = spinEdit1.Value;
            var currentPos = spinEdit2.Value;

            var delta = discountedPrice - (currentCash + currentPos);

            currentCash += delta;
            if (currentCash < 0)
            {
                currentPos += currentCash;
                currentCash = 0;
            }
            if (currentPos < 0)
                currentPos = 0;

            spinEdit1.Value = currentCash;
            spinEdit2.Value = currentPos;
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
            var currentPos = spinEdit2.Value;
            var currentCash = spinEdit1.Value;
            var discountedPrice = GenericUtils.Functions.NullToDecimal(textEdit3.EditValue);

            if (discountedPrice < currentCash + currentPos)
            {
                if (currentCash > discountedPrice)
                    currentCash = discountedPrice;
                currentPos = discountedPrice - currentCash;
            }

            spinEdit1.EditValueChanged -= spinEdit1_EditValueChanged;
            spinEdit2.EditValueChanged -= spinEdit2_EditValueChanged;
            spinEdit1.Value = currentCash;
            spinEdit2.Value = currentPos;
            spinEdit1.EditValueChanged += spinEdit1_EditValueChanged;
            spinEdit2.EditValueChanged += spinEdit2_EditValueChanged;
        }

        private void spinEdit1_EditValueChanged(object sender, EventArgs e)
        {
            var currentPos = spinEdit2.Value;
            var currentCash = spinEdit1.Value;
            var discountedPrice = GenericUtils.Functions.NullToDecimal(textEdit3.EditValue);

            if (discountedPrice < currentCash + currentPos)
            {
                if (currentPos > discountedPrice)
                    currentPos = discountedPrice;
                currentCash = discountedPrice - currentPos;
            }

            spinEdit1.EditValueChanged -= spinEdit1_EditValueChanged;
            spinEdit2.EditValueChanged -= spinEdit2_EditValueChanged;
            spinEdit1.Value = currentCash;
            spinEdit2.Value = currentPos;
            spinEdit1.EditValueChanged += spinEdit1_EditValueChanged;
            spinEdit2.EditValueChanged += spinEdit2_EditValueChanged;
        }

        private void spinEdit1_EditValueChanging(object sender, DevExpress.XtraEditors.Controls.ChangingEventArgs e)
        {

        }

        private void spinEdit2_EditValueChanging(object sender, DevExpress.XtraEditors.Controls.ChangingEventArgs e)
        {

        }
    }
}