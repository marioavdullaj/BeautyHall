using BeautyHall.Api.SDK.Responses;

namespace BSMS.Winforms.Forms
{
    partial class OrderHistoryForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OrderHistoryForm));
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
            barButtonItem2 = new DevExpress.XtraBars.BarButtonItem();
            dateFrom = new DevExpress.XtraBars.BarEditItem();
            dateFromRepo = new DevExpress.XtraEditors.Repository.RepositoryItemDateEdit();
            dateTo = new DevExpress.XtraBars.BarEditItem();
            dateToRepo = new DevExpress.XtraEditors.Repository.RepositoryItemDateEdit();
            barButtonItem3 = new DevExpress.XtraBars.BarButtonItem();
            barButtonItem4 = new DevExpress.XtraBars.BarButtonItem();
            barButtonItem5 = new DevExpress.XtraBars.BarButtonItem();
            barButtonItem6 = new DevExpress.XtraBars.BarButtonItem();
            ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            ribbonPageGroup3 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            ribbonPageGroup2 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            repositoryItemDateEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemDateEdit();
            ribbonStatusBar = new DevExpress.XtraBars.Ribbon.RibbonStatusBar();
            orderSummaryBindingSource = new BindingSource(components);
            orderSummaryBindingSource1 = new BindingSource(components);
            ((System.ComponentModel.ISupportInitialize)grvProducts).BeginInit();
            ((System.ComponentModel.ISupportInitialize)grOrders).BeginInit();
            ((System.ComponentModel.ISupportInitialize)grvOrders).BeginInit();
            ((System.ComponentModel.ISupportInitialize)repositoryItemCheckEdit2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)repositoryItemCheckEdit1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ribbon).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dateFromRepo).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dateFromRepo.CalendarTimeProperties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dateToRepo).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dateToRepo.CalendarTimeProperties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)repositoryItemDateEdit1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)repositoryItemDateEdit1.CalendarTimeProperties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)orderSummaryBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)orderSummaryBindingSource1).BeginInit();
            SuspendLayout();
            // 
            // grvProducts
            // 
            grvProducts.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] { colOrderId, colProductCode, colProductDescription, colProductQuantity, colTotalPriceProduct });
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
            grOrders.DataSource = typeof(OrderProduct);
            grOrders.Dock = DockStyle.Fill;
            grOrders.EmbeddedNavigator.Margin = new Padding(4, 2, 4, 2);
            gridLevelNode1.LevelTemplate = grvProducts;
            gridLevelNode1.RelationName = "Level1";
            grOrders.LevelTree.Nodes.AddRange(new DevExpress.XtraGrid.GridLevelNode[] { gridLevelNode1 });
            grOrders.Location = new Point(0, 193);
            grOrders.MainView = grvOrders;
            grOrders.Margin = new Padding(4, 2, 4, 2);
            grOrders.MenuManager = ribbon;
            grOrders.Name = "grOrders";
            grOrders.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] { repositoryItemCheckEdit1, repositoryItemCheckEdit2 });
            grOrders.Size = new Size(1447, 535);
            grOrders.TabIndex = 2;
            grOrders.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] { grvOrders, grvProducts });
            grOrders.Load += grOrders_Load;
            // 
            // grvOrders
            // 
            grvOrders.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] { colId, colCustomerFullName, colDate, colNotes, colProductsInOrder, colTotalPrice, colPayed, colDiscountedPrice, colDiscountPercentage, colTotalCash, colTotalPOS });
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
            grvOrders.SelectionChanged += grvOrders_SelectionChanged;
            // 
            // colId
            // 
            colId.Caption = "Order Id";
            colId.FieldName = "Id";
            colId.MinWidth = 24;
            colId.Name = "colId";
            colId.Visible = true;
            colId.VisibleIndex = 1;
            colId.Width = 94;
            // 
            // colCustomerFullName
            // 
            colCustomerFullName.Caption = "Customer";
            colCustomerFullName.FieldName = "CustomerFullName";
            colCustomerFullName.MinWidth = 24;
            colCustomerFullName.Name = "colCustomerFullName";
            colCustomerFullName.Visible = true;
            colCustomerFullName.VisibleIndex = 2;
            colCustomerFullName.Width = 94;
            // 
            // colDate
            // 
            colDate.Caption = "Date";
            colDate.FieldName = "Date";
            colDate.MinWidth = 24;
            colDate.Name = "colDate";
            colDate.Visible = true;
            colDate.VisibleIndex = 3;
            colDate.Width = 94;
            // 
            // colNotes
            // 
            colNotes.Caption = "Notes";
            colNotes.FieldName = "Notes";
            colNotes.MinWidth = 24;
            colNotes.Name = "colNotes";
            colNotes.Visible = true;
            colNotes.VisibleIndex = 4;
            colNotes.Width = 94;
            // 
            // colProductsInOrder
            // 
            colProductsInOrder.Caption = "Products in order";
            colProductsInOrder.ColumnEdit = repositoryItemCheckEdit2;
            colProductsInOrder.FieldName = "ExistProductsInOrder";
            colProductsInOrder.MinWidth = 24;
            colProductsInOrder.Name = "colProductsInOrder";
            colProductsInOrder.Visible = true;
            colProductsInOrder.VisibleIndex = 5;
            colProductsInOrder.Width = 94;
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
            colTotalPrice.MinWidth = 24;
            colTotalPrice.Name = "colTotalPrice";
            colTotalPrice.Visible = true;
            colTotalPrice.VisibleIndex = 6;
            colTotalPrice.Width = 94;
            // 
            // colPayed
            // 
            colPayed.Caption = "Payed";
            colPayed.ColumnEdit = repositoryItemCheckEdit1;
            colPayed.FieldName = "Payed";
            colPayed.MinWidth = 24;
            colPayed.Name = "colPayed";
            colPayed.Visible = true;
            colPayed.VisibleIndex = 7;
            colPayed.Width = 94;
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
            colDiscountedPrice.MinWidth = 24;
            colDiscountedPrice.Name = "colDiscountedPrice";
            colDiscountedPrice.Visible = true;
            colDiscountedPrice.VisibleIndex = 8;
            colDiscountedPrice.Width = 94;
            // 
            // colDiscountPercentage
            // 
            colDiscountPercentage.Caption = "Discount";
            colDiscountPercentage.FieldName = "DiscountPercentage";
            colDiscountPercentage.MinWidth = 24;
            colDiscountPercentage.Name = "colDiscountPercentage";
            colDiscountPercentage.Visible = true;
            colDiscountPercentage.VisibleIndex = 9;
            colDiscountPercentage.Width = 94;
            // 
            // colTotalCash
            // 
            colTotalCash.Caption = "Total Cash";
            colTotalCash.DisplayFormat.FormatString = "c";
            colTotalCash.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            colTotalCash.FieldName = "TotalCash";
            colTotalCash.GroupFormat.FormatString = "c";
            colTotalCash.GroupFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            colTotalCash.MinWidth = 24;
            colTotalCash.Name = "colTotalCash";
            colTotalCash.Visible = true;
            colTotalCash.VisibleIndex = 10;
            colTotalCash.Width = 94;
            // 
            // colTotalPOS
            // 
            colTotalPOS.Caption = "Total POS";
            colTotalPOS.DisplayFormat.FormatString = "c";
            colTotalPOS.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            colTotalPOS.FieldName = "TotalPOS";
            colTotalPOS.GroupFormat.FormatString = "c";
            colTotalPOS.GroupFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            colTotalPOS.MinWidth = 24;
            colTotalPOS.Name = "colTotalPOS";
            colTotalPOS.Visible = true;
            colTotalPOS.VisibleIndex = 11;
            colTotalPOS.Width = 94;
            // 
            // ribbon
            // 
            ribbon.ExpandCollapseItem.Id = 0;
            ribbon.Items.AddRange(new DevExpress.XtraBars.BarItem[] { ribbon.ExpandCollapseItem, ribbon.SearchEditItem, barButtonItem1, barButtonItem2, dateFrom, dateTo, barButtonItem3, barButtonItem4, barButtonItem5, barButtonItem6 });
            ribbon.Location = new Point(0, 0);
            ribbon.Margin = new Padding(4, 2, 4, 2);
            ribbon.MaxItemId = 10;
            ribbon.Name = "ribbon";
            ribbon.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] { ribbonPage1 });
            ribbon.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] { dateFromRepo, dateToRepo, repositoryItemDateEdit1 });
            ribbon.Size = new Size(1447, 193);
            ribbon.StatusBar = ribbonStatusBar;
            // 
            // barButtonItem1
            // 
            barButtonItem1.Caption = "Refresh";
            barButtonItem1.Id = 1;
            barButtonItem1.ImageOptions.SvgImage = (DevExpress.Utils.Svg.SvgImage)resources.GetObject("barButtonItem1.ImageOptions.SvgImage");
            barButtonItem1.Name = "barButtonItem1";
            barButtonItem1.ItemClick += barButtonItem1_ItemClick;
            // 
            // barButtonItem2
            // 
            barButtonItem2.Caption = "Close";
            barButtonItem2.Id = 2;
            barButtonItem2.ImageOptions.SvgImage = (DevExpress.Utils.Svg.SvgImage)resources.GetObject("barButtonItem2.ImageOptions.SvgImage");
            barButtonItem2.Name = "barButtonItem2";
            barButtonItem2.ItemClick += barButtonItem2_ItemClick;
            // 
            // dateFrom
            // 
            dateFrom.Caption = "Date From:   ";
            dateFrom.Edit = dateFromRepo;
            dateFrom.EditWidth = 100;
            dateFrom.Id = 3;
            dateFrom.Name = "dateFrom";
            // 
            // dateFromRepo
            // 
            dateFromRepo.AutoHeight = false;
            dateFromRepo.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] { new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo) });
            dateFromRepo.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] { new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo) });
            dateFromRepo.CalendarView = DevExpress.XtraEditors.Repository.CalendarView.Fluent;
            dateFromRepo.Name = "dateFromRepo";
            dateFromRepo.VistaDisplayMode = DevExpress.Utils.DefaultBoolean.False;
            // 
            // dateTo
            // 
            dateTo.Caption = "Date To:       ";
            dateTo.Edit = dateToRepo;
            dateTo.EditWidth = 100;
            dateTo.Id = 4;
            dateTo.Name = "dateTo";
            // 
            // dateToRepo
            // 
            dateToRepo.AutoHeight = false;
            dateToRepo.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] { new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo) });
            dateToRepo.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] { new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo) });
            dateToRepo.CalendarView = DevExpress.XtraEditors.Repository.CalendarView.Fluent;
            dateToRepo.Name = "dateToRepo";
            dateToRepo.VistaDisplayMode = DevExpress.Utils.DefaultBoolean.False;
            // 
            // barButtonItem3
            // 
            barButtonItem3.Caption = "Open Order";
            barButtonItem3.Id = 5;
            barButtonItem3.ImageOptions.SvgImage = (DevExpress.Utils.Svg.SvgImage)resources.GetObject("barButtonItem3.ImageOptions.SvgImage");
            barButtonItem3.Name = "barButtonItem3";
            barButtonItem3.ItemClick += barButtonItem3_ItemClick;
            // 
            // barButtonItem4
            // 
            barButtonItem4.Caption = "Save as PDF";
            barButtonItem4.Id = 6;
            barButtonItem4.ImageOptions.SvgImage = (DevExpress.Utils.Svg.SvgImage)resources.GetObject("barButtonItem4.ImageOptions.SvgImage");
            barButtonItem4.Name = "barButtonItem4";
            barButtonItem4.ItemClick += barButtonItem4_ItemClick;
            // 
            // barButtonItem5
            // 
            barButtonItem5.Caption = "Delete Orders";
            barButtonItem5.Id = 7;
            barButtonItem5.ImageOptions.SvgImage = (DevExpress.Utils.Svg.SvgImage)resources.GetObject("barButtonItem5.ImageOptions.SvgImage");
            barButtonItem5.Name = "barButtonItem5";
            barButtonItem5.ItemClick += barButtonItem5_ItemClick;
            // 
            // barButtonItem6
            // 
            barButtonItem6.Caption = "Export Grid";
            barButtonItem6.Id = 9;
            barButtonItem6.ImageOptions.SvgImage = (DevExpress.Utils.Svg.SvgImage)resources.GetObject("barButtonItem6.ImageOptions.SvgImage");
            barButtonItem6.Name = "barButtonItem6";
            barButtonItem6.ItemClick += barButtonItem6_ItemClick;
            // 
            // ribbonPage1
            // 
            ribbonPage1.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] { ribbonPageGroup1, ribbonPageGroup3, ribbonPageGroup2 });
            ribbonPage1.Name = "ribbonPage1";
            ribbonPage1.Text = "All orders";
            // 
            // ribbonPageGroup1
            // 
            ribbonPageGroup1.ItemLinks.Add(barButtonItem1);
            ribbonPageGroup1.ItemLinks.Add(barButtonItem3);
            ribbonPageGroup1.ItemLinks.Add(barButtonItem5);
            ribbonPageGroup1.ItemLinks.Add(barButtonItem6);
            ribbonPageGroup1.Name = "ribbonPageGroup1";
            // 
            // ribbonPageGroup3
            // 
            ribbonPageGroup3.ItemLinks.Add(dateFrom);
            ribbonPageGroup3.ItemLinks.Add(dateTo);
            ribbonPageGroup3.Name = "ribbonPageGroup3";
            // 
            // ribbonPageGroup2
            // 
            ribbonPageGroup2.ItemLinks.Add(barButtonItem4);
            ribbonPageGroup2.ItemLinks.Add(barButtonItem2);
            ribbonPageGroup2.Name = "ribbonPageGroup2";
            // 
            // repositoryItemDateEdit1
            // 
            repositoryItemDateEdit1.AutoHeight = false;
            repositoryItemDateEdit1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] { new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo) });
            repositoryItemDateEdit1.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] { new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo) });
            repositoryItemDateEdit1.Name = "repositoryItemDateEdit1";
            // 
            // ribbonStatusBar
            // 
            ribbonStatusBar.Location = new Point(0, 728);
            ribbonStatusBar.Margin = new Padding(4, 2, 4, 2);
            ribbonStatusBar.Name = "ribbonStatusBar";
            ribbonStatusBar.Ribbon = ribbon;
            ribbonStatusBar.Size = new Size(1447, 30);
            // 
            // orderSummaryBindingSource
            // 
            orderSummaryBindingSource.DataSource = typeof(Models.OrderSummary);
            // 
            // orderSummaryBindingSource1
            // 
            orderSummaryBindingSource1.DataSource = typeof(Models.OrderSummary);
            // 
            // OrderHistoryForm
            // 
            AutoScaleDimensions = new SizeF(7F, 16F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1447, 758);
            Controls.Add(grOrders);
            Controls.Add(ribbonStatusBar);
            Controls.Add(ribbon);
            Margin = new Padding(4, 2, 4, 2);
            Name = "OrderHistoryForm";
            Ribbon = ribbon;
            StatusBar = ribbonStatusBar;
            ((System.ComponentModel.ISupportInitialize)grvProducts).EndInit();
            ((System.ComponentModel.ISupportInitialize)grOrders).EndInit();
            ((System.ComponentModel.ISupportInitialize)grvOrders).EndInit();
            ((System.ComponentModel.ISupportInitialize)repositoryItemCheckEdit2).EndInit();
            ((System.ComponentModel.ISupportInitialize)repositoryItemCheckEdit1).EndInit();
            ((System.ComponentModel.ISupportInitialize)ribbon).EndInit();
            ((System.ComponentModel.ISupportInitialize)dateFromRepo.CalendarTimeProperties).EndInit();
            ((System.ComponentModel.ISupportInitialize)dateFromRepo).EndInit();
            ((System.ComponentModel.ISupportInitialize)dateToRepo.CalendarTimeProperties).EndInit();
            ((System.ComponentModel.ISupportInitialize)dateToRepo).EndInit();
            ((System.ComponentModel.ISupportInitialize)repositoryItemDateEdit1.CalendarTimeProperties).EndInit();
            ((System.ComponentModel.ISupportInitialize)repositoryItemDateEdit1).EndInit();
            ((System.ComponentModel.ISupportInitialize)orderSummaryBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)orderSummaryBindingSource1).EndInit();
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
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup2;
        private DevExpress.XtraGrid.GridControl grOrders;
        private DevExpress.XtraGrid.Views.Grid.GridView grvOrders;
        private DevExpress.XtraBars.BarEditItem dateFrom;
        private DevExpress.XtraEditors.Repository.RepositoryItemDateEdit dateFromRepo;
        private DevExpress.XtraBars.BarEditItem dateTo;
        private DevExpress.XtraEditors.Repository.RepositoryItemDateEdit dateToRepo;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup3;
        private BindingSource orderSummaryBindingSource;
        private DevExpress.XtraGrid.Columns.GridColumn colId;
        private DevExpress.XtraGrid.Columns.GridColumn colCustomerFullName;
        private DevExpress.XtraGrid.Columns.GridColumn colDate;
        private DevExpress.XtraGrid.Columns.GridColumn colNotes;
        private DevExpress.XtraGrid.Columns.GridColumn colTotalPrice;
        private DevExpress.XtraGrid.Columns.GridColumn colDiscountedPrice;
        private DevExpress.XtraGrid.Columns.GridColumn colTotalCash;
        private DevExpress.XtraGrid.Columns.GridColumn colTotalPOS;
        private DevExpress.XtraGrid.Columns.GridColumn colPayed;
        private DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit repositoryItemCheckEdit1;
        private DevExpress.XtraBars.BarButtonItem barButtonItem3;
        private DevExpress.XtraBars.BarButtonItem barButtonItem4;
        private DevExpress.XtraBars.BarButtonItem barButtonItem5;
        private DevExpress.XtraEditors.Repository.RepositoryItemDateEdit repositoryItemDateEdit1;
        private DevExpress.XtraGrid.Columns.GridColumn colProductsInOrder;
        private DevExpress.XtraGrid.Views.Grid.GridView grvProducts;
        private DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit repositoryItemCheckEdit2;
        private BindingSource orderSummaryBindingSource1;
        private DevExpress.XtraGrid.Columns.GridColumn colProductCode;
        private DevExpress.XtraGrid.Columns.GridColumn colProductDescription;
        private DevExpress.XtraGrid.Columns.GridColumn colProductQuantity;
        private DevExpress.XtraGrid.Columns.GridColumn colTotalPriceProduct;
        private DevExpress.XtraGrid.Columns.GridColumn colOrderId;
        private DevExpress.XtraGrid.Columns.GridColumn colDiscountPercentage;
        private DevExpress.XtraBars.BarButtonItem barButtonItem6;
    }
}