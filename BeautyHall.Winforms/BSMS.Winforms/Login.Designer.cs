namespace BSMS
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            textEdit1 = new DevExpress.XtraEditors.TextEdit();
            textEdit2 = new DevExpress.XtraEditors.TextEdit();
            label1 = new Label();
            label2 = new Label();
            simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)textEdit1.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)textEdit2.Properties).BeginInit();
            SuspendLayout();
            // 
            // textEdit1
            // 
            textEdit1.EditValue = "";
            textEdit1.Location = new Point(142, 10);
            textEdit1.Margin = new Padding(4, 4, 4, 4);
            textEdit1.Name = "textEdit1";
            textEdit1.Size = new Size(173, 22);
            textEdit1.TabIndex = 0;
            // 
            // textEdit2
            // 
            textEdit2.Location = new Point(142, 47);
            textEdit2.Margin = new Padding(4, 4, 4, 4);
            textEdit2.Name = "textEdit2";
            textEdit2.Properties.UseSystemPasswordChar = true;
            textEdit2.Size = new Size(173, 22);
            textEdit2.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(26, 12);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(65, 16);
            label1.TabIndex = 2;
            label1.Text = "Username";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(26, 50);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(62, 16);
            label2.TabIndex = 3;
            label2.Text = "Password";
            // 
            // simpleButton1
            // 
            simpleButton1.ImageOptions.SvgImage = (DevExpress.Utils.Svg.SvgImage)resources.GetObject("simpleButton1.ImageOptions.SvgImage");
            simpleButton1.Location = new Point(26, 87);
            simpleButton1.Margin = new Padding(4, 4, 4, 4);
            simpleButton1.Name = "simpleButton1";
            simpleButton1.Size = new Size(289, 48);
            simpleButton1.TabIndex = 4;
            simpleButton1.Text = "Login";
            simpleButton1.Click += simpleButton1_Click;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(7F, 16F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(346, 150);
            Controls.Add(simpleButton1);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textEdit2);
            Controls.Add(textEdit1);
            Margin = new Padding(4, 4, 4, 4);
            Name = "Login";
            Text = "Login";
            Shown += Login_Shown;
            ((System.ComponentModel.ISupportInitialize)textEdit1.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)textEdit2.Properties).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DevExpress.XtraEditors.TextEdit textEdit1;
        private DevExpress.XtraEditors.TextEdit textEdit2;
        private Label label1;
        private Label label2;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
    }
}