namespace BSMS.Winforms.Forms
{
    partial class EmployeeForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EmployeeForm));
            ribbon = new DevExpress.XtraBars.Ribbon.RibbonControl();
            barButtonItem1 = new DevExpress.XtraBars.BarButtonItem();
            SaveEmployeeButton = new DevExpress.XtraBars.BarButtonItem();
            CancelEmployeeButton = new DevExpress.XtraBars.BarButtonItem();
            barButtonItem4 = new DevExpress.XtraBars.BarButtonItem();
            barButtonItem2 = new DevExpress.XtraBars.BarButtonItem();
            bliDate = new DevExpress.XtraBars.BarListItem();
            bliTime = new DevExpress.XtraBars.BarListItem();
            bsiTime = new DevExpress.XtraBars.BarStaticItem();
            bsiDate = new DevExpress.XtraBars.BarStaticItem();
            ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            ribbonPageGroup2 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            repositoryItemPictureEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemPictureEdit();
            ribbonStatusBar = new DevExpress.XtraBars.Ribbon.RibbonStatusBar();
            labelControl5 = new DevExpress.XtraEditors.LabelControl();
            textEdit2 = new DevExpress.XtraEditors.TextEdit();
            dateEdit1 = new DevExpress.XtraEditors.DateEdit();
            labelControl6 = new DevExpress.XtraEditors.LabelControl();
            labelControl3 = new DevExpress.XtraEditors.LabelControl();
            textEdit5 = new DevExpress.XtraEditors.TextEdit();
            labelControl4 = new DevExpress.XtraEditors.LabelControl();
            textEdit4 = new DevExpress.XtraEditors.TextEdit();
            textEdit3 = new DevExpress.XtraEditors.TextEdit();
            labelControl2 = new DevExpress.XtraEditors.LabelControl();
            textEdit1 = new DevExpress.XtraEditors.TextEdit();
            labelControl1 = new DevExpress.XtraEditors.LabelControl();
            gridControl1 = new DevExpress.XtraGrid.GridControl();
            employeeBindingSource = new BindingSource(components);
            gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            colId = new DevExpress.XtraGrid.Columns.GridColumn();
            colCode = new DevExpress.XtraGrid.Columns.GridColumn();
            colSurname = new DevExpress.XtraGrid.Columns.GridColumn();
            colName = new DevExpress.XtraGrid.Columns.GridColumn();
            colTel = new DevExpress.XtraGrid.Columns.GridColumn();
            colEmail = new DevExpress.XtraGrid.Columns.GridColumn();
            EmployeeHeaderPanel = new DevExpress.XtraEditors.PanelControl();
            labelControl7 = new DevExpress.XtraEditors.LabelControl();
            employeeCodeTxt = new DevExpress.XtraEditors.TextEdit();
            panelControl1 = new DevExpress.XtraEditors.PanelControl();
            panelControl2 = new DevExpress.XtraEditors.PanelControl();
            panelControl3 = new DevExpress.XtraEditors.PanelControl();
            dateTimeChartRangeControlClient1 = new DevExpress.XtraEditors.DateTimeChartRangeControlClient();
            ((System.ComponentModel.ISupportInitialize)ribbon).BeginInit();
            ((System.ComponentModel.ISupportInitialize)repositoryItemPictureEdit1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)textEdit2.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dateEdit1.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dateEdit1.Properties.CalendarTimeProperties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)textEdit5.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)textEdit4.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)textEdit3.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)textEdit1.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)gridControl1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)employeeBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)gridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)EmployeeHeaderPanel).BeginInit();
            EmployeeHeaderPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)employeeCodeTxt.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)panelControl1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)panelControl2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)panelControl3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dateTimeChartRangeControlClient1).BeginInit();
            SuspendLayout();
            // 
            // ribbon
            // 
            ribbon.ExpandCollapseItem.Id = 0;
            ribbon.Items.AddRange(new DevExpress.XtraBars.BarItem[] { ribbon.ExpandCollapseItem, ribbon.SearchEditItem, barButtonItem1, SaveEmployeeButton, CancelEmployeeButton, barButtonItem4, barButtonItem2, bliDate, bliTime, bsiTime, bsiDate });
            ribbon.Location = new Point(0, 0);
            ribbon.MaxItemId = 11;
            ribbon.Name = "ribbon";
            ribbon.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] { ribbonPage1 });
            ribbon.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] { repositoryItemPictureEdit1 });
            ribbon.Size = new Size(1346, 193);
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
            // SaveEmployeeButton
            // 
            SaveEmployeeButton.Caption = "Καταχώρηση";
            SaveEmployeeButton.Id = 2;
            SaveEmployeeButton.ImageOptions.SvgImage = (DevExpress.Utils.Svg.SvgImage)resources.GetObject("SaveEmployeeButton.ImageOptions.SvgImage");
            SaveEmployeeButton.Name = "SaveEmployeeButton";
            SaveEmployeeButton.ItemClick += SaveEmployeeButton_ItemClick;
            // 
            // CancelEmployeeButton
            // 
            CancelEmployeeButton.Caption = "Ακύρωση";
            CancelEmployeeButton.Id = 3;
            CancelEmployeeButton.ImageOptions.SvgImage = (DevExpress.Utils.Svg.SvgImage)resources.GetObject("CancelEmployeeButton.ImageOptions.SvgImage");
            CancelEmployeeButton.Name = "CancelEmployeeButton";
            CancelEmployeeButton.ItemClick += CancelEmployeeButton_ItemClick;
            // 
            // barButtonItem4
            // 
            barButtonItem4.Caption = "Διαγραφή";
            barButtonItem4.Id = 4;
            barButtonItem4.ImageOptions.SvgImage = (DevExpress.Utils.Svg.SvgImage)resources.GetObject("barButtonItem4.ImageOptions.SvgImage");
            barButtonItem4.Name = "barButtonItem4";
            barButtonItem4.ItemClick += barButtonItem4_ItemClick;
            // 
            // barButtonItem2
            // 
            barButtonItem2.Caption = "Close";
            barButtonItem2.Id = 5;
            barButtonItem2.ImageOptions.SvgImage = (DevExpress.Utils.Svg.SvgImage)resources.GetObject("barButtonItem2.ImageOptions.SvgImage");
            barButtonItem2.Name = "barButtonItem2";
            barButtonItem2.ItemClick += barButtonItem2_ItemClick;
            // 
            // bliDate
            // 
            bliDate.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Right;
            bliDate.Caption = "Date";
            bliDate.Id = 7;
            bliDate.Name = "bliDate";
            // 
            // bliTime
            // 
            bliTime.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Right;
            bliTime.Caption = "Time";
            bliTime.Id = 8;
            bliTime.Name = "bliTime";
            // 
            // bsiTime
            // 
            bsiTime.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Right;
            bsiTime.Caption = "Time";
            bsiTime.Id = 9;
            bsiTime.Name = "bsiTime";
            // 
            // bsiDate
            // 
            bsiDate.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Right;
            bsiDate.Caption = "Date";
            bsiDate.Id = 10;
            bsiDate.Name = "bsiDate";
            // 
            // ribbonPage1
            // 
            ribbonPage1.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] { ribbonPageGroup1, ribbonPageGroup2 });
            ribbonPage1.Name = "ribbonPage1";
            ribbonPage1.Text = "Εγγραφή Κομμωτή - Υπάλληλο";
            // 
            // ribbonPageGroup1
            // 
            ribbonPageGroup1.ItemLinks.Add(barButtonItem1);
            ribbonPageGroup1.ItemLinks.Add(SaveEmployeeButton);
            ribbonPageGroup1.ItemLinks.Add(CancelEmployeeButton);
            ribbonPageGroup1.ItemLinks.Add(barButtonItem4);
            ribbonPageGroup1.Name = "ribbonPageGroup1";
            // 
            // ribbonPageGroup2
            // 
            ribbonPageGroup2.ImageOptions.SvgImage = (DevExpress.Utils.Svg.SvgImage)resources.GetObject("ribbonPageGroup2.ImageOptions.SvgImage");
            ribbonPageGroup2.ItemLinks.Add(barButtonItem2);
            ribbonPageGroup2.Name = "ribbonPageGroup2";
            // 
            // repositoryItemPictureEdit1
            // 
            repositoryItemPictureEdit1.Name = "repositoryItemPictureEdit1";
            // 
            // ribbonStatusBar
            // 
            ribbonStatusBar.ItemLinks.Add(bliDate);
            ribbonStatusBar.ItemLinks.Add(bliTime);
            ribbonStatusBar.ItemLinks.Add(bsiTime);
            ribbonStatusBar.ItemLinks.Add(bsiDate);
            ribbonStatusBar.Location = new Point(0, 770);
            ribbonStatusBar.Name = "ribbonStatusBar";
            ribbonStatusBar.Ribbon = ribbon;
            ribbonStatusBar.Size = new Size(1346, 30);
            // 
            // labelControl5
            // 
            labelControl5.Appearance.Font = new Font("Tahoma", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            labelControl5.Appearance.Options.UseFont = true;
            labelControl5.Location = new Point(315, 18);
            labelControl5.Margin = new Padding(4, 2, 4, 2);
            labelControl5.Name = "labelControl5";
            labelControl5.Size = new Size(95, 21);
            labelControl5.TabIndex = 12;
            labelControl5.Text = "IdΚομμωτή :";
            // 
            // textEdit2
            // 
            textEdit2.EditValue = "0";
            textEdit2.Enabled = false;
            textEdit2.Location = new Point(448, 14);
            textEdit2.Margin = new Padding(4, 2, 4, 2);
            textEdit2.MenuManager = ribbon;
            textEdit2.Name = "textEdit2";
            textEdit2.Properties.Appearance.Font = new Font("Tahoma", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            textEdit2.Properties.Appearance.Options.UseFont = true;
            textEdit2.Size = new Size(98, 28);
            textEdit2.TabIndex = 11;
            // 
            // dateEdit1
            // 
            dateEdit1.EditValue = null;
            dateEdit1.Location = new Point(84, 16);
            dateEdit1.Margin = new Padding(4);
            dateEdit1.MenuManager = ribbon;
            dateEdit1.Name = "dateEdit1";
            dateEdit1.Properties.Appearance.Font = new Font("Tahoma", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            dateEdit1.Properties.Appearance.Options.UseFont = true;
            dateEdit1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] { new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo) });
            dateEdit1.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] { new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo) });
            dateEdit1.Size = new Size(156, 28);
            dateEdit1.TabIndex = 9;
            // 
            // labelControl6
            // 
            labelControl6.Appearance.Font = new Font("Tahoma", 10F, FontStyle.Regular, GraphicsUnit.Point);
            labelControl6.Appearance.Options.UseFont = true;
            labelControl6.Location = new Point(6, 17);
            labelControl6.Margin = new Padding(4);
            labelControl6.Name = "labelControl6";
            labelControl6.Size = new Size(70, 21);
            labelControl6.TabIndex = 10;
            labelControl6.Text = "ΗΜ/ΝΙΑ :";
            // 
            // labelControl3
            // 
            labelControl3.Appearance.Font = new Font("Tahoma", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            labelControl3.Appearance.Options.UseFont = true;
            labelControl3.Location = new Point(1007, 18);
            labelControl3.Margin = new Padding(4, 2, 4, 2);
            labelControl3.Name = "labelControl3";
            labelControl3.Size = new Size(38, 21);
            labelControl3.TabIndex = 4;
            labelControl3.Text = "Τηλ.:";
            // 
            // textEdit5
            // 
            textEdit5.Location = new Point(1071, 75);
            textEdit5.Margin = new Padding(4, 2, 4, 2);
            textEdit5.MenuManager = ribbon;
            textEdit5.Name = "textEdit5";
            textEdit5.Properties.Appearance.Font = new Font("Tahoma", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            textEdit5.Properties.Appearance.Options.UseFont = true;
            textEdit5.Size = new Size(246, 28);
            textEdit5.TabIndex = 3;
            // 
            // labelControl4
            // 
            labelControl4.Appearance.Font = new Font("Tahoma", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            labelControl4.Appearance.Options.UseFont = true;
            labelControl4.Location = new Point(1007, 78);
            labelControl4.Margin = new Padding(4, 2, 4, 2);
            labelControl4.Name = "labelControl4";
            labelControl4.Size = new Size(47, 21);
            labelControl4.TabIndex = 3;
            labelControl4.Text = "Email:";
            // 
            // textEdit4
            // 
            textEdit4.Location = new Point(1071, 15);
            textEdit4.Margin = new Padding(4, 2, 4, 2);
            textEdit4.MenuManager = ribbon;
            textEdit4.Name = "textEdit4";
            textEdit4.Properties.Appearance.Font = new Font("Tahoma", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            textEdit4.Properties.Appearance.Options.UseFont = true;
            textEdit4.Size = new Size(246, 28);
            textEdit4.TabIndex = 2;
            // 
            // textEdit3
            // 
            textEdit3.Location = new Point(716, 75);
            textEdit3.Margin = new Padding(4, 2, 4, 2);
            textEdit3.MenuManager = ribbon;
            textEdit3.Name = "textEdit3";
            textEdit3.Properties.Appearance.Font = new Font("Tahoma", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            textEdit3.Properties.Appearance.Options.UseFont = true;
            textEdit3.Size = new Size(244, 28);
            textEdit3.TabIndex = 1;
            // 
            // labelControl2
            // 
            labelControl2.Appearance.Font = new Font("Tahoma", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            labelControl2.Appearance.Options.UseFont = true;
            labelControl2.Location = new Point(621, 78);
            labelControl2.Margin = new Padding(4, 2, 4, 2);
            labelControl2.Name = "labelControl2";
            labelControl2.Size = new Size(56, 21);
            labelControl2.TabIndex = 1;
            labelControl2.Text = "Όνομα:";
            // 
            // textEdit1
            // 
            textEdit1.Location = new Point(716, 15);
            textEdit1.Margin = new Padding(4, 2, 4, 2);
            textEdit1.MenuManager = ribbon;
            textEdit1.Name = "textEdit1";
            textEdit1.Properties.Appearance.Font = new Font("Tahoma", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            textEdit1.Properties.Appearance.Options.UseFont = true;
            textEdit1.Size = new Size(246, 28);
            textEdit1.TabIndex = 0;
            // 
            // labelControl1
            // 
            labelControl1.Appearance.Font = new Font("Tahoma", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            labelControl1.Appearance.Options.UseFont = true;
            labelControl1.Location = new Point(621, 17);
            labelControl1.Margin = new Padding(4, 2, 4, 2);
            labelControl1.Name = "labelControl1";
            labelControl1.Size = new Size(80, 21);
            labelControl1.TabIndex = 0;
            labelControl1.Text = "Επώνυμο :";
            // 
            // gridControl1
            // 
            gridControl1.DataSource = employeeBindingSource;
            gridControl1.Dock = DockStyle.Fill;
            gridControl1.EmbeddedNavigator.Margin = new Padding(4, 2, 4, 2);
            gridControl1.Location = new Point(0, 318);
            gridControl1.MainView = gridView1;
            gridControl1.Margin = new Padding(4, 2, 4, 2);
            gridControl1.MenuManager = ribbon;
            gridControl1.Name = "gridControl1";
            gridControl1.Size = new Size(1346, 452);
            gridControl1.TabIndex = 13;
            gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] { gridView1 });
            // 
            // employeeBindingSource
            // 
            employeeBindingSource.DataSource = typeof(Models.Employee);
            // 
            // gridView1
            // 
            gridView1.Appearance.Row.Font = new Font("Tahoma", 10.25F, FontStyle.Regular, GraphicsUnit.Point);
            gridView1.Appearance.Row.Options.UseFont = true;
            gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] { colId, colCode, colSurname, colName, colTel, colEmail });
            gridView1.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFullFocus;
            gridView1.GridControl = gridControl1;
            gridView1.Name = "gridView1";
            gridView1.OptionsBehavior.Editable = false;
            gridView1.OptionsView.ShowAutoFilterRow = true;
            gridView1.OptionsView.ShowGroupPanel = false;
            gridView1.RowClick += gridView1_RowClick_1;
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
            // colCode
            // 
            colCode.Caption = "Code";
            colCode.FieldName = "Code";
            colCode.MinWidth = 25;
            colCode.Name = "colCode";
            colCode.Visible = true;
            colCode.VisibleIndex = 1;
            colCode.Width = 94;
            // 
            // colSurname
            // 
            colSurname.FieldName = "Surname";
            colSurname.MinWidth = 24;
            colSurname.Name = "colSurname";
            colSurname.Visible = true;
            colSurname.VisibleIndex = 2;
            colSurname.Width = 180;
            // 
            // colName
            // 
            colName.FieldName = "Name";
            colName.MinWidth = 24;
            colName.Name = "colName";
            colName.Visible = true;
            colName.VisibleIndex = 3;
            colName.Width = 180;
            // 
            // colTel
            // 
            colTel.FieldName = "Tel";
            colTel.MinWidth = 24;
            colTel.Name = "colTel";
            colTel.Visible = true;
            colTel.VisibleIndex = 4;
            colTel.Width = 180;
            // 
            // colEmail
            // 
            colEmail.FieldName = "Email";
            colEmail.MinWidth = 24;
            colEmail.Name = "colEmail";
            colEmail.Visible = true;
            colEmail.VisibleIndex = 5;
            colEmail.Width = 185;
            // 
            // EmployeeHeaderPanel
            // 
            EmployeeHeaderPanel.Controls.Add(labelControl7);
            EmployeeHeaderPanel.Controls.Add(employeeCodeTxt);
            EmployeeHeaderPanel.Controls.Add(labelControl3);
            EmployeeHeaderPanel.Controls.Add(dateEdit1);
            EmployeeHeaderPanel.Controls.Add(labelControl5);
            EmployeeHeaderPanel.Controls.Add(labelControl6);
            EmployeeHeaderPanel.Controls.Add(textEdit5);
            EmployeeHeaderPanel.Controls.Add(labelControl4);
            EmployeeHeaderPanel.Controls.Add(textEdit2);
            EmployeeHeaderPanel.Controls.Add(textEdit4);
            EmployeeHeaderPanel.Controls.Add(textEdit3);
            EmployeeHeaderPanel.Controls.Add(labelControl2);
            EmployeeHeaderPanel.Controls.Add(labelControl1);
            EmployeeHeaderPanel.Controls.Add(textEdit1);
            EmployeeHeaderPanel.Controls.Add(panelControl1);
            EmployeeHeaderPanel.Controls.Add(panelControl2);
            EmployeeHeaderPanel.Controls.Add(panelControl3);
            EmployeeHeaderPanel.Dock = DockStyle.Top;
            EmployeeHeaderPanel.Location = new Point(0, 193);
            EmployeeHeaderPanel.Name = "EmployeeHeaderPanel";
            EmployeeHeaderPanel.Size = new Size(1346, 125);
            EmployeeHeaderPanel.TabIndex = 18;
            // 
            // labelControl7
            // 
            labelControl7.Appearance.Font = new Font("Tahoma", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            labelControl7.Appearance.Options.UseFont = true;
            labelControl7.Location = new Point(315, 78);
            labelControl7.Margin = new Padding(4, 2, 4, 2);
            labelControl7.Name = "labelControl7";
            labelControl7.Size = new Size(117, 21);
            labelControl7.TabIndex = 13;
            labelControl7.Text = "Κωδ.Κομμωτή :";
            // 
            // employeeCodeTxt
            // 
            employeeCodeTxt.Location = new Point(448, 71);
            employeeCodeTxt.Margin = new Padding(4, 2, 4, 2);
            employeeCodeTxt.MenuManager = ribbon;
            employeeCodeTxt.Name = "employeeCodeTxt";
            employeeCodeTxt.Properties.Appearance.Font = new Font("Tahoma", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            employeeCodeTxt.Properties.Appearance.Options.UseFont = true;
            employeeCodeTxt.Size = new Size(98, 28);
            employeeCodeTxt.TabIndex = 14;
            // 
            // panelControl1
            // 
            panelControl1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            panelControl1.Location = new Point(3, 6);
            panelControl1.Name = "panelControl1";
            panelControl1.Size = new Size(296, 114);
            panelControl1.TabIndex = 15;
            // 
            // panelControl2
            // 
            panelControl2.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            panelControl2.Location = new Point(305, 6);
            panelControl2.Name = "panelControl2";
            panelControl2.Size = new Size(287, 114);
            panelControl2.TabIndex = 16;
            // 
            // panelControl3
            // 
            panelControl3.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            panelControl3.Location = new Point(598, 6);
            panelControl3.Name = "panelControl3";
            panelControl3.Size = new Size(743, 114);
            panelControl3.TabIndex = 17;
            // 
            // EmployeeForm
            // 
            AutoScaleDimensions = new SizeF(7F, 16F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1346, 800);
            Controls.Add(gridControl1);
            Controls.Add(EmployeeHeaderPanel);
            Controls.Add(ribbonStatusBar);
            Controls.Add(ribbon);
            Name = "EmployeeForm";
            Ribbon = ribbon;
            StatusBar = ribbonStatusBar;
            Text = "InsertEmployee";
            Load += InsertEmployee_Load;
            ((System.ComponentModel.ISupportInitialize)ribbon).EndInit();
            ((System.ComponentModel.ISupportInitialize)repositoryItemPictureEdit1).EndInit();
            ((System.ComponentModel.ISupportInitialize)textEdit2.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)dateEdit1.Properties.CalendarTimeProperties).EndInit();
            ((System.ComponentModel.ISupportInitialize)dateEdit1.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)textEdit5.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)textEdit4.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)textEdit3.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)textEdit1.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)gridControl1).EndInit();
            ((System.ComponentModel.ISupportInitialize)employeeBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)gridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)EmployeeHeaderPanel).EndInit();
            EmployeeHeaderPanel.ResumeLayout(false);
            EmployeeHeaderPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)employeeCodeTxt.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)panelControl1).EndInit();
            ((System.ComponentModel.ISupportInitialize)panelControl2).EndInit();
            ((System.ComponentModel.ISupportInitialize)panelControl3).EndInit();
            ((System.ComponentModel.ISupportInitialize)dateTimeChartRangeControlClient1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbon;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraBars.Ribbon.RibbonStatusBar ribbonStatusBar;
        private DevExpress.XtraBars.BarButtonItem barButtonItem1;
        private DevExpress.XtraBars.BarButtonItem SaveEmployeeButton;
        private DevExpress.XtraBars.BarButtonItem CancelEmployeeButton;
        private DevExpress.XtraBars.BarButtonItem barButtonItem4;
        private DevExpress.XtraEditors.TextEdit textEdit2;
        private DevExpress.XtraEditors.DateEdit dateEdit1;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.TextEdit textEdit5;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.TextEdit textEdit4;
        private DevExpress.XtraEditors.TextEdit textEdit3;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.TextEdit textEdit1;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colId;
        private DevExpress.XtraGrid.Columns.GridColumn colSurname;
        private DevExpress.XtraGrid.Columns.GridColumn colName;
        private DevExpress.XtraGrid.Columns.GridColumn colTel;
        private DevExpress.XtraGrid.Columns.GridColumn colEmail;
        private DevExpress.XtraEditors.PanelControl EmployeeHeaderPanel;
        private BindingSource employeeBindingSource;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup2;
        private DevExpress.XtraBars.BarButtonItem barButtonItem2;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private DevExpress.XtraEditors.TextEdit employeeCodeTxt;
        private DevExpress.XtraEditors.Repository.RepositoryItemPictureEdit repositoryItemPictureEdit1;
        private DevExpress.XtraGrid.Columns.GridColumn colCode;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.PanelControl panelControl2;
        private DevExpress.XtraEditors.PanelControl panelControl3;
        private DevExpress.XtraBars.BarListItem bliDate;
        private DevExpress.XtraBars.BarListItem bliTime;
        private DevExpress.XtraBars.BarStaticItem bsiTime;
        private DevExpress.XtraBars.BarStaticItem bsiDate;
        private DevExpress.XtraEditors.DateTimeChartRangeControlClient dateTimeChartRangeControlClient1;
    }
}