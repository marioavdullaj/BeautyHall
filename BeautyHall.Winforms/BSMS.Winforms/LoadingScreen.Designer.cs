namespace BSMS
{
    partial class LoadingScreen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoadingScreen));
            progressBarControl = new DevExpress.XtraEditors.MarqueeProgressBarControl();
            labelStatus = new DevExpress.XtraEditors.LabelControl();
            peImage = new DevExpress.XtraEditors.PictureEdit();
            ((System.ComponentModel.ISupportInitialize)progressBarControl.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)peImage.Properties).BeginInit();
            SuspendLayout();
            // 
            // progressBarControl
            // 
            progressBarControl.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            progressBarControl.EditValue = 0;
            progressBarControl.Location = new Point(28, 286);
            progressBarControl.Margin = new Padding(4, 4, 4, 4);
            progressBarControl.Name = "progressBarControl";
            progressBarControl.Size = new Size(469, 15);
            progressBarControl.TabIndex = 5;
            // 
            // labelStatus
            // 
            labelStatus.Location = new Point(28, 265);
            labelStatus.Margin = new Padding(4, 4, 4, 1);
            labelStatus.Name = "labelStatus";
            labelStatus.Size = new Size(57, 16);
            labelStatus.TabIndex = 7;
            labelStatus.Text = "Starting...";
            // 
            // peImage
            // 
            peImage.BackgroundImage = Winforms.Properties.Resources.Elena_s_Beauty_Hall_Logo;
            peImage.BackgroundImageLayout = ImageLayout.Zoom;
            peImage.Dock = DockStyle.Top;
            peImage.EditValue = resources.GetObject("peImage.EditValue");
            peImage.Location = new Point(1, 1);
            peImage.Margin = new Padding(4, 4, 4, 4);
            peImage.Name = "peImage";
            peImage.Properties.AllowFocused = false;
            peImage.Properties.Appearance.BackColor = Color.Transparent;
            peImage.Properties.Appearance.Options.UseBackColor = true;
            peImage.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            peImage.Properties.ShowMenu = false;
            peImage.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Stretch;
            peImage.Properties.SvgImageColorizationMode = DevExpress.Utils.SvgImageColorizationMode.None;
            peImage.Size = new Size(523, 246);
            peImage.TabIndex = 9;
            // 
            // LoadingScreen
            // 
            AutoScaleDimensions = new SizeF(7F, 16F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(525, 394);
            Controls.Add(peImage);
            Controls.Add(labelStatus);
            Controls.Add(progressBarControl);
            Margin = new Padding(4, 4, 4, 4);
            Name = "LoadingScreen";
            Padding = new Padding(1);
            Text = "LoadingScreen";
            ((System.ComponentModel.ISupportInitialize)progressBarControl.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)peImage.Properties).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DevExpress.XtraEditors.MarqueeProgressBarControl progressBarControl;
        private DevExpress.XtraEditors.LabelControl labelStatus;
        private DevExpress.XtraEditors.PictureEdit peImage;
    }
}
