namespace BSMS.Winforms.Forms
{
    partial class StockProductForm
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StockProductForm));
            ribbon = new DevExpress.XtraBars.Ribbon.RibbonControl();
            barButtonItem1 = new DevExpress.XtraBars.BarButtonItem();
            barButtonItem2 = new DevExpress.XtraBars.BarButtonItem();
            barButtonItem3 = new DevExpress.XtraBars.BarButtonItem();
            barButtonItem4 = new DevExpress.XtraBars.BarButtonItem();
            barExitbtn = new DevExpress.XtraBars.BarButtonItem();
            ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            ribbonPageGroup2 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            ribbonStatusBar = new DevExpress.XtraBars.Ribbon.RibbonStatusBar();
            panelControl1 = new DevExpress.XtraEditors.PanelControl();
            textEdit1 = new DevExpress.XtraEditors.TextEdit();
            label2 = new Label();
            dateEdit1 = new DevExpress.XtraEditors.DateEdit();
            label1 = new Label();
            panelControl2 = new DevExpress.XtraEditors.PanelControl();
            txtStock = new DevExpress.XtraEditors.TextEdit();
            label7 = new Label();
            textEdit3 = new DevExpress.XtraEditors.TextEdit();
            label4 = new Label();
            textEdit2 = new DevExpress.XtraEditors.TextEdit();
            lookUpEdit1 = new DevExpress.XtraEditors.LookUpEdit();
            productsBindingSource = new BindingSource(components);
            label6 = new Label();
            label3 = new Label();
            stockProductsBindingSource = new BindingSource(components);
            gridControl1 = new DevExpress.XtraGrid.GridControl();
            gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            colProductId = new DevExpress.XtraGrid.Columns.GridColumn();
            colProductCode = new DevExpress.XtraGrid.Columns.GridColumn();
            colProductTitle = new DevExpress.XtraGrid.Columns.GridColumn();
            colProductQuantity = new DevExpress.XtraGrid.Columns.GridColumn();
            colStockRegistrationDate = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)ribbon).BeginInit();
            ((System.ComponentModel.ISupportInitialize)panelControl1).BeginInit();
            panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)textEdit1.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dateEdit1.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dateEdit1.Properties.CalendarTimeProperties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)panelControl2).BeginInit();
            panelControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)txtStock.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)textEdit3.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)textEdit2.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)lookUpEdit1.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)productsBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)stockProductsBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)gridControl1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)gridView1).BeginInit();
            SuspendLayout();
            // 
            // ribbon
            // 
            ribbon.ExpandCollapseItem.Id = 0;
            ribbon.Items.AddRange(new DevExpress.XtraBars.BarItem[] { ribbon.ExpandCollapseItem, ribbon.SearchEditItem, barButtonItem1, barButtonItem2, barButtonItem3, barButtonItem4, barExitbtn });
            ribbon.Location = new Point(0, 0);
            ribbon.MaxItemId = 6;
            ribbon.Name = "ribbon";
            ribbon.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] { ribbonPage1 });
            ribbon.Size = new Size(1166, 193);
            ribbon.StatusBar = ribbonStatusBar;
            // 
            // barButtonItem1
            // 
            barButtonItem1.Caption = "Add Stock";
            barButtonItem1.Id = 1;
            barButtonItem1.ImageOptions.SvgImage = (DevExpress.Utils.Svg.SvgImage)resources.GetObject("barButtonItem1.ImageOptions.SvgImage");
            barButtonItem1.Name = "barButtonItem1";
            // 
            // barButtonItem2
            // 
            barButtonItem2.Caption = "Καταχώρηση";
            barButtonItem2.Id = 2;
            barButtonItem2.ImageOptions.SvgImage = (DevExpress.Utils.Svg.SvgImage)resources.GetObject("barButtonItem2.ImageOptions.SvgImage");
            barButtonItem2.Name = "barButtonItem2";
            barButtonItem2.ItemClick += barButtonItem2_ItemClick;
            // 
            // barButtonItem3
            // 
            barButtonItem3.Caption = "Ακύρωση";
            barButtonItem3.Id = 3;
            barButtonItem3.ImageOptions.SvgImage = (DevExpress.Utils.Svg.SvgImage)resources.GetObject("barButtonItem3.ImageOptions.SvgImage");
            barButtonItem3.Name = "barButtonItem3";
            // 
            // barButtonItem4
            // 
            barButtonItem4.Caption = "Διαγραφή ";
            barButtonItem4.Id = 4;
            barButtonItem4.ImageOptions.SvgImage = (DevExpress.Utils.Svg.SvgImage)resources.GetObject("barButtonItem4.ImageOptions.SvgImage");
            barButtonItem4.Name = "barButtonItem4";
            // 
            // barExitbtn
            // 
            barExitbtn.Caption = "Close";
            barExitbtn.Id = 5;
            barExitbtn.ImageOptions.SvgImage = (DevExpress.Utils.Svg.SvgImage)resources.GetObject("barExitbtn.ImageOptions.SvgImage");
            barExitbtn.Name = "barExitbtn";
            barExitbtn.ItemClick += barExitbtn_ItemClick;
            // 
            // ribbonPage1
            // 
            ribbonPage1.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] { ribbonPageGroup1, ribbonPageGroup2 });
            ribbonPage1.Name = "ribbonPage1";
            ribbonPage1.Text = "Απόθεμα Προϊόντων";
            // 
            // ribbonPageGroup1
            // 
            ribbonPageGroup1.ItemLinks.Add(barButtonItem1);
            ribbonPageGroup1.ItemLinks.Add(barButtonItem2);
            ribbonPageGroup1.ItemLinks.Add(barButtonItem3);
            ribbonPageGroup1.ItemLinks.Add(barButtonItem4);
            ribbonPageGroup1.Name = "ribbonPageGroup1";
            // 
            // ribbonPageGroup2
            // 
            ribbonPageGroup2.ItemLinks.Add(barExitbtn);
            ribbonPageGroup2.Name = "ribbonPageGroup2";
            // 
            // ribbonStatusBar
            // 
            ribbonStatusBar.Location = new Point(0, 746);
            ribbonStatusBar.Name = "ribbonStatusBar";
            ribbonStatusBar.Ribbon = ribbon;
            ribbonStatusBar.Size = new Size(1166, 30);
            // 
            // panelControl1
            // 
            panelControl1.Controls.Add(textEdit1);
            panelControl1.Controls.Add(label2);
            panelControl1.Controls.Add(dateEdit1);
            panelControl1.Controls.Add(label1);
            panelControl1.Location = new Point(12, 199);
            panelControl1.Name = "panelControl1";
            panelControl1.Size = new Size(389, 88);
            panelControl1.TabIndex = 2;
            // 
            // textEdit1
            // 
            textEdit1.Enabled = false;
            textEdit1.Location = new Point(103, 54);
            textEdit1.MenuManager = ribbon;
            textEdit1.Name = "textEdit1";
            textEdit1.Properties.Appearance.Font = new Font("Tahoma", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            textEdit1.Properties.Appearance.Options.UseFont = true;
            textEdit1.Size = new Size(170, 28);
            textEdit1.TabIndex = 27;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Tahoma", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(9, 57);
            label2.Name = "label2";
            label2.Size = new Size(87, 21);
            label2.TabIndex = 15;
            label2.Text = "ProductId:";
            // 
            // dateEdit1
            // 
            dateEdit1.EditValue = null;
            dateEdit1.Location = new Point(103, 6);
            dateEdit1.Margin = new Padding(4);
            dateEdit1.MenuManager = ribbon;
            dateEdit1.Name = "dateEdit1";
            dateEdit1.Properties.Appearance.Font = new Font("Tahoma", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            dateEdit1.Properties.Appearance.Options.UseFont = true;
            dateEdit1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] { new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo) });
            dateEdit1.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] { new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo) });
            dateEdit1.Size = new Size(170, 28);
            dateEdit1.TabIndex = 14;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Tahoma", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(9, 9);
            label1.Name = "label1";
            label1.Size = new Size(75, 21);
            label1.TabIndex = 13;
            label1.Text = "ΗΜ/ΝΙΑ:";
            // 
            // panelControl2
            // 
            panelControl2.Controls.Add(txtStock);
            panelControl2.Controls.Add(label7);
            panelControl2.Controls.Add(textEdit3);
            panelControl2.Controls.Add(label4);
            panelControl2.Controls.Add(textEdit2);
            panelControl2.Controls.Add(lookUpEdit1);
            panelControl2.Controls.Add(label6);
            panelControl2.Controls.Add(label3);
            panelControl2.Location = new Point(407, 199);
            panelControl2.Name = "panelControl2";
            panelControl2.Size = new Size(747, 88);
            panelControl2.TabIndex = 3;
            // 
            // txtStock
            // 
            txtStock.Enabled = false;
            txtStock.Location = new Point(612, 32);
            txtStock.Margin = new Padding(4, 2, 4, 2);
            txtStock.MenuManager = ribbon;
            txtStock.Name = "txtStock";
            txtStock.Properties.Appearance.Font = new Font("Tahoma", 9F, FontStyle.Regular, GraphicsUnit.Point);
            txtStock.Properties.Appearance.Options.UseFont = true;
            txtStock.Size = new Size(85, 24);
            txtStock.TabIndex = 33;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Tahoma", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(565, 9);
            label7.Name = "label7";
            label7.Size = new Size(177, 21);
            label7.TabIndex = 32;
            label7.Text = "Available Qty in Stock:";
            // 
            // textEdit3
            // 
            textEdit3.Enabled = false;
            textEdit3.Location = new Point(127, 54);
            textEdit3.MenuManager = ribbon;
            textEdit3.Name = "textEdit3";
            textEdit3.Properties.Appearance.Font = new Font("Tahoma", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            textEdit3.Properties.Appearance.Options.UseFont = true;
            textEdit3.Size = new Size(117, 28);
            textEdit3.TabIndex = 31;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Tahoma", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(12, 9);
            label4.Name = "label4";
            label4.Size = new Size(110, 21);
            label4.TabIndex = 30;
            label4.Text = "Product Title:";
            // 
            // textEdit2
            // 
            textEdit2.Location = new Point(397, 55);
            textEdit2.MenuManager = ribbon;
            textEdit2.Name = "textEdit2";
            textEdit2.Properties.Appearance.Font = new Font("Tahoma", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            textEdit2.Properties.Appearance.Options.UseFont = true;
            textEdit2.Size = new Size(117, 28);
            textEdit2.TabIndex = 28;
            // 
            // lookUpEdit1
            // 
            lookUpEdit1.Location = new Point(128, 6);
            lookUpEdit1.MenuManager = ribbon;
            lookUpEdit1.Name = "lookUpEdit1";
            lookUpEdit1.Properties.Appearance.Font = new Font("Tahoma", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            lookUpEdit1.Properties.Appearance.Options.UseFont = true;
            lookUpEdit1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] { new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo) });
            lookUpEdit1.Properties.DataSource = productsBindingSource;
            lookUpEdit1.Properties.DisplayMember = "Product";
            lookUpEdit1.Properties.NullText = "";
            lookUpEdit1.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            lookUpEdit1.Properties.ValueMember = "ProductID";
            lookUpEdit1.Size = new Size(386, 28);
            lookUpEdit1.TabIndex = 26;
            lookUpEdit1.EditValueChanged += lookUpEdit1_EditValueChanged;
            // 
            // productsBindingSource
            // 
            productsBindingSource.DataSource = typeof(Models.Products);
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Tahoma", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(288, 57);
            label6.Name = "label6";
            label6.Size = new Size(103, 21);
            label6.TabIndex = 24;
            label6.Text = "Product Qty:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Tahoma", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(12, 57);
            label3.Name = "label3";
            label3.Size = new Size(109, 21);
            label3.TabIndex = 18;
            label3.Text = "ProductCode:";
            // 
            // stockProductsBindingSource
            // 
            stockProductsBindingSource.DataSource = typeof(Models.StockProducts);
            // 
            // gridControl1
            // 
            gridControl1.DataSource = productsBindingSource;
            gridControl1.Location = new Point(12, 293);
            gridControl1.MainView = gridView1;
            gridControl1.MenuManager = ribbon;
            gridControl1.Name = "gridControl1";
            gridControl1.Size = new Size(1142, 447);
            gridControl1.TabIndex = 4;
            gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] { gridView1 });
            // 
            // gridView1
            // 
            gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] { colProductId, colProductCode, colProductTitle, colProductQuantity, colStockRegistrationDate });
            gridView1.GridControl = gridControl1;
            gridView1.Name = "gridView1";
            gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // colProductId
            // 
            colProductId.Caption = "Product Id";
            colProductId.FieldName = "ProductId";
            colProductId.MinWidth = 25;
            colProductId.Name = "colProductId";
            colProductId.Visible = true;
            colProductId.VisibleIndex = 0;
            colProductId.Width = 94;
            // 
            // colProductCode
            // 
            colProductCode.Caption = "Product Code";
            colProductCode.FieldName = "ProductCode";
            colProductCode.MinWidth = 25;
            colProductCode.Name = "colProductCode";
            colProductCode.Visible = true;
            colProductCode.VisibleIndex = 1;
            colProductCode.Width = 94;
            // 
            // colProductTitle
            // 
            colProductTitle.Caption = "Product Title";
            colProductTitle.FieldName = "ProductTitle";
            colProductTitle.MinWidth = 25;
            colProductTitle.Name = "colProductTitle";
            colProductTitle.Visible = true;
            colProductTitle.VisibleIndex = 2;
            colProductTitle.Width = 94;
            // 
            // colProductQuantity
            // 
            colProductQuantity.Caption = "Product Quantity";
            colProductQuantity.FieldName = "ProductQuantity";
            colProductQuantity.MinWidth = 25;
            colProductQuantity.Name = "colProductQuantity";
            colProductQuantity.Visible = true;
            colProductQuantity.VisibleIndex = 3;
            colProductQuantity.Width = 94;
            // 
            // colStockRegistrationDate
            // 
            colStockRegistrationDate.Caption = "Stock Registration Date";
            colStockRegistrationDate.FieldName = "StockRegistrationDate";
            colStockRegistrationDate.MinWidth = 25;
            colStockRegistrationDate.Name = "colStockRegistrationDate";
            colStockRegistrationDate.Visible = true;
            colStockRegistrationDate.VisibleIndex = 4;
            colStockRegistrationDate.Width = 94;
            // 
            // StockProduct
            // 
            AutoScaleDimensions = new SizeF(7F, 16F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1166, 776);
            Controls.Add(gridControl1);
            Controls.Add(panelControl2);
            Controls.Add(panelControl1);
            Controls.Add(ribbonStatusBar);
            Controls.Add(ribbon);
            Name = "StockProduct";
            Ribbon = ribbon;
            StatusBar = ribbonStatusBar;
            Text = "StockProduct";
            Load += StockProduct_Load;
            ((System.ComponentModel.ISupportInitialize)ribbon).EndInit();
            ((System.ComponentModel.ISupportInitialize)panelControl1).EndInit();
            panelControl1.ResumeLayout(false);
            panelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)textEdit1.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)dateEdit1.Properties.CalendarTimeProperties).EndInit();
            ((System.ComponentModel.ISupportInitialize)dateEdit1.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)panelControl2).EndInit();
            panelControl2.ResumeLayout(false);
            panelControl2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)txtStock.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)textEdit3.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)textEdit2.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)lookUpEdit1.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)productsBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)stockProductsBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)gridControl1).EndInit();
            ((System.ComponentModel.ISupportInitialize)gridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbon;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraBars.Ribbon.RibbonStatusBar ribbonStatusBar;
        private DevExpress.XtraBars.BarButtonItem barButtonItem1;
        private DevExpress.XtraBars.BarButtonItem barButtonItem2;
        private DevExpress.XtraBars.BarButtonItem barButtonItem3;
        private DevExpress.XtraBars.BarButtonItem barButtonItem4;
        private DevExpress.XtraBars.BarButtonItem barExitbtn;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup2;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.PanelControl panelControl2;
        private Label label2;
        private DevExpress.XtraEditors.DateEdit dateEdit1;
        private Label label1;
        private Label label6;
        private Label label3;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colProductCode;
        private DevExpress.XtraGrid.Columns.GridColumn colProductQuantity;
        private DevExpress.XtraGrid.Columns.GridColumn colStockRegistrationDate;
        private DevExpress.XtraEditors.TextEdit textEdit1;
        private DevExpress.XtraEditors.TextEdit textEdit2;
        private DevExpress.XtraEditors.LookUpEdit lookUpEdit1;
        private Label label4;
        private DevExpress.XtraGrid.Columns.GridColumn colProductTitle;
        private BindingSource stockProductsBindingSource;
        private DevExpress.XtraGrid.Columns.GridColumn colProductId;
        private DevExpress.XtraEditors.TextEdit textEdit3;
        private BindingSource productsBindingSource;
        private Label label7;
        private DevExpress.XtraEditors.TextEdit txtStock;
    }
}