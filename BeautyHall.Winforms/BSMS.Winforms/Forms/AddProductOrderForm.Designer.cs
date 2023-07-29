namespace BSMS.Winforms.Forms
{
    partial class AddProductOrderForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddProductOrderForm));
            lookUpEdit1 = new DevExpress.XtraEditors.LookUpEdit();
            labelControl1 = new DevExpress.XtraEditors.LabelControl();
            labelControl2 = new DevExpress.XtraEditors.LabelControl();
            labelControl3 = new DevExpress.XtraEditors.LabelControl();
            labelControl4 = new DevExpress.XtraEditors.LabelControl();
            labelControl5 = new DevExpress.XtraEditors.LabelControl();
            spinEdit1 = new DevExpress.XtraEditors.SpinEdit();
            simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            simpleButton2 = new DevExpress.XtraEditors.SimpleButton();
            textEdit1 = new DevExpress.XtraEditors.TextEdit();
            textEdit2 = new DevExpress.XtraEditors.TextEdit();
            textEdit3 = new DevExpress.XtraEditors.TextEdit();
            textEdit4 = new DevExpress.XtraEditors.TextEdit();
            ((System.ComponentModel.ISupportInitialize)lookUpEdit1.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)spinEdit1.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)textEdit1.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)textEdit2.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)textEdit3.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)textEdit4.Properties).BeginInit();
            SuspendLayout();
            // 
            // lookUpEdit1
            // 
            lookUpEdit1.Location = new Point(29, 12);
            lookUpEdit1.Name = "lookUpEdit1";
            lookUpEdit1.Properties.Appearance.Font = new Font("Tahoma", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            lookUpEdit1.Properties.Appearance.Options.UseFont = true;
            lookUpEdit1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] { new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo) });
            lookUpEdit1.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] { new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ProductCode", "Code"), new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ProductDescription", "Description") });
            lookUpEdit1.Properties.NullText = "Search for a product";
            lookUpEdit1.Properties.SearchMode = DevExpress.XtraEditors.Controls.SearchMode.AutoSuggest;
            lookUpEdit1.Size = new Size(527, 34);
            lookUpEdit1.TabIndex = 0;
            lookUpEdit1.EditValueChanged += lookUpEdit1_EditValueChanged;
            // 
            // labelControl1
            // 
            labelControl1.Appearance.Font = new Font("Tahoma", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            labelControl1.Appearance.Options.UseFont = true;
            labelControl1.Location = new Point(29, 82);
            labelControl1.Name = "labelControl1";
            labelControl1.Size = new Size(133, 28);
            labelControl1.TabIndex = 1;
            labelControl1.Text = "Product code";
            // 
            // labelControl2
            // 
            labelControl2.Appearance.Font = new Font("Tahoma", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            labelControl2.Appearance.Options.UseFont = true;
            labelControl2.Location = new Point(29, 139);
            labelControl2.Name = "labelControl2";
            labelControl2.Size = new Size(195, 28);
            labelControl2.TabIndex = 2;
            labelControl2.Text = "Product description";
            // 
            // labelControl3
            // 
            labelControl3.Appearance.Font = new Font("Tahoma", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            labelControl3.Appearance.Options.UseFont = true;
            labelControl3.Location = new Point(29, 196);
            labelControl3.Name = "labelControl3";
            labelControl3.Size = new Size(149, 28);
            labelControl3.TabIndex = 3;
            labelControl3.Text = "Stock available";
            // 
            // labelControl4
            // 
            labelControl4.Appearance.Font = new Font("Tahoma", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            labelControl4.Appearance.Options.UseFont = true;
            labelControl4.Location = new Point(29, 253);
            labelControl4.Name = "labelControl4";
            labelControl4.Size = new Size(97, 28);
            labelControl4.TabIndex = 4;
            labelControl4.Text = "Unit Price";
            // 
            // labelControl5
            // 
            labelControl5.Appearance.Font = new Font("Tahoma", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            labelControl5.Appearance.Options.UseFont = true;
            labelControl5.Location = new Point(29, 317);
            labelControl5.Name = "labelControl5";
            labelControl5.Size = new Size(125, 28);
            labelControl5.TabIndex = 5;
            labelControl5.Text = "Add in order";
            // 
            // spinEdit1
            // 
            spinEdit1.EditValue = new decimal(new int[] { 0, 0, 0, 0 });
            spinEdit1.Location = new Point(400, 314);
            spinEdit1.Name = "spinEdit1";
            spinEdit1.Properties.Appearance.Font = new Font("Tahoma", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            spinEdit1.Properties.Appearance.Options.UseFont = true;
            spinEdit1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] { new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo) });
            spinEdit1.Size = new Size(156, 34);
            spinEdit1.TabIndex = 6;
            // 
            // simpleButton1
            // 
            simpleButton1.ImageOptions.SvgImage = (DevExpress.Utils.Svg.SvgImage)resources.GetObject("simpleButton1.ImageOptions.SvgImage");
            simpleButton1.Location = new Point(29, 384);
            simpleButton1.Name = "simpleButton1";
            simpleButton1.Size = new Size(258, 54);
            simpleButton1.TabIndex = 7;
            simpleButton1.Text = "Cancel";
            simpleButton1.Click += simpleButton1_Click;
            // 
            // simpleButton2
            // 
            simpleButton2.ImageOptions.SvgImage = (DevExpress.Utils.Svg.SvgImage)resources.GetObject("simpleButton2.ImageOptions.SvgImage");
            simpleButton2.Location = new Point(298, 384);
            simpleButton2.Name = "simpleButton2";
            simpleButton2.Size = new Size(258, 54);
            simpleButton2.TabIndex = 8;
            simpleButton2.Text = "Add";
            simpleButton2.Click += simpleButton2_Click;
            // 
            // textEdit1
            // 
            textEdit1.Enabled = false;
            textEdit1.Location = new Point(298, 76);
            textEdit1.Name = "textEdit1";
            textEdit1.Properties.Appearance.Font = new Font("Tahoma", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            textEdit1.Properties.Appearance.Options.UseFont = true;
            textEdit1.Size = new Size(258, 34);
            textEdit1.TabIndex = 9;
            // 
            // textEdit2
            // 
            textEdit2.Enabled = false;
            textEdit2.Location = new Point(298, 136);
            textEdit2.Name = "textEdit2";
            textEdit2.Properties.Appearance.Font = new Font("Tahoma", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            textEdit2.Properties.Appearance.Options.UseFont = true;
            textEdit2.Size = new Size(258, 34);
            textEdit2.TabIndex = 10;
            // 
            // textEdit3
            // 
            textEdit3.Enabled = false;
            textEdit3.Location = new Point(400, 193);
            textEdit3.Name = "textEdit3";
            textEdit3.Properties.Appearance.Font = new Font("Tahoma", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            textEdit3.Properties.Appearance.Options.UseFont = true;
            textEdit3.Size = new Size(156, 34);
            textEdit3.TabIndex = 11;
            // 
            // textEdit4
            // 
            textEdit4.Enabled = false;
            textEdit4.Location = new Point(400, 250);
            textEdit4.Name = "textEdit4";
            textEdit4.Properties.Appearance.Font = new Font("Tahoma", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            textEdit4.Properties.Appearance.Options.UseFont = true;
            textEdit4.Properties.DisplayFormat.FormatString = "c";
            textEdit4.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            textEdit4.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            textEdit4.Size = new Size(156, 34);
            textEdit4.TabIndex = 12;
            // 
            // AddProductOrderForm
            // 
            AutoScaleDimensions = new SizeF(7F, 16F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(600, 546);
            Controls.Add(textEdit4);
            Controls.Add(textEdit3);
            Controls.Add(textEdit2);
            Controls.Add(textEdit1);
            Controls.Add(simpleButton2);
            Controls.Add(simpleButton1);
            Controls.Add(spinEdit1);
            Controls.Add(labelControl5);
            Controls.Add(labelControl4);
            Controls.Add(labelControl3);
            Controls.Add(labelControl2);
            Controls.Add(labelControl1);
            Controls.Add(lookUpEdit1);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "AddProductOrderForm";
            Text = "Add a product";
            Load += AddProductOrderForm_Load;
            ((System.ComponentModel.ISupportInitialize)lookUpEdit1.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)spinEdit1.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)textEdit1.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)textEdit2.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)textEdit3.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)textEdit4.Properties).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DevExpress.XtraEditors.LookUpEdit lookUpEdit1;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.SpinEdit spinEdit1;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private DevExpress.XtraEditors.SimpleButton simpleButton2;
        private DevExpress.XtraEditors.TextEdit textEdit1;
        private DevExpress.XtraEditors.TextEdit textEdit2;
        private DevExpress.XtraEditors.TextEdit textEdit3;
        private DevExpress.XtraEditors.TextEdit textEdit4;
    }
}