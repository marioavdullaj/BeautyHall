namespace BSMS.Winforms.Forms
{
    partial class ProductForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProductForm));
            ribbon = new DevExpress.XtraBars.Ribbon.RibbonControl();
            barAddProduct = new DevExpress.XtraBars.BarButtonItem();
            barSaveProduct = new DevExpress.XtraBars.BarButtonItem();
            barCancelProduct = new DevExpress.XtraBars.BarButtonItem();
            barDeleteProduct = new DevExpress.XtraBars.BarButtonItem();
            barExitForm = new DevExpress.XtraBars.BarButtonItem();
            barButtonItem6 = new DevExpress.XtraBars.BarButtonItem();
            ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            ribbonPageGroup2 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            ribbonStatusBar = new DevExpress.XtraBars.Ribbon.RibbonStatusBar();
            panelControl1 = new DevExpress.XtraEditors.PanelControl();
            txtproductId = new DevExpress.XtraEditors.TextEdit();
            dateEdit1 = new DevExpress.XtraEditors.DateEdit();
            label1 = new Label();
            label6 = new Label();
            label2 = new Label();
            panelControl2 = new DevExpress.XtraEditors.PanelControl();
            txtStock = new DevExpress.XtraEditors.TextEdit();
            label7 = new Label();
            luaProductTitle = new DevExpress.XtraEditors.LookUpEdit();
            txtProductPrice = new DevExpress.XtraEditors.TextEdit();
            txtProductCode = new DevExpress.XtraEditors.TextEdit();
            txtSupplier = new DevExpress.XtraEditors.TextEdit();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            gridControl1 = new DevExpress.XtraGrid.GridControl();
            productsBindingSource = new BindingSource(components);
            gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            ProductId = new DevExpress.XtraGrid.Columns.GridColumn();
            ProductCode = new DevExpress.XtraGrid.Columns.GridColumn();
            ProductDescription = new DevExpress.XtraGrid.Columns.GridColumn();
            SupplierId = new DevExpress.XtraGrid.Columns.GridColumn();
            SellingPrice = new DevExpress.XtraGrid.Columns.GridColumn();
            ProductRegistrationDate = new DevExpress.XtraGrid.Columns.GridColumn();
            ProductHeaderPanel = new DevExpress.XtraEditors.PanelControl();
            ((System.ComponentModel.ISupportInitialize)ribbon).BeginInit();
            ((System.ComponentModel.ISupportInitialize)panelControl1).BeginInit();
            panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)txtproductId.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dateEdit1.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dateEdit1.Properties.CalendarTimeProperties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)panelControl2).BeginInit();
            panelControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)txtStock.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)luaProductTitle.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)txtProductPrice.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)txtProductCode.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)txtSupplier.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)gridControl1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)productsBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)gridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ProductHeaderPanel).BeginInit();
            ProductHeaderPanel.SuspendLayout();
            SuspendLayout();
            // 
            // ribbon
            // 
            ribbon.ExpandCollapseItem.Id = 0;
            ribbon.Items.AddRange(new DevExpress.XtraBars.BarItem[] { ribbon.ExpandCollapseItem, ribbon.SearchEditItem, barAddProduct, barSaveProduct, barCancelProduct, barDeleteProduct, barExitForm, barButtonItem6 });
            ribbon.Location = new Point(0, 0);
            ribbon.MaxItemId = 7;
            ribbon.Name = "ribbon";
            ribbon.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] { ribbonPage1 });
            ribbon.Size = new Size(1328, 193);
            ribbon.StatusBar = ribbonStatusBar;
            // 
            // barAddProduct
            // 
            barAddProduct.Caption = "Add Product";
            barAddProduct.Id = 1;
            barAddProduct.ImageOptions.SvgImage = (DevExpress.Utils.Svg.SvgImage)resources.GetObject("barAddProduct.ImageOptions.SvgImage");
            barAddProduct.Name = "barAddProduct";
            barAddProduct.ItemClick += barAddProduct_ItemClick;
            // 
            // barSaveProduct
            // 
            barSaveProduct.Caption = "Καταχώρηση";
            barSaveProduct.Id = 2;
            barSaveProduct.ImageOptions.SvgImage = (DevExpress.Utils.Svg.SvgImage)resources.GetObject("barSaveProduct.ImageOptions.SvgImage");
            barSaveProduct.Name = "barSaveProduct";
            barSaveProduct.ItemClick += barSaveProduct_ItemClick;
            // 
            // barCancelProduct
            // 
            barCancelProduct.Caption = "Ακύρωση";
            barCancelProduct.Id = 3;
            barCancelProduct.ImageOptions.SvgImage = (DevExpress.Utils.Svg.SvgImage)resources.GetObject("barCancelProduct.ImageOptions.SvgImage");
            barCancelProduct.Name = "barCancelProduct";
            // 
            // barDeleteProduct
            // 
            barDeleteProduct.Caption = "Διαγραφή";
            barDeleteProduct.Id = 4;
            barDeleteProduct.ImageOptions.SvgImage = (DevExpress.Utils.Svg.SvgImage)resources.GetObject("barDeleteProduct.ImageOptions.SvgImage");
            barDeleteProduct.Name = "barDeleteProduct";
            barDeleteProduct.ItemClick += barDeleteProduct_ItemClick;
            // 
            // barExitForm
            // 
            barExitForm.Caption = "Close";
            barExitForm.Id = 5;
            barExitForm.ImageOptions.SvgImage = (DevExpress.Utils.Svg.SvgImage)resources.GetObject("barExitForm.ImageOptions.SvgImage");
            barExitForm.Name = "barExitForm";
            barExitForm.ItemClick += barExitForm_ItemClick;
            // 
            // barButtonItem6
            // 
            barButtonItem6.Caption = "Open Stock Product";
            barButtonItem6.Id = 6;
            barButtonItem6.ImageOptions.SvgImage = (DevExpress.Utils.Svg.SvgImage)resources.GetObject("barButtonItem6.ImageOptions.SvgImage");
            barButtonItem6.Name = "barButtonItem6";
            barButtonItem6.ItemClick += barButtonItem6_ItemClick;
            // 
            // ribbonPage1
            // 
            ribbonPage1.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] { ribbonPageGroup1, ribbonPageGroup2 });
            ribbonPage1.Name = "ribbonPage1";
            ribbonPage1.Text = "Εγγραφή Προϊόντων";
            // 
            // ribbonPageGroup1
            // 
            ribbonPageGroup1.ItemLinks.Add(barAddProduct);
            ribbonPageGroup1.ItemLinks.Add(barSaveProduct);
            ribbonPageGroup1.ItemLinks.Add(barCancelProduct);
            ribbonPageGroup1.ItemLinks.Add(barDeleteProduct);
            ribbonPageGroup1.Name = "ribbonPageGroup1";
            // 
            // ribbonPageGroup2
            // 
            ribbonPageGroup2.ItemLinks.Add(barButtonItem6);
            ribbonPageGroup2.ItemLinks.Add(barExitForm);
            ribbonPageGroup2.Name = "ribbonPageGroup2";
            // 
            // ribbonStatusBar
            // 
            ribbonStatusBar.Location = new Point(0, 783);
            ribbonStatusBar.Name = "ribbonStatusBar";
            ribbonStatusBar.Ribbon = ribbon;
            ribbonStatusBar.Size = new Size(1328, 30);
            // 
            // panelControl1
            // 
            panelControl1.Controls.Add(txtproductId);
            panelControl1.Controls.Add(dateEdit1);
            panelControl1.Controls.Add(label1);
            panelControl1.Controls.Add(label6);
            panelControl1.Location = new Point(5, 5);
            panelControl1.Name = "panelControl1";
            panelControl1.Size = new Size(319, 95);
            panelControl1.TabIndex = 2;
            // 
            // txtproductId
            // 
            txtproductId.Enabled = false;
            txtproductId.Location = new Point(129, 63);
            txtproductId.Margin = new Padding(4, 2, 4, 2);
            txtproductId.MenuManager = ribbon;
            txtproductId.Name = "txtproductId";
            txtproductId.Properties.Appearance.Font = new Font("Tahoma", 9F, FontStyle.Regular, GraphicsUnit.Point);
            txtproductId.Properties.Appearance.Options.UseFont = true;
            txtproductId.Size = new Size(140, 24);
            txtproductId.TabIndex = 17;
            // 
            // dateEdit1
            // 
            dateEdit1.EditValue = null;
            dateEdit1.Location = new Point(129, 15);
            dateEdit1.Margin = new Padding(4);
            dateEdit1.MenuManager = ribbon;
            dateEdit1.Name = "dateEdit1";
            dateEdit1.Properties.Appearance.Font = new Font("Tahoma", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dateEdit1.Properties.Appearance.Options.UseFont = true;
            dateEdit1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] { new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo) });
            dateEdit1.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] { new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo) });
            dateEdit1.Size = new Size(140, 24);
            dateEdit1.TabIndex = 10;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Tahoma", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(5, 16);
            label1.Name = "label1";
            label1.Size = new Size(75, 21);
            label1.TabIndex = 0;
            label1.Text = "ΗΜ/ΝΙΑ:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Tahoma", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(5, 64);
            label6.Name = "label6";
            label6.Size = new Size(87, 21);
            label6.TabIndex = 16;
            label6.Text = "ProductId:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Tahoma", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(434, 12);
            label2.Name = "label2";
            label2.Size = new Size(109, 21);
            label2.TabIndex = 11;
            label2.Text = "ProductCode:";
            // 
            // panelControl2
            // 
            panelControl2.Controls.Add(txtStock);
            panelControl2.Controls.Add(label7);
            panelControl2.Controls.Add(luaProductTitle);
            panelControl2.Controls.Add(txtProductPrice);
            panelControl2.Controls.Add(txtProductCode);
            panelControl2.Controls.Add(txtSupplier);
            panelControl2.Controls.Add(label2);
            panelControl2.Controls.Add(label5);
            panelControl2.Controls.Add(label4);
            panelControl2.Controls.Add(label3);
            panelControl2.Location = new Point(330, 7);
            panelControl2.Name = "panelControl2";
            panelControl2.Size = new Size(986, 95);
            panelControl2.TabIndex = 3;
            // 
            // txtStock
            // 
            txtStock.Enabled = false;
            txtStock.Location = new Point(819, 42);
            txtStock.Margin = new Padding(4, 2, 4, 2);
            txtStock.MenuManager = ribbon;
            txtStock.Name = "txtStock";
            txtStock.Properties.Appearance.Font = new Font("Tahoma", 9F, FontStyle.Regular, GraphicsUnit.Point);
            txtStock.Properties.Appearance.Options.UseFont = true;
            txtStock.Size = new Size(85, 24);
            txtStock.TabIndex = 20;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Tahoma", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(773, 19);
            label7.Name = "label7";
            label7.Size = new Size(177, 21);
            label7.TabIndex = 19;
            label7.Text = "Available Qty in Stock:";
            // 
            // luaProductTitle
            // 
            luaProductTitle.Location = new Point(135, 13);
            luaProductTitle.MenuManager = ribbon;
            luaProductTitle.Name = "luaProductTitle";
            luaProductTitle.Properties.Appearance.Font = new Font("Tahoma", 9F, FontStyle.Regular, GraphicsUnit.Point);
            luaProductTitle.Properties.Appearance.Options.UseFont = true;
            luaProductTitle.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] { new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo) });
            luaProductTitle.Properties.NullText = "";
            luaProductTitle.Properties.PopupFilterMode = DevExpress.XtraEditors.PopupFilterMode.Contains;
            luaProductTitle.Properties.SearchMode = DevExpress.XtraEditors.Controls.SearchMode.AutoSuggest;
            luaProductTitle.Size = new Size(254, 24);
            luaProductTitle.TabIndex = 18;
            // 
            // txtProductPrice
            // 
            txtProductPrice.Location = new Point(551, 61);
            txtProductPrice.Margin = new Padding(4, 2, 4, 2);
            txtProductPrice.MenuManager = ribbon;
            txtProductPrice.Name = "txtProductPrice";
            txtProductPrice.Properties.Appearance.Font = new Font("Tahoma", 9F, FontStyle.Regular, GraphicsUnit.Point);
            txtProductPrice.Properties.Appearance.Options.UseFont = true;
            txtProductPrice.Size = new Size(140, 24);
            txtProductPrice.TabIndex = 17;
            // 
            // txtProductCode
            // 
            txtProductCode.Location = new Point(551, 13);
            txtProductCode.Margin = new Padding(4, 2, 4, 2);
            txtProductCode.MenuManager = ribbon;
            txtProductCode.Name = "txtProductCode";
            txtProductCode.Properties.Appearance.Font = new Font("Tahoma", 9F, FontStyle.Regular, GraphicsUnit.Point);
            txtProductCode.Properties.Appearance.Options.UseFont = true;
            txtProductCode.Size = new Size(140, 24);
            txtProductCode.TabIndex = 16;
            // 
            // txtSupplier
            // 
            txtSupplier.Location = new Point(135, 61);
            txtSupplier.Margin = new Padding(4, 2, 4, 2);
            txtSupplier.MenuManager = ribbon;
            txtSupplier.Name = "txtSupplier";
            txtSupplier.Properties.Appearance.Font = new Font("Tahoma", 9F, FontStyle.Regular, GraphicsUnit.Point);
            txtSupplier.Properties.Appearance.Options.UseFont = true;
            txtSupplier.Size = new Size(254, 24);
            txtSupplier.TabIndex = 15;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Tahoma", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(18, 60);
            label5.Name = "label5";
            label5.Size = new Size(75, 21);
            label5.TabIndex = 14;
            label5.Text = "Supplier:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Tahoma", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(434, 60);
            label4.Name = "label4";
            label4.Size = new Size(113, 21);
            label4.TabIndex = 12;
            label4.Text = "Product Price:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Tahoma", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(18, 12);
            label3.Name = "label3";
            label3.Size = new Size(110, 21);
            label3.TabIndex = 1;
            label3.Text = "Product Title:";
            // 
            // gridControl1
            // 
            gridControl1.DataSource = productsBindingSource;
            gridControl1.Location = new Point(0, 300);
            gridControl1.MainView = gridView1;
            gridControl1.MenuManager = ribbon;
            gridControl1.Name = "gridControl1";
            gridControl1.Size = new Size(1316, 460);
            gridControl1.TabIndex = 6;
            gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] { gridView1 });
            // 
            // gridView1
            // 
            gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] { ProductId, ProductCode, ProductDescription, SupplierId, SellingPrice, ProductRegistrationDate });
            gridView1.GridControl = gridControl1;
            gridView1.Name = "gridView1";
            gridView1.OptionsView.ShowAutoFilterRow = true;
            gridView1.OptionsView.ShowGroupPanel = false;
            gridView1.RowClick += gridView1_RowClick;
            // 
            // ProductId
            // 
            ProductId.FieldName = "ProductId";
            ProductId.MinWidth = 25;
            ProductId.Name = "ProductId";
            ProductId.Visible = true;
            ProductId.VisibleIndex = 0;
            ProductId.Width = 94;
            // 
            // ProductCode
            // 
            ProductCode.FieldName = "ProductCode";
            ProductCode.MinWidth = 25;
            ProductCode.Name = "ProductCode";
            ProductCode.Visible = true;
            ProductCode.VisibleIndex = 1;
            ProductCode.Width = 94;
            // 
            // ProductDescription
            // 
            ProductDescription.FieldName = "ProductDescription";
            ProductDescription.MinWidth = 25;
            ProductDescription.Name = "ProductDescription";
            ProductDescription.Visible = true;
            ProductDescription.VisibleIndex = 2;
            ProductDescription.Width = 94;
            // 
            // SupplierId
            // 
            SupplierId.FieldName = "SupplierId";
            SupplierId.MinWidth = 25;
            SupplierId.Name = "SupplierId";
            SupplierId.Visible = true;
            SupplierId.VisibleIndex = 3;
            SupplierId.Width = 94;
            // 
            // SellingPrice
            // 
            SellingPrice.FieldName = "SellingPrice";
            SellingPrice.MinWidth = 25;
            SellingPrice.Name = "SellingPrice";
            SellingPrice.Visible = true;
            SellingPrice.VisibleIndex = 4;
            SellingPrice.Width = 94;
            // 
            // ProductRegistrationDate
            // 
            ProductRegistrationDate.DisplayFormat.FormatString = "d";
            ProductRegistrationDate.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            ProductRegistrationDate.FieldName = "ProductRegistrationDate";
            ProductRegistrationDate.MinWidth = 25;
            ProductRegistrationDate.Name = "ProductRegistrationDate";
            ProductRegistrationDate.Visible = true;
            ProductRegistrationDate.VisibleIndex = 5;
            ProductRegistrationDate.Width = 94;
            // 
            // ProductHeaderPanel
            // 
            ProductHeaderPanel.Controls.Add(panelControl1);
            ProductHeaderPanel.Controls.Add(panelControl2);
            ProductHeaderPanel.Dock = DockStyle.Top;
            ProductHeaderPanel.Location = new Point(0, 193);
            ProductHeaderPanel.Name = "ProductHeaderPanel";
            ProductHeaderPanel.Size = new Size(1328, 110);
            ProductHeaderPanel.TabIndex = 9;
            // 
            // ProductForm
            // 
            AutoScaleDimensions = new SizeF(7F, 16F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1328, 813);
            Controls.Add(ProductHeaderPanel);
            Controls.Add(gridControl1);
            Controls.Add(ribbonStatusBar);
            Controls.Add(ribbon);
            Name = "ProductForm";
            Ribbon = ribbon;
            StatusBar = ribbonStatusBar;
            Text = "ProductForm";
            Load += ProductForm_Load;
            ((System.ComponentModel.ISupportInitialize)ribbon).EndInit();
            ((System.ComponentModel.ISupportInitialize)panelControl1).EndInit();
            panelControl1.ResumeLayout(false);
            panelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)txtproductId.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)dateEdit1.Properties.CalendarTimeProperties).EndInit();
            ((System.ComponentModel.ISupportInitialize)dateEdit1.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)panelControl2).EndInit();
            panelControl2.ResumeLayout(false);
            panelControl2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)txtStock.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)luaProductTitle.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)txtProductPrice.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)txtProductCode.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)txtSupplier.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)gridControl1).EndInit();
            ((System.ComponentModel.ISupportInitialize)productsBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)gridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)ProductHeaderPanel).EndInit();
            ProductHeaderPanel.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbon;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraBars.Ribbon.RibbonStatusBar ribbonStatusBar;
        private DevExpress.XtraBars.BarButtonItem barAddProduct;
        private DevExpress.XtraBars.BarButtonItem barSaveProduct;
        private DevExpress.XtraBars.BarButtonItem barCancelProduct;
        private DevExpress.XtraBars.BarButtonItem barDeleteProduct;
        private DevExpress.XtraBars.BarButtonItem barExitForm;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup2;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.PanelControl panelControl2;
        private Label label1;
        private DevExpress.XtraEditors.DateEdit dateEdit1;
        private Label label2;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label6;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn ProductId;
        private DevExpress.XtraGrid.Columns.GridColumn ProductCode;
        private DevExpress.XtraGrid.Columns.GridColumn ProductDescription;
        private DevExpress.XtraGrid.Columns.GridColumn SupplierId;
        private DevExpress.XtraGrid.Columns.GridColumn SellingPrice;
        private DevExpress.XtraGrid.Columns.GridColumn ProductRegistrationDate;
        private DevExpress.XtraBars.BarButtonItem barButtonItem6;
        private DevExpress.XtraEditors.PanelControl ProductHeaderPanel;
        private DevExpress.XtraEditors.TextEdit txtSupplier;
        private DevExpress.XtraEditors.TextEdit txtproductId;
        private DevExpress.XtraEditors.TextEdit txtProductPrice;
        private DevExpress.XtraEditors.TextEdit txtProductCode;
        private DevExpress.XtraEditors.LookUpEdit luaProductTitle;
        private BindingSource productsBindingSource;
        private Label label7;
        private DevExpress.XtraEditors.TextEdit txtStock;
    }
}