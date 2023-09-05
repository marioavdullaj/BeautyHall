namespace BSMS.Winforms.Forms
{
    partial class TotalSummary
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TotalSummary));
            ribbon = new DevExpress.XtraBars.Ribbon.RibbonControl();
            CalculateTotalSummarybtn = new DevExpress.XtraBars.BarButtonItem();
            barButtonItem2 = new DevExpress.XtraBars.BarButtonItem();
            ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            ribbonPageGroup2 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            repositoryItemButtonEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            repositoryItemButtonEdit2 = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            repositoryItemDateEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemDateEdit();
            repositoryItemDateEdit2 = new DevExpress.XtraEditors.Repository.RepositoryItemDateEdit();
            ribbonStatusBar = new DevExpress.XtraBars.Ribbon.RibbonStatusBar();
            panelControl1 = new DevExpress.XtraEditors.PanelControl();
            SummaryPanel = new DevExpress.XtraEditors.PanelControl();
            labelControl10 = new DevExpress.XtraEditors.LabelControl();
            labelControl1 = new DevExpress.XtraEditors.LabelControl();
            DateTo = new DevExpress.XtraEditors.DateEdit();
            DateFrom = new DevExpress.XtraEditors.DateEdit();
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
            orderSummaryBindingSource = new BindingSource(components);
            barEditItem1 = new DevExpress.XtraBars.BarEditItem();
            barEditItem2 = new DevExpress.XtraBars.BarEditItem();
            ((System.ComponentModel.ISupportInitialize)ribbon).BeginInit();
            ((System.ComponentModel.ISupportInitialize)repositoryItemButtonEdit1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)repositoryItemButtonEdit2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)repositoryItemDateEdit1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)repositoryItemDateEdit1.CalendarTimeProperties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)repositoryItemDateEdit2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)repositoryItemDateEdit2.CalendarTimeProperties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)panelControl1).BeginInit();
            panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)SummaryPanel).BeginInit();
            SummaryPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DateTo.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)DateTo.Properties.CalendarTimeProperties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)DateFrom.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)DateFrom.Properties.CalendarTimeProperties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)cashNetEdit.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)totalNetEdit.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dailyCostsEdit.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)totalPosEdit.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)totalCashEdit.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)totalGrossEdit.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)orderSummaryBindingSource).BeginInit();
            SuspendLayout();
            // 
            // ribbon
            // 
            ribbon.ExpandCollapseItem.Id = 0;
            ribbon.Items.AddRange(new DevExpress.XtraBars.BarItem[] { ribbon.ExpandCollapseItem, ribbon.SearchEditItem, CalculateTotalSummarybtn, barButtonItem2 });
            ribbon.Location = new Point(0, 0);
            ribbon.MaxItemId = 5;
            ribbon.Name = "ribbon";
            ribbon.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] { ribbonPage1 });
            ribbon.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] { repositoryItemButtonEdit1, repositoryItemButtonEdit2, repositoryItemDateEdit1, repositoryItemDateEdit2 });
            ribbon.Size = new Size(1279, 193);
            ribbon.StatusBar = ribbonStatusBar;
            // 
            // CalculateTotalSummarybtn
            // 
            CalculateTotalSummarybtn.Caption = "Calculate";
            CalculateTotalSummarybtn.Id = 1;
            CalculateTotalSummarybtn.ImageOptions.SvgImage = (DevExpress.Utils.Svg.SvgImage)resources.GetObject("CalculateTotalSummarybtn.ImageOptions.SvgImage");
            CalculateTotalSummarybtn.Name = "CalculateTotalSummarybtn";
            CalculateTotalSummarybtn.ItemClick += CalculateTotalSummarybtn_ItemClick;
            // 
            // barButtonItem2
            // 
            barButtonItem2.Caption = "Close";
            barButtonItem2.Id = 2;
            barButtonItem2.ImageOptions.SvgImage = (DevExpress.Utils.Svg.SvgImage)resources.GetObject("barButtonItem2.ImageOptions.SvgImage");
            barButtonItem2.Name = "barButtonItem2";
            barButtonItem2.ItemClick += barButtonItem2_ItemClick;
            // 
            // ribbonPage1
            // 
            ribbonPage1.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] { ribbonPageGroup1, ribbonPageGroup2 });
            ribbonPage1.Name = "ribbonPage1";
            ribbonPage1.Text = "Calculate Total Summary";
            // 
            // ribbonPageGroup1
            // 
            ribbonPageGroup1.ItemLinks.Add(CalculateTotalSummarybtn);
            ribbonPageGroup1.Name = "ribbonPageGroup1";
            // 
            // ribbonPageGroup2
            // 
            ribbonPageGroup2.ItemLinks.Add(barButtonItem2);
            ribbonPageGroup2.Name = "ribbonPageGroup2";
            // 
            // repositoryItemButtonEdit1
            // 
            repositoryItemButtonEdit1.AutoHeight = false;
            repositoryItemButtonEdit1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] { new DevExpress.XtraEditors.Controls.EditorButton() });
            repositoryItemButtonEdit1.Name = "repositoryItemButtonEdit1";
            // 
            // repositoryItemButtonEdit2
            // 
            repositoryItemButtonEdit2.AutoHeight = false;
            repositoryItemButtonEdit2.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] { new DevExpress.XtraEditors.Controls.EditorButton() });
            repositoryItemButtonEdit2.Name = "repositoryItemButtonEdit2";
            // 
            // repositoryItemDateEdit1
            // 
            repositoryItemDateEdit1.AutoHeight = false;
            repositoryItemDateEdit1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] { new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo) });
            repositoryItemDateEdit1.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] { new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo) });
            repositoryItemDateEdit1.Name = "repositoryItemDateEdit1";
            // 
            // repositoryItemDateEdit2
            // 
            repositoryItemDateEdit2.AutoHeight = false;
            repositoryItemDateEdit2.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] { new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo) });
            repositoryItemDateEdit2.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] { new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo) });
            repositoryItemDateEdit2.Name = "repositoryItemDateEdit2";
            // 
            // ribbonStatusBar
            // 
            ribbonStatusBar.Location = new Point(0, 739);
            ribbonStatusBar.Name = "ribbonStatusBar";
            ribbonStatusBar.Ribbon = ribbon;
            ribbonStatusBar.Size = new Size(1279, 30);
            // 
            // panelControl1
            // 
            panelControl1.Controls.Add(SummaryPanel);
            panelControl1.Dock = DockStyle.Top;
            panelControl1.Location = new Point(0, 193);
            panelControl1.Name = "panelControl1";
            panelControl1.Size = new Size(1279, 540);
            panelControl1.TabIndex = 2;
            // 
            // SummaryPanel
            // 
            SummaryPanel.Controls.Add(labelControl10);
            SummaryPanel.Controls.Add(labelControl1);
            SummaryPanel.Controls.Add(DateTo);
            SummaryPanel.Controls.Add(DateFrom);
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
            SummaryPanel.Location = new Point(2, 2);
            SummaryPanel.Name = "SummaryPanel";
            SummaryPanel.Size = new Size(1275, 536);
            SummaryPanel.TabIndex = 1;
            // 
            // labelControl10
            // 
            labelControl10.Appearance.Font = new Font("Tahoma", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            labelControl10.Appearance.Options.UseFont = true;
            labelControl10.Location = new Point(332, 14);
            labelControl10.Name = "labelControl10";
            labelControl10.Size = new Size(95, 28);
            labelControl10.TabIndex = 35;
            labelControl10.Text = "Date To :";
            // 
            // labelControl1
            // 
            labelControl1.Appearance.Font = new Font("Tahoma", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            labelControl1.Appearance.Options.UseFont = true;
            labelControl1.Location = new Point(16, 14);
            labelControl1.Name = "labelControl1";
            labelControl1.Size = new Size(121, 28);
            labelControl1.TabIndex = 34;
            labelControl1.Text = "Date From :";
            // 
            // DateTo
            // 
            DateTo.EditValue = null;
            DateTo.Location = new Point(433, 16);
            DateTo.MenuManager = ribbon;
            DateTo.Name = "DateTo";
            DateTo.Properties.Appearance.Font = new Font("Tahoma", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            DateTo.Properties.Appearance.Options.UseFont = true;
            DateTo.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] { new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo) });
            DateTo.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] { new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo) });
            DateTo.Size = new Size(156, 28);
            DateTo.TabIndex = 33;
            // 
            // DateFrom
            // 
            DateFrom.EditValue = null;
            DateFrom.Location = new Point(143, 16);
            DateFrom.MenuManager = ribbon;
            DateFrom.Name = "DateFrom";
            DateFrom.Properties.Appearance.Font = new Font("Tahoma", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            DateFrom.Properties.Appearance.Options.UseFont = true;
            DateFrom.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] { new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo) });
            DateFrom.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] { new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo) });
            DateFrom.Size = new Size(156, 28);
            DateFrom.TabIndex = 32;
            // 
            // CalculateDailySumbtn
            // 
            CalculateDailySumbtn.ImageOptions.SvgImage = (DevExpress.Utils.Svg.SvgImage)resources.GetObject("CalculateDailySumbtn.ImageOptions.SvgImage");
            CalculateDailySumbtn.Location = new Point(503, 285);
            CalculateDailySumbtn.Name = "CalculateDailySumbtn";
            CalculateDailySumbtn.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light;
            CalculateDailySumbtn.Size = new Size(134, 51);
            CalculateDailySumbtn.TabIndex = 31;
            CalculateDailySumbtn.Text = "Υπολογισμός";
            CalculateDailySumbtn.Click += CalculateDailySumbtn_Click;
            // 
            // cashNetEdit
            // 
            cashNetEdit.Enabled = false;
            cashNetEdit.Location = new Point(244, 441);
            cashNetEdit.MenuManager = ribbon;
            cashNetEdit.Name = "cashNetEdit";
            cashNetEdit.Properties.Appearance.Font = new Font("Tahoma", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            cashNetEdit.Properties.Appearance.Options.UseFont = true;
            cashNetEdit.Properties.DisplayFormat.FormatString = "c";
            cashNetEdit.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            cashNetEdit.Properties.MaskSettings.Set("MaskManagerType", typeof(DevExpress.Data.Mask.NumericMaskManager));
            cashNetEdit.Properties.MaskSettings.Set("mask", "c");
            cashNetEdit.Size = new Size(183, 28);
            cashNetEdit.TabIndex = 30;
            // 
            // totalNetEdit
            // 
            totalNetEdit.Enabled = false;
            totalNetEdit.Location = new Point(244, 382);
            totalNetEdit.MenuManager = ribbon;
            totalNetEdit.Name = "totalNetEdit";
            totalNetEdit.Properties.Appearance.Font = new Font("Tahoma", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            totalNetEdit.Properties.Appearance.Options.UseFont = true;
            totalNetEdit.Properties.DisplayFormat.FormatString = "c";
            totalNetEdit.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            totalNetEdit.Properties.MaskSettings.Set("MaskManagerType", typeof(DevExpress.Data.Mask.NumericMaskManager));
            totalNetEdit.Properties.MaskSettings.Set("mask", "c");
            totalNetEdit.Size = new Size(183, 28);
            totalNetEdit.TabIndex = 29;
            // 
            // labelControl8
            // 
            labelControl8.Appearance.Font = new Font("Tahoma", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            labelControl8.Appearance.Options.UseFont = true;
            labelControl8.Location = new Point(45, 439);
            labelControl8.Name = "labelControl8";
            labelControl8.Size = new Size(190, 28);
            labelControl8.TabIndex = 28;
            labelControl8.Text = "Καθαρά Μετρητά :";
            // 
            // labelControl9
            // 
            labelControl9.Appearance.Font = new Font("Tahoma", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            labelControl9.Appearance.Options.UseFont = true;
            labelControl9.Location = new Point(44, 380);
            labelControl9.Name = "labelControl9";
            labelControl9.Size = new Size(172, 28);
            labelControl9.TabIndex = 27;
            labelControl9.Text = "Καθαρό Σύνολο :";
            // 
            // labelControl7
            // 
            labelControl7.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            labelControl7.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            labelControl7.Location = new Point(42, 350);
            labelControl7.Name = "labelControl7";
            labelControl7.Size = new Size(760, 1);
            labelControl7.TabIndex = 26;
            // 
            // dailyCostsEdit
            // 
            dailyCostsEdit.Enabled = false;
            dailyCostsEdit.Location = new Point(244, 295);
            dailyCostsEdit.MenuManager = ribbon;
            dailyCostsEdit.Name = "dailyCostsEdit";
            dailyCostsEdit.Properties.Appearance.Font = new Font("Tahoma", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            dailyCostsEdit.Properties.Appearance.Options.UseFont = true;
            dailyCostsEdit.Properties.DisplayFormat.FormatString = "c";
            dailyCostsEdit.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            dailyCostsEdit.Properties.MaskSettings.Set("MaskManagerType", typeof(DevExpress.Data.Mask.NumericMaskManager));
            dailyCostsEdit.Properties.MaskSettings.Set("mask", "c");
            dailyCostsEdit.Size = new Size(183, 28);
            dailyCostsEdit.TabIndex = 25;
            // 
            // labelControl6
            // 
            labelControl6.Appearance.Font = new Font("Tahoma", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            labelControl6.Appearance.Options.UseFont = true;
            labelControl6.Location = new Point(44, 293);
            labelControl6.Name = "labelControl6";
            labelControl6.Size = new Size(78, 28);
            labelControl6.TabIndex = 24;
            labelControl6.Text = "Έξοδα :";
            // 
            // totalPosEdit
            // 
            totalPosEdit.Enabled = false;
            totalPosEdit.Location = new Point(244, 206);
            totalPosEdit.MenuManager = ribbon;
            totalPosEdit.Name = "totalPosEdit";
            totalPosEdit.Properties.Appearance.Font = new Font("Tahoma", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            totalPosEdit.Properties.Appearance.Options.UseFont = true;
            totalPosEdit.Properties.DisplayFormat.FormatString = "c";
            totalPosEdit.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            totalPosEdit.Properties.MaskSettings.Set("MaskManagerType", typeof(DevExpress.Data.Mask.NumericMaskManager));
            totalPosEdit.Properties.MaskSettings.Set("mask", "c");
            totalPosEdit.Size = new Size(183, 28);
            totalPosEdit.TabIndex = 23;
            // 
            // totalCashEdit
            // 
            totalCashEdit.Enabled = false;
            totalCashEdit.Location = new Point(244, 138);
            totalCashEdit.MenuManager = ribbon;
            totalCashEdit.Name = "totalCashEdit";
            totalCashEdit.Properties.Appearance.Font = new Font("Tahoma", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            totalCashEdit.Properties.Appearance.Options.UseFont = true;
            totalCashEdit.Properties.DisplayFormat.FormatString = "c";
            totalCashEdit.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            totalCashEdit.Properties.MaskSettings.Set("MaskManagerType", typeof(DevExpress.Data.Mask.NumericMaskManager));
            totalCashEdit.Properties.MaskSettings.Set("mask", "c");
            totalCashEdit.Size = new Size(183, 28);
            totalCashEdit.TabIndex = 22;
            // 
            // totalGrossEdit
            // 
            totalGrossEdit.Enabled = false;
            totalGrossEdit.Location = new Point(244, 70);
            totalGrossEdit.MenuManager = ribbon;
            totalGrossEdit.Name = "totalGrossEdit";
            totalGrossEdit.Properties.Appearance.Font = new Font("Tahoma", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            totalGrossEdit.Properties.Appearance.Options.UseFont = true;
            totalGrossEdit.Properties.DisplayFormat.FormatString = "c";
            totalGrossEdit.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            totalGrossEdit.Properties.MaskSettings.Set("MaskManagerType", typeof(DevExpress.Data.Mask.NumericMaskManager));
            totalGrossEdit.Properties.MaskSettings.Set("mask", "c");
            totalGrossEdit.Size = new Size(183, 28);
            totalGrossEdit.TabIndex = 21;
            // 
            // labelControl5
            // 
            labelControl5.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            labelControl5.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            labelControl5.Location = new Point(44, 251);
            labelControl5.Name = "labelControl5";
            labelControl5.Size = new Size(760, 1);
            labelControl5.TabIndex = 20;
            // 
            // labelControl4
            // 
            labelControl4.Appearance.Font = new Font("Tahoma", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            labelControl4.Appearance.Options.UseFont = true;
            labelControl4.Location = new Point(44, 204);
            labelControl4.Name = "labelControl4";
            labelControl4.Size = new Size(136, 28);
            labelControl4.TabIndex = 19;
            labelControl4.Text = "Σύνολο POS :";
            // 
            // labelControl3
            // 
            labelControl3.Appearance.Font = new Font("Tahoma", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            labelControl3.Appearance.Options.UseFont = true;
            labelControl3.Location = new Point(42, 136);
            labelControl3.Name = "labelControl3";
            labelControl3.Size = new Size(183, 28);
            labelControl3.TabIndex = 18;
            labelControl3.Text = "Σύνολο Μετρητά :";
            // 
            // labelControl2
            // 
            labelControl2.Appearance.Font = new Font("Tahoma", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            labelControl2.Appearance.Options.UseFont = true;
            labelControl2.Location = new Point(42, 68);
            labelControl2.Name = "labelControl2";
            labelControl2.Size = new Size(155, 28);
            labelControl2.TabIndex = 17;
            labelControl2.Text = "Γενικό Σύνολο :";
            // 
            // orderSummaryBindingSource
            // 
            orderSummaryBindingSource.DataSource = typeof(Models.OrderSummary);
            // 
            // barEditItem1
            // 
            barEditItem1.Caption = "Date From:   ";
            barEditItem1.Edit = null;
            barEditItem1.EditWidth = 100;
            barEditItem1.Id = 3;
            barEditItem1.Name = "barEditItem1";
            // 
            // barEditItem2
            // 
            barEditItem2.Caption = "Date From:   ";
            barEditItem2.Edit = null;
            barEditItem2.EditWidth = 100;
            barEditItem2.Id = 3;
            barEditItem2.Name = "barEditItem2";
            // 
            // TotalSummary
            // 
            AutoScaleDimensions = new SizeF(7F, 16F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1279, 769);
            Controls.Add(panelControl1);
            Controls.Add(ribbonStatusBar);
            Controls.Add(ribbon);
            Name = "TotalSummary";
            Ribbon = ribbon;
            StatusBar = ribbonStatusBar;
            Text = "TotalSummary";
            Load += TotalSummary_Load;
            ((System.ComponentModel.ISupportInitialize)ribbon).EndInit();
            ((System.ComponentModel.ISupportInitialize)repositoryItemButtonEdit1).EndInit();
            ((System.ComponentModel.ISupportInitialize)repositoryItemButtonEdit2).EndInit();
            ((System.ComponentModel.ISupportInitialize)repositoryItemDateEdit1.CalendarTimeProperties).EndInit();
            ((System.ComponentModel.ISupportInitialize)repositoryItemDateEdit1).EndInit();
            ((System.ComponentModel.ISupportInitialize)repositoryItemDateEdit2.CalendarTimeProperties).EndInit();
            ((System.ComponentModel.ISupportInitialize)repositoryItemDateEdit2).EndInit();
            ((System.ComponentModel.ISupportInitialize)panelControl1).EndInit();
            panelControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)SummaryPanel).EndInit();
            SummaryPanel.ResumeLayout(false);
            SummaryPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)DateTo.Properties.CalendarTimeProperties).EndInit();
            ((System.ComponentModel.ISupportInitialize)DateTo.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)DateFrom.Properties.CalendarTimeProperties).EndInit();
            ((System.ComponentModel.ISupportInitialize)DateFrom.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)cashNetEdit.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)totalNetEdit.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)dailyCostsEdit.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)totalPosEdit.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)totalCashEdit.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)totalGrossEdit.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)orderSummaryBindingSource).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbon;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraBars.Ribbon.RibbonStatusBar ribbonStatusBar;
        private DevExpress.XtraBars.BarButtonItem CalculateTotalSummarybtn;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.PanelControl SummaryPanel;
        private DevExpress.XtraBars.BarButtonItem barButtonItem2;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup2;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit repositoryItemButtonEdit1;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit repositoryItemButtonEdit2;
        private BindingSource orderSummaryBindingSource;
        private DevExpress.XtraEditors.SimpleButton CalculateDailySumbtn;
        private DevExpress.XtraEditors.TextEdit cashNetEdit;
        private DevExpress.XtraEditors.TextEdit totalNetEdit;
        private DevExpress.XtraEditors.LabelControl labelControl8;
        private DevExpress.XtraEditors.LabelControl labelControl9;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private DevExpress.XtraEditors.TextEdit dailyCostsEdit;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.TextEdit totalPosEdit;
        private DevExpress.XtraEditors.TextEdit totalCashEdit;
        private DevExpress.XtraEditors.TextEdit totalGrossEdit;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.Repository.RepositoryItemDateEdit repositoryItemDateEdit1;
        private DevExpress.XtraEditors.Repository.RepositoryItemDateEdit repositoryItemDateEdit2;
        private DevExpress.XtraBars.BarEditItem barEditItem1;
        private DevExpress.XtraBars.BarEditItem barEditItem2;
        private DevExpress.XtraEditors.LabelControl labelControl10;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.DateEdit DateTo;
        private DevExpress.XtraEditors.DateEdit DateFrom;
    }
}