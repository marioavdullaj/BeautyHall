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
            simpleButton2 = new DevExpress.XtraEditors.SimpleButton();
            simpleButton3 = new DevExpress.XtraEditors.SimpleButton();
            labelControl5 = new DevExpress.XtraEditors.LabelControl();
            labelControl6 = new DevExpress.XtraEditors.LabelControl();
            panelControl1 = new DevExpress.XtraEditors.PanelControl();
            panelControl2 = new DevExpress.XtraEditors.PanelControl();
            panelControl3 = new DevExpress.XtraEditors.PanelControl();
            panelControl4 = new DevExpress.XtraEditors.PanelControl();
            ((System.ComponentModel.ISupportInitialize)textEdit1.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)textEdit2.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)textEdit3.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)comboBoxEdit1.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)spinEdit1.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)spinEdit2.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)panelControl1).BeginInit();
            panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)panelControl2).BeginInit();
            panelControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)panelControl3).BeginInit();
            panelControl3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)panelControl4).BeginInit();
            SuspendLayout();
            // 
            // labelControl1
            // 
            labelControl1.Appearance.Font = new Font("Tahoma", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            labelControl1.Appearance.Options.UseFont = true;
            labelControl1.Location = new Point(32, 12);
            labelControl1.Name = "labelControl1";
            labelControl1.Size = new Size(119, 33);
            labelControl1.TabIndex = 0;
            labelControl1.Text = "{OrderId}";
            // 
            // textEdit1
            // 
            textEdit1.Enabled = false;
            textEdit1.Location = new Point(215, 67);
            textEdit1.Name = "textEdit1";
            textEdit1.Properties.Appearance.Font = new Font("Tahoma", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            textEdit1.Properties.Appearance.Options.UseFont = true;
            textEdit1.Size = new Size(362, 34);
            textEdit1.TabIndex = 1;
            // 
            // labelControl2
            // 
            labelControl2.Appearance.Font = new Font("Tahoma", 15.8F, FontStyle.Regular, GraphicsUnit.Point);
            labelControl2.Appearance.Options.UseFont = true;
            labelControl2.Location = new Point(20, 16);
            labelControl2.Name = "labelControl2";
            labelControl2.Size = new Size(112, 31);
            labelControl2.TabIndex = 2;
            labelControl2.Text = "Πελάτης :";
            // 
            // labelControl3
            // 
            labelControl3.Appearance.Font = new Font("Tahoma", 15.8F, FontStyle.Regular, GraphicsUnit.Point);
            labelControl3.Appearance.Options.UseFont = true;
            labelControl3.Location = new Point(32, 132);
            labelControl3.Name = "labelControl3";
            labelControl3.Size = new Size(99, 31);
            labelControl3.TabIndex = 4;
            labelControl3.Text = "Σύνολο :";
            // 
            // textEdit2
            // 
            textEdit2.Enabled = false;
            textEdit2.Location = new Point(450, 129);
            textEdit2.Name = "textEdit2";
            textEdit2.Properties.Appearance.Font = new Font("Tahoma", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            textEdit2.Properties.Appearance.Options.UseFont = true;
            textEdit2.Properties.DisplayFormat.FormatString = "c";
            textEdit2.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            textEdit2.Properties.MaskSettings.Set("MaskManagerType", typeof(DevExpress.Data.Mask.NumericMaskManager));
            textEdit2.Properties.MaskSettings.Set("MaskManagerSignature", "allowNull=False");
            textEdit2.Properties.MaskSettings.Set("mask", "c");
            textEdit2.Properties.NullText = "0";
            textEdit2.Size = new Size(127, 34);
            textEdit2.TabIndex = 5;
            // 
            // textEdit3
            // 
            textEdit3.Location = new Point(438, 4);
            textEdit3.Name = "textEdit3";
            textEdit3.Properties.Appearance.Font = new Font("Tahoma", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            textEdit3.Properties.Appearance.Options.UseFont = true;
            textEdit3.Properties.DisplayFormat.FormatString = "c";
            textEdit3.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            textEdit3.Properties.MaskSettings.Set("MaskManagerType", typeof(DevExpress.Data.Mask.NumericMaskManager));
            textEdit3.Properties.MaskSettings.Set("mask", "c");
            textEdit3.Properties.NullText = "0";
            textEdit3.Size = new Size(127, 34);
            textEdit3.TabIndex = 7;
            textEdit3.ToolTip = "s";
            textEdit3.EditValueChanged += textEdit3_EditValueChanged;
            textEdit3.EditValueChanging += textEdit3_EditValueChanging;
            // 
            // labelControl4
            // 
            labelControl4.Appearance.Font = new Font("Tahoma", 15.8F, FontStyle.Regular, GraphicsUnit.Point);
            labelControl4.Appearance.Options.UseFont = true;
            labelControl4.Location = new Point(32, 194);
            labelControl4.Name = "labelControl4";
            labelControl4.Size = new Size(124, 31);
            labelControl4.TabIndex = 6;
            labelControl4.Text = "Έκπτωση :";
            // 
            // labelControl7
            // 
            labelControl7.Appearance.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point);
            labelControl7.Appearance.Options.UseFont = true;
            labelControl7.Location = new Point(396, 197);
            labelControl7.Name = "labelControl7";
            labelControl7.Size = new Size(20, 24);
            labelControl7.TabIndex = 12;
            labelControl7.Text = "%";
            // 
            // comboBoxEdit1
            // 
            comboBoxEdit1.Location = new Point(450, 191);
            comboBoxEdit1.Name = "comboBoxEdit1";
            comboBoxEdit1.Properties.Appearance.Font = new Font("Tahoma", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            comboBoxEdit1.Properties.Appearance.Options.UseFont = true;
            comboBoxEdit1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] { new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo) });
            comboBoxEdit1.Properties.DisplayFormat.FormatString = "p0";
            comboBoxEdit1.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            comboBoxEdit1.Properties.EditFormat.FormatString = "p0";
            comboBoxEdit1.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            comboBoxEdit1.Properties.NullText = "0";
            comboBoxEdit1.Properties.PopupDisplayFormat.FormatString = "p0";
            comboBoxEdit1.Properties.PopupDisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            comboBoxEdit1.Size = new Size(127, 34);
            comboBoxEdit1.TabIndex = 13;
            comboBoxEdit1.EditValueChanged += comboBoxEdit1_SelectedIndexChanged;
            // 
            // spinEdit1
            // 
            spinEdit1.EditValue = new decimal(new int[] { 0, 0, 0, 0 });
            spinEdit1.Location = new Point(388, 37);
            spinEdit1.Name = "spinEdit1";
            spinEdit1.Properties.Appearance.Font = new Font("Tahoma", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            spinEdit1.Properties.Appearance.Options.UseFont = true;
            spinEdit1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] { new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo) });
            spinEdit1.Properties.DisplayFormat.FormatString = "c";
            spinEdit1.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            spinEdit1.Properties.MaskSettings.Set("mask", "c");
            spinEdit1.Properties.MaskSettings.Set("culture", "el-GR");
            spinEdit1.Properties.Name = "spinEdit1";
            spinEdit1.Size = new Size(127, 34);
            spinEdit1.TabIndex = 14;
            spinEdit1.EditValueChanging += spinEdit1_EditValueChanging;
            // 
            // labelControl9
            // 
            labelControl9.Appearance.Font = new Font("Tahoma", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            labelControl9.Appearance.Options.UseFont = true;
            labelControl9.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            labelControl9.Location = new Point(248, 40);
            labelControl9.Name = "labelControl9";
            labelControl9.Size = new Size(129, 28);
            labelControl9.TabIndex = 16;
            labelControl9.Text = "Μετρητά -->";
            // 
            // labelControl10
            // 
            labelControl10.Appearance.Font = new Font("Tahoma", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            labelControl10.Appearance.Options.UseFont = true;
            labelControl10.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            labelControl10.Location = new Point(223, 84);
            labelControl10.Name = "labelControl10";
            labelControl10.Size = new Size(154, 28);
            labelControl10.TabIndex = 19;
            labelControl10.Text = "Κάρτα-POS -->";
            // 
            // spinEdit2
            // 
            spinEdit2.EditValue = new decimal(new int[] { 0, 0, 0, 0 });
            spinEdit2.Location = new Point(389, 81);
            spinEdit2.Name = "spinEdit2";
            spinEdit2.Properties.Appearance.Font = new Font("Tahoma", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            spinEdit2.Properties.Appearance.Options.UseFont = true;
            spinEdit2.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] { new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo) });
            spinEdit2.Properties.DisplayFormat.FormatString = "c";
            spinEdit2.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            spinEdit2.Properties.MaskSettings.Set("mask", "c");
            spinEdit2.Properties.MaskSettings.Set("culture", "el-GR");
            spinEdit2.Size = new Size(127, 34);
            spinEdit2.TabIndex = 17;
            spinEdit2.EditValueChanging += spinEdit2_EditValueChanging;
            // 
            // simpleButton1
            // 
            simpleButton1.Appearance.Font = new Font("Tahoma", 18F, FontStyle.Regular, GraphicsUnit.Point);
            simpleButton1.Appearance.Options.UseFont = true;
            simpleButton1.ImageOptions.SvgImage = (DevExpress.Utils.Svg.SvgImage)resources.GetObject("simpleButton1.ImageOptions.SvgImage");
            simpleButton1.Location = new Point(32, 458);
            simpleButton1.Name = "simpleButton1";
            simpleButton1.Size = new Size(491, 47);
            simpleButton1.TabIndex = 20;
            simpleButton1.Text = "Αποθήκευση";
            simpleButton1.Click += simpleButton1_Click;
            // 
            // simpleButton2
            // 
            simpleButton2.ImageOptions.SvgImage = (DevExpress.Utils.Svg.SvgImage)resources.GetObject("simpleButton2.ImageOptions.SvgImage");
            simpleButton2.Location = new Point(532, 458);
            simpleButton2.Name = "simpleButton2";
            simpleButton2.Size = new Size(45, 47);
            simpleButton2.TabIndex = 21;
            simpleButton2.Click += simpleButton2_Click;
            // 
            // simpleButton3
            // 
            simpleButton3.ImageOptions.SvgImage = (DevExpress.Utils.Svg.SvgImage)resources.GetObject("simpleButton3.ImageOptions.SvgImage");
            simpleButton3.Location = new Point(520, 38);
            simpleButton3.Name = "simpleButton3";
            simpleButton3.Size = new Size(44, 75);
            simpleButton3.TabIndex = 22;
            simpleButton3.Click += simpleButton3_Click;
            // 
            // labelControl5
            // 
            labelControl5.Appearance.Font = new Font("Tahoma", 15.8F, FontStyle.Regular, GraphicsUnit.Point);
            labelControl5.Appearance.Options.UseFont = true;
            labelControl5.Location = new Point(20, 5);
            labelControl5.Name = "labelControl5";
            labelControl5.Size = new Size(178, 31);
            labelControl5.TabIndex = 23;
            labelControl5.Text = "Γενικό Σύνολο :";
            // 
            // labelControl6
            // 
            labelControl6.Appearance.Font = new Font("Tahoma", 15.8F, FontStyle.Regular, GraphicsUnit.Point);
            labelControl6.Appearance.Options.UseFont = true;
            labelControl6.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            labelControl6.Location = new Point(20, 5);
            labelControl6.Name = "labelControl6";
            labelControl6.Size = new Size(126, 31);
            labelControl6.TabIndex = 24;
            labelControl6.Text = "Πληρωμή :";
            // 
            // panelControl1
            // 
            panelControl1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            panelControl1.Controls.Add(simpleButton3);
            panelControl1.Controls.Add(labelControl6);
            panelControl1.Controls.Add(labelControl10);
            panelControl1.Controls.Add(labelControl9);
            panelControl1.Controls.Add(spinEdit1);
            panelControl1.Controls.Add(spinEdit2);
            panelControl1.Location = new Point(12, 303);
            panelControl1.Name = "panelControl1";
            panelControl1.Size = new Size(576, 125);
            panelControl1.TabIndex = 25;
            // 
            // panelControl2
            // 
            panelControl2.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            panelControl2.Controls.Add(labelControl2);
            panelControl2.Location = new Point(12, 51);
            panelControl2.Name = "panelControl2";
            panelControl2.Size = new Size(576, 196);
            panelControl2.TabIndex = 26;
            // 
            // panelControl3
            // 
            panelControl3.Controls.Add(textEdit3);
            panelControl3.Controls.Add(labelControl5);
            panelControl3.Location = new Point(12, 256);
            panelControl3.Name = "panelControl3";
            panelControl3.Size = new Size(576, 41);
            panelControl3.TabIndex = 27;
            // 
            // panelControl4
            // 
            panelControl4.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            panelControl4.Location = new Point(12, 434);
            panelControl4.Name = "panelControl4";
            panelControl4.Size = new Size(576, 100);
            panelControl4.TabIndex = 28;
            // 
            // PaymentSummaryForm
            // 
            AutoScaleDimensions = new SizeF(7F, 16F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(600, 546);
            Controls.Add(simpleButton2);
            Controls.Add(simpleButton1);
            Controls.Add(comboBoxEdit1);
            Controls.Add(labelControl7);
            Controls.Add(labelControl4);
            Controls.Add(textEdit2);
            Controls.Add(labelControl3);
            Controls.Add(textEdit1);
            Controls.Add(labelControl1);
            Controls.Add(panelControl1);
            Controls.Add(panelControl2);
            Controls.Add(panelControl3);
            Controls.Add(panelControl4);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "PaymentSummaryForm";
            Text = "Πληρωμή";
            Load += PaymentSummaryForm_Load;
            ((System.ComponentModel.ISupportInitialize)textEdit1.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)textEdit2.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)textEdit3.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)comboBoxEdit1.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)spinEdit1.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)spinEdit2.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)panelControl1).EndInit();
            panelControl1.ResumeLayout(false);
            panelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)panelControl2).EndInit();
            panelControl2.ResumeLayout(false);
            panelControl2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)panelControl3).EndInit();
            panelControl3.ResumeLayout(false);
            panelControl3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)panelControl4).EndInit();
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
        private DevExpress.XtraEditors.SimpleButton simpleButton2;
        private DevExpress.XtraEditors.SimpleButton simpleButton3;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.PanelControl panelControl2;
        private DevExpress.XtraEditors.PanelControl panelControl3;
        private DevExpress.XtraEditors.PanelControl panelControl4;
    }
}