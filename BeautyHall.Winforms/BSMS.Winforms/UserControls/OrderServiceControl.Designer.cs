namespace BSMS.Winforms.UserControls
{
    partial class OrderServiceControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OrderServiceControl));
            labelControl1 = new DevExpress.XtraEditors.LabelControl();
            labelControl2 = new DevExpress.XtraEditors.LabelControl();
            labelControl3 = new DevExpress.XtraEditors.LabelControl();
            labelControl4 = new DevExpress.XtraEditors.LabelControl();
            labelControl5 = new DevExpress.XtraEditors.LabelControl();
            labelControl6 = new DevExpress.XtraEditors.LabelControl();
            simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            SuspendLayout();
            // 
            // labelControl1
            // 
            labelControl1.Appearance.Font = new Font("Tahoma", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            labelControl1.Appearance.Options.UseFont = true;
            labelControl1.Location = new Point(9, 6);
            labelControl1.Margin = new Padding(4, 2, 4, 2);
            labelControl1.Name = "labelControl1";
            labelControl1.Size = new Size(91, 22);
            labelControl1.TabIndex = 0;
            labelControl1.Text = "Υπηρεσία:";
            // 
            // labelControl2
            // 
            labelControl2.Appearance.Font = new Font("Tahoma", 10.5F, FontStyle.Regular, GraphicsUnit.Point);
            labelControl2.Appearance.Options.UseFont = true;
            labelControl2.Location = new Point(115, 7);
            labelControl2.Margin = new Padding(4, 2, 4, 2);
            labelControl2.Name = "labelControl2";
            labelControl2.Size = new Size(97, 21);
            labelControl2.TabIndex = 1;
            labelControl2.Text = "labelControl2";
            // 
            // labelControl3
            // 
            labelControl3.Appearance.Font = new Font("Tahoma", 10.5F, FontStyle.Regular, GraphicsUnit.Point);
            labelControl3.Appearance.Options.UseFont = true;
            labelControl3.Location = new Point(115, 35);
            labelControl3.Margin = new Padding(4, 2, 4, 2);
            labelControl3.Name = "labelControl3";
            labelControl3.Size = new Size(97, 21);
            labelControl3.TabIndex = 3;
            labelControl3.Text = "labelControl3";
            // 
            // labelControl4
            // 
            labelControl4.Appearance.Font = new Font("Tahoma", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            labelControl4.Appearance.Options.UseFont = true;
            labelControl4.Location = new Point(9, 34);
            labelControl4.Margin = new Padding(4, 2, 4, 2);
            labelControl4.Name = "labelControl4";
            labelControl4.Size = new Size(100, 22);
            labelControl4.TabIndex = 2;
            labelControl4.Text = "Κομμωτής:";
            // 
            // labelControl5
            // 
            labelControl5.Appearance.Font = new Font("Tahoma", 10.5F, FontStyle.Regular, GraphicsUnit.Point);
            labelControl5.Appearance.Options.UseFont = true;
            labelControl5.Location = new Point(115, 65);
            labelControl5.Margin = new Padding(4, 2, 4, 2);
            labelControl5.Name = "labelControl5";
            labelControl5.Size = new Size(97, 21);
            labelControl5.TabIndex = 5;
            labelControl5.Text = "labelControl5";
            // 
            // labelControl6
            // 
            labelControl6.Appearance.Font = new Font("Tahoma", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            labelControl6.Appearance.Options.UseFont = true;
            labelControl6.Location = new Point(9, 64);
            labelControl6.Margin = new Padding(4, 2, 4, 2);
            labelControl6.Name = "labelControl6";
            labelControl6.Size = new Size(47, 22);
            labelControl6.TabIndex = 4;
            labelControl6.Text = "Τιμή:";
            // 
            // simpleButton1
            // 
            simpleButton1.ImageOptions.SvgImage = (DevExpress.Utils.Svg.SvgImage)resources.GetObject("simpleButton1.ImageOptions.SvgImage");
            simpleButton1.Location = new Point(261, 8);
            simpleButton1.Margin = new Padding(4, 2, 4, 2);
            simpleButton1.Name = "simpleButton1";
            simpleButton1.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light;
            simpleButton1.Size = new Size(40, 78);
            simpleButton1.TabIndex = 6;
            simpleButton1.Click += simpleButton1_Click;
            // 
            // OrderServiceControl
            // 
            Appearance.BackColor = Color.Gainsboro;
            Appearance.Options.UseBackColor = true;
            AutoScaleDimensions = new SizeF(7F, 16F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(simpleButton1);
            Controls.Add(labelControl5);
            Controls.Add(labelControl6);
            Controls.Add(labelControl3);
            Controls.Add(labelControl4);
            Controls.Add(labelControl2);
            Controls.Add(labelControl1);
            Margin = new Padding(6);
            Name = "OrderServiceControl";
            Size = new Size(317, 96);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
    }
}
