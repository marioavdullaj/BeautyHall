namespace BSMS.Winforms.Forms
{
    partial class StockProduct
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StockProduct));
            ribbon = new DevExpress.XtraBars.Ribbon.RibbonControl();
            barButtonItem1 = new DevExpress.XtraBars.BarButtonItem();
            barButtonItem2 = new DevExpress.XtraBars.BarButtonItem();
            barButtonItem3 = new DevExpress.XtraBars.BarButtonItem();
            barButtonItem4 = new DevExpress.XtraBars.BarButtonItem();
            barButtonItem5 = new DevExpress.XtraBars.BarButtonItem();
            ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            ribbonPageGroup2 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            ribbonStatusBar = new DevExpress.XtraBars.Ribbon.RibbonStatusBar();
            panelControl1 = new DevExpress.XtraEditors.PanelControl();
            dateEdit2 = new DevExpress.XtraEditors.DateEdit();
            label2 = new Label();
            dateEdit1 = new DevExpress.XtraEditors.DateEdit();
            label1 = new Label();
            panelControl2 = new DevExpress.XtraEditors.PanelControl();
            dateEdit6 = new DevExpress.XtraEditors.DateEdit();
            label6 = new Label();
            dateEdit3 = new DevExpress.XtraEditors.DateEdit();
            label3 = new Label();
            gridControl1 = new DevExpress.XtraGrid.GridControl();
            gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            stockProductsBindingSource = new BindingSource(components);
            colStockId = new DevExpress.XtraGrid.Columns.GridColumn();
            colProductID = new DevExpress.XtraGrid.Columns.GridColumn();
            colProductQuantity = new DevExpress.XtraGrid.Columns.GridColumn();
            colStockRegistrationDate = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)ribbon).BeginInit();
            ((System.ComponentModel.ISupportInitialize)panelControl1).BeginInit();
            panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dateEdit2.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dateEdit2.Properties.CalendarTimeProperties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dateEdit1.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dateEdit1.Properties.CalendarTimeProperties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)panelControl2).BeginInit();
            panelControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dateEdit6.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dateEdit6.Properties.CalendarTimeProperties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dateEdit3.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dateEdit3.Properties.CalendarTimeProperties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)gridControl1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)gridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)stockProductsBindingSource).BeginInit();
            SuspendLayout();
            // 
            // ribbon
            // 
            ribbon.ExpandCollapseItem.Id = 0;
            ribbon.Items.AddRange(new DevExpress.XtraBars.BarItem[] { ribbon.ExpandCollapseItem, ribbon.SearchEditItem, barButtonItem1, barButtonItem2, barButtonItem3, barButtonItem4, barButtonItem5 });
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
            // barButtonItem5
            // 
            barButtonItem5.Caption = "Close";
            barButtonItem5.Id = 5;
            barButtonItem5.ImageOptions.SvgImage = (DevExpress.Utils.Svg.SvgImage)resources.GetObject("barButtonItem5.ImageOptions.SvgImage");
            barButtonItem5.Name = "barButtonItem5";
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
            ribbonPageGroup2.ItemLinks.Add(barButtonItem5);
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
            panelControl1.Controls.Add(dateEdit2);
            panelControl1.Controls.Add(label2);
            panelControl1.Controls.Add(dateEdit1);
            panelControl1.Controls.Add(label1);
            panelControl1.Location = new Point(12, 199);
            panelControl1.Name = "panelControl1";
            panelControl1.Size = new Size(389, 88);
            panelControl1.TabIndex = 2;
            // 
            // dateEdit2
            // 
            dateEdit2.EditValue = null;
            dateEdit2.Enabled = false;
            dateEdit2.Location = new Point(103, 54);
            dateEdit2.Margin = new Padding(4);
            dateEdit2.MenuManager = ribbon;
            dateEdit2.Name = "dateEdit2";
            dateEdit2.Properties.Appearance.Font = new Font("Tahoma", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            dateEdit2.Properties.Appearance.Options.UseFont = true;
            dateEdit2.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] { new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo) });
            dateEdit2.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] { new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo) });
            dateEdit2.Size = new Size(121, 28);
            dateEdit2.TabIndex = 16;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Tahoma", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(9, 57);
            label2.Name = "label2";
            label2.Size = new Size(77, 21);
            label2.TabIndex = 15;
            label2.Text = "StocktId:";
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
            dateEdit1.Size = new Size(121, 28);
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
            panelControl2.Controls.Add(dateEdit6);
            panelControl2.Controls.Add(label6);
            panelControl2.Controls.Add(dateEdit3);
            panelControl2.Controls.Add(label3);
            panelControl2.Location = new Point(407, 199);
            panelControl2.Name = "panelControl2";
            panelControl2.Size = new Size(747, 88);
            panelControl2.TabIndex = 3;
            // 
            // dateEdit6
            // 
            dateEdit6.EditValue = null;
            dateEdit6.Enabled = false;
            dateEdit6.Location = new Point(129, 54);
            dateEdit6.Margin = new Padding(4);
            dateEdit6.MenuManager = ribbon;
            dateEdit6.Name = "dateEdit6";
            dateEdit6.Properties.Appearance.Font = new Font("Tahoma", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            dateEdit6.Properties.Appearance.Options.UseFont = true;
            dateEdit6.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] { new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo) });
            dateEdit6.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] { new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo) });
            dateEdit6.Size = new Size(140, 28);
            dateEdit6.TabIndex = 25;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Tahoma", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(12, 57);
            label6.Name = "label6";
            label6.Size = new Size(103, 21);
            label6.TabIndex = 24;
            label6.Text = "Product Qty:";
            // 
            // dateEdit3
            // 
            dateEdit3.EditValue = null;
            dateEdit3.Location = new Point(129, 6);
            dateEdit3.Margin = new Padding(4);
            dateEdit3.MenuManager = ribbon;
            dateEdit3.Name = "dateEdit3";
            dateEdit3.Properties.Appearance.Font = new Font("Tahoma", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            dateEdit3.Properties.Appearance.Options.UseFont = true;
            dateEdit3.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] { new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo) });
            dateEdit3.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] { new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo) });
            dateEdit3.Size = new Size(140, 28);
            dateEdit3.TabIndex = 19;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Tahoma", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(12, 9);
            label3.Name = "label3";
            label3.Size = new Size(87, 21);
            label3.TabIndex = 18;
            label3.Text = "ProductId:";
            // 
            // gridControl1
            // 
            gridControl1.DataSource = stockProductsBindingSource;
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
            gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] { colStockId, colProductID, colProductQuantity, colStockRegistrationDate });
            gridView1.GridControl = gridControl1;
            gridView1.Name = "gridView1";
            // 
            // stockProductsBindingSource
            // 
            stockProductsBindingSource.DataSource = typeof(Models.StockProducts);
            // 
            // colStockId
            // 
            colStockId.FieldName = "StockId";
            colStockId.MinWidth = 25;
            colStockId.Name = "colStockId";
            colStockId.Visible = true;
            colStockId.VisibleIndex = 0;
            colStockId.Width = 94;
            // 
            // colProductID
            // 
            colProductID.FieldName = "ProductID";
            colProductID.MinWidth = 25;
            colProductID.Name = "colProductID";
            colProductID.Visible = true;
            colProductID.VisibleIndex = 1;
            colProductID.Width = 94;
            // 
            // colProductQuantity
            // 
            colProductQuantity.FieldName = "ProductQuantity";
            colProductQuantity.MinWidth = 25;
            colProductQuantity.Name = "colProductQuantity";
            colProductQuantity.Visible = true;
            colProductQuantity.VisibleIndex = 2;
            colProductQuantity.Width = 94;
            // 
            // colStockRegistrationDate
            // 
            colStockRegistrationDate.FieldName = "StockRegistrationDate";
            colStockRegistrationDate.MinWidth = 25;
            colStockRegistrationDate.Name = "colStockRegistrationDate";
            colStockRegistrationDate.Visible = true;
            colStockRegistrationDate.VisibleIndex = 3;
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
            ((System.ComponentModel.ISupportInitialize)ribbon).EndInit();
            ((System.ComponentModel.ISupportInitialize)panelControl1).EndInit();
            panelControl1.ResumeLayout(false);
            panelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dateEdit2.Properties.CalendarTimeProperties).EndInit();
            ((System.ComponentModel.ISupportInitialize)dateEdit2.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)dateEdit1.Properties.CalendarTimeProperties).EndInit();
            ((System.ComponentModel.ISupportInitialize)dateEdit1.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)panelControl2).EndInit();
            panelControl2.ResumeLayout(false);
            panelControl2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dateEdit6.Properties.CalendarTimeProperties).EndInit();
            ((System.ComponentModel.ISupportInitialize)dateEdit6.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)dateEdit3.Properties.CalendarTimeProperties).EndInit();
            ((System.ComponentModel.ISupportInitialize)dateEdit3.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)gridControl1).EndInit();
            ((System.ComponentModel.ISupportInitialize)gridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)stockProductsBindingSource).EndInit();
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
        private DevExpress.XtraBars.BarButtonItem barButtonItem5;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup2;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.PanelControl panelControl2;
        private DevExpress.XtraEditors.DateEdit dateEdit2;
        private Label label2;
        private DevExpress.XtraEditors.DateEdit dateEdit1;
        private Label label1;
        private DevExpress.XtraEditors.DateEdit dateEdit6;
        private Label label6;
        private DevExpress.XtraEditors.DateEdit dateEdit3;
        private Label label3;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private BindingSource stockProductsBindingSource;
        private DevExpress.XtraGrid.Columns.GridColumn colStockId;
        private DevExpress.XtraGrid.Columns.GridColumn colProductID;
        private DevExpress.XtraGrid.Columns.GridColumn colProductQuantity;
        private DevExpress.XtraGrid.Columns.GridColumn colStockRegistrationDate;
    }
}