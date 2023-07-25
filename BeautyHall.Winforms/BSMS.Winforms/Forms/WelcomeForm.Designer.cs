namespace BSMS.Winforms.Forms
{
    partial class WelcomeForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WelcomeForm));
            labelControl1 = new DevExpress.XtraEditors.LabelControl();
            pictureEdit1 = new DevExpress.XtraEditors.PictureEdit();
            stackPanel1 = new DevExpress.Utils.Layout.StackPanel();
            ((System.ComponentModel.ISupportInitialize)pictureEdit1.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)stackPanel1).BeginInit();
            stackPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // labelControl1
            // 
            labelControl1.Appearance.Font = new Font("Tahoma", 20.8F, FontStyle.Regular, GraphicsUnit.Point);
            labelControl1.Appearance.ForeColor = SystemColors.Control;
            labelControl1.Appearance.Options.UseFont = true;
            labelControl1.Appearance.Options.UseForeColor = true;
            labelControl1.Location = new Point(149, 193);
            labelControl1.Name = "labelControl1";
            labelControl1.Size = new Size(410, 42);
            labelControl1.TabIndex = 0;
            labelControl1.Text = "Welcome back, Username!";
            // 
            // pictureEdit1
            // 
            pictureEdit1.EditValue = resources.GetObject("pictureEdit1.EditValue");
            pictureEdit1.Location = new Point(3, 173);
            pictureEdit1.Name = "pictureEdit1";
            pictureEdit1.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            pictureEdit1.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Stretch;
            pictureEdit1.Size = new Size(140, 82);
            pictureEdit1.TabIndex = 1;
            // 
            // stackPanel1
            // 
            stackPanel1.Controls.Add(pictureEdit1);
            stackPanel1.Controls.Add(labelControl1);
            stackPanel1.Dock = DockStyle.Fill;
            stackPanel1.Location = new Point(0, 0);
            stackPanel1.Name = "stackPanel1";
            stackPanel1.Size = new Size(677, 428);
            stackPanel1.TabIndex = 2;
            // 
            // WelcomeForm
            // 
            Appearance.BackColor = Color.Transparent;
            Appearance.Options.UseBackColor = true;
            AutoScaleDimensions = new SizeF(7F, 16F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImageLayoutStore = ImageLayout.Stretch;
            BackgroundImageStore = Properties.Resources._2182672;
            ClientSize = new Size(677, 428);
            Controls.Add(stackPanel1);
            Name = "WelcomeForm";
            ((System.ComponentModel.ISupportInitialize)pictureEdit1.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)stackPanel1).EndInit();
            stackPanel1.ResumeLayout(false);
            stackPanel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.PictureEdit pictureEdit1;
        private DevExpress.Utils.Layout.StackPanel stackPanel1;
    }
}