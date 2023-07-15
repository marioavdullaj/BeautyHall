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
            labelControl5 = new DevExpress.XtraEditors.LabelControl();
            labelControl6 = new DevExpress.XtraEditors.LabelControl();
            labelControl7 = new DevExpress.XtraEditors.LabelControl();
            comboBoxEdit1 = new DevExpress.XtraEditors.ComboBoxEdit();
            spinEdit1 = new DevExpress.XtraEditors.SpinEdit();
            labelControl8 = new DevExpress.XtraEditors.LabelControl();
            labelControl9 = new DevExpress.XtraEditors.LabelControl();
            labelControl10 = new DevExpress.XtraEditors.LabelControl();
            labelControl11 = new DevExpress.XtraEditors.LabelControl();
            spinEdit2 = new DevExpress.XtraEditors.SpinEdit();
            simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            labelControl12 = new DevExpress.XtraEditors.LabelControl();
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
            labelControl1.Location = new Point(241, 12);
            labelControl1.Name = "labelControl1";
            labelControl1.Size = new Size(167, 46);
            labelControl1.TabIndex = 0;
            labelControl1.Text = "{OrderId}";
            // 
            // textEdit1
            // 
            textEdit1.Enabled = false;
            textEdit1.Location = new Point(241, 86);
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
            labelControl2.Location = new Point(58, 93);
            labelControl2.Name = "labelControl2";
            labelControl2.Size = new Size(111, 31);
            labelControl2.TabIndex = 2;
            labelControl2.Text = "Customer";
            // 
            // labelControl3
            // 
            labelControl3.Appearance.Font = new Font("Tahoma", 15.8F, FontStyle.Regular, GraphicsUnit.Point);
            labelControl3.Appearance.Options.UseFont = true;
            labelControl3.Location = new Point(58, 173);
            labelControl3.Name = "labelControl3";
            labelControl3.Size = new Size(121, 31);
            labelControl3.TabIndex = 4;
            labelControl3.Text = "Total price";
            // 
            // textEdit2
            // 
            textEdit2.Enabled = false;
            textEdit2.Location = new Point(411, 161);
            textEdit2.Name = "textEdit2";
            textEdit2.Properties.Appearance.Font = new Font("Tahoma", 19.8F, FontStyle.Regular, GraphicsUnit.Point);
            textEdit2.Properties.Appearance.Options.UseFont = true;
            textEdit2.Properties.NullText = "0";
            textEdit2.Size = new Size(167, 46);
            textEdit2.TabIndex = 5;
            // 
            // textEdit3
            // 
            textEdit3.Location = new Point(411, 240);
            textEdit3.Name = "textEdit3";
            textEdit3.Properties.Appearance.Font = new Font("Tahoma", 19.8F, FontStyle.Regular, GraphicsUnit.Point);
            textEdit3.Properties.Appearance.Options.UseFont = true;
            textEdit3.Properties.MaskSettings.Set("MaskManagerType", typeof(DevExpress.Data.Mask.NumericMaskManager));
            textEdit3.Properties.NullText = "0";
            textEdit3.Size = new Size(167, 46);
            textEdit3.TabIndex = 7;
            textEdit3.EditValueChanged += textEdit3_EditValueChanged;
            textEdit3.EditValueChanging += textEdit3_EditValueChanging;
            // 
            // labelControl4
            // 
            labelControl4.Appearance.Font = new Font("Tahoma", 15.8F, FontStyle.Regular, GraphicsUnit.Point);
            labelControl4.Appearance.Options.UseFont = true;
            labelControl4.Location = new Point(58, 250);
            labelControl4.Name = "labelControl4";
            labelControl4.Size = new Size(118, 31);
            labelControl4.TabIndex = 6;
            labelControl4.Text = "Final price";
            // 
            // labelControl5
            // 
            labelControl5.Appearance.Font = new Font("Tahoma", 15.8F, FontStyle.Regular, GraphicsUnit.Point);
            labelControl5.Appearance.Options.UseFont = true;
            labelControl5.Location = new Point(589, 171);
            labelControl5.Name = "labelControl5";
            labelControl5.Size = new Size(14, 31);
            labelControl5.TabIndex = 10;
            labelControl5.Text = "€";
            // 
            // labelControl6
            // 
            labelControl6.Appearance.Font = new Font("Tahoma", 15.8F, FontStyle.Regular, GraphicsUnit.Point);
            labelControl6.Appearance.Options.UseFont = true;
            labelControl6.Location = new Point(589, 250);
            labelControl6.Name = "labelControl6";
            labelControl6.Size = new Size(14, 31);
            labelControl6.TabIndex = 11;
            labelControl6.Text = "€";
            // 
            // labelControl7
            // 
            labelControl7.Appearance.Font = new Font("Tahoma", 18.8F, FontStyle.Regular, GraphicsUnit.Point);
            labelControl7.Appearance.Options.UseFont = true;
            labelControl7.Location = new Point(216, 243);
            labelControl7.Name = "labelControl7";
            labelControl7.Size = new Size(11, 37);
            labelControl7.TabIndex = 12;
            labelControl7.Text = "-";
            // 
            // comboBoxEdit1
            // 
            comboBoxEdit1.Location = new Point(235, 240);
            comboBoxEdit1.Name = "comboBoxEdit1";
            comboBoxEdit1.Properties.Appearance.Font = new Font("Tahoma", 20F, FontStyle.Regular, GraphicsUnit.Point);
            comboBoxEdit1.Properties.Appearance.Options.UseFont = true;
            comboBoxEdit1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] { new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo) });
            comboBoxEdit1.Properties.DisplayFormat.FormatString = "p0";
            comboBoxEdit1.Size = new Size(127, 46);
            comboBoxEdit1.TabIndex = 13;
            comboBoxEdit1.SelectedIndexChanged += comboBoxEdit1_SelectedIndexChanged;
            // 
            // spinEdit1
            // 
            spinEdit1.EditValue = new decimal(new int[] { 0, 0, 0, 0 });
            spinEdit1.Location = new Point(411, 318);
            spinEdit1.Name = "spinEdit1";
            spinEdit1.Properties.Appearance.Font = new Font("Tahoma", 19.8F, FontStyle.Regular, GraphicsUnit.Point);
            spinEdit1.Properties.Appearance.Options.UseFont = true;
            spinEdit1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] { new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo) });
            spinEdit1.Size = new Size(167, 46);
            spinEdit1.TabIndex = 14;
            spinEdit1.EditValueChanged += spinEdit1_EditValueChanged;
            // 
            // labelControl8
            // 
            labelControl8.Appearance.Font = new Font("Tahoma", 15.8F, FontStyle.Regular, GraphicsUnit.Point);
            labelControl8.Appearance.Options.UseFont = true;
            labelControl8.Location = new Point(589, 328);
            labelControl8.Name = "labelControl8";
            labelControl8.Size = new Size(14, 31);
            labelControl8.TabIndex = 15;
            labelControl8.Text = "€";
            // 
            // labelControl9
            // 
            labelControl9.Appearance.Font = new Font("Tahoma", 15.8F, FontStyle.Regular, GraphicsUnit.Point);
            labelControl9.Appearance.Options.UseFont = true;
            labelControl9.Location = new Point(322, 328);
            labelControl9.Name = "labelControl9";
            labelControl9.Size = new Size(57, 31);
            labelControl9.TabIndex = 16;
            labelControl9.Text = "Cash";
            // 
            // labelControl10
            // 
            labelControl10.Appearance.Font = new Font("Tahoma", 15.8F, FontStyle.Regular, GraphicsUnit.Point);
            labelControl10.Appearance.Options.UseFont = true;
            labelControl10.Location = new Point(322, 393);
            labelControl10.Name = "labelControl10";
            labelControl10.Size = new Size(46, 31);
            labelControl10.TabIndex = 19;
            labelControl10.Text = "POS";
            // 
            // labelControl11
            // 
            labelControl11.Appearance.Font = new Font("Tahoma", 15.8F, FontStyle.Regular, GraphicsUnit.Point);
            labelControl11.Appearance.Options.UseFont = true;
            labelControl11.Location = new Point(589, 393);
            labelControl11.Name = "labelControl11";
            labelControl11.Size = new Size(14, 31);
            labelControl11.TabIndex = 18;
            labelControl11.Text = "€";
            // 
            // spinEdit2
            // 
            spinEdit2.EditValue = new decimal(new int[] { 0, 0, 0, 0 });
            spinEdit2.Location = new Point(411, 383);
            spinEdit2.Name = "spinEdit2";
            spinEdit2.Properties.Appearance.Font = new Font("Tahoma", 19.8F, FontStyle.Regular, GraphicsUnit.Point);
            spinEdit2.Properties.Appearance.Options.UseFont = true;
            spinEdit2.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] { new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo) });
            spinEdit2.Size = new Size(167, 46);
            spinEdit2.TabIndex = 17;
            spinEdit2.EditValueChanged += spinEdit2_EditValueChanged;
            // 
            // simpleButton1
            // 
            simpleButton1.Appearance.Font = new Font("Tahoma", 21.8F, FontStyle.Regular, GraphicsUnit.Point);
            simpleButton1.Appearance.Options.UseFont = true;
            simpleButton1.ImageOptions.SvgImage = (DevExpress.Utils.Svg.SvgImage)resources.GetObject("simpleButton1.ImageOptions.SvgImage");
            simpleButton1.Location = new Point(58, 468);
            simpleButton1.Name = "simpleButton1";
            simpleButton1.Size = new Size(520, 71);
            simpleButton1.TabIndex = 20;
            simpleButton1.Text = "PAY";
            simpleButton1.Click += simpleButton1_Click;
            // 
            // labelControl12
            // 
            labelControl12.Appearance.Font = new Font("Tahoma", 15.8F, FontStyle.Regular, GraphicsUnit.Point);
            labelControl12.Appearance.Options.UseFont = true;
            labelControl12.Location = new Point(365, 250);
            labelControl12.Name = "labelControl12";
            labelControl12.Size = new Size(25, 31);
            labelControl12.TabIndex = 21;
            labelControl12.Text = "%";
            // 
            // PaymentSummaryForm
            // 
            AutoScaleDimensions = new SizeF(7F, 16F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(684, 556);
            Controls.Add(labelControl12);
            Controls.Add(simpleButton1);
            Controls.Add(labelControl10);
            Controls.Add(labelControl11);
            Controls.Add(spinEdit2);
            Controls.Add(labelControl9);
            Controls.Add(labelControl8);
            Controls.Add(spinEdit1);
            Controls.Add(comboBoxEdit1);
            Controls.Add(labelControl7);
            Controls.Add(labelControl6);
            Controls.Add(labelControl5);
            Controls.Add(textEdit3);
            Controls.Add(labelControl4);
            Controls.Add(textEdit2);
            Controls.Add(labelControl3);
            Controls.Add(labelControl2);
            Controls.Add(textEdit1);
            Controls.Add(labelControl1);
            Name = "PaymentSummaryForm";
            Text = "PaymentSummaryForm";
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
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private DevExpress.XtraEditors.ComboBoxEdit comboBoxEdit1;
        private DevExpress.XtraEditors.SpinEdit spinEdit1;
        private DevExpress.XtraEditors.LabelControl labelControl8;
        private DevExpress.XtraEditors.LabelControl labelControl9;
        private DevExpress.XtraEditors.LabelControl labelControl10;
        private DevExpress.XtraEditors.LabelControl labelControl11;
        private DevExpress.XtraEditors.SpinEdit spinEdit2;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private DevExpress.XtraEditors.LabelControl labelControl12;
    }
}