namespace BSMS.Winforms.Forms
{
    partial class CustomerForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CustomerForm));
            ribbon = new DevExpress.XtraBars.Ribbon.RibbonControl();
            barButtonItem1 = new DevExpress.XtraBars.BarButtonItem();
            SaveClientButton = new DevExpress.XtraBars.BarButtonItem();
            CancelClientButton = new DevExpress.XtraBars.BarButtonItem();
            EditClientButton = new DevExpress.XtraBars.BarButtonItem();
            barButtonItem2 = new DevExpress.XtraBars.BarButtonItem();
            barButtonItem3 = new DevExpress.XtraBars.BarButtonItem();
            barEditItem1 = new DevExpress.XtraBars.BarEditItem();
            Εγγραφη = new DevExpress.XtraBars.Ribbon.RibbonPage();
            ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            ribbonPageGroup2 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            ribbonStatusBar = new DevExpress.XtraBars.Ribbon.RibbonStatusBar();
            ClientHeaderPanel = new DevExpress.XtraEditors.PanelControl();
            labelControl5 = new DevExpress.XtraEditors.LabelControl();
            panelControl2 = new DevExpress.XtraEditors.PanelControl();
            textEdit5 = new DevExpress.XtraEditors.TextEdit();
            labelControl3 = new DevExpress.XtraEditors.LabelControl();
            labelControl4 = new DevExpress.XtraEditors.LabelControl();
            textEdit4 = new DevExpress.XtraEditors.TextEdit();
            textEdit3 = new DevExpress.XtraEditors.TextEdit();
            labelControl2 = new DevExpress.XtraEditors.LabelControl();
            textEdit1 = new DevExpress.XtraEditors.TextEdit();
            labelControl1 = new DevExpress.XtraEditors.LabelControl();
            panelControl3 = new DevExpress.XtraEditors.PanelControl();
            textEdit2 = new DevExpress.XtraEditors.TextEdit();
            dateEdit1 = new DevExpress.XtraEditors.DateEdit();
            labelControl6 = new DevExpress.XtraEditors.LabelControl();
            lookUpEdit1 = new DevExpress.XtraEditors.LookUpEdit();
            customerBindingSource = new BindingSource(components);
            gridControl1 = new DevExpress.XtraGrid.GridControl();
            gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            colId = new DevExpress.XtraGrid.Columns.GridColumn();
            colSurname = new DevExpress.XtraGrid.Columns.GridColumn();
            colName = new DevExpress.XtraGrid.Columns.GridColumn();
            colTel = new DevExpress.XtraGrid.Columns.GridColumn();
            colEmail = new DevExpress.XtraGrid.Columns.GridColumn();
            productsBindingSource = new BindingSource(components);
            ((System.ComponentModel.ISupportInitialize)ribbon).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ClientHeaderPanel).BeginInit();
            ClientHeaderPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)panelControl2).BeginInit();
            panelControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)textEdit5.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)textEdit4.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)textEdit3.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)textEdit1.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)panelControl3).BeginInit();
            panelControl3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)textEdit2.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dateEdit1.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dateEdit1.Properties.CalendarTimeProperties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)lookUpEdit1.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)customerBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)gridControl1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)gridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)productsBindingSource).BeginInit();
            SuspendLayout();
            // 
            // ribbon
            // 
            ribbon.ExpandCollapseItem.Id = 0;
            ribbon.Items.AddRange(new DevExpress.XtraBars.BarItem[] { ribbon.ExpandCollapseItem, ribbon.SearchEditItem, barButtonItem1, SaveClientButton, CancelClientButton, EditClientButton, barButtonItem2, barButtonItem3, barEditItem1 });
            ribbon.Location = new Point(0, 0);
            ribbon.Margin = new Padding(4, 2, 4, 2);
            ribbon.MaxItemId = 11;
            ribbon.Name = "ribbon";
            ribbon.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] { Εγγραφη });
            ribbon.Size = new Size(1362, 193);
            ribbon.StatusBar = ribbonStatusBar;
            // 
            // barButtonItem1
            // 
            barButtonItem1.Caption = "Εγγραφή";
            barButtonItem1.Id = 1;
            barButtonItem1.ImageOptions.SvgImage = (DevExpress.Utils.Svg.SvgImage)resources.GetObject("barButtonItem1.ImageOptions.SvgImage");
            barButtonItem1.Name = "barButtonItem1";
            barButtonItem1.ItemClick += barButtonItem1_ItemClick;
            // 
            // SaveClientButton
            // 
            SaveClientButton.Caption = "Καταχώρηση";
            SaveClientButton.Id = 2;
            SaveClientButton.ImageOptions.SvgImage = (DevExpress.Utils.Svg.SvgImage)resources.GetObject("SaveClientButton.ImageOptions.SvgImage");
            SaveClientButton.Name = "SaveClientButton";
            SaveClientButton.ItemClick += SaveClientButton_ItemClick;
            // 
            // CancelClientButton
            // 
            CancelClientButton.Caption = "Ακύρωση";
            CancelClientButton.Id = 3;
            CancelClientButton.ImageOptions.SvgImage = (DevExpress.Utils.Svg.SvgImage)resources.GetObject("CancelClientButton.ImageOptions.SvgImage");
            CancelClientButton.Name = "CancelClientButton";
            CancelClientButton.ItemClick += CancelClientButton_ItemClick;
            // 
            // EditClientButton
            // 
            EditClientButton.Caption = "Επεξεργασία";
            EditClientButton.Id = 4;
            EditClientButton.ImageOptions.Image = (Image)resources.GetObject("EditClientButton.ImageOptions.Image");
            EditClientButton.ImageOptions.LargeImage = (Image)resources.GetObject("EditClientButton.ImageOptions.LargeImage");
            EditClientButton.Name = "EditClientButton";
            // 
            // barButtonItem2
            // 
            barButtonItem2.Caption = "Διαγραφή";
            barButtonItem2.Id = 5;
            barButtonItem2.ImageOptions.SvgImage = (DevExpress.Utils.Svg.SvgImage)resources.GetObject("barButtonItem2.ImageOptions.SvgImage");
            barButtonItem2.Name = "barButtonItem2";
            barButtonItem2.ItemClick += barButtonItem2_ItemClick;
            // 
            // barButtonItem3
            // 
            barButtonItem3.Caption = "Close";
            barButtonItem3.Id = 6;
            barButtonItem3.ImageOptions.SvgImage = (DevExpress.Utils.Svg.SvgImage)resources.GetObject("barButtonItem3.ImageOptions.SvgImage");
            barButtonItem3.Name = "barButtonItem3";
            barButtonItem3.ItemClick += barButtonItem3_ItemClick;
            // 
            // barEditItem1
            // 
            barEditItem1.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Right;
            barEditItem1.Caption = "barEditItem1";
            barEditItem1.Edit = null;
            barEditItem1.Id = 7;
            barEditItem1.Name = "barEditItem1";
            // 
            // Εγγραφη
            // 
            Εγγραφη.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] { ribbonPageGroup1, ribbonPageGroup2 });
            Εγγραφη.Name = "Εγγραφη";
            Εγγραφη.Text = "Εγγραφή Πελάτη";
            // 
            // ribbonPageGroup1
            // 
            ribbonPageGroup1.ItemLinks.Add(barButtonItem1);
            ribbonPageGroup1.ItemLinks.Add(SaveClientButton);
            ribbonPageGroup1.ItemLinks.Add(CancelClientButton);
            ribbonPageGroup1.ItemLinks.Add(barButtonItem2);
            ribbonPageGroup1.Name = "ribbonPageGroup1";
            // 
            // ribbonPageGroup2
            // 
            ribbonPageGroup2.ItemLinks.Add(barButtonItem3);
            ribbonPageGroup2.Name = "ribbonPageGroup2";
            // 
            // ribbonStatusBar
            // 
            ribbonStatusBar.Location = new Point(0, 766);
            ribbonStatusBar.Margin = new Padding(4, 2, 4, 2);
            ribbonStatusBar.Name = "ribbonStatusBar";
            ribbonStatusBar.Ribbon = ribbon;
            ribbonStatusBar.Size = new Size(1362, 30);
            // 
            // ClientHeaderPanel
            // 
            ClientHeaderPanel.Controls.Add(labelControl5);
            ClientHeaderPanel.Controls.Add(panelControl2);
            ClientHeaderPanel.Controls.Add(panelControl3);
            ClientHeaderPanel.Dock = DockStyle.Top;
            ClientHeaderPanel.Location = new Point(0, 193);
            ClientHeaderPanel.Margin = new Padding(4, 2, 4, 2);
            ClientHeaderPanel.Name = "ClientHeaderPanel";
            ClientHeaderPanel.Size = new Size(1362, 132);
            ClientHeaderPanel.TabIndex = 2;
            // 
            // labelControl5
            // 
            labelControl5.Appearance.Font = new Font("Tahoma", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            labelControl5.Appearance.Options.UseFont = true;
            labelControl5.Location = new Point(6, 25);
            labelControl5.Margin = new Padding(4, 2, 4, 2);
            labelControl5.Name = "labelControl5";
            labelControl5.Size = new Size(63, 21);
            labelControl5.TabIndex = 8;
            labelControl5.Text = "ClientId:";
            // 
            // panelControl2
            // 
            panelControl2.Controls.Add(textEdit5);
            panelControl2.Controls.Add(labelControl3);
            panelControl2.Controls.Add(labelControl4);
            panelControl2.Controls.Add(textEdit4);
            panelControl2.Controls.Add(textEdit3);
            panelControl2.Controls.Add(labelControl2);
            panelControl2.Controls.Add(textEdit1);
            panelControl2.Controls.Add(labelControl1);
            panelControl2.Location = new Point(310, 2);
            panelControl2.Margin = new Padding(4, 2, 4, 2);
            panelControl2.Name = "panelControl2";
            panelControl2.Size = new Size(1046, 126);
            panelControl2.TabIndex = 12;
            // 
            // textEdit5
            // 
            textEdit5.Location = new Point(486, 81);
            textEdit5.Margin = new Padding(4, 2, 4, 2);
            textEdit5.MenuManager = ribbon;
            textEdit5.Name = "textEdit5";
            textEdit5.Properties.Appearance.Font = new Font("Tahoma", 9F, FontStyle.Regular, GraphicsUnit.Point);
            textEdit5.Properties.Appearance.Options.UseFont = true;
            textEdit5.Size = new Size(216, 24);
            textEdit5.TabIndex = 3;
            // 
            // labelControl3
            // 
            labelControl3.Appearance.Font = new Font("Tahoma", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            labelControl3.Appearance.Options.UseFont = true;
            labelControl3.Location = new Point(21, 82);
            labelControl3.Margin = new Padding(4, 2, 4, 2);
            labelControl3.Name = "labelControl3";
            labelControl3.Size = new Size(38, 21);
            labelControl3.TabIndex = 2;
            labelControl3.Text = "Τηλ.:";
            // 
            // labelControl4
            // 
            labelControl4.Appearance.Font = new Font("Tahoma", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            labelControl4.Appearance.Options.UseFont = true;
            labelControl4.Location = new Point(404, 82);
            labelControl4.Margin = new Padding(4, 2, 4, 2);
            labelControl4.Name = "labelControl4";
            labelControl4.Size = new Size(47, 21);
            labelControl4.TabIndex = 3;
            labelControl4.Text = "Email:";
            // 
            // textEdit4
            // 
            textEdit4.Location = new Point(148, 81);
            textEdit4.Margin = new Padding(4, 2, 4, 2);
            textEdit4.MenuManager = ribbon;
            textEdit4.Name = "textEdit4";
            textEdit4.Properties.Appearance.Font = new Font("Tahoma", 9F, FontStyle.Regular, GraphicsUnit.Point);
            textEdit4.Properties.Appearance.Options.UseFont = true;
            textEdit4.Size = new Size(216, 24);
            textEdit4.TabIndex = 2;
            // 
            // textEdit3
            // 
            textEdit3.Location = new Point(486, 24);
            textEdit3.Margin = new Padding(4, 2, 4, 2);
            textEdit3.MenuManager = ribbon;
            textEdit3.Name = "textEdit3";
            textEdit3.Properties.Appearance.Font = new Font("Tahoma", 9F, FontStyle.Regular, GraphicsUnit.Point);
            textEdit3.Properties.Appearance.Options.UseFont = true;
            textEdit3.Size = new Size(216, 24);
            textEdit3.TabIndex = 1;
            // 
            // labelControl2
            // 
            labelControl2.Appearance.Font = new Font("Tahoma", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            labelControl2.Appearance.Options.UseFont = true;
            labelControl2.Location = new Point(404, 23);
            labelControl2.Margin = new Padding(4, 2, 4, 2);
            labelControl2.Name = "labelControl2";
            labelControl2.Size = new Size(56, 21);
            labelControl2.TabIndex = 1;
            labelControl2.Text = "Όνομα:";
            // 
            // textEdit1
            // 
            textEdit1.Location = new Point(148, 24);
            textEdit1.Margin = new Padding(4, 2, 4, 2);
            textEdit1.MenuManager = ribbon;
            textEdit1.Name = "textEdit1";
            textEdit1.Properties.Appearance.Font = new Font("Tahoma", 9F, FontStyle.Regular, GraphicsUnit.Point);
            textEdit1.Properties.Appearance.Options.UseFont = true;
            textEdit1.Size = new Size(216, 24);
            textEdit1.TabIndex = 0;
            // 
            // labelControl1
            // 
            labelControl1.Appearance.Font = new Font("Tahoma", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            labelControl1.Appearance.Options.UseFont = true;
            labelControl1.Location = new Point(21, 23);
            labelControl1.Margin = new Padding(4, 2, 4, 2);
            labelControl1.Name = "labelControl1";
            labelControl1.Size = new Size(75, 21);
            labelControl1.TabIndex = 0;
            labelControl1.Text = "Επώνυμο:";
            // 
            // panelControl3
            // 
            panelControl3.Controls.Add(textEdit2);
            panelControl3.Controls.Add(dateEdit1);
            panelControl3.Controls.Add(labelControl6);
            panelControl3.Location = new Point(0, 2);
            panelControl3.Margin = new Padding(4, 2, 4, 2);
            panelControl3.Name = "panelControl3";
            panelControl3.Size = new Size(302, 126);
            panelControl3.TabIndex = 13;
            // 
            // textEdit2
            // 
            textEdit2.EditValue = "0";
            textEdit2.Enabled = false;
            textEdit2.Location = new Point(105, 22);
            textEdit2.Margin = new Padding(4, 2, 4, 2);
            textEdit2.MenuManager = ribbon;
            textEdit2.Name = "textEdit2";
            textEdit2.Properties.Appearance.Font = new Font("Tahoma", 9F, FontStyle.Regular, GraphicsUnit.Point);
            textEdit2.Properties.Appearance.Options.UseFont = true;
            textEdit2.Size = new Size(186, 24);
            textEdit2.TabIndex = 11;
            // 
            // dateEdit1
            // 
            dateEdit1.EditValue = null;
            dateEdit1.Location = new Point(105, 81);
            dateEdit1.Margin = new Padding(4);
            dateEdit1.MenuManager = ribbon;
            dateEdit1.Name = "dateEdit1";
            dateEdit1.Properties.Appearance.Font = new Font("Tahoma", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dateEdit1.Properties.Appearance.Options.UseFont = true;
            dateEdit1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] { new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo) });
            dateEdit1.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] { new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo) });
            dateEdit1.Size = new Size(186, 24);
            dateEdit1.TabIndex = 9;
            // 
            // labelControl6
            // 
            labelControl6.Appearance.Font = new Font("Tahoma", 10F, FontStyle.Regular, GraphicsUnit.Point);
            labelControl6.Appearance.Options.UseFont = true;
            labelControl6.Location = new Point(6, 82);
            labelControl6.Margin = new Padding(4);
            labelControl6.Name = "labelControl6";
            labelControl6.Size = new Size(65, 21);
            labelControl6.TabIndex = 10;
            labelControl6.Text = "ΗΜ/ΝΙΑ:";
            // 
            // lookUpEdit1
            // 
            lookUpEdit1.Location = new Point(492, 129);
            lookUpEdit1.MenuManager = ribbon;
            lookUpEdit1.Name = "lookUpEdit1";
            lookUpEdit1.Properties.Appearance.Font = new Font("Tahoma", 9F, FontStyle.Regular, GraphicsUnit.Point);
            lookUpEdit1.Properties.Appearance.Options.UseFont = true;
            lookUpEdit1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] { new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo) });
            lookUpEdit1.Properties.NullText = "";
            lookUpEdit1.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            lookUpEdit1.Size = new Size(278, 24);
            lookUpEdit1.TabIndex = 4;
            lookUpEdit1.EditValueChanged += lookUpEdit1_EditValueChanged;
            // 
            // customerBindingSource
            // 
            customerBindingSource.DataSource = typeof(Models.Customer);
            // 
            // gridControl1
            // 
            gridControl1.DataSource = customerBindingSource;
            gridControl1.Dock = DockStyle.Fill;
            gridControl1.EmbeddedNavigator.Margin = new Padding(4, 2, 4, 2);
            gridControl1.Location = new Point(0, 325);
            gridControl1.MainView = gridView1;
            gridControl1.Margin = new Padding(4, 2, 4, 2);
            gridControl1.MenuManager = ribbon;
            gridControl1.Name = "gridControl1";
            gridControl1.Size = new Size(1362, 441);
            gridControl1.TabIndex = 5;
            gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] { gridView1 });
            // 
            // gridView1
            // 
            gridView1.Appearance.Row.Font = new Font("Tahoma", 10.25F, FontStyle.Regular, GraphicsUnit.Point);
            gridView1.Appearance.Row.Options.UseFont = true;
            gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] { colId, colSurname, colName, colTel, colEmail });
            gridView1.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFullFocus;
            gridView1.GridControl = gridControl1;
            gridView1.Name = "gridView1";
            gridView1.OptionsBehavior.Editable = false;
            gridView1.OptionsView.ShowAutoFilterRow = true;
            gridView1.OptionsView.ShowGroupPanel = false;
            gridView1.RowClick += gridView1_RowClick;
            // 
            // colId
            // 
            colId.FieldName = "Id";
            colId.MinWidth = 24;
            colId.Name = "colId";
            colId.Visible = true;
            colId.VisibleIndex = 0;
            colId.Width = 77;
            // 
            // colSurname
            // 
            colSurname.FieldName = "Surname";
            colSurname.MinWidth = 24;
            colSurname.Name = "colSurname";
            colSurname.Visible = true;
            colSurname.VisibleIndex = 1;
            colSurname.Width = 180;
            // 
            // colName
            // 
            colName.FieldName = "Name";
            colName.MinWidth = 24;
            colName.Name = "colName";
            colName.Visible = true;
            colName.VisibleIndex = 2;
            colName.Width = 180;
            // 
            // colTel
            // 
            colTel.FieldName = "Tel";
            colTel.MinWidth = 24;
            colTel.Name = "colTel";
            colTel.Visible = true;
            colTel.VisibleIndex = 3;
            colTel.Width = 180;
            // 
            // colEmail
            // 
            colEmail.FieldName = "Email";
            colEmail.MinWidth = 24;
            colEmail.Name = "colEmail";
            colEmail.Visible = true;
            colEmail.VisibleIndex = 4;
            colEmail.Width = 185;
            // 
            // productsBindingSource
            // 
            productsBindingSource.DataSource = typeof(Models.Products);
            // 
            // CustomerForm
            // 
            AutoScaleDimensions = new SizeF(7F, 16F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1362, 796);
            Controls.Add(lookUpEdit1);
            Controls.Add(gridControl1);
            Controls.Add(ClientHeaderPanel);
            Controls.Add(ribbonStatusBar);
            Controls.Add(ribbon);
            Margin = new Padding(4, 2, 4, 2);
            Name = "CustomerForm";
            Ribbon = ribbon;
            StatusBar = ribbonStatusBar;
            Text = "InsertClient";
            Load += InsertClient_Load;
            ((System.ComponentModel.ISupportInitialize)ribbon).EndInit();
            ((System.ComponentModel.ISupportInitialize)ClientHeaderPanel).EndInit();
            ClientHeaderPanel.ResumeLayout(false);
            ClientHeaderPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)panelControl2).EndInit();
            panelControl2.ResumeLayout(false);
            panelControl2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)textEdit5.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)textEdit4.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)textEdit3.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)textEdit1.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)panelControl3).EndInit();
            panelControl3.ResumeLayout(false);
            panelControl3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)textEdit2.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)dateEdit1.Properties.CalendarTimeProperties).EndInit();
            ((System.ComponentModel.ISupportInitialize)dateEdit1.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)lookUpEdit1.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)customerBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)gridControl1).EndInit();
            ((System.ComponentModel.ISupportInitialize)gridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)productsBindingSource).EndInit();
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
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.DateEdit dateEdit1;
        private DevExpress.XtraEditors.PanelControl panelControl2;
        private DevExpress.XtraEditors.PanelControl panelControl3;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraEditors.TextEdit textEdit5;
        private DevExpress.XtraEditors.TextEdit textEdit4;
        private DevExpress.XtraEditors.TextEdit textEdit3;
        private DevExpress.XtraEditors.TextEdit textEdit1;
        private DevExpress.XtraEditors.TextEdit textEdit2;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private BindingSource customerBindingSource;
        private DevExpress.XtraGrid.Columns.GridColumn colId;
        private DevExpress.XtraGrid.Columns.GridColumn colSurname;
        private DevExpress.XtraGrid.Columns.GridColumn colName;
        private DevExpress.XtraGrid.Columns.GridColumn colTel;
        private DevExpress.XtraGrid.Columns.GridColumn colEmail;
        private DevExpress.XtraBars.BarButtonItem barButtonItem2;
        private DevExpress.XtraBars.BarButtonItem barButtonItem3;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup2;
        private DevExpress.XtraBars.BarEditItem barEditItem1;
        private BindingSource productsBindingSource;
        private DevExpress.XtraEditors.LookUpEdit lookUpEdit1;
    }
}