namespace BSMS.Winforms.Forms
{
    partial class ClientHistoryForm
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
            DevExpress.XtraGrid.GridLevelNode gridLevelNode1 = new DevExpress.XtraGrid.GridLevelNode();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ClientHistoryForm));
            grvProducts = new DevExpress.XtraGrid.Views.Grid.GridView();
            colOrderId = new DevExpress.XtraGrid.Columns.GridColumn();
            colProductCode = new DevExpress.XtraGrid.Columns.GridColumn();
            colProductDescription = new DevExpress.XtraGrid.Columns.GridColumn();
            colProductQuantity = new DevExpress.XtraGrid.Columns.GridColumn();
            colTotalPriceProduct = new DevExpress.XtraGrid.Columns.GridColumn();
            grOrders = new DevExpress.XtraGrid.GridControl();
            grvOrders = new DevExpress.XtraGrid.Views.Grid.GridView();
            colId = new DevExpress.XtraGrid.Columns.GridColumn();
            colCustomerFullName = new DevExpress.XtraGrid.Columns.GridColumn();
            colDate = new DevExpress.XtraGrid.Columns.GridColumn();
            colNotes = new DevExpress.XtraGrid.Columns.GridColumn();
            colProductsInOrder = new DevExpress.XtraGrid.Columns.GridColumn();
            repositoryItemCheckEdit2 = new DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit();
            colTotalPrice = new DevExpress.XtraGrid.Columns.GridColumn();
            colPayed = new DevExpress.XtraGrid.Columns.GridColumn();
            repositoryItemCheckEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit();
            colDiscountedPrice = new DevExpress.XtraGrid.Columns.GridColumn();
            colDiscountPercentage = new DevExpress.XtraGrid.Columns.GridColumn();
            colTotalCash = new DevExpress.XtraGrid.Columns.GridColumn();
            colTotalPOS = new DevExpress.XtraGrid.Columns.GridColumn();
            ribbon = new DevExpress.XtraBars.Ribbon.RibbonControl();
            barButtonItem1 = new DevExpress.XtraBars.BarButtonItem();
            dateFrom = new DevExpress.XtraBars.BarEditItem();
            repositoryItemDateEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemDateEdit();
            dateTo = new DevExpress.XtraBars.BarEditItem();
            repositoryItemDateEdit2 = new DevExpress.XtraEditors.Repository.RepositoryItemDateEdit();
            barItemName = new DevExpress.XtraBars.BarEditItem();
            repositoryItemTextEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            baritemPhone = new DevExpress.XtraBars.BarEditItem();
            repositoryItemTextEdit2 = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            barItemSurname = new DevExpress.XtraBars.BarEditItem();
            repositoryItemTextEdit3 = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            baritemEmail = new DevExpress.XtraBars.BarEditItem();
            repositoryItemTextEdit4 = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            baritemRegisterDate = new DevExpress.XtraBars.BarEditItem();
            repositoryItemTextEdit5 = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            baritemId = new DevExpress.XtraBars.BarEditItem();
            repositoryItemTextEdit6 = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            barButtonItem2 = new DevExpress.XtraBars.BarButtonItem();
            barButtonItem5 = new DevExpress.XtraBars.BarButtonItem();
            barButtonItem6 = new DevExpress.XtraBars.BarButtonItem();
            barButtonItem7 = new DevExpress.XtraBars.BarButtonItem();
            barButtonItem8 = new DevExpress.XtraBars.BarButtonItem();
            barButtonItem4 = new DevExpress.XtraBars.BarButtonItem();
            Ribbonpage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            ribbonPageGroup2 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            ribbonPageGroup3 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            ribbonPageGroup4 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            repositoryItemLookUpEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            repositoryItemDateEdit3 = new DevExpress.XtraEditors.Repository.RepositoryItemDateEdit();
            repositoryItemDateEdit4 = new DevExpress.XtraEditors.Repository.RepositoryItemDateEdit();
            repositoryItemTextEdit7 = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            ribbonStatusBar = new DevExpress.XtraBars.Ribbon.RibbonStatusBar();
            orderProductsBindingSource = new BindingSource(components);
            orderSummaryBindingSource = new BindingSource(components);
            orderBindingSource = new BindingSource(components);
            customerBindingSource = new BindingSource(components);
            panelControl1 = new DevExpress.XtraEditors.PanelControl();
            customerLookUpEdit = new DevExpress.XtraEditors.LookUpEdit();
            barButtonItem3 = new DevExpress.XtraBars.BarButtonItem();
            label1 = new Label();
            barEditItem1 = new DevExpress.XtraBars.BarEditItem();
            barEditItem2 = new DevExpress.XtraBars.BarEditItem();
            textEdit1 = new DevExpress.XtraEditors.TextEdit();
            ((System.ComponentModel.ISupportInitialize)grvProducts).BeginInit();
            ((System.ComponentModel.ISupportInitialize)grOrders).BeginInit();
            ((System.ComponentModel.ISupportInitialize)grvOrders).BeginInit();
            ((System.ComponentModel.ISupportInitialize)repositoryItemCheckEdit2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)repositoryItemCheckEdit1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ribbon).BeginInit();
            ((System.ComponentModel.ISupportInitialize)repositoryItemDateEdit1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)repositoryItemDateEdit1.CalendarTimeProperties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)repositoryItemDateEdit2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)repositoryItemDateEdit2.CalendarTimeProperties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)repositoryItemTextEdit1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)repositoryItemTextEdit2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)repositoryItemTextEdit3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)repositoryItemTextEdit4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)repositoryItemTextEdit5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)repositoryItemTextEdit6).BeginInit();
            ((System.ComponentModel.ISupportInitialize)repositoryItemLookUpEdit1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)repositoryItemDateEdit3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)repositoryItemDateEdit3.CalendarTimeProperties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)repositoryItemDateEdit4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)repositoryItemDateEdit4.CalendarTimeProperties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)repositoryItemTextEdit7).BeginInit();
            ((System.ComponentModel.ISupportInitialize)orderProductsBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)orderSummaryBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)orderBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)customerBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)panelControl1).BeginInit();
            panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)customerLookUpEdit.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)textEdit1.Properties).BeginInit();
            SuspendLayout();
            // 
            // grvProducts
            // 
            grvProducts.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] { colOrderId, colProductCode, colProductDescription, colProductQuantity, colTotalPriceProduct });
            grvProducts.DetailHeight = 284;
            grvProducts.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFullFocus;
            grvProducts.GridControl = grOrders;
            grvProducts.Name = "grvProducts";
            grvProducts.OptionsView.ColumnAutoWidth = false;
            grvProducts.OptionsView.EnableAppearanceEvenRow = true;
            grvProducts.OptionsView.ShowGroupPanel = false;
            // 
            // colOrderId
            // 
            colOrderId.Caption = "Order Id";
            colOrderId.FieldName = "OrderId";
            colOrderId.MinWidth = 24;
            colOrderId.Name = "colOrderId";
            colOrderId.Width = 94;
            // 
            // colProductCode
            // 
            colProductCode.Caption = "Product Code";
            colProductCode.FieldName = "ProductCode";
            colProductCode.MinWidth = 24;
            colProductCode.Name = "colProductCode";
            colProductCode.Visible = true;
            colProductCode.VisibleIndex = 0;
            colProductCode.Width = 160;
            // 
            // colProductDescription
            // 
            colProductDescription.Caption = "Product Description";
            colProductDescription.FieldName = "ProductDescription";
            colProductDescription.MinWidth = 24;
            colProductDescription.Name = "colProductDescription";
            colProductDescription.Visible = true;
            colProductDescription.VisibleIndex = 1;
            colProductDescription.Width = 260;
            // 
            // colProductQuantity
            // 
            colProductQuantity.Caption = "Quantity";
            colProductQuantity.FieldName = "ProductQuantity";
            colProductQuantity.MinWidth = 24;
            colProductQuantity.Name = "colProductQuantity";
            colProductQuantity.Visible = true;
            colProductQuantity.VisibleIndex = 2;
            colProductQuantity.Width = 94;
            // 
            // colTotalPriceProduct
            // 
            colTotalPriceProduct.Caption = "Total Price";
            colTotalPriceProduct.FieldName = "TotalPrice";
            colTotalPriceProduct.MinWidth = 24;
            colTotalPriceProduct.Name = "colTotalPriceProduct";
            colTotalPriceProduct.Visible = true;
            colTotalPriceProduct.VisibleIndex = 3;
            colTotalPriceProduct.Width = 94;
            // 
            // grOrders
            // 
            grOrders.Dock = DockStyle.Fill;
            grOrders.EmbeddedNavigator.Margin = new Padding(4);
            gridLevelNode1.LevelTemplate = grvProducts;
            gridLevelNode1.RelationName = "Level1";
            grOrders.LevelTree.Nodes.AddRange(new DevExpress.XtraGrid.GridLevelNode[] { gridLevelNode1 });
            grOrders.Location = new Point(2, 2);
            grOrders.MainView = grvOrders;
            grOrders.Margin = new Padding(4);
            grOrders.MenuManager = ribbon;
            grOrders.Name = "grOrders";
            grOrders.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] { repositoryItemCheckEdit1, repositoryItemCheckEdit2 });
            grOrders.Size = new Size(1599, 575);
            grOrders.TabIndex = 0;
            grOrders.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] { grvOrders, grvProducts });
            grOrders.Load += grOrders_Load;
            // 
            // grvOrders
            // 
            grvOrders.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] { colId, colCustomerFullName, colDate, colNotes, colProductsInOrder, colTotalPrice, colPayed, colDiscountedPrice, colDiscountPercentage, colTotalCash, colTotalPOS });
            grvOrders.DetailHeight = 284;
            grvOrders.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFullFocus;
            grvOrders.GridControl = grOrders;
            grvOrders.Name = "grvOrders";
            grvOrders.OptionsBehavior.Editable = false;
            grvOrders.OptionsDetail.AllowExpandEmptyDetails = true;
            grvOrders.OptionsDetail.AllowOnlyOneMasterRowExpanded = true;
            grvOrders.OptionsDetail.SmartDetailExpandButtonMode = DevExpress.XtraGrid.Views.Grid.DetailExpandButtonMode.AlwaysEnabled;
            grvOrders.OptionsSelection.MultiSelect = true;
            grvOrders.OptionsSelection.MultiSelectMode = DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.CheckBoxRowSelect;
            grvOrders.OptionsView.EnableAppearanceEvenRow = true;
            grvOrders.OptionsView.ShowAutoFilterRow = true;
            grvOrders.OptionsView.ShowFooter = true;
            grvOrders.OptionsView.ShowGroupPanel = false;
            grvOrders.OptionsView.ShowHorizontalLines = DevExpress.Utils.DefaultBoolean.True;
            grvOrders.OptionsView.ShowVerticalLines = DevExpress.Utils.DefaultBoolean.True;
            grvOrders.ViewCaptionHeight = 0;
            grvOrders.MasterRowExpanding += grvOrders_MasterRowExpanding;
            grvOrders.SelectionChanged += grvOrders_SelectionChanged_1;
            // 
            // colId
            // 
            colId.Caption = "Order Id";
            colId.FieldName = "Id";
            colId.MinWidth = 21;
            colId.Name = "colId";
            colId.Visible = true;
            colId.VisibleIndex = 1;
            colId.Width = 80;
            // 
            // colCustomerFullName
            // 
            colCustomerFullName.Caption = "Customer";
            colCustomerFullName.FieldName = "CustomerFullName";
            colCustomerFullName.MinWidth = 21;
            colCustomerFullName.Name = "colCustomerFullName";
            colCustomerFullName.Visible = true;
            colCustomerFullName.VisibleIndex = 2;
            colCustomerFullName.Width = 80;
            // 
            // colDate
            // 
            colDate.Caption = "Date";
            colDate.FieldName = "Date";
            colDate.MinWidth = 21;
            colDate.Name = "colDate";
            colDate.Visible = true;
            colDate.VisibleIndex = 3;
            colDate.Width = 80;
            // 
            // colNotes
            // 
            colNotes.Caption = "Notes";
            colNotes.FieldName = "Notes";
            colNotes.MinWidth = 21;
            colNotes.Name = "colNotes";
            colNotes.Visible = true;
            colNotes.VisibleIndex = 4;
            colNotes.Width = 80;
            // 
            // colProductsInOrder
            // 
            colProductsInOrder.Caption = "Products in order";
            colProductsInOrder.ColumnEdit = repositoryItemCheckEdit2;
            colProductsInOrder.FieldName = "ExistProductsInOrder";
            colProductsInOrder.MinWidth = 21;
            colProductsInOrder.Name = "colProductsInOrder";
            colProductsInOrder.Visible = true;
            colProductsInOrder.VisibleIndex = 5;
            colProductsInOrder.Width = 80;
            // 
            // repositoryItemCheckEdit2
            // 
            repositoryItemCheckEdit2.AutoHeight = false;
            repositoryItemCheckEdit2.Name = "repositoryItemCheckEdit2";
            // 
            // colTotalPrice
            // 
            colTotalPrice.Caption = "Total Price";
            colTotalPrice.DisplayFormat.FormatString = "c";
            colTotalPrice.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            colTotalPrice.FieldName = "TotalPrice";
            colTotalPrice.GroupFormat.FormatString = "c";
            colTotalPrice.GroupFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            colTotalPrice.MinWidth = 21;
            colTotalPrice.Name = "colTotalPrice";
            colTotalPrice.Visible = true;
            colTotalPrice.VisibleIndex = 6;
            colTotalPrice.Width = 80;
            // 
            // colPayed
            // 
            colPayed.Caption = "Payed";
            colPayed.ColumnEdit = repositoryItemCheckEdit1;
            colPayed.FieldName = "Payed";
            colPayed.MinWidth = 21;
            colPayed.Name = "colPayed";
            colPayed.Visible = true;
            colPayed.VisibleIndex = 7;
            colPayed.Width = 80;
            // 
            // repositoryItemCheckEdit1
            // 
            repositoryItemCheckEdit1.AutoHeight = false;
            repositoryItemCheckEdit1.Name = "repositoryItemCheckEdit1";
            // 
            // colDiscountedPrice
            // 
            colDiscountedPrice.Caption = "Payed price";
            colDiscountedPrice.DisplayFormat.FormatString = "c";
            colDiscountedPrice.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            colDiscountedPrice.FieldName = "DiscountedPrice";
            colDiscountedPrice.GroupFormat.FormatString = "c";
            colDiscountedPrice.GroupFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            colDiscountedPrice.MinWidth = 21;
            colDiscountedPrice.Name = "colDiscountedPrice";
            colDiscountedPrice.Visible = true;
            colDiscountedPrice.VisibleIndex = 8;
            colDiscountedPrice.Width = 80;
            // 
            // colDiscountPercentage
            // 
            colDiscountPercentage.Caption = "Discount";
            colDiscountPercentage.FieldName = "DiscountPercentage";
            colDiscountPercentage.MinWidth = 21;
            colDiscountPercentage.Name = "colDiscountPercentage";
            colDiscountPercentage.Visible = true;
            colDiscountPercentage.VisibleIndex = 9;
            colDiscountPercentage.Width = 80;
            // 
            // colTotalCash
            // 
            colTotalCash.Caption = "Total Cash";
            colTotalCash.DisplayFormat.FormatString = "c";
            colTotalCash.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            colTotalCash.FieldName = "TotalCash";
            colTotalCash.GroupFormat.FormatString = "c";
            colTotalCash.GroupFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            colTotalCash.MinWidth = 21;
            colTotalCash.Name = "colTotalCash";
            colTotalCash.Visible = true;
            colTotalCash.VisibleIndex = 10;
            colTotalCash.Width = 80;
            // 
            // colTotalPOS
            // 
            colTotalPOS.Caption = "Total POS";
            colTotalPOS.DisplayFormat.FormatString = "c";
            colTotalPOS.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            colTotalPOS.FieldName = "TotalPOS";
            colTotalPOS.GroupFormat.FormatString = "c";
            colTotalPOS.GroupFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            colTotalPOS.MinWidth = 21;
            colTotalPOS.Name = "colTotalPOS";
            colTotalPOS.Visible = true;
            colTotalPOS.VisibleIndex = 11;
            colTotalPOS.Width = 80;
            // 
            // ribbon
            // 
            ribbon.ExpandCollapseItem.Id = 0;
            ribbon.Items.AddRange(new DevExpress.XtraBars.BarItem[] { ribbon.ExpandCollapseItem, ribbon.SearchEditItem, barButtonItem1, dateFrom, dateTo, barItemName, baritemPhone, barItemSurname, baritemEmail, baritemRegisterDate, baritemId, barButtonItem2, barButtonItem5, barButtonItem6, barButtonItem7, barButtonItem8, barButtonItem4 });
            ribbon.Location = new Point(0, 0);
            ribbon.Margin = new Padding(4, 2, 4, 2);
            ribbon.MaxItemId = 24;
            ribbon.Name = "ribbon";
            ribbon.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] { Ribbonpage1 });
            ribbon.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] { repositoryItemLookUpEdit1, repositoryItemDateEdit1, repositoryItemDateEdit2, repositoryItemDateEdit3, repositoryItemDateEdit4, repositoryItemTextEdit1, repositoryItemTextEdit2, repositoryItemTextEdit3, repositoryItemTextEdit4, repositoryItemTextEdit5, repositoryItemTextEdit6, repositoryItemTextEdit7 });
            ribbon.Size = new Size(1603, 193);
            ribbon.StatusBar = ribbonStatusBar;
            // 
            // barButtonItem1
            // 
            barButtonItem1.Caption = "View";
            barButtonItem1.Id = 1;
            barButtonItem1.ImageOptions.SvgImage = (DevExpress.Utils.Svg.SvgImage)resources.GetObject("barButtonItem1.ImageOptions.SvgImage");
            barButtonItem1.Name = "barButtonItem1";
            // 
            // dateFrom
            // 
            dateFrom.Caption = "Date From:";
            dateFrom.Edit = repositoryItemDateEdit1;
            dateFrom.EditWidth = 100;
            dateFrom.Id = 4;
            dateFrom.ItemAppearance.Disabled.BackColor = Color.Black;
            dateFrom.ItemAppearance.Disabled.Font = new Font("Tahoma", 9F, FontStyle.Bold, GraphicsUnit.Point);
            dateFrom.ItemAppearance.Disabled.ForeColor = Color.Black;
            dateFrom.ItemAppearance.Disabled.Options.UseBackColor = true;
            dateFrom.ItemAppearance.Disabled.Options.UseFont = true;
            dateFrom.ItemAppearance.Disabled.Options.UseForeColor = true;
            dateFrom.Name = "dateFrom";
            // 
            // repositoryItemDateEdit1
            // 
            repositoryItemDateEdit1.AutoHeight = false;
            repositoryItemDateEdit1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] { new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo) });
            repositoryItemDateEdit1.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] { new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo) });
            repositoryItemDateEdit1.Name = "repositoryItemDateEdit1";
            // 
            // dateTo
            // 
            dateTo.Caption = "Date To:    ";
            dateTo.Edit = repositoryItemDateEdit2;
            dateTo.EditWidth = 100;
            dateTo.Id = 5;
            dateTo.ItemAppearance.Disabled.BackColor = Color.Black;
            dateTo.ItemAppearance.Disabled.Font = new Font("Tahoma", 9F, FontStyle.Bold, GraphicsUnit.Point);
            dateTo.ItemAppearance.Disabled.ForeColor = Color.Black;
            dateTo.ItemAppearance.Disabled.Options.UseBackColor = true;
            dateTo.ItemAppearance.Disabled.Options.UseFont = true;
            dateTo.ItemAppearance.Disabled.Options.UseForeColor = true;
            dateTo.Name = "dateTo";
            // 
            // repositoryItemDateEdit2
            // 
            repositoryItemDateEdit2.AutoHeight = false;
            repositoryItemDateEdit2.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] { new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo) });
            repositoryItemDateEdit2.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] { new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo) });
            repositoryItemDateEdit2.Name = "repositoryItemDateEdit2";
            // 
            // barItemName
            // 
            barItemName.Caption = "Όνομα:    ";
            barItemName.Edit = repositoryItemTextEdit1;
            barItemName.EditWidth = 100;
            barItemName.Enabled = false;
            barItemName.Id = 8;
            barItemName.ItemAppearance.Disabled.BackColor = Color.Black;
            barItemName.ItemAppearance.Disabled.Font = new Font("Tahoma", 9F, FontStyle.Bold, GraphicsUnit.Point);
            barItemName.ItemAppearance.Disabled.ForeColor = Color.Black;
            barItemName.ItemAppearance.Disabled.Options.UseBackColor = true;
            barItemName.ItemAppearance.Disabled.Options.UseFont = true;
            barItemName.ItemAppearance.Disabled.Options.UseForeColor = true;
            barItemName.Name = "barItemName";
            // 
            // repositoryItemTextEdit1
            // 
            repositoryItemTextEdit1.AutoHeight = false;
            repositoryItemTextEdit1.Name = "repositoryItemTextEdit1";
            // 
            // baritemPhone
            // 
            baritemPhone.Caption = "Τηλ.:   ";
            baritemPhone.Edit = repositoryItemTextEdit2;
            baritemPhone.EditWidth = 100;
            baritemPhone.Enabled = false;
            baritemPhone.Id = 9;
            baritemPhone.ItemAppearance.Disabled.BackColor = Color.Black;
            baritemPhone.ItemAppearance.Disabled.Font = new Font("Tahoma", 9F, FontStyle.Bold, GraphicsUnit.Point);
            baritemPhone.ItemAppearance.Disabled.ForeColor = Color.Black;
            baritemPhone.ItemAppearance.Disabled.Options.UseBackColor = true;
            baritemPhone.ItemAppearance.Disabled.Options.UseFont = true;
            baritemPhone.ItemAppearance.Disabled.Options.UseForeColor = true;
            baritemPhone.Name = "baritemPhone";
            // 
            // repositoryItemTextEdit2
            // 
            repositoryItemTextEdit2.AutoHeight = false;
            repositoryItemTextEdit2.Name = "repositoryItemTextEdit2";
            // 
            // barItemSurname
            // 
            barItemSurname.Caption = "Επώνυμο:";
            barItemSurname.Edit = repositoryItemTextEdit3;
            barItemSurname.EditWidth = 100;
            barItemSurname.Enabled = false;
            barItemSurname.Id = 10;
            barItemSurname.ItemAppearance.Disabled.BackColor = Color.Black;
            barItemSurname.ItemAppearance.Disabled.Font = new Font("Tahoma", 9F, FontStyle.Bold, GraphicsUnit.Point);
            barItemSurname.ItemAppearance.Disabled.ForeColor = Color.Black;
            barItemSurname.ItemAppearance.Disabled.Options.UseBackColor = true;
            barItemSurname.ItemAppearance.Disabled.Options.UseFont = true;
            barItemSurname.ItemAppearance.Disabled.Options.UseForeColor = true;
            barItemSurname.ItemAppearance.Hovered.BackColor = Color.Black;
            barItemSurname.ItemAppearance.Hovered.Font = new Font("Tahoma", 9F, FontStyle.Bold, GraphicsUnit.Point);
            barItemSurname.ItemAppearance.Hovered.ForeColor = Color.Black;
            barItemSurname.ItemAppearance.Hovered.Options.UseBackColor = true;
            barItemSurname.ItemAppearance.Hovered.Options.UseFont = true;
            barItemSurname.ItemAppearance.Hovered.Options.UseForeColor = true;
            barItemSurname.Name = "barItemSurname";
            // 
            // repositoryItemTextEdit3
            // 
            repositoryItemTextEdit3.AutoHeight = false;
            repositoryItemTextEdit3.Name = "repositoryItemTextEdit3";
            // 
            // baritemEmail
            // 
            baritemEmail.Caption = "Email: ";
            baritemEmail.Edit = repositoryItemTextEdit4;
            baritemEmail.EditWidth = 100;
            baritemEmail.Enabled = false;
            baritemEmail.Id = 11;
            baritemEmail.ItemAppearance.Disabled.BackColor = Color.Black;
            baritemEmail.ItemAppearance.Disabled.Font = new Font("Tahoma", 9F, FontStyle.Bold, GraphicsUnit.Point);
            baritemEmail.ItemAppearance.Disabled.ForeColor = Color.Black;
            baritemEmail.ItemAppearance.Disabled.Options.UseBackColor = true;
            baritemEmail.ItemAppearance.Disabled.Options.UseFont = true;
            baritemEmail.ItemAppearance.Disabled.Options.UseForeColor = true;
            baritemEmail.Name = "baritemEmail";
            // 
            // repositoryItemTextEdit4
            // 
            repositoryItemTextEdit4.AutoHeight = false;
            repositoryItemTextEdit4.Name = "repositoryItemTextEdit4";
            // 
            // baritemRegisterDate
            // 
            baritemRegisterDate.Caption = "Ημ/νια Εγγραφής:";
            baritemRegisterDate.Edit = repositoryItemTextEdit5;
            baritemRegisterDate.EditWidth = 90;
            baritemRegisterDate.Enabled = false;
            baritemRegisterDate.Id = 12;
            baritemRegisterDate.ItemAppearance.Disabled.BackColor = Color.Black;
            baritemRegisterDate.ItemAppearance.Disabled.Font = new Font("Tahoma", 9F, FontStyle.Bold, GraphicsUnit.Point);
            baritemRegisterDate.ItemAppearance.Disabled.ForeColor = Color.Black;
            baritemRegisterDate.ItemAppearance.Disabled.Options.UseBackColor = true;
            baritemRegisterDate.ItemAppearance.Disabled.Options.UseFont = true;
            baritemRegisterDate.ItemAppearance.Disabled.Options.UseForeColor = true;
            baritemRegisterDate.Name = "baritemRegisterDate";
            // 
            // repositoryItemTextEdit5
            // 
            repositoryItemTextEdit5.AutoHeight = false;
            repositoryItemTextEdit5.Name = "repositoryItemTextEdit5";
            // 
            // baritemId
            // 
            baritemId.Caption = "ClientId:                 ";
            baritemId.Edit = repositoryItemTextEdit6;
            baritemId.EditWidth = 90;
            baritemId.Enabled = false;
            baritemId.Id = 13;
            baritemId.ItemAppearance.Disabled.BackColor = Color.Black;
            baritemId.ItemAppearance.Disabled.Font = new Font("Tahoma", 9F, FontStyle.Bold, GraphicsUnit.Point);
            baritemId.ItemAppearance.Disabled.ForeColor = Color.Black;
            baritemId.ItemAppearance.Disabled.Options.UseBackColor = true;
            baritemId.ItemAppearance.Disabled.Options.UseFont = true;
            baritemId.ItemAppearance.Disabled.Options.UseForeColor = true;
            baritemId.Name = "baritemId";
            // 
            // repositoryItemTextEdit6
            // 
            repositoryItemTextEdit6.AutoHeight = false;
            repositoryItemTextEdit6.Name = "repositoryItemTextEdit6";
            // 
            // barButtonItem2
            // 
            barButtonItem2.Caption = "View";
            barButtonItem2.Id = 14;
            barButtonItem2.ImageOptions.SvgImage = (DevExpress.Utils.Svg.SvgImage)resources.GetObject("barButtonItem2.ImageOptions.SvgImage");
            barButtonItem2.Name = "barButtonItem2";
            // 
            // barButtonItem5
            // 
            barButtonItem5.Caption = "Close";
            barButtonItem5.Id = 17;
            barButtonItem5.ImageOptions.SvgImage = (DevExpress.Utils.Svg.SvgImage)resources.GetObject("barButtonItem5.ImageOptions.SvgImage");
            barButtonItem5.Name = "barButtonItem5";
            barButtonItem5.ItemClick += barButtonItem5_ItemClick;
            // 
            // barButtonItem6
            // 
            barButtonItem6.Caption = "Open Order";
            barButtonItem6.Id = 18;
            barButtonItem6.ImageOptions.SvgImage = (DevExpress.Utils.Svg.SvgImage)resources.GetObject("barButtonItem6.ImageOptions.SvgImage");
            barButtonItem6.Name = "barButtonItem6";
            barButtonItem6.ItemClick += barButtonItem6_ItemClick;
            // 
            // barButtonItem7
            // 
            barButtonItem7.Caption = "Save as pdf";
            barButtonItem7.Id = 19;
            barButtonItem7.ImageOptions.SvgImage = (DevExpress.Utils.Svg.SvgImage)resources.GetObject("barButtonItem7.ImageOptions.SvgImage");
            barButtonItem7.Name = "barButtonItem7";
            barButtonItem7.ItemClick += barButtonItem7_ItemClick;
            // 
            // barButtonItem8
            // 
            barButtonItem8.Caption = "Clear";
            barButtonItem8.Id = 20;
            barButtonItem8.ImageOptions.SvgImage = (DevExpress.Utils.Svg.SvgImage)resources.GetObject("barButtonItem8.ImageOptions.SvgImage");
            barButtonItem8.Name = "barButtonItem8";
            barButtonItem8.ItemClick += barButtonItem8_ItemClick;
            // 
            // barButtonItem4
            // 
            barButtonItem4.Caption = "Open Customer Summary";
            barButtonItem4.Id = 23;
            barButtonItem4.ImageOptions.SvgImage = (DevExpress.Utils.Svg.SvgImage)resources.GetObject("barButtonItem4.ImageOptions.SvgImage");
            barButtonItem4.Name = "barButtonItem4";
            barButtonItem4.ItemClick += barButtonItem4_ItemClick;
            // 
            // Ribbonpage1
            // 
            Ribbonpage1.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] { ribbonPageGroup2, ribbonPageGroup3, ribbonPageGroup4 });
            Ribbonpage1.Name = "Ribbonpage1";
            Ribbonpage1.Text = "Client History";
            // 
            // ribbonPageGroup2
            // 
            ribbonPageGroup2.ItemLinks.Add(barButtonItem8);
            ribbonPageGroup2.ItemLinks.Add(barButtonItem6);
            ribbonPageGroup2.ItemLinks.Add(barButtonItem7);
            ribbonPageGroup2.ItemLinks.Add(barButtonItem5);
            ribbonPageGroup2.ItemLinks.Add(barButtonItem4);
            ribbonPageGroup2.Name = "ribbonPageGroup2";
            // 
            // ribbonPageGroup3
            // 
            ribbonPageGroup3.ItemLinks.Add(dateFrom);
            ribbonPageGroup3.ItemLinks.Add(dateTo);
            ribbonPageGroup3.Name = "ribbonPageGroup3";
            // 
            // ribbonPageGroup4
            // 
            ribbonPageGroup4.ItemLinks.Add(barItemSurname);
            ribbonPageGroup4.ItemLinks.Add(barItemName);
            ribbonPageGroup4.ItemLinks.Add(baritemPhone);
            ribbonPageGroup4.ItemLinks.Add(baritemEmail);
            ribbonPageGroup4.ItemLinks.Add(baritemRegisterDate);
            ribbonPageGroup4.ItemLinks.Add(baritemId);
            ribbonPageGroup4.ItemsLayout = DevExpress.XtraBars.Ribbon.RibbonPageGroupItemsLayout.TwoRows;
            ribbonPageGroup4.Name = "ribbonPageGroup4";
            // 
            // repositoryItemLookUpEdit1
            // 
            repositoryItemLookUpEdit1.AutoHeight = false;
            repositoryItemLookUpEdit1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] { new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo) });
            repositoryItemLookUpEdit1.Name = "repositoryItemLookUpEdit1";
            repositoryItemLookUpEdit1.NullText = "";
            // 
            // repositoryItemDateEdit3
            // 
            repositoryItemDateEdit3.AutoHeight = false;
            repositoryItemDateEdit3.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] { new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo) });
            repositoryItemDateEdit3.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] { new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo) });
            repositoryItemDateEdit3.Name = "repositoryItemDateEdit3";
            // 
            // repositoryItemDateEdit4
            // 
            repositoryItemDateEdit4.AutoHeight = false;
            repositoryItemDateEdit4.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] { new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo) });
            repositoryItemDateEdit4.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] { new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo) });
            repositoryItemDateEdit4.Name = "repositoryItemDateEdit4";
            // 
            // repositoryItemTextEdit7
            // 
            repositoryItemTextEdit7.AutoHeight = false;
            repositoryItemTextEdit7.Name = "repositoryItemTextEdit7";
            // 
            // ribbonStatusBar
            // 
            ribbonStatusBar.Location = new Point(0, 772);
            ribbonStatusBar.Margin = new Padding(4, 2, 4, 2);
            ribbonStatusBar.Name = "ribbonStatusBar";
            ribbonStatusBar.Ribbon = ribbon;
            ribbonStatusBar.Size = new Size(1603, 30);
            // 
            // orderSummaryBindingSource
            // 
            orderSummaryBindingSource.DataSource = typeof(Models.OrderSummary);
            // 
            // orderBindingSource
            // 
            orderBindingSource.DataSource = typeof(Assets.Reports.Order);
            // 
            // customerBindingSource
            // 
            customerBindingSource.DataSource = typeof(Models.Customer);
            // 
            // panelControl1
            // 
            panelControl1.Controls.Add(grOrders);
            panelControl1.Dock = DockStyle.Fill;
            panelControl1.Location = new Point(0, 193);
            panelControl1.Margin = new Padding(4, 2, 4, 2);
            panelControl1.Name = "panelControl1";
            panelControl1.Size = new Size(1603, 579);
            panelControl1.TabIndex = 2;
            // 
            // customerLookUpEdit
            // 
            customerLookUpEdit.Location = new Point(66, 165);
            customerLookUpEdit.Margin = new Padding(4, 2, 4, 2);
            customerLookUpEdit.MenuManager = ribbon;
            customerLookUpEdit.Name = "customerLookUpEdit";
            customerLookUpEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] { new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo) });
            customerLookUpEdit.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] { new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Id", "Id"), new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Surname", "Surname"), new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Name", "Name") });
            customerLookUpEdit.Properties.DataSource = orderSummaryBindingSource;
            customerLookUpEdit.Properties.DisplayMember = "Name";
            customerLookUpEdit.Properties.NullText = "";
            customerLookUpEdit.Properties.PopupFilterMode = DevExpress.XtraEditors.PopupFilterMode.Contains;
            customerLookUpEdit.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            customerLookUpEdit.Properties.ValueMember = "Id";
            customerLookUpEdit.Size = new Size(188, 22);
            customerLookUpEdit.TabIndex = 0;
            customerLookUpEdit.EditValueChanged += customerLookUpEdit_EditValueChanged;
            // 
            // barButtonItem3
            // 
            barButtonItem3.Caption = "Close";
            barButtonItem3.Id = 15;
            barButtonItem3.Name = "barButtonItem3";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.FlatStyle = FlatStyle.Flat;
            label1.Location = new Point(12, 169);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(48, 16);
            label1.TabIndex = 5;
            label1.Text = "Client :";
            // 
            // barEditItem1
            // 
            barEditItem1.Caption = "Id:                     ";
            barEditItem1.Edit = repositoryItemTextEdit6;
            barEditItem1.EditWidth = 90;
            barEditItem1.Enabled = false;
            barEditItem1.Id = 13;
            barEditItem1.Name = "barEditItem1";
            // 
            // barEditItem2
            // 
            barEditItem2.Caption = "Id:                     ";
            barEditItem2.Edit = repositoryItemTextEdit6;
            barEditItem2.EditWidth = 90;
            barEditItem2.Enabled = false;
            barEditItem2.Id = 13;
            barEditItem2.Name = "barEditItem2";
            // 
            // textEdit1
            // 
            textEdit1.Location = new Point(262, 166);
            textEdit1.Margin = new Padding(4);
            textEdit1.MenuManager = ribbon;
            textEdit1.Name = "textEdit1";
            textEdit1.Properties.Appearance.Options.UseFont = true;
            textEdit1.Size = new Size(65, 22);
            textEdit1.TabIndex = 8;
            // 
            // ClientHistoryForm
            // 
            AutoScaleDimensions = new SizeF(7F, 16F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1603, 802);
            Controls.Add(textEdit1);
            Controls.Add(label1);
            Controls.Add(customerLookUpEdit);
            Controls.Add(panelControl1);
            Controls.Add(ribbonStatusBar);
            Controls.Add(ribbon);
            Margin = new Padding(4, 2, 4, 2);
            Name = "ClientHistoryForm";
            Ribbon = ribbon;
            StatusBar = ribbonStatusBar;
            Text = "ClientHistory";
            ((System.ComponentModel.ISupportInitialize)grvProducts).EndInit();
            ((System.ComponentModel.ISupportInitialize)grOrders).EndInit();
            ((System.ComponentModel.ISupportInitialize)grvOrders).EndInit();
            ((System.ComponentModel.ISupportInitialize)repositoryItemCheckEdit2).EndInit();
            ((System.ComponentModel.ISupportInitialize)repositoryItemCheckEdit1).EndInit();
            ((System.ComponentModel.ISupportInitialize)ribbon).EndInit();
            ((System.ComponentModel.ISupportInitialize)repositoryItemDateEdit1.CalendarTimeProperties).EndInit();
            ((System.ComponentModel.ISupportInitialize)repositoryItemDateEdit1).EndInit();
            ((System.ComponentModel.ISupportInitialize)repositoryItemDateEdit2.CalendarTimeProperties).EndInit();
            ((System.ComponentModel.ISupportInitialize)repositoryItemDateEdit2).EndInit();
            ((System.ComponentModel.ISupportInitialize)repositoryItemTextEdit1).EndInit();
            ((System.ComponentModel.ISupportInitialize)repositoryItemTextEdit2).EndInit();
            ((System.ComponentModel.ISupportInitialize)repositoryItemTextEdit3).EndInit();
            ((System.ComponentModel.ISupportInitialize)repositoryItemTextEdit4).EndInit();
            ((System.ComponentModel.ISupportInitialize)repositoryItemTextEdit5).EndInit();
            ((System.ComponentModel.ISupportInitialize)repositoryItemTextEdit6).EndInit();
            ((System.ComponentModel.ISupportInitialize)repositoryItemLookUpEdit1).EndInit();
            ((System.ComponentModel.ISupportInitialize)repositoryItemDateEdit3.CalendarTimeProperties).EndInit();
            ((System.ComponentModel.ISupportInitialize)repositoryItemDateEdit3).EndInit();
            ((System.ComponentModel.ISupportInitialize)repositoryItemDateEdit4.CalendarTimeProperties).EndInit();
            ((System.ComponentModel.ISupportInitialize)repositoryItemDateEdit4).EndInit();
            ((System.ComponentModel.ISupportInitialize)repositoryItemTextEdit7).EndInit();
            ((System.ComponentModel.ISupportInitialize)orderProductsBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)orderSummaryBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)orderBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)customerBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)panelControl1).EndInit();
            panelControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)customerLookUpEdit.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)textEdit1.Properties).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbon;
        private DevExpress.XtraBars.Ribbon.RibbonPage Ribbonpage1;
        private DevExpress.XtraBars.Ribbon.RibbonStatusBar ribbonStatusBar;
        private DevExpress.XtraBars.BarButtonItem barButtonItem1;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit repositoryItemLookUpEdit1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup2;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraBars.BarEditItem dateFrom;
        private DevExpress.XtraEditors.Repository.RepositoryItemDateEdit repositoryItemDateEdit1;
        private DevExpress.XtraBars.BarEditItem dateTo;
        private DevExpress.XtraEditors.Repository.RepositoryItemDateEdit repositoryItemDateEdit2;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup3;
        private DevExpress.XtraEditors.Repository.RepositoryItemDateEdit repositoryItemDateEdit3;
        private DevExpress.XtraEditors.Repository.RepositoryItemDateEdit repositoryItemDateEdit4;
        private DevExpress.XtraBars.BarEditItem barItemName;
        private DevExpress.XtraEditors.Repository.RepositoryItemTextEdit repositoryItemTextEdit1;
        private DevExpress.XtraBars.BarEditItem baritemPhone;
        private DevExpress.XtraEditors.Repository.RepositoryItemTextEdit repositoryItemTextEdit2;
        private DevExpress.XtraBars.BarEditItem barItemSurname;
        private DevExpress.XtraEditors.Repository.RepositoryItemTextEdit repositoryItemTextEdit3;
        private DevExpress.XtraBars.BarEditItem baritemEmail;
        private DevExpress.XtraEditors.Repository.RepositoryItemTextEdit repositoryItemTextEdit4;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup4;
        private DevExpress.XtraBars.BarEditItem baritemRegisterDate;
        private DevExpress.XtraEditors.Repository.RepositoryItemTextEdit repositoryItemTextEdit5;
        private DevExpress.XtraBars.BarEditItem baritemId;
        private DevExpress.XtraEditors.Repository.RepositoryItemTextEdit repositoryItemTextEdit6;
        private DevExpress.XtraBars.BarButtonItem barButtonItem2;
        private DevExpress.XtraEditors.LookUpEdit customerLookUpEdit;
        private BindingSource customerBindingSource;
        private DevExpress.XtraBars.BarButtonItem barButtonItem3;
        private DevExpress.XtraBars.BarButtonItem barButtonItem5;
        private DevExpress.XtraBars.BarButtonItem barButtonItem6;
        private DevExpress.XtraBars.BarButtonItem barButtonItem7;
        private Label label1;
        private DevExpress.XtraBars.BarButtonItem barButtonItem8;
        private DevExpress.XtraEditors.Repository.RepositoryItemTextEdit repositoryItemTextEdit7;
        private DevExpress.XtraBars.BarEditItem barEditItem1;
        private DevExpress.XtraBars.BarEditItem barEditItem2;
        private DevExpress.XtraEditors.TextEdit textEdit1;
        private BindingSource orderBindingSource;
        private BindingSource orderSummaryBindingSource;
        private DevExpress.XtraGrid.GridControl grOrders;
        private DevExpress.XtraGrid.Views.Grid.GridView grvOrders;
        private DevExpress.XtraGrid.Columns.GridColumn colCustomerFullName;
        private DevExpress.XtraGrid.Columns.GridColumn colTotalPrice;
        private DevExpress.XtraGrid.Columns.GridColumn colTotalCash;
        private DevExpress.XtraGrid.Columns.GridColumn colTotalPOS;
        private DevExpress.XtraGrid.Views.Grid.GridView grvProducts;
        private DevExpress.XtraGrid.Columns.GridColumn colOrderId;
        private DevExpress.XtraGrid.Columns.GridColumn colProductCode;
        private DevExpress.XtraGrid.Columns.GridColumn colProductDescription;
        private DevExpress.XtraGrid.Columns.GridColumn colProductQuantity;
        private DevExpress.XtraGrid.Columns.GridColumn colTotalPriceProduct;
        private DevExpress.XtraGrid.Columns.GridColumn colId;
        private DevExpress.XtraGrid.Columns.GridColumn colDate;
        private DevExpress.XtraGrid.Columns.GridColumn colProductsInOrder;
        private DevExpress.XtraBars.BarButtonItem barButtonItem4;
        private DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit repositoryItemCheckEdit2;
        private DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit repositoryItemCheckEdit1;
        private DevExpress.XtraGrid.Columns.GridColumn colNotes;
        private DevExpress.XtraGrid.Columns.GridColumn colPayed;
        private DevExpress.XtraGrid.Columns.GridColumn colDiscountedPrice;
        private DevExpress.XtraGrid.Columns.GridColumn colDiscountPercentage;
        private BindingSource orderProductsBindingSource;
    }
}