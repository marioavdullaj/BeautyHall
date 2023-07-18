namespace BSMS.Winforms.Forms
{
    partial class InsertClient
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InsertClient));
            ribbon = new DevExpress.XtraBars.Ribbon.RibbonControl();
            barButtonItem1 = new DevExpress.XtraBars.BarButtonItem();
            SaveClientButton = new DevExpress.XtraBars.BarButtonItem();
            CancelClientButton = new DevExpress.XtraBars.BarButtonItem();
            EditClientButton = new DevExpress.XtraBars.BarButtonItem();
            Εγγραφη = new DevExpress.XtraBars.Ribbon.RibbonPage();
            ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            ribbonStatusBar = new DevExpress.XtraBars.Ribbon.RibbonStatusBar();
            ClientHeaderPanel = new DevExpress.XtraEditors.PanelControl();
            textEdit2 = new DevExpress.XtraEditors.TextEdit();
            labelControl6 = new DevExpress.XtraEditors.LabelControl();
            dateEdit1 = new DevExpress.XtraEditors.DateEdit();
            labelControl5 = new DevExpress.XtraEditors.LabelControl();
            textBox3 = new TextBox();
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            labelControl4 = new DevExpress.XtraEditors.LabelControl();
            labelControl3 = new DevExpress.XtraEditors.LabelControl();
            labelControl2 = new DevExpress.XtraEditors.LabelControl();
            labelControl1 = new DevExpress.XtraEditors.LabelControl();
            panelControl2 = new DevExpress.XtraEditors.PanelControl();
            lookUpEdit1 = new DevExpress.XtraEditors.LookUpEdit();
            panelControl3 = new DevExpress.XtraEditors.PanelControl();
            gridControl1 = new DevExpress.XtraGrid.GridControl();
            gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            ((System.ComponentModel.ISupportInitialize)ribbon).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ClientHeaderPanel).BeginInit();
            ClientHeaderPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)textEdit2.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dateEdit1.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dateEdit1.Properties.CalendarTimeProperties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)panelControl2).BeginInit();
            panelControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)lookUpEdit1.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)panelControl3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)gridControl1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)gridView1).BeginInit();
            SuspendLayout();
            // 
            // ribbon
            // 
            ribbon.ExpandCollapseItem.Id = 0;
            ribbon.Items.AddRange(new DevExpress.XtraBars.BarItem[] { ribbon.ExpandCollapseItem, ribbon.SearchEditItem, barButtonItem1, SaveClientButton, CancelClientButton, EditClientButton });
            ribbon.Location = new Point(0, 0);
            ribbon.MaxItemId = 5;
            ribbon.Name = "ribbon";
            ribbon.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] { Εγγραφη });
            ribbon.Size = new Size(1361, 193);
            ribbon.StatusBar = ribbonStatusBar;
            // 
            // barButtonItem1
            // 
            barButtonItem1.Caption = "Εγγραφή";
            barButtonItem1.Id = 1;
            barButtonItem1.ImageOptions.Image = (Image)resources.GetObject("barButtonItem1.ImageOptions.Image");
            barButtonItem1.ImageOptions.LargeImage = (Image)resources.GetObject("barButtonItem1.ImageOptions.LargeImage");
            barButtonItem1.Name = "barButtonItem1";
            barButtonItem1.ItemClick += barButtonItem1_ItemClick;
            // 
            // SaveClientButton
            // 
            SaveClientButton.Caption = "Καταχώρηση";
            SaveClientButton.Id = 2;
            SaveClientButton.ImageOptions.Image = (Image)resources.GetObject("SaveClientButton.ImageOptions.Image");
            SaveClientButton.ImageOptions.LargeImage = (Image)resources.GetObject("SaveClientButton.ImageOptions.LargeImage");
            SaveClientButton.Name = "SaveClientButton";
            SaveClientButton.ItemClick += SaveClientButton_ItemClick;
            // 
            // CancelClientButton
            // 
            CancelClientButton.Caption = "Ακύρωση";
            CancelClientButton.Id = 3;
            CancelClientButton.ImageOptions.Image = (Image)resources.GetObject("CancelClientButton.ImageOptions.Image");
            CancelClientButton.ImageOptions.LargeImage = (Image)resources.GetObject("CancelClientButton.ImageOptions.LargeImage");
            CancelClientButton.Name = "CancelClientButton";
            // 
            // EditClientButton
            // 
            EditClientButton.Caption = "Επεξεργασία";
            EditClientButton.Id = 4;
            EditClientButton.ImageOptions.Image = (Image)resources.GetObject("EditClientButton.ImageOptions.Image");
            EditClientButton.ImageOptions.LargeImage = (Image)resources.GetObject("EditClientButton.ImageOptions.LargeImage");
            EditClientButton.Name = "EditClientButton";
            // 
            // Εγγραφη
            // 
            Εγγραφη.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] { ribbonPageGroup1 });
            Εγγραφη.Name = "Εγγραφη";
            Εγγραφη.Text = "Εγγραφή Πελάτη";
            // 
            // ribbonPageGroup1
            // 
            ribbonPageGroup1.ItemLinks.Add(barButtonItem1);
            ribbonPageGroup1.ItemLinks.Add(SaveClientButton);
            ribbonPageGroup1.ItemLinks.Add(CancelClientButton);
            ribbonPageGroup1.ItemLinks.Add(EditClientButton);
            ribbonPageGroup1.Name = "ribbonPageGroup1";
            // 
            // ribbonStatusBar
            // 
            ribbonStatusBar.Location = new Point(0, 766);
            ribbonStatusBar.Name = "ribbonStatusBar";
            ribbonStatusBar.Ribbon = ribbon;
            ribbonStatusBar.Size = new Size(1361, 30);
            // 
            // ClientHeaderPanel
            // 
            ClientHeaderPanel.Controls.Add(textEdit2);
            ClientHeaderPanel.Controls.Add(labelControl6);
            ClientHeaderPanel.Controls.Add(dateEdit1);
            ClientHeaderPanel.Controls.Add(labelControl5);
            ClientHeaderPanel.Controls.Add(textBox3);
            ClientHeaderPanel.Controls.Add(textBox2);
            ClientHeaderPanel.Controls.Add(textBox1);
            ClientHeaderPanel.Controls.Add(labelControl4);
            ClientHeaderPanel.Controls.Add(labelControl3);
            ClientHeaderPanel.Controls.Add(labelControl2);
            ClientHeaderPanel.Controls.Add(labelControl1);
            ClientHeaderPanel.Controls.Add(panelControl2);
            ClientHeaderPanel.Controls.Add(panelControl3);
            ClientHeaderPanel.Dock = DockStyle.Top;
            ClientHeaderPanel.Location = new Point(0, 193);
            ClientHeaderPanel.Name = "ClientHeaderPanel";
            ClientHeaderPanel.Size = new Size(1361, 132);
            ClientHeaderPanel.TabIndex = 2;
            // 
            // textEdit2
            // 
            textEdit2.Location = new Point(105, 22);
            textEdit2.MenuManager = ribbon;
            textEdit2.Name = "textEdit2";
            textEdit2.Properties.Appearance.Font = new Font("Tahoma", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            textEdit2.Properties.Appearance.Options.UseFont = true;
            textEdit2.Size = new Size(185, 28);
            textEdit2.TabIndex = 11;
            // 
            // labelControl6
            // 
            labelControl6.Appearance.Font = new Font("Tahoma", 10F, FontStyle.Regular, GraphicsUnit.Point);
            labelControl6.Appearance.Options.UseFont = true;
            labelControl6.Location = new Point(6, 95);
            labelControl6.Margin = new Padding(4);
            labelControl6.Name = "labelControl6";
            labelControl6.Size = new Size(91, 21);
            labelControl6.TabIndex = 10;
            labelControl6.Text = "Insert Date:";
            // 
            // dateEdit1
            // 
            dateEdit1.EditValue = null;
            dateEdit1.Location = new Point(105, 93);
            dateEdit1.Margin = new Padding(4);
            dateEdit1.MenuManager = ribbon;
            dateEdit1.Name = "dateEdit1";
            dateEdit1.Properties.Appearance.Font = new Font("Tahoma", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            dateEdit1.Properties.Appearance.Options.UseFont = true;
            dateEdit1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] { new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo) });
            dateEdit1.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] { new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo) });
            dateEdit1.Size = new Size(185, 28);
            dateEdit1.TabIndex = 9;
            // 
            // labelControl5
            // 
            labelControl5.Appearance.Font = new Font("Tahoma", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            labelControl5.Appearance.Options.UseFont = true;
            labelControl5.Location = new Point(6, 24);
            labelControl5.Name = "labelControl5";
            labelControl5.Size = new Size(63, 21);
            labelControl5.TabIndex = 8;
            labelControl5.Text = "ClientId:";
            // 
            // textBox3
            // 
            textBox3.Font = new Font("Tahoma", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            textBox3.Location = new Point(779, 92);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(282, 28);
            textBox3.TabIndex = 7;
            // 
            // textBox2
            // 
            textBox2.Font = new Font("Tahoma", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            textBox2.Location = new Point(779, 21);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(282, 28);
            textBox2.TabIndex = 6;
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Tahoma", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            textBox1.Location = new Point(424, 92);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(282, 28);
            textBox1.TabIndex = 5;
            // 
            // labelControl4
            // 
            labelControl4.Appearance.Font = new Font("Tahoma", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            labelControl4.Appearance.Options.UseFont = true;
            labelControl4.Location = new Point(726, 94);
            labelControl4.Name = "labelControl4";
            labelControl4.Size = new Size(47, 21);
            labelControl4.TabIndex = 3;
            labelControl4.Text = "Email:";
            // 
            // labelControl3
            // 
            labelControl3.Appearance.Font = new Font("Tahoma", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            labelControl3.Appearance.Options.UseFont = true;
            labelControl3.Location = new Point(726, 24);
            labelControl3.Name = "labelControl3";
            labelControl3.Size = new Size(38, 21);
            labelControl3.TabIndex = 2;
            labelControl3.Text = "Τηλ.:";
            // 
            // labelControl2
            // 
            labelControl2.Appearance.Font = new Font("Tahoma", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            labelControl2.Appearance.Options.UseFont = true;
            labelControl2.Location = new Point(343, 94);
            labelControl2.Name = "labelControl2";
            labelControl2.Size = new Size(56, 21);
            labelControl2.TabIndex = 1;
            labelControl2.Text = "Όνομα:";
            // 
            // labelControl1
            // 
            labelControl1.Appearance.Font = new Font("Tahoma", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            labelControl1.Appearance.Options.UseFont = true;
            labelControl1.Location = new Point(343, 24);
            labelControl1.Name = "labelControl1";
            labelControl1.Size = new Size(75, 21);
            labelControl1.TabIndex = 0;
            labelControl1.Text = "Επώνυμο:";
            // 
            // panelControl2
            // 
            panelControl2.Controls.Add(lookUpEdit1);
            panelControl2.Location = new Point(322, 2);
            panelControl2.Name = "panelControl2";
            panelControl2.Size = new Size(774, 125);
            panelControl2.TabIndex = 12;
            // 
            // lookUpEdit1
            // 
            lookUpEdit1.Location = new Point(102, 19);
            lookUpEdit1.MenuManager = ribbon;
            lookUpEdit1.Name = "lookUpEdit1";
            lookUpEdit1.Properties.Appearance.Font = new Font("Tahoma", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            lookUpEdit1.Properties.Appearance.Options.UseFont = true;
            lookUpEdit1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] { new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo) });
            lookUpEdit1.Properties.NullText = "";
            lookUpEdit1.Properties.PopupFilterMode = DevExpress.XtraEditors.PopupFilterMode.Contains;
            lookUpEdit1.Properties.SearchMode = DevExpress.XtraEditors.Controls.SearchMode.AutoSuggest;
            lookUpEdit1.Size = new Size(282, 28);
            lookUpEdit1.TabIndex = 0;
            // 
            // panelControl3
            // 
            panelControl3.Location = new Point(0, 2);
            panelControl3.Name = "panelControl3";
            panelControl3.Size = new Size(322, 125);
            panelControl3.TabIndex = 13;
            // 
            // gridControl1
            // 
            gridControl1.Dock = DockStyle.Fill;
            gridControl1.Location = new Point(0, 325);
            gridControl1.MainView = gridView1;
            gridControl1.MenuManager = ribbon;
            gridControl1.Name = "gridControl1";
            gridControl1.Size = new Size(1361, 441);
            gridControl1.TabIndex = 5;
            gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] { gridView1 });
            // 
            // gridView1
            // 
            gridView1.GridControl = gridControl1;
            gridView1.Name = "gridView1";
            // 
            // InsertClient
            // 
            AutoScaleDimensions = new SizeF(7F, 16F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1361, 796);
            Controls.Add(gridControl1);
            Controls.Add(ClientHeaderPanel);
            Controls.Add(ribbonStatusBar);
            Controls.Add(ribbon);
            Name = "InsertClient";
            Ribbon = ribbon;
            StatusBar = ribbonStatusBar;
            Text = "InsertClient";
            Load += InsertClient_Load;
            ((System.ComponentModel.ISupportInitialize)ribbon).EndInit();
            ((System.ComponentModel.ISupportInitialize)ClientHeaderPanel).EndInit();
            ClientHeaderPanel.ResumeLayout(false);
            ClientHeaderPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)textEdit2.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)dateEdit1.Properties.CalendarTimeProperties).EndInit();
            ((System.ComponentModel.ISupportInitialize)dateEdit1.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)panelControl2).EndInit();
            panelControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)lookUpEdit1.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)panelControl3).EndInit();
            ((System.ComponentModel.ISupportInitialize)gridControl1).EndInit();
            ((System.ComponentModel.ISupportInitialize)gridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbon;
        private DevExpress.XtraBars.Ribbon.RibbonPage Εγγραφη;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraBars.Ribbon.RibbonStatusBar ribbonStatusBar;
        private DevExpress.XtraBars.BarButtonItem barButtonItem1;
        private DevExpress.XtraBars.BarButtonItem SaveClientButton;
        private DevExpress.XtraBars.BarButtonItem CancelClientButton;
        private DevExpress.XtraBars.BarButtonItem EditClientButton;
        private DevExpress.XtraEditors.PanelControl ClientHeaderPanel;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private TextBox textBox3;
        private TextBox textBox2;
        private TextBox textBox1;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.DateEdit dateEdit1;
        private DevExpress.XtraEditors.TextEdit textEdit2;
        private DevExpress.XtraEditors.PanelControl panelControl2;
        private DevExpress.XtraEditors.PanelControl panelControl3;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraEditors.LookUpEdit lookUpEdit1;
    }
}