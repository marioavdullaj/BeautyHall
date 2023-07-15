namespace BSMS.Winforms.Forms
{
    partial class AllOrdersForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AllOrdersForm));
            ribbon = new DevExpress.XtraBars.Ribbon.RibbonControl();
            barButtonItem1 = new DevExpress.XtraBars.BarButtonItem();
            barButtonItem2 = new DevExpress.XtraBars.BarButtonItem();
            ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            ribbonPageGroup2 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            ribbonStatusBar = new DevExpress.XtraBars.Ribbon.RibbonStatusBar();
            customerBindingSource = new BindingSource(components);
            grOrders = new DevExpress.XtraGrid.GridControl();
            grvOrders = new DevExpress.XtraGrid.Views.Grid.GridView();
            ribbonPageGroup3 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            dateFrom = new DevExpress.XtraBars.BarEditItem();
            dateFromRepo = new DevExpress.XtraEditors.Repository.RepositoryItemDateEdit();
            dateTo = new DevExpress.XtraBars.BarEditItem();
            dateToRepo = new DevExpress.XtraEditors.Repository.RepositoryItemDateEdit();
            ((System.ComponentModel.ISupportInitialize)ribbon).BeginInit();
            ((System.ComponentModel.ISupportInitialize)customerBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)grOrders).BeginInit();
            ((System.ComponentModel.ISupportInitialize)grvOrders).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dateFromRepo).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dateFromRepo.CalendarTimeProperties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dateToRepo).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dateToRepo.CalendarTimeProperties).BeginInit();
            SuspendLayout();
            // 
            // ribbon
            // 
            ribbon.ExpandCollapseItem.Id = 0;
            ribbon.Items.AddRange(new DevExpress.XtraBars.BarItem[] { ribbon.ExpandCollapseItem, ribbon.SearchEditItem, barButtonItem1, barButtonItem2, dateFrom, dateTo });
            ribbon.Location = new Point(0, 0);
            ribbon.MaxItemId = 5;
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
            // ribbonPage1
            // 
            ribbonPage1.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] { ribbonPageGroup1, ribbonPageGroup3, ribbonPageGroup2 });
            ribbonPage1.Name = "ribbonPage1";
            ribbonPage1.Text = "All orders";
            // 
            // ribbonPageGroup1
            // 
            ribbonPageGroup1.ItemLinks.Add(barButtonItem1);
            ribbonPageGroup1.Name = "ribbonPageGroup1";
            // 
            // ribbonPageGroup2
            // 
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
            // customerBindingSource
            // 
            customerBindingSource.DataSource = typeof(Models.Customer);
            // 
            // grOrders
            // 
            grOrders.Dock = DockStyle.Fill;
            grOrders.Location = new Point(0, 193);
            grOrders.MainView = grvOrders;
            grOrders.MenuManager = ribbon;
            grOrders.Name = "grOrders";
            grOrders.Size = new Size(1097, 299);
            grOrders.TabIndex = 2;
            grOrders.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] { grvOrders });
            grOrders.Load += grOrders_Load;
            // 
            // grvOrders
            // 
            grvOrders.GridControl = grOrders;
            grvOrders.Name = "grvOrders";
            grvOrders.OptionsView.ShowGroupPanel = false;
            // 
            // ribbonPageGroup3
            // 
            ribbonPageGroup3.ItemLinks.Add(dateFrom);
            ribbonPageGroup3.ItemLinks.Add(dateTo);
            ribbonPageGroup3.Name = "ribbonPageGroup3";
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
            // AllOrdersForm
            // 
            AutoScaleDimensions = new SizeF(7F, 16F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1097, 522);
            Controls.Add(grOrders);
            Controls.Add(ribbonStatusBar);
            Controls.Add(ribbon);
            Name = "AllOrdersForm";
            Ribbon = ribbon;
            StatusBar = ribbonStatusBar;
            ((System.ComponentModel.ISupportInitialize)ribbon).EndInit();
            ((System.ComponentModel.ISupportInitialize)customerBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)grOrders).EndInit();
            ((System.ComponentModel.ISupportInitialize)grvOrders).EndInit();
            ((System.ComponentModel.ISupportInitialize)dateFromRepo.CalendarTimeProperties).EndInit();
            ((System.ComponentModel.ISupportInitialize)dateFromRepo).EndInit();
            ((System.ComponentModel.ISupportInitialize)dateToRepo.CalendarTimeProperties).EndInit();
            ((System.ComponentModel.ISupportInitialize)dateToRepo).EndInit();
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
        private BindingSource customerBindingSource;
        private DevExpress.XtraGrid.GridControl grOrders;
        private DevExpress.XtraGrid.Views.Grid.GridView grvOrders;
        private DevExpress.XtraBars.BarEditItem dateFrom;
        private DevExpress.XtraEditors.Repository.RepositoryItemDateEdit dateFromRepo;
        private DevExpress.XtraBars.BarEditItem dateTo;
        private DevExpress.XtraEditors.Repository.RepositoryItemDateEdit dateToRepo;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup3;
    }
}