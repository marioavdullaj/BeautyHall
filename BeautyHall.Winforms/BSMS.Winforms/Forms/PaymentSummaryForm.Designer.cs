namespace BSMS.Winforms.Forms
{
    partial class PaymentSummaryForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PaymentSummaryForm));
            labelControl1 = new DevExpress.XtraEditors.LabelControl();
            textEdit1 = new DevExpress.XtraEditors.TextEdit();
            labelControl2 = new DevExpress.XtraEditors.LabelControl();
            labelControl3 = new DevExpress.XtraEditors.LabelControl();
            textEdit2 = new DevExpress.XtraEditors.TextEdit();
            textEdit3 = new DevExpress.XtraEditors.TextEdit();
            labelControl4 = new DevExpress.XtraEditors.LabelControl();
            labelControl7 = new DevExpress.XtraEditors.LabelControl();
            comboBoxEdit1 = new DevExpress.XtraEditors.ComboBox();
            spinEdit1 = new DevExpress.XtraEditors.SpinEdit();
            labelControl9 = new DevExpress.XtraEditors.LabelControl();
            labelControl10 = new DevExpress.XtraEditors.LabelControl();
            spinEdit2 = new DevExpress.XtraEditors.SpinEdit();
            simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)textEdit1.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)textEdit2.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)textEdit3.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)comboBoxEdit1.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)spinEdit1.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)spinEdit2.Properties).BeginInit();
            SuspendLayout();
            // 
            // labelControl1
            // 
            labelControl1.Appearance.Font = new Font("Tahoma", 22.8F, FontStyle.Regular, GraphicsUnit.Point);
            labelControl1.Appearance.Options.UseFont = true;
            labelControl1.Location = new Point(32, 12);
            labelControl1.Name = "labelControl1";
            labelControl1.Size = new Size(167, 46);
            labelControl1.TabIndex = 0;
            labelControl1.Text = "{OrderId}";
            // 
            // textEdit1
            // 
            textEdit1.Enabled = false;
            textEdit1.Location = new Point(215, 92);
            textEdit1.Name = "textEdit1";
            textEdit1.Properties.Appearance.Font = new Font("Tahoma", 19.8F, FontStyle.Regular, GraphicsUnit.Point);
            textEdit1.Properties.Appearance.Options.UseFont = true;
            textEdit1.Size = new Size(362, 46);
            textEdit1.TabIndex = 1;
            // 
            // labelControl2
            // 
            labelControl2.Appearance.Font = new Font("Tahoma", 15.8F, FontStyle.Regular, GraphicsUnit.Point);
            labelControl2.Appearance.Options.UseFont = true;
            labelControl2.Location = new Point(32, 99);
            labelControl2.Name = "labelControl2";
            labelControl2.Size = new Size(111, 31);
            labelControl2.TabIndex = 2;
            labelControl2.Text = "Customer";
            // 
            // labelControl3
            // 
            labelControl3.Appearance.Font = new Font("Tahoma", 15.8F, FontStyle.Regular, GraphicsUnit.Point);
            labelControl3.Appearance.Options.UseFont = true;
            labelControl3.Location = new Point(32, 179);
            labelControl3.Name = "labelControl3";
            labelControl3.Size = new Size(121, 31);
            labelControl3.TabIndex = 4;
            labelControl3.Text = "Total price";
            // 
            // textEdit2
            // 
            textEdit2.Enabled = false;
            textEdit2.Location = new Point(385, 167);
            textEdit2.Name = "textEdit2";
            textEdit2.Properties.Appearance.Font = new Font("Tahoma", 19.8F, FontStyle.Regular, GraphicsUnit.Point);
            textEdit2.Properties.Appearance.Options.UseFont = true;
            textEdit2.Properties.DisplayFormat.FormatString = "c";
            textEdit2.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            textEdit2.Properties.MaskSettings.Set("MaskManagerType", typeof(DevExpress.Data.Mask.NumericMaskManager));
            textEdit2.Properties.MaskSettings.Set("MaskManagerSignature", "allowNull=False");
            textEdit2.Properties.MaskSettings.Set("mask", "c");
            textEdit2.Properties.NullText = "0";
            textEdit2.Size = new Size(192, 46);
            textEdit2.TabIndex = 5;
            // 
            // textEdit3
            // 
            textEdit3.Location = new Point(385, 246);
            textEdit3.Name = "textEdit3";
            textEdit3.Properties.Appearance.Font = new Font("Tahoma", 19.8F, FontStyle.Regular, GraphicsUnit.Point);
            textEdit3.Properties.Appearance.Options.UseFont = true;
            textEdit3.Properties.DisplayFormat.FormatString = "c";
            textEdit3.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            textEdit3.Properties.MaskSettings.Set("MaskManagerType", typeof(DevExpress.Data.Mask.NumericMaskManager));
            textEdit3.Properties.MaskSettings.Set("mask", "c");
            textEdit3.Properties.NullText = "0";
            textEdit3.Size = new Size(192, 46);
            textEdit3.TabIndex = 7;
            textEdit3.ToolTip = "s";
            textEdit3.EditValueChanged += textEdit3_EditValueChanged;
            textEdit3.EditValueChanging += textEdit3_EditValueChanging;
            // 
            // labelControl4
            // 
            labelControl4.Appearance.Font = new Font("Tahoma", 15.8F, FontStyle.Regular, GraphicsUnit.Point);
            labelControl4.Appearance.Options.UseFont = true;
            labelControl4.Location = new Point(32, 256);
            labelControl4.Name = "labelControl4";
            labelControl4.Size = new Size(118, 31);
            labelControl4.TabIndex = 6;
            labelControl4.Text = "Final price";
            // 
            // labelControl7
            // 
            labelControl7.Appearance.Font = new Font("Tahoma", 18.8F, FontStyle.Regular, GraphicsUnit.Point);
            labelControl7.Appearance.Options.UseFont = true;
            labelControl7.Location = new Point(215, 251);
            labelControl7.Name = "labelControl7";
            labelControl7.Size = new Size(11, 37);
            labelControl7.TabIndex = 12;
            labelControl7.Text = "-";
            // 
            // comboBoxEdit1
            // 
            comboBoxEdit1.Location = new Point(241, 246);
            comboBoxEdit1.Name = "comboBoxEdit1";
            comboBoxEdit1.Properties.Appearance.Font = new Font("Tahoma", 20F, FontStyle.Regular, GraphicsUnit.Point);
            comboBoxEdit1.Properties.Appearance.Options.UseFont = true;
            comboBoxEdit1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] { new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo) });
            comboBoxEdit1.Properties.DisplayFormat.FormatString = "p0";
            comboBoxEdit1.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            comboBoxEdit1.Properties.EditFormat.FormatString = "p0";
            comboBoxEdit1.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            comboBoxEdit1.Properties.PopupDisplayFormat.FormatString = "p0";
            comboBoxEdit1.Properties.PopupDisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            comboBoxEdit1.Properties.NullText = "0";
            comboBoxEdit1.Size = new Size(127, 46);
            comboBoxEdit1.TabIndex = 13;
            comboBoxEdit1.EditValueChanged += comboBoxEdit1_SelectedIndexChanged;
            // 
            // spinEdit1
            // 
            spinEdit1.EditValue = new decimal(new int[] { 0, 0, 0, 0 });
            spinEdit1.Location = new Point(385, 324);
            spinEdit1.Name = "spinEdit1";
            spinEdit1.Properties.Appearance.Font = new Font("Tahoma", 19.8F, FontStyle.Regular, GraphicsUnit.Point);
            spinEdit1.Properties.Appearance.Options.UseFont = true;
            spinEdit1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] { new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo) });
            spinEdit1.Properties.DisplayFormat.FormatString = "c";
            spinEdit1.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            spinEdit1.Properties.MaskSettings.Set("mask", "c");
            spinEdit1.Size = new Size(192, 46);
            spinEdit1.TabIndex = 14;
            spinEdit1.EditValueChanging += spinEdit1_EditValueChanging;
            // 
            // labelControl9
            // 
            labelControl9.Appearance.Font = new Font("Tahoma", 15.8F, FontStyle.Regular, GraphicsUnit.Point);
            labelControl9.Appearance.Options.UseFont = true;
            labelControl9.Location = new Point(296, 334);
            labelControl9.Name = "labelControl9";
            labelControl9.Size = new Size(57, 31);
            labelControl9.TabIndex = 16;
            labelControl9.Text = "Cash";
            // 
            // labelControl10
            // 
            labelControl10.Appearance.Font = new Font("Tahoma", 15.8F, FontStyle.Regular, GraphicsUnit.Point);
            labelControl10.Appearance.Options.UseFont = true;
            labelControl10.Location = new Point(296, 399);
            labelControl10.Name = "labelControl10";
            labelControl10.Size = new Size(46, 31);
            labelControl10.TabIndex = 19;
            labelControl10.Text = "POS";
            // 
            // spinEdit2
            // 
            spinEdit2.EditValue = new decimal(new int[] { 0, 0, 0, 0 });
            spinEdit2.Location = new Point(385, 389);
            spinEdit2.Name = "spinEdit2";
            spinEdit2.Properties.Appearance.Font = new Font("Tahoma", 19.8F, FontStyle.Regular, GraphicsUnit.Point);
            spinEdit2.Properties.Appearance.Options.UseFont = true;
            spinEdit2.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] { new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo) });
            spinEdit2.Properties.DisplayFormat.FormatString = "c";
            spinEdit2.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            spinEdit2.Properties.MaskSettings.Set("mask", "c");
            spinEdit2.Size = new Size(192, 46);
            spinEdit2.TabIndex = 17;
            spinEdit2.EditValueChanging += spinEdit2_EditValueChanging;
            // 
            // simpleButton1
            // 
            simpleButton1.Appearance.Font = new Font("Tahoma", 21.8F, FontStyle.Regular, GraphicsUnit.Point);
            simpleButton1.Appearance.Options.UseFont = true;
            simpleButton1.ImageOptions.SvgImage = (DevExpress.Utils.Svg.SvgImage)resources.GetObject("simpleButton1.ImageOptions.SvgImage");
            simpleButton1.Location = new Point(32, 463);
            simpleButton1.Name = "simpleButton1";
            simpleButton1.Size = new Size(545, 71);
            simpleButton1.TabIndex = 20;
            simpleButton1.Text = "PAY";
            simpleButton1.Click += simpleButton1_Click;
            // 
            // PaymentSummaryForm
            // 
            AutoScaleDimensions = new SizeF(7F, 16F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(613, 556);
            Controls.Add(simpleButton1);
            Controls.Add(labelControl10);
            Controls.Add(spinEdit2);
            Controls.Add(labelControl9);
            Controls.Add(spinEdit1);
            Controls.Add(comboBoxEdit1);
            Controls.Add(labelControl7);
            Controls.Add(textEdit3);
            Controls.Add(labelControl4);
            Controls.Add(textEdit2);
            Controls.Add(labelControl3);
            Controls.Add(labelControl2);
            Controls.Add(textEdit1);
            Controls.Add(labelControl1);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "PaymentSummaryForm";
            Text = "Payment";
            Load += PaymentSummaryForm_Load;
            ((System.ComponentModel.ISupportInitialize)textEdit1.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)textEdit2.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)textEdit3.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)comboBoxEdit1.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)spinEdit1.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)spinEdit2.Properties).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.TextEdit textEdit1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.TextEdit textEdit2;
        private DevExpress.XtraEditors.TextEdit textEdit3;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private DevExpress.XtraEditors.ComboBox comboBoxEdit1;
        private DevExpress.XtraEditors.SpinEdit spinEdit1;
        private DevExpress.XtraEditors.LabelControl labelControl9;
        private DevExpress.XtraEditors.LabelControl labelControl10;
        private DevExpress.XtraEditors.SpinEdit spinEdit2;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
    }
}