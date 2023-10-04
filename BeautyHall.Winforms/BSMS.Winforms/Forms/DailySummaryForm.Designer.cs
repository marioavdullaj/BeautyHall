namespace BSMS.Winforms.Forms
{
    partial class DailySummaryForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DailySummaryForm));
            ribbon = new DevExpress.XtraBars.Ribbon.RibbonControl();
            barButtonItem1 = new DevExpress.XtraBars.BarButtonItem();
            calculateDailySummaryButton = new DevExpress.XtraBars.BarButtonItem();
            ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            ribbonPageGroup2 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            ribbonStatusBar = new DevExpress.XtraBars.Ribbon.RibbonStatusBar();
            panelControl1 = new DevExpress.XtraEditors.PanelControl();
            summaryDateEdit = new DevExpress.XtraEditors.DateEdit();
            labelControl1 = new DevExpress.XtraEditors.LabelControl();
            orderSummaryGridControl = new DevExpress.XtraGrid.GridControl();
            orderSummaryBindingSource = new BindingSource(components);
            orderSummaryGridView = new DevExpress.XtraGrid.Views.Grid.GridView();
            colCustomerFullName = new DevExpress.XtraGrid.Columns.GridColumn();
            colDiscountedPrice = new DevExpress.XtraGrid.Columns.GridColumn();
            colTotalCash = new DevExpress.XtraGrid.Columns.GridColumn();
            colTotalPOS = new DevExpress.XtraGrid.Columns.GridColumn();
            SummaryPanel = new DevExpress.XtraEditors.PanelControl();
            labelControl10 = new DevExpress.XtraEditors.LabelControl();
            labelControl19 = new DevExpress.XtraEditors.LabelControl();
            labelControl18 = new DevExpress.XtraEditors.LabelControl();
            labelControl17 = new DevExpress.XtraEditors.LabelControl();
            labelControl16 = new DevExpress.XtraEditors.LabelControl();
            PaymentsCostsPOS = new DevExpress.XtraEditors.TextEdit();
            labelControl15 = new DevExpress.XtraEditors.LabelControl();
            labelControl14 = new DevExpress.XtraEditors.LabelControl();
            labelControl13 = new DevExpress.XtraEditors.LabelControl();
            labelControl12 = new DevExpress.XtraEditors.LabelControl();
            PaymentsCostsCash = new DevExpress.XtraEditors.TextEdit();
            ShopingCostsPOS = new DevExpress.XtraEditors.TextEdit();
            ShoppingCostsCash = new DevExpress.XtraEditors.TextEdit();
            CalculateDailySumbtn = new DevExpress.XtraEditors.SimpleButton();
            cashNetEdit = new DevExpress.XtraEditors.TextEdit();
            totalNetEdit = new DevExpress.XtraEditors.TextEdit();
            labelControl8 = new DevExpress.XtraEditors.LabelControl();
            labelControl9 = new DevExpress.XtraEditors.LabelControl();
            labelControl7 = new DevExpress.XtraEditors.LabelControl();
            dailyCostsEdit = new DevExpress.XtraEditors.TextEdit();
            labelControl6 = new DevExpress.XtraEditors.LabelControl();
            totalPosEdit = new DevExpress.XtraEditors.TextEdit();
            totalCashEdit = new DevExpress.XtraEditors.TextEdit();
            totalGrossEdit = new DevExpress.XtraEditors.TextEdit();
            labelControl5 = new DevExpress.XtraEditors.LabelControl();
            labelControl4 = new DevExpress.XtraEditors.LabelControl();
            labelControl3 = new DevExpress.XtraEditors.LabelControl();
            labelControl2 = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)ribbon).BeginInit();
            ((System.ComponentModel.ISupportInitialize)panelControl1).BeginInit();
            panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)summaryDateEdit.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)summaryDateEdit.Properties.CalendarTimeProperties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)orderSummaryGridControl).BeginInit();
            ((System.ComponentModel.ISupportInitialize)orderSummaryBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)orderSummaryGridView).BeginInit();
            ((System.ComponentModel.ISupportInitialize)SummaryPanel).BeginInit();
            SummaryPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)PaymentsCostsPOS.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)PaymentsCostsCash.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ShopingCostsPOS.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ShoppingCostsCash.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)cashNetEdit.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)totalNetEdit.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dailyCostsEdit.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)totalPosEdit.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)totalCashEdit.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)totalGrossEdit.Properties).BeginInit();
            SuspendLayout();
            // 
            // ribbon
            // 
            ribbon.ExpandCollapseItem.Id = 0;
            ribbon.Items.AddRange(new DevExpress.XtraBars.BarItem[] { ribbon.ExpandCollapseItem, ribbon.SearchEditItem, barButtonItem1, calculateDailySummaryButton });
            ribbon.Location = new Point(0, 0);
            ribbon.Margin = new Padding(4, 2, 4, 2);
            ribbon.MaxItemId = 4;
            ribbon.Name = "ribbon";
            ribbon.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] { ribbonPage1 });
            ribbon.Size = new Size(1304, 193);
            ribbon.StatusBar = ribbonStatusBar;
            // 
            // barButtonItem1
            // 
            barButtonItem1.Caption = "Close";
            barButtonItem1.Id = 1;
            barButtonItem1.ImageOptions.SvgImage = (DevExpress.Utils.Svg.SvgImage)resources.GetObject("barButtonItem1.ImageOptions.SvgImage");
            barButtonItem1.Name = "barButtonItem1";
            barButtonItem1.ItemClick += barButtonItem1_ItemClick;
            // 
            // calculateDailySummaryButton
            // 
            calculateDailySummaryButton.Caption = "Calculate";
            calculateDailySummaryButton.Id = 2;
            calculateDailySummaryButton.ImageOptions.SvgImage = (DevExpress.Utils.Svg.SvgImage)resources.GetObject("calculateDailySummaryButton.ImageOptions.SvgImage");
            calculateDailySummaryButton.Name = "calculateDailySummaryButton";
            calculateDailySummaryButton.ItemClick += calculateDailySummaryButton_ItemClick;
            // 
            // ribbonPage1
            // 
            ribbonPage1.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] { ribbonPageGroup2, ribbonPageGroup1 });
            ribbonPage1.Name = "ribbonPage1";
            ribbonPage1.Text = "Calculate Daily Summary";
            // 
            // ribbonPageGroup2
            // 
            ribbonPageGroup2.ItemLinks.Add(calculateDailySummaryButton);
            ribbonPageGroup2.Name = "ribbonPageGroup2";
            // 
            // ribbonPageGroup1
            // 
            ribbonPageGroup1.ItemLinks.Add(barButtonItem1);
            ribbonPageGroup1.Name = "ribbonPageGroup1";
            // 
            // ribbonStatusBar
            // 
            ribbonStatusBar.Location = new Point(0, 921);
            ribbonStatusBar.Margin = new Padding(4, 2, 4, 2);
            ribbonStatusBar.Name = "ribbonStatusBar";
            ribbonStatusBar.Ribbon = ribbon;
            ribbonStatusBar.Size = new Size(1304, 30);
            // 
            // panelControl1
            // 
            panelControl1.Controls.Add(summaryDateEdit);
            panelControl1.Controls.Add(labelControl1);
            panelControl1.Dock = DockStyle.Top;
            panelControl1.Location = new Point(0, 193);
            panelControl1.Margin = new Padding(4, 2, 4, 2);
            panelControl1.Name = "panelControl1";
            panelControl1.Size = new Size(1304, 78);
            panelControl1.TabIndex = 2;
            // 
            // summaryDateEdit
            // 
            summaryDateEdit.EditValue = null;
            summaryDateEdit.Location = new Point(666, 27);
            summaryDateEdit.Margin = new Padding(4, 2, 4, 2);
            summaryDateEdit.MenuManager = ribbon;
            summaryDateEdit.Name = "summaryDateEdit";
            summaryDateEdit.Properties.Appearance.Font = new Font("Tahoma", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            summaryDateEdit.Properties.Appearance.Options.UseFont = true;
            summaryDateEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] { new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo) });
            summaryDateEdit.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] { new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo) });
            summaryDateEdit.Size = new Size(131, 28);
            summaryDateEdit.TabIndex = 1;
            summaryDateEdit.EditValueChanged += summaryDateEdit_EditValueChanged;
            // 
            // labelControl1
            // 
            labelControl1.Appearance.Font = new Font("Tahoma", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            labelControl1.Appearance.Options.UseFont = true;
            labelControl1.Location = new Point(464, 25);
            labelControl1.Margin = new Padding(4, 2, 4, 2);
            labelControl1.Name = "labelControl1";
            labelControl1.Size = new Size(161, 28);
            labelControl1.TabIndex = 0;
            labelControl1.Text = "Επιλογή Ημέρας";
            // 
            // orderSummaryGridControl
            // 
            orderSummaryGridControl.DataSource = orderSummaryBindingSource;
            orderSummaryGridControl.Dock = DockStyle.Left;
            orderSummaryGridControl.EmbeddedNavigator.Margin = new Padding(4, 2, 4, 2);
            orderSummaryGridControl.Location = new Point(0, 271);
            orderSummaryGridControl.MainView = orderSummaryGridView;
            orderSummaryGridControl.Margin = new Padding(4, 2, 4, 2);
            orderSummaryGridControl.MenuManager = ribbon;
            orderSummaryGridControl.Name = "orderSummaryGridControl";
            orderSummaryGridControl.Size = new Size(429, 650);
            orderSummaryGridControl.TabIndex = 3;
            orderSummaryGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] { orderSummaryGridView });
            // 
            // orderSummaryBindingSource
            // 
            orderSummaryBindingSource.DataSource = typeof(Models.OrderSummary);
            // 
            // orderSummaryGridView
            // 
            orderSummaryGridView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] { colCustomerFullName, colDiscountedPrice, colTotalCash, colTotalPOS });
            orderSummaryGridView.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFullFocus;
            orderSummaryGridView.GridControl = orderSummaryGridControl;
            orderSummaryGridView.Name = "orderSummaryGridView";
            orderSummaryGridView.OptionsBehavior.Editable = false;
            orderSummaryGridView.OptionsView.ShowGroupPanel = false;
            // 
            // colCustomerFullName
            // 
            colCustomerFullName.Caption = "Customer";
            colCustomerFullName.FieldName = "CustomerFullName";
            colCustomerFullName.MinWidth = 24;
            colCustomerFullName.Name = "colCustomerFullName";
            colCustomerFullName.Visible = true;
            colCustomerFullName.VisibleIndex = 0;
            colCustomerFullName.Width = 94;
            // 
            // colDiscountedPrice
            // 
            colDiscountedPrice.Caption = "Total";
            colDiscountedPrice.FieldName = "DiscountedPrice";
            colDiscountedPrice.MinWidth = 24;
            colDiscountedPrice.Name = "colDiscountedPrice";
            colDiscountedPrice.Visible = true;
            colDiscountedPrice.VisibleIndex = 1;
            colDiscountedPrice.Width = 94;
            // 
            // colTotalCash
            // 
            colTotalCash.FieldName = "TotalCash";
            colTotalCash.MinWidth = 24;
            colTotalCash.Name = "colTotalCash";
            colTotalCash.Visible = true;
            colTotalCash.VisibleIndex = 2;
            colTotalCash.Width = 94;
            // 
            // colTotalPOS
            // 
            colTotalPOS.FieldName = "TotalPOS";
            colTotalPOS.MinWidth = 24;
            colTotalPOS.Name = "colTotalPOS";
            colTotalPOS.Visible = true;
            colTotalPOS.VisibleIndex = 3;
            colTotalPOS.Width = 94;
            // 
            // SummaryPanel
            // 
            SummaryPanel.Controls.Add(labelControl10);
            SummaryPanel.Controls.Add(labelControl19);
            SummaryPanel.Controls.Add(labelControl18);
            SummaryPanel.Controls.Add(labelControl17);
            SummaryPanel.Controls.Add(labelControl16);
            SummaryPanel.Controls.Add(PaymentsCostsPOS);
            SummaryPanel.Controls.Add(labelControl15);
            SummaryPanel.Controls.Add(labelControl14);
            SummaryPanel.Controls.Add(labelControl13);
            SummaryPanel.Controls.Add(labelControl12);
            SummaryPanel.Controls.Add(PaymentsCostsCash);
            SummaryPanel.Controls.Add(ShopingCostsPOS);
            SummaryPanel.Controls.Add(ShoppingCostsCash);
            SummaryPanel.Controls.Add(CalculateDailySumbtn);
            SummaryPanel.Controls.Add(cashNetEdit);
            SummaryPanel.Controls.Add(totalNetEdit);
            SummaryPanel.Controls.Add(labelControl8);
            SummaryPanel.Controls.Add(labelControl9);
            SummaryPanel.Controls.Add(labelControl7);
            SummaryPanel.Controls.Add(dailyCostsEdit);
            SummaryPanel.Controls.Add(labelControl6);
            SummaryPanel.Controls.Add(totalPosEdit);
            SummaryPanel.Controls.Add(totalCashEdit);
            SummaryPanel.Controls.Add(totalGrossEdit);
            SummaryPanel.Controls.Add(labelControl5);
            SummaryPanel.Controls.Add(labelControl4);
            SummaryPanel.Controls.Add(labelControl3);
            SummaryPanel.Controls.Add(labelControl2);
            SummaryPanel.Dock = DockStyle.Fill;
            SummaryPanel.Location = new Point(429, 271);
            SummaryPanel.Margin = new Padding(4, 2, 4, 2);
            SummaryPanel.Name = "SummaryPanel";
            SummaryPanel.Size = new Size(875, 650);
            SummaryPanel.TabIndex = 4;
            SummaryPanel.Visible = false;
            // 
            // labelControl10
            // 
            labelControl10.Appearance.Font = new Font("Tahoma", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            labelControl10.Appearance.Options.UseFont = true;
            labelControl10.Location = new Point(415, 244);
            labelControl10.Name = "labelControl10";
            labelControl10.Size = new Size(89, 28);
            labelControl10.TabIndex = 72;
            labelControl10.Text = "Μετρητά";
            // 
            // labelControl19
            // 
            labelControl19.Appearance.Font = new Font("Tahoma", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            labelControl19.Appearance.Options.UseFont = true;
            labelControl19.Location = new Point(415, 450);
            labelControl19.Name = "labelControl19";
            labelControl19.Size = new Size(42, 28);
            labelControl19.TabIndex = 71;
            labelControl19.Text = "POS";
            // 
            // labelControl18
            // 
            labelControl18.Appearance.Font = new Font("Tahoma", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            labelControl18.Appearance.Options.UseFont = true;
            labelControl18.Location = new Point(415, 401);
            labelControl18.Name = "labelControl18";
            labelControl18.Size = new Size(89, 28);
            labelControl18.TabIndex = 70;
            labelControl18.Text = "Μετρητά";
            // 
            // labelControl17
            // 
            labelControl17.Appearance.Font = new Font("Tahoma", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            labelControl17.Appearance.Options.UseFont = true;
            labelControl17.Location = new Point(415, 352);
            labelControl17.Name = "labelControl17";
            labelControl17.Size = new Size(42, 28);
            labelControl17.TabIndex = 69;
            labelControl17.Text = "POS";
            // 
            // labelControl16
            // 
            labelControl16.Appearance.Font = new Font("Tahoma", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            labelControl16.Appearance.Options.UseFont = true;
            labelControl16.Location = new Point(415, 303);
            labelControl16.Name = "labelControl16";
            labelControl16.Size = new Size(89, 28);
            labelControl16.TabIndex = 68;
            labelControl16.Text = "Μετρητά";
            // 
            // PaymentsCostsPOS
            // 
            PaymentsCostsPOS.Location = new Point(244, 452);
            PaymentsCostsPOS.MenuManager = ribbon;
            PaymentsCostsPOS.Name = "PaymentsCostsPOS";
            PaymentsCostsPOS.Properties.Appearance.Font = new Font("Tahoma", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            PaymentsCostsPOS.Properties.Appearance.Options.UseFont = true;
            PaymentsCostsPOS.Size = new Size(124, 28);
            PaymentsCostsPOS.TabIndex = 63;
            // 
            // labelControl15
            // 
            labelControl15.Appearance.Font = new Font("Tahoma", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            labelControl15.Appearance.Options.UseFont = true;
            labelControl15.Location = new Point(38, 450);
            labelControl15.Name = "labelControl15";
            labelControl15.Size = new Size(189, 28);
            labelControl15.TabIndex = 67;
            labelControl15.Text = "Έξοδα Πληρωμών:";
            // 
            // labelControl14
            // 
            labelControl14.Appearance.Font = new Font("Tahoma", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            labelControl14.Appearance.Options.UseFont = true;
            labelControl14.Location = new Point(38, 401);
            labelControl14.Name = "labelControl14";
            labelControl14.Size = new Size(189, 28);
            labelControl14.TabIndex = 66;
            labelControl14.Text = "Έξοδα Πληρωμών:";
            // 
            // labelControl13
            // 
            labelControl13.Appearance.Font = new Font("Tahoma", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            labelControl13.Appearance.Options.UseFont = true;
            labelControl13.Location = new Point(38, 352);
            labelControl13.Name = "labelControl13";
            labelControl13.Size = new Size(163, 28);
            labelControl13.TabIndex = 65;
            labelControl13.Text = "Έξοδα Αγορών :";
            // 
            // labelControl12
            // 
            labelControl12.Appearance.Font = new Font("Tahoma", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            labelControl12.Appearance.Options.UseFont = true;
            labelControl12.Location = new Point(38, 303);
            labelControl12.Name = "labelControl12";
            labelControl12.Size = new Size(163, 28);
            labelControl12.TabIndex = 64;
            labelControl12.Text = "Έξοδα Αγορών :";
            // 
            // PaymentsCostsCash
            // 
            PaymentsCostsCash.Location = new Point(244, 401);
            PaymentsCostsCash.MenuManager = ribbon;
            PaymentsCostsCash.Name = "PaymentsCostsCash";
            PaymentsCostsCash.Properties.Appearance.Font = new Font("Tahoma", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            PaymentsCostsCash.Properties.Appearance.Options.UseFont = true;
            PaymentsCostsCash.Size = new Size(124, 28);
            PaymentsCostsCash.TabIndex = 62;
            // 
            // ShopingCostsPOS
            // 
            ShopingCostsPOS.Location = new Point(244, 354);
            ShopingCostsPOS.MenuManager = ribbon;
            ShopingCostsPOS.Name = "ShopingCostsPOS";
            ShopingCostsPOS.Properties.Appearance.Font = new Font("Tahoma", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            ShopingCostsPOS.Properties.Appearance.Options.UseFont = true;
            ShopingCostsPOS.Size = new Size(124, 28);
            ShopingCostsPOS.TabIndex = 61;
            // 
            // ShoppingCostsCash
            // 
            ShoppingCostsCash.Location = new Point(244, 305);
            ShoppingCostsCash.MenuManager = ribbon;
            ShoppingCostsCash.Name = "ShoppingCostsCash";
            ShoppingCostsCash.Properties.Appearance.Font = new Font("Tahoma", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            ShoppingCostsCash.Properties.Appearance.Options.UseFont = true;
            ShoppingCostsCash.Size = new Size(124, 28);
            ShoppingCostsCash.TabIndex = 60;
            // 
            // CalculateDailySumbtn
            // 
            CalculateDailySumbtn.ImageOptions.SvgImage = (DevExpress.Utils.Svg.SvgImage)resources.GetObject("CalculateDailySumbtn.ImageOptions.SvgImage");
            CalculateDailySumbtn.Location = new Point(661, 244);
            CalculateDailySumbtn.Margin = new Padding(4, 2, 4, 2);
            CalculateDailySumbtn.Name = "CalculateDailySumbtn";
            CalculateDailySumbtn.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light;
            CalculateDailySumbtn.Size = new Size(134, 50);
            CalculateDailySumbtn.TabIndex = 16;
            CalculateDailySumbtn.Text = "Υπολογισμός";
            CalculateDailySumbtn.Click += simpleButton1_Click;
            // 
            // cashNetEdit
            // 
            cashNetEdit.Enabled = false;
            cashNetEdit.Location = new Point(244, 595);
            cashNetEdit.Margin = new Padding(4, 2, 4, 2);
            cashNetEdit.MenuManager = ribbon;
            cashNetEdit.Name = "cashNetEdit";
            cashNetEdit.Properties.Appearance.Font = new Font("Tahoma", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            cashNetEdit.Properties.Appearance.Options.UseFont = true;
            cashNetEdit.Properties.DisplayFormat.FormatString = "c";
            cashNetEdit.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            cashNetEdit.Properties.MaskSettings.Set("MaskManagerType", typeof(DevExpress.Data.Mask.NumericMaskManager));
            cashNetEdit.Properties.MaskSettings.Set("mask", "c");
            cashNetEdit.Size = new Size(152, 28);
            cashNetEdit.TabIndex = 15;
            // 
            // totalNetEdit
            // 
            totalNetEdit.Enabled = false;
            totalNetEdit.Location = new Point(244, 538);
            totalNetEdit.Margin = new Padding(4, 2, 4, 2);
            totalNetEdit.MenuManager = ribbon;
            totalNetEdit.Name = "totalNetEdit";
            totalNetEdit.Properties.Appearance.Font = new Font("Tahoma", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            totalNetEdit.Properties.Appearance.Options.UseFont = true;
            totalNetEdit.Properties.DisplayFormat.FormatString = "c";
            totalNetEdit.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            totalNetEdit.Properties.MaskSettings.Set("MaskManagerType", typeof(DevExpress.Data.Mask.NumericMaskManager));
            totalNetEdit.Properties.MaskSettings.Set("mask", "c");
            totalNetEdit.Size = new Size(152, 28);
            totalNetEdit.TabIndex = 14;
            // 
            // labelControl8
            // 
            labelControl8.Appearance.Font = new Font("Tahoma", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            labelControl8.Appearance.Options.UseFont = true;
            labelControl8.Location = new Point(38, 594);
            labelControl8.Margin = new Padding(4, 2, 4, 2);
            labelControl8.Name = "labelControl8";
            labelControl8.Size = new Size(190, 28);
            labelControl8.TabIndex = 13;
            labelControl8.Text = "Καθαρά Μετρητά :";
            // 
            // labelControl9
            // 
            labelControl9.Appearance.Font = new Font("Tahoma", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            labelControl9.Appearance.Options.UseFont = true;
            labelControl9.Location = new Point(37, 535);
            labelControl9.Margin = new Padding(4, 2, 4, 2);
            labelControl9.Name = "labelControl9";
            labelControl9.Size = new Size(172, 28);
            labelControl9.TabIndex = 12;
            labelControl9.Text = "Καθαρό Σύνολο :";
            // 
            // labelControl7
            // 
            labelControl7.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            labelControl7.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            labelControl7.Location = new Point(35, 518);
            labelControl7.Margin = new Padding(4, 2, 4, 2);
            labelControl7.Name = "labelControl7";
            labelControl7.Size = new Size(760, 1);
            labelControl7.TabIndex = 10;
            // 
            // dailyCostsEdit
            // 
            dailyCostsEdit.Location = new Point(244, 246);
            dailyCostsEdit.Margin = new Padding(4, 2, 4, 2);
            dailyCostsEdit.MenuManager = ribbon;
            dailyCostsEdit.Name = "dailyCostsEdit";
            dailyCostsEdit.Properties.Appearance.Font = new Font("Tahoma", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            dailyCostsEdit.Properties.Appearance.Options.UseFont = true;
            dailyCostsEdit.Properties.DisplayFormat.FormatString = "c";
            dailyCostsEdit.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            dailyCostsEdit.Properties.MaskSettings.Set("MaskManagerType", typeof(DevExpress.Data.Mask.NumericMaskManager));
            dailyCostsEdit.Properties.MaskSettings.Set("mask", "c");
            dailyCostsEdit.Size = new Size(124, 28);
            dailyCostsEdit.TabIndex = 9;
            // 
            // labelControl6
            // 
            labelControl6.Appearance.Font = new Font("Tahoma", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            labelControl6.Appearance.Options.UseFont = true;
            labelControl6.Location = new Point(37, 244);
            labelControl6.Margin = new Padding(4, 2, 4, 2);
            labelControl6.Name = "labelControl6";
            labelControl6.Size = new Size(160, 28);
            labelControl6.TabIndex = 8;
            labelControl6.Text = "Έξοδα Ημέρας :";
            // 
            // totalPosEdit
            // 
            totalPosEdit.Enabled = false;
            totalPosEdit.Location = new Point(244, 158);
            totalPosEdit.Margin = new Padding(4, 2, 4, 2);
            totalPosEdit.MenuManager = ribbon;
            totalPosEdit.Name = "totalPosEdit";
            totalPosEdit.Properties.Appearance.Font = new Font("Tahoma", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            totalPosEdit.Properties.Appearance.Options.UseFont = true;
            totalPosEdit.Properties.DisplayFormat.FormatString = "c";
            totalPosEdit.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            totalPosEdit.Properties.MaskSettings.Set("MaskManagerType", typeof(DevExpress.Data.Mask.NumericMaskManager));
            totalPosEdit.Properties.MaskSettings.Set("mask", "c");
            totalPosEdit.Size = new Size(124, 28);
            totalPosEdit.TabIndex = 6;
            // 
            // totalCashEdit
            // 
            totalCashEdit.Enabled = false;
            totalCashEdit.Location = new Point(244, 89);
            totalCashEdit.Margin = new Padding(4, 2, 4, 2);
            totalCashEdit.MenuManager = ribbon;
            totalCashEdit.Name = "totalCashEdit";
            totalCashEdit.Properties.Appearance.Font = new Font("Tahoma", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            totalCashEdit.Properties.Appearance.Options.UseFont = true;
            totalCashEdit.Properties.DisplayFormat.FormatString = "c";
            totalCashEdit.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            totalCashEdit.Properties.MaskSettings.Set("MaskManagerType", typeof(DevExpress.Data.Mask.NumericMaskManager));
            totalCashEdit.Properties.MaskSettings.Set("mask", "c");
            totalCashEdit.Size = new Size(124, 28);
            totalCashEdit.TabIndex = 5;
            // 
            // totalGrossEdit
            // 
            totalGrossEdit.Enabled = false;
            totalGrossEdit.Location = new Point(244, 21);
            totalGrossEdit.Margin = new Padding(4, 2, 4, 2);
            totalGrossEdit.MenuManager = ribbon;
            totalGrossEdit.Name = "totalGrossEdit";
            totalGrossEdit.Properties.Appearance.Font = new Font("Tahoma", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            totalGrossEdit.Properties.Appearance.Options.UseFont = true;
            totalGrossEdit.Properties.DisplayFormat.FormatString = "c";
            totalGrossEdit.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            totalGrossEdit.Properties.MaskSettings.Set("MaskManagerType", typeof(DevExpress.Data.Mask.NumericMaskManager));
            totalGrossEdit.Properties.MaskSettings.Set("mask", "c");
            totalGrossEdit.Size = new Size(124, 28);
            totalGrossEdit.TabIndex = 4;
            // 
            // labelControl5
            // 
            labelControl5.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            labelControl5.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            labelControl5.Location = new Point(37, 202);
            labelControl5.Margin = new Padding(4, 2, 4, 2);
            labelControl5.Name = "labelControl5";
            labelControl5.Size = new Size(760, 1);
            labelControl5.TabIndex = 3;
            // 
            // labelControl4
            // 
            labelControl4.Appearance.Font = new Font("Tahoma", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            labelControl4.Appearance.Options.UseFont = true;
            labelControl4.Location = new Point(37, 155);
            labelControl4.Margin = new Padding(4, 2, 4, 2);
            labelControl4.Name = "labelControl4";
            labelControl4.Size = new Size(136, 28);
            labelControl4.TabIndex = 2;
            labelControl4.Text = "Σύνολο POS :";
            // 
            // labelControl3
            // 
            labelControl3.Appearance.Font = new Font("Tahoma", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            labelControl3.Appearance.Options.UseFont = true;
            labelControl3.Location = new Point(35, 87);
            labelControl3.Margin = new Padding(4, 2, 4, 2);
            labelControl3.Name = "labelControl3";
            labelControl3.Size = new Size(183, 28);
            labelControl3.TabIndex = 1;
            labelControl3.Text = "Σύνολο Μετρητά :";
            // 
            // labelControl2
            // 
            labelControl2.Appearance.Font = new Font("Tahoma", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            labelControl2.Appearance.Options.UseFont = true;
            labelControl2.Location = new Point(35, 18);
            labelControl2.Margin = new Padding(4, 2, 4, 2);
            labelControl2.Name = "labelControl2";
            labelControl2.Size = new Size(155, 28);
            labelControl2.TabIndex = 0;
            labelControl2.Text = "Γενικό Σύνολο :";
            // 
            // DailySummaryForm
            // 
            AutoScaleDimensions = new SizeF(7F, 16F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1304, 951);
            Controls.Add(SummaryPanel);
            Controls.Add(orderSummaryGridControl);
            Controls.Add(panelControl1);
            Controls.Add(ribbonStatusBar);
            Controls.Add(ribbon);
            Margin = new Padding(4, 2, 4, 2);
            Name = "DailySummaryForm";
            Ribbon = ribbon;
            StatusBar = ribbonStatusBar;
            Text = "Calculate Daily Summary";
            Load += DailySummaryForm_Load;
            ((System.ComponentModel.ISupportInitialize)ribbon).EndInit();
            ((System.ComponentModel.ISupportInitialize)panelControl1).EndInit();
            panelControl1.ResumeLayout(false);
            panelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)summaryDateEdit.Properties.CalendarTimeProperties).EndInit();
            ((System.ComponentModel.ISupportInitialize)summaryDateEdit.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)orderSummaryGridControl).EndInit();
            ((System.ComponentModel.ISupportInitialize)orderSummaryBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)orderSummaryGridView).EndInit();
            ((System.ComponentModel.ISupportInitialize)SummaryPanel).EndInit();
            SummaryPanel.ResumeLayout(false);
            SummaryPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)PaymentsCostsPOS.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)PaymentsCostsCash.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)ShopingCostsPOS.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)ShoppingCostsCash.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)cashNetEdit.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)totalNetEdit.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)dailyCostsEdit.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)totalPosEdit.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)totalCashEdit.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)totalGrossEdit.Properties).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbon;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraBars.Ribbon.RibbonStatusBar ribbonStatusBar;
        private DevExpress.XtraBars.BarButtonItem barButtonItem1;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.DateEdit summaryDateEdit;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraGrid.GridControl orderSummaryGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView orderSummaryGridView;
        private DevExpress.XtraEditors.PanelControl SummaryPanel;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.TextEdit totalPosEdit;
        private DevExpress.XtraEditors.TextEdit totalCashEdit;
        private DevExpress.XtraEditors.TextEdit totalGrossEdit;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private DevExpress.XtraEditors.TextEdit dailyCostsEdit;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraBars.BarButtonItem calculateDailySummaryButton;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup2;
        private DevExpress.XtraEditors.TextEdit cashNetEdit;
        private DevExpress.XtraEditors.TextEdit totalNetEdit;
        private DevExpress.XtraEditors.LabelControl labelControl8;
        private DevExpress.XtraEditors.LabelControl labelControl9;
        private BindingSource orderSummaryBindingSource;
        private DevExpress.XtraGrid.Columns.GridColumn colDiscountedPrice;
        private DevExpress.XtraGrid.Columns.GridColumn colTotalCash;
        private DevExpress.XtraGrid.Columns.GridColumn colTotalPOS;
        private DevExpress.XtraGrid.Columns.GridColumn colCustomerFullName;
        private DevExpress.XtraEditors.SimpleButton CalculateDailySumbtn;
        private DevExpress.XtraEditors.LabelControl labelControl10;
        private DevExpress.XtraEditors.LabelControl labelControl19;
        private DevExpress.XtraEditors.LabelControl labelControl18;
        private DevExpress.XtraEditors.LabelControl labelControl17;
        private DevExpress.XtraEditors.LabelControl labelControl16;
        private DevExpress.XtraEditors.TextEdit PaymentsCostsPOS;
        private DevExpress.XtraEditors.LabelControl labelControl15;
        private DevExpress.XtraEditors.LabelControl labelControl14;
        private DevExpress.XtraEditors.LabelControl labelControl13;
        private DevExpress.XtraEditors.LabelControl labelControl12;
        private DevExpress.XtraEditors.TextEdit PaymentsCostsCash;
        private DevExpress.XtraEditors.TextEdit ShopingCostsPOS;
        private DevExpress.XtraEditors.TextEdit ShoppingCostsCash;
    }
}