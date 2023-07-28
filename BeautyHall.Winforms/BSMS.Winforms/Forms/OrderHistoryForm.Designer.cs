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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OrderHistoryForm));
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
            ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            ribbonPageGroup3 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            ribbonPageGroup2 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            ribbonStatusBar = new DevExpress.XtraBars.Ribbon.RibbonStatusBar();
            grOrders = new DevExpress.XtraGrid.GridControl();
            orderSummaryBindingSource = new BindingSource(components);
            grvOrders = new DevExpress.XtraGrid.Views.Grid.GridView();
            colId = new DevExpress.XtraGrid.Columns.GridColumn();
            colCustomerFullName = new DevExpress.XtraGrid.Columns.GridColumn();
            colDate = new DevExpress.XtraGrid.Columns.GridColumn();
            colNotes = new DevExpress.XtraGrid.Columns.GridColumn();
            colTotalPrice = new DevExpress.XtraGrid.Columns.GridColumn();
            colPayed = new DevExpress.XtraGrid.Columns.GridColumn();
            repositoryItemCheckEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit();
            colDiscountedPrice = new DevExpress.XtraGrid.Columns.GridColumn();
            colTotalCash = new DevExpress.XtraGrid.Columns.GridColumn();
            colTotalPOS = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)ribbon).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dateFromRepo).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dateFromRepo.CalendarTimeProperties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dateToRepo).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dateToRepo.CalendarTimeProperties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)grOrders).BeginInit();
            ((System.ComponentModel.ISupportInitialize)orderSummaryBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)grvOrders).BeginInit();
            ((System.ComponentModel.ISupportInitialize)repositoryItemCheckEdit1).BeginInit();
            SuspendLayout();
            // 
            // ribbon
            // 
            ribbon.ExpandCollapseItem.Id = 0;
            ribbon.Items.AddRange(new DevExpress.XtraBars.BarItem[] { ribbon.ExpandCollapseItem, ribbon.SearchEditItem, barButtonItem1, barButtonItem2, dateFrom, dateTo, barButtonItem3, barButtonItem4, barButtonItem5 });
            ribbon.Location = new Point(0, 0);
            ribbon.MaxItemId = 8;
            ribbon.Name = "ribbon";
            ribbon.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] { ribbonPage1 });
            ribbon.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] { dateFromRepo, dateToRepo });
            ribbon.Size = new Size(1097, 193);
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
            // ribbonStatusBar
            // 
            ribbonStatusBar.Location = new Point(0, 492);
            ribbonStatusBar.Name = "ribbonStatusBar";
            ribbonStatusBar.Ribbon = ribbon;
            ribbonStatusBar.Size = new Size(1097, 30);
            // 
            // grOrders
            // 
            grOrders.DataSource = orderSummaryBindingSource;
            grOrders.Dock = DockStyle.Fill;
            grOrders.Location = new Point(0, 193);
            grOrders.MainView = grvOrders;
            grOrders.MenuManager = ribbon;
            grOrders.Name = "grOrders";
            grOrders.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] { repositoryItemCheckEdit1 });
            grOrders.Size = new Size(1097, 299);
            grOrders.TabIndex = 2;
            grOrders.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] { grvOrders });
            grOrders.Load += grOrders_Load;
            // 
            // orderSummaryBindingSource
            // 
            orderSummaryBindingSource.DataSource = typeof(Models.OrderSummary);
            // 
            // grvOrders
            // 
            grvOrders.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] { colId, colCustomerFullName, colDate, colNotes, colTotalPrice, colPayed, colDiscountedPrice, colTotalCash, colTotalPOS });
            grvOrders.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFullFocus;
            grvOrders.GridControl = grOrders;
            grvOrders.Name = "grvOrders";
            grvOrders.OptionsBehavior.Editable = false;
            grvOrders.OptionsSelection.MultiSelect = true;
            grvOrders.OptionsSelection.MultiSelectMode = DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.CheckBoxRowSelect;
            grvOrders.OptionsView.ShowAutoFilterRow = true;
            grvOrders.OptionsView.ShowFooter = true;
            grvOrders.OptionsView.ShowGroupPanel = false;
            grvOrders.OptionsView.ShowHorizontalLines = DevExpress.Utils.DefaultBoolean.True;
            grvOrders.OptionsView.ShowVerticalLines = DevExpress.Utils.DefaultBoolean.True;
            grvOrders.SelectionChanged += grvOrders_SelectionChanged;
            // 
            // colId
            // 
            colId.FieldName = "Id";
            colId.MinWidth = 25;
            colId.Name = "colId";
            colId.Visible = true;
            colId.VisibleIndex = 1;
            colId.Width = 94;
            // 
            // colCustomerFullName
            // 
            colCustomerFullName.FieldName = "CustomerFullName";
            colCustomerFullName.MinWidth = 25;
            colCustomerFullName.Name = "colCustomerFullName";
            colCustomerFullName.Visible = true;
            colCustomerFullName.VisibleIndex = 2;
            colCustomerFullName.Width = 94;
            // 
            // colDate
            // 
            colDate.FieldName = "Date";
            colDate.MinWidth = 25;
            colDate.Name = "colDate";
            colDate.Visible = true;
            colDate.VisibleIndex = 3;
            colDate.Width = 94;
            // 
            // colNotes
            // 
            colNotes.FieldName = "Notes";
            colNotes.MinWidth = 25;
            colNotes.Name = "colNotes";
            colNotes.Visible = true;
            colNotes.VisibleIndex = 4;
            colNotes.Width = 94;
            // 
            // colTotalPrice
            // 
            colTotalPrice.DisplayFormat.FormatString = "c";
            colTotalPrice.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            colTotalPrice.FieldName = "TotalPrice";
            colTotalPrice.GroupFormat.FormatString = "c";
            colTotalPrice.GroupFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            colTotalPrice.MinWidth = 25;
            colTotalPrice.Name = "colTotalPrice";
            colTotalPrice.Visible = true;
            colTotalPrice.VisibleIndex = 5;
            colTotalPrice.Width = 94;
            // 
            // colPayed
            // 
            colPayed.Caption = "Order Payed";
            colPayed.ColumnEdit = repositoryItemCheckEdit1;
            colPayed.FieldName = "Payed";
            colPayed.MinWidth = 25;
            colPayed.Name = "colPayed";
            colPayed.Visible = true;
            colPayed.VisibleIndex = 6;
            colPayed.Width = 94;
            // 
            // repositoryItemCheckEdit1
            // 
            repositoryItemCheckEdit1.AutoHeight = false;
            repositoryItemCheckEdit1.Name = "repositoryItemCheckEdit1";
            // 
            // colDiscountedPrice
            // 
            colDiscountedPrice.DisplayFormat.FormatString = "c";
            colDiscountedPrice.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            colDiscountedPrice.FieldName = "DiscountedPrice";
            colDiscountedPrice.GroupFormat.FormatString = "c";
            colDiscountedPrice.GroupFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            colDiscountedPrice.MinWidth = 25;
            colDiscountedPrice.Name = "colDiscountedPrice";
            colDiscountedPrice.Visible = true;
            colDiscountedPrice.VisibleIndex = 7;
            colDiscountedPrice.Width = 94;
            // 
            // colTotalCash
            // 
            colTotalCash.DisplayFormat.FormatString = "c";
            colTotalCash.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            colTotalCash.FieldName = "TotalCash";
            colTotalCash.GroupFormat.FormatString = "c";
            colTotalCash.GroupFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            colTotalCash.MinWidth = 25;
            colTotalCash.Name = "colTotalCash";
            colTotalCash.Visible = true;
            colTotalCash.VisibleIndex = 8;
            colTotalCash.Width = 94;
            // 
            // colTotalPOS
            // 
            colTotalPOS.DisplayFormat.FormatString = "c";
            colTotalPOS.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            colTotalPOS.FieldName = "TotalPOS";
            colTotalPOS.GroupFormat.FormatString = "c";
            colTotalPOS.GroupFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            colTotalPOS.MinWidth = 25;
            colTotalPOS.Name = "colTotalPOS";
            colTotalPOS.Visible = true;
            colTotalPOS.VisibleIndex = 9;
            colTotalPOS.Width = 94;
            // 
            // OrderHistoryForm
            // 
            AutoScaleDimensions = new SizeF(7F, 16F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1097, 522);
            Controls.Add(grOrders);
            Controls.Add(ribbonStatusBar);
            Controls.Add(ribbon);
            Name = "OrderHistoryForm";
            Ribbon = ribbon;
            StatusBar = ribbonStatusBar;
            ((System.ComponentModel.ISupportInitialize)ribbon).EndInit();
            ((System.ComponentModel.ISupportInitialize)dateFromRepo.CalendarTimeProperties).EndInit();
            ((System.ComponentModel.ISupportInitialize)dateFromRepo).EndInit();
            ((System.ComponentModel.ISupportInitialize)dateToRepo.CalendarTimeProperties).EndInit();
            ((System.ComponentModel.ISupportInitialize)dateToRepo).EndInit();
            ((System.ComponentModel.ISupportInitialize)grOrders).EndInit();
            ((System.ComponentModel.ISupportInitialize)orderSummaryBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)grvOrders).EndInit();
            ((System.ComponentModel.ISupportInitialize)repositoryItemCheckEdit1).EndInit();
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
    }
}