namespace BSMS.Winforms.Forms
{
    partial class OrderForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OrderForm));
            DevExpress.Utils.Animation.PushTransition pushTransition1 = new DevExpress.Utils.Animation.PushTransition();
            ribbon = new DevExpress.XtraBars.Ribbon.RibbonControl();
            addOrderButton = new DevExpress.XtraBars.BarButtonItem();
            cancelOrderButton = new DevExpress.XtraBars.BarButtonItem();
            paymentButton = new DevExpress.XtraBars.BarButtonItem();
            printButton = new DevExpress.XtraBars.BarButtonItem();
            closeButton = new DevExpress.XtraBars.BarButtonItem();
            saveOrderButton = new DevExpress.XtraBars.BarButtonItem();
            barButtonItem1 = new DevExpress.XtraBars.BarButtonItem();
            addProductButton = new DevExpress.XtraBars.BarButtonItem();
            ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            ribbonPageGroup2 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            ribbonPageGroup3 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            OrderHeaderPanel = new DevExpress.XtraEditors.PanelControl();
            lookUpEdit1 = new DevExpress.XtraEditors.LookUpEdit();
            employeeBindingSource = new BindingSource(components);
            dateEdit1 = new DevExpress.XtraEditors.DateEdit();
            labelControl4 = new DevExpress.XtraEditors.LabelControl();
            textEdit4 = new DevExpress.XtraEditors.TextEdit();
            labelControl8 = new DevExpress.XtraEditors.LabelControl();
            textEdit2 = new DevExpress.XtraEditors.TextEdit();
            textEdit3 = new DevExpress.XtraEditors.TextEdit();
            labelControl6 = new DevExpress.XtraEditors.LabelControl();
            labelControl5 = new DevExpress.XtraEditors.LabelControl();
            labelControl7 = new DevExpress.XtraEditors.LabelControl();
            memoEdit1 = new DevExpress.XtraEditors.MemoEdit();
            labelControl3 = new DevExpress.XtraEditors.LabelControl();
            textEdit1 = new DevExpress.XtraEditors.TextEdit();
            labelControl2 = new DevExpress.XtraEditors.LabelControl();
            AddedServicesFlowLayout = new FlowLayoutPanel();
            panelControl4 = new DevExpress.XtraEditors.PanelControl();
            ServicesFlowPanel = new FlowLayoutPanel();
            panelControl2 = new DevExpress.XtraEditors.PanelControl();
            labelControl1 = new DevExpress.XtraEditors.LabelControl();
            panelControl5 = new DevExpress.XtraEditors.PanelControl();
            panelControl3 = new DevExpress.XtraEditors.PanelControl();
            servicesInOrderLabel = new DevExpress.XtraEditors.LabelControl();
            xtraScrollableControl1 = new DevExpress.XtraEditors.XtraScrollableControl();
            panelControl7 = new DevExpress.XtraEditors.PanelControl();
            xtraTabControl1 = new DevExpress.XtraTab.XtraTabControl();
            xtraTabPage1 = new DevExpress.XtraTab.XtraTabPage();
            xtraTabPage2 = new DevExpress.XtraTab.XtraTabPage();
            panelControl1 = new DevExpress.XtraEditors.PanelControl();
            AddedProductsFlowLayout = new FlowLayoutPanel();
            panelControl6 = new DevExpress.XtraEditors.PanelControl();
            labelControl9 = new DevExpress.XtraEditors.LabelControl();
            panelControl8 = new DevExpress.XtraEditors.PanelControl();
            totalPriceLabel = new DevExpress.XtraEditors.LabelControl();
            workspaceManager1 = new DevExpress.Utils.WorkspaceManager(components);
            ((System.ComponentModel.ISupportInitialize)ribbon).BeginInit();
            ((System.ComponentModel.ISupportInitialize)OrderHeaderPanel).BeginInit();
            OrderHeaderPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)lookUpEdit1.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)employeeBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dateEdit1.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dateEdit1.Properties.CalendarTimeProperties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)textEdit4.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)textEdit2.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)textEdit3.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)memoEdit1.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)textEdit1.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)panelControl4).BeginInit();
            panelControl4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)panelControl2).BeginInit();
            panelControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)panelControl5).BeginInit();
            panelControl5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)panelControl3).BeginInit();
            panelControl3.SuspendLayout();
            xtraScrollableControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)panelControl7).BeginInit();
            panelControl7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)xtraTabControl1).BeginInit();
            xtraTabControl1.SuspendLayout();
            xtraTabPage1.SuspendLayout();
            xtraTabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)panelControl1).BeginInit();
            panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)panelControl6).BeginInit();
            panelControl6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)panelControl8).BeginInit();
            panelControl8.SuspendLayout();
            SuspendLayout();
            // 
            // ribbon
            // 
            ribbon.ExpandCollapseItem.Id = 0;
            ribbon.Items.AddRange(new DevExpress.XtraBars.BarItem[] { ribbon.ExpandCollapseItem, ribbon.SearchEditItem, addOrderButton, cancelOrderButton, paymentButton, printButton, closeButton, saveOrderButton, barButtonItem1, addProductButton });
            ribbon.Location = new Point(0, 0);
            ribbon.Margin = new Padding(4, 2, 4, 2);
            ribbon.MaxItemId = 16;
            ribbon.Name = "ribbon";
            ribbon.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] { ribbonPage1 });
            ribbon.Size = new Size(1366, 193);
            // 
            // addOrderButton
            // 
            addOrderButton.Caption = "Προσθήκη Υπηρεσίας";
            addOrderButton.Id = 1;
            addOrderButton.ImageOptions.SvgImage = (DevExpress.Utils.Svg.SvgImage)resources.GetObject("addOrderButton.ImageOptions.SvgImage");
            addOrderButton.Name = "addOrderButton";
            addOrderButton.ItemClick += addOrderButton_ItemClick;
            // 
            // cancelOrderButton
            // 
            cancelOrderButton.Caption = "Ακύρωση Υπηρεσίας";
            cancelOrderButton.Id = 2;
            cancelOrderButton.ImageOptions.SvgImage = (DevExpress.Utils.Svg.SvgImage)resources.GetObject("cancelOrderButton.ImageOptions.SvgImage");
            cancelOrderButton.Name = "cancelOrderButton";
            cancelOrderButton.ItemClick += barButtonItem2_ItemClick;
            // 
            // paymentButton
            // 
            paymentButton.Caption = "Πληρωμή";
            paymentButton.Id = 3;
            paymentButton.ImageOptions.SvgImage = (DevExpress.Utils.Svg.SvgImage)resources.GetObject("paymentButton.ImageOptions.SvgImage");
            paymentButton.Name = "paymentButton";
            paymentButton.ItemClick += barButtonItem3_ItemClick;
            // 
            // printButton
            // 
            printButton.Caption = "Save as file";
            printButton.Id = 4;
            printButton.ImageOptions.SvgImage = (DevExpress.Utils.Svg.SvgImage)resources.GetObject("printButton.ImageOptions.SvgImage");
            printButton.Name = "printButton";
            printButton.ItemClick += printButton_ItemClick;
            // 
            // closeButton
            // 
            closeButton.Caption = "Close";
            closeButton.Id = 5;
            closeButton.ImageOptions.SvgImage = (DevExpress.Utils.Svg.SvgImage)resources.GetObject("closeButton.ImageOptions.SvgImage");
            closeButton.Name = "closeButton";
            closeButton.ItemClick += barButtonItem4_ItemClick;
            // 
            // saveOrderButton
            // 
            saveOrderButton.Caption = "Αποθήκευση Υπηρεσίας";
            saveOrderButton.Id = 6;
            saveOrderButton.ImageOptions.SvgImage = (DevExpress.Utils.Svg.SvgImage)resources.GetObject("saveOrderButton.ImageOptions.SvgImage");
            saveOrderButton.Name = "saveOrderButton";
            saveOrderButton.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
            saveOrderButton.ItemClick += saveOrderButton_ItemClick;
            // 
            // barButtonItem1
            // 
            barButtonItem1.Caption = "Delete Payment";
            barButtonItem1.Id = 9;
            barButtonItem1.ImageOptions.SvgImage = (DevExpress.Utils.Svg.SvgImage)resources.GetObject("barButtonItem1.ImageOptions.SvgImage");
            barButtonItem1.Name = "barButtonItem1";
            barButtonItem1.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
            barButtonItem1.ItemClick += barButtonItem1_ItemClick_1;
            // 
            // addProductButton
            // 
            addProductButton.Caption = "Add products to order";
            addProductButton.Id = 15;
            addProductButton.ImageOptions.SvgImage = (DevExpress.Utils.Svg.SvgImage)resources.GetObject("addProductButton.ImageOptions.SvgImage");
            addProductButton.Name = "addProductButton";
            addProductButton.ItemClick += addProductButton_ItemClick;
            // 
            // ribbonPage1
            // 
            ribbonPage1.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] { ribbonPageGroup1, ribbonPageGroup2, ribbonPageGroup3 });
            ribbonPage1.Name = "ribbonPage1";
            ribbonPage1.Text = "Υπηρεσία";
            // 
            // ribbonPageGroup1
            // 
            ribbonPageGroup1.ItemLinks.Add(addOrderButton);
            ribbonPageGroup1.ItemLinks.Add(saveOrderButton);
            ribbonPageGroup1.ItemLinks.Add(cancelOrderButton);
            ribbonPageGroup1.ItemLinks.Add(addProductButton);
            ribbonPageGroup1.Name = "ribbonPageGroup1";
            // 
            // ribbonPageGroup2
            // 
            ribbonPageGroup2.ItemLinks.Add(paymentButton);
            ribbonPageGroup2.ItemLinks.Add(barButtonItem1);
            ribbonPageGroup2.ItemLinks.Add(printButton);
            ribbonPageGroup2.Name = "ribbonPageGroup2";
            // 
            // ribbonPageGroup3
            // 
            ribbonPageGroup3.ItemLinks.Add(closeButton);
            ribbonPageGroup3.Name = "ribbonPageGroup3";
            // 
            // OrderHeaderPanel
            // 
            OrderHeaderPanel.Controls.Add(lookUpEdit1);
            OrderHeaderPanel.Controls.Add(dateEdit1);
            OrderHeaderPanel.Controls.Add(labelControl4);
            OrderHeaderPanel.Controls.Add(textEdit4);
            OrderHeaderPanel.Controls.Add(labelControl8);
            OrderHeaderPanel.Controls.Add(textEdit2);
            OrderHeaderPanel.Controls.Add(textEdit3);
            OrderHeaderPanel.Controls.Add(labelControl6);
            OrderHeaderPanel.Controls.Add(labelControl5);
            OrderHeaderPanel.Controls.Add(labelControl7);
            OrderHeaderPanel.Controls.Add(memoEdit1);
            OrderHeaderPanel.Controls.Add(labelControl3);
            OrderHeaderPanel.Controls.Add(textEdit1);
            OrderHeaderPanel.Controls.Add(labelControl2);
            OrderHeaderPanel.Dock = DockStyle.Top;
            OrderHeaderPanel.Location = new Point(0, 193);
            OrderHeaderPanel.Margin = new Padding(4, 2, 4, 2);
            OrderHeaderPanel.Name = "OrderHeaderPanel";
            OrderHeaderPanel.Size = new Size(1366, 116);
            OrderHeaderPanel.TabIndex = 2;
            // 
            // lookUpEdit1
            // 
            lookUpEdit1.Location = new Point(356, 12);
            lookUpEdit1.MenuManager = ribbon;
            lookUpEdit1.Name = "lookUpEdit1";
            lookUpEdit1.Properties.Appearance.Font = new Font("Tahoma", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            lookUpEdit1.Properties.Appearance.Options.UseFont = true;
            lookUpEdit1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] { new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo) });
            lookUpEdit1.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] { new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Id", "Id", 22, DevExpress.Utils.FormatType.Numeric, "", true, DevExpress.Utils.HorzAlignment.Far, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default), new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Surname", "Surname", 63, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default), new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Name", "Name", 40, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default) });
            lookUpEdit1.Properties.DataSource = employeeBindingSource;
            lookUpEdit1.Properties.DisplayMember = "Surname";
            lookUpEdit1.Properties.NullText = "Επιλογή πελάτη";
            lookUpEdit1.Properties.PopupFilterMode = DevExpress.XtraEditors.PopupFilterMode.Contains;
            lookUpEdit1.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            lookUpEdit1.Properties.ValueMember = "Id";
            lookUpEdit1.Size = new Size(218, 28);
            lookUpEdit1.TabIndex = 14;
            lookUpEdit1.EditValueChanged += lookUpEdit1_EditValueChanged;
            // 
            // employeeBindingSource
            // 
            employeeBindingSource.DataSource = typeof(Models.Employee);
            // 
            // dateEdit1
            // 
            dateEdit1.EditValue = null;
            dateEdit1.Location = new Point(104, 70);
            dateEdit1.Margin = new Padding(4);
            dateEdit1.MenuManager = ribbon;
            dateEdit1.Name = "dateEdit1";
            dateEdit1.Properties.Appearance.Font = new Font("Tahoma", 9.8F, FontStyle.Regular, GraphicsUnit.Point);
            dateEdit1.Properties.Appearance.Options.UseFont = true;
            dateEdit1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] { new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo) });
            dateEdit1.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] { new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo) });
            dateEdit1.Size = new Size(117, 26);
            dateEdit1.TabIndex = 4;
            dateEdit1.EditValueChanged += lookUpEdit1_EditValueChanged;
            // 
            // labelControl4
            // 
            labelControl4.Appearance.Font = new Font("Tahoma", 10F, FontStyle.Regular, GraphicsUnit.Point);
            labelControl4.Appearance.Options.UseFont = true;
            labelControl4.Location = new Point(13, 73);
            labelControl4.Margin = new Padding(4);
            labelControl4.Name = "labelControl4";
            labelControl4.Size = new Size(70, 21);
            labelControl4.TabIndex = 6;
            labelControl4.Text = "ΗΜ/ΝΙΑ :";
            // 
            // textEdit4
            // 
            textEdit4.Enabled = false;
            textEdit4.Location = new Point(675, 69);
            textEdit4.MenuManager = ribbon;
            textEdit4.Name = "textEdit4";
            textEdit4.Properties.Appearance.Font = new Font("Tahoma", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            textEdit4.Properties.Appearance.Options.UseFont = true;
            textEdit4.Size = new Size(218, 28);
            textEdit4.TabIndex = 13;
            // 
            // labelControl8
            // 
            labelControl8.Appearance.Font = new Font("Tahoma", 10F, FontStyle.Regular, GraphicsUnit.Point);
            labelControl8.Appearance.Options.UseFont = true;
            labelControl8.Location = new Point(598, 72);
            labelControl8.Margin = new Padding(4);
            labelControl8.Name = "labelControl8";
            labelControl8.Size = new Size(54, 21);
            labelControl8.TabIndex = 12;
            labelControl8.Text = "EMAIL:";
            // 
            // textEdit2
            // 
            textEdit2.Enabled = false;
            textEdit2.Location = new Point(675, 12);
            textEdit2.MenuManager = ribbon;
            textEdit2.Name = "textEdit2";
            textEdit2.Properties.Appearance.Font = new Font("Tahoma", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            textEdit2.Properties.Appearance.Options.UseFont = true;
            textEdit2.Size = new Size(218, 28);
            textEdit2.TabIndex = 9;
            // 
            // textEdit3
            // 
            textEdit3.Enabled = false;
            textEdit3.Location = new Point(356, 69);
            textEdit3.MenuManager = ribbon;
            textEdit3.Name = "textEdit3";
            textEdit3.Properties.Appearance.Font = new Font("Tahoma", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            textEdit3.Properties.Appearance.Options.UseFont = true;
            textEdit3.Size = new Size(218, 28);
            textEdit3.TabIndex = 11;
            // 
            // labelControl6
            // 
            labelControl6.Appearance.Font = new Font("Tahoma", 10F, FontStyle.Regular, GraphicsUnit.Point);
            labelControl6.Appearance.Options.UseFont = true;
            labelControl6.Location = new Point(598, 17);
            labelControl6.Margin = new Padding(4);
            labelControl6.Name = "labelControl6";
            labelControl6.Size = new Size(65, 21);
            labelControl6.TabIndex = 8;
            labelControl6.Text = "ΟΝΟΜΑ:";
            // 
            // labelControl5
            // 
            labelControl5.Appearance.Font = new Font("Tahoma", 10F, FontStyle.Regular, GraphicsUnit.Point);
            labelControl5.Appearance.Options.UseFont = true;
            labelControl5.Location = new Point(926, 6);
            labelControl5.Margin = new Padding(4);
            labelControl5.Name = "labelControl5";
            labelControl5.Size = new Size(88, 21);
            labelControl5.TabIndex = 7;
            labelControl5.Text = "Σημειώσεις:";
            // 
            // labelControl7
            // 
            labelControl7.Appearance.Font = new Font("Tahoma", 10F, FontStyle.Regular, GraphicsUnit.Point);
            labelControl7.Appearance.Options.UseFont = true;
            labelControl7.Location = new Point(248, 76);
            labelControl7.Margin = new Padding(4);
            labelControl7.Name = "labelControl7";
            labelControl7.Size = new Size(43, 21);
            labelControl7.TabIndex = 10;
            labelControl7.Text = "ΤΗΛ.:";
            // 
            // memoEdit1
            // 
            memoEdit1.Location = new Point(926, 35);
            memoEdit1.Margin = new Padding(4);
            memoEdit1.MenuManager = ribbon;
            memoEdit1.Name = "memoEdit1";
            memoEdit1.Size = new Size(438, 62);
            memoEdit1.TabIndex = 5;
            // 
            // labelControl3
            // 
            labelControl3.Appearance.Font = new Font("Tahoma", 10F, FontStyle.Regular, GraphicsUnit.Point);
            labelControl3.Appearance.Options.UseFont = true;
            labelControl3.Location = new Point(247, 17);
            labelControl3.Margin = new Padding(4);
            labelControl3.Name = "labelControl3";
            labelControl3.Size = new Size(85, 21);
            labelControl3.TabIndex = 2;
            labelControl3.Text = "ΕΠΩΝΥΜΟ:";
            // 
            // textEdit1
            // 
            textEdit1.Enabled = false;
            textEdit1.Location = new Point(104, 17);
            textEdit1.Margin = new Padding(4);
            textEdit1.MenuManager = ribbon;
            textEdit1.Name = "textEdit1";
            textEdit1.Properties.Appearance.Font = new Font("Tahoma", 9.8F, FontStyle.Regular, GraphicsUnit.Point);
            textEdit1.Properties.Appearance.Options.UseFont = true;
            textEdit1.Size = new Size(117, 26);
            textEdit1.TabIndex = 1;
            // 
            // labelControl2
            // 
            labelControl2.Appearance.Font = new Font("Tahoma", 10F, FontStyle.Regular, GraphicsUnit.Point);
            labelControl2.Appearance.Options.UseFont = true;
            labelControl2.Location = new Point(13, 15);
            labelControl2.Margin = new Padding(4);
            labelControl2.Name = "labelControl2";
            labelControl2.Size = new Size(60, 21);
            labelControl2.TabIndex = 0;
            labelControl2.Text = "OrderID";
            // 
            // AddedServicesFlowLayout
            // 
            AddedServicesFlowLayout.AutoScroll = true;
            AddedServicesFlowLayout.AutoSize = true;
            AddedServicesFlowLayout.Dock = DockStyle.Fill;
            AddedServicesFlowLayout.Location = new Point(2, 57);
            AddedServicesFlowLayout.Margin = new Padding(4, 2, 4, 2);
            AddedServicesFlowLayout.Name = "AddedServicesFlowLayout";
            AddedServicesFlowLayout.Padding = new Padding(6);
            AddedServicesFlowLayout.Size = new Size(491, 333);
            AddedServicesFlowLayout.TabIndex = 0;
            // 
            // panelControl4
            // 
            panelControl4.Controls.Add(ServicesFlowPanel);
            panelControl4.Controls.Add(panelControl2);
            panelControl4.Dock = DockStyle.Fill;
            panelControl4.Location = new Point(0, 0);
            panelControl4.Margin = new Padding(4, 2, 4, 2);
            panelControl4.Name = "panelControl4";
            panelControl4.Size = new Size(865, 487);
            panelControl4.TabIndex = 6;
            // 
            // ServicesFlowPanel
            // 
            ServicesFlowPanel.AutoScroll = true;
            ServicesFlowPanel.Dock = DockStyle.Fill;
            ServicesFlowPanel.Location = new Point(2, 57);
            ServicesFlowPanel.Margin = new Padding(4);
            ServicesFlowPanel.Name = "ServicesFlowPanel";
            ServicesFlowPanel.Padding = new Padding(12);
            ServicesFlowPanel.Size = new Size(861, 428);
            ServicesFlowPanel.TabIndex = 3;
            // 
            // panelControl2
            // 
            panelControl2.Controls.Add(labelControl1);
            panelControl2.Dock = DockStyle.Top;
            panelControl2.Location = new Point(2, 2);
            panelControl2.Margin = new Padding(4, 2, 4, 2);
            panelControl2.Name = "panelControl2";
            panelControl2.Size = new Size(861, 55);
            panelControl2.TabIndex = 2;
            // 
            // labelControl1
            // 
            labelControl1.Appearance.Font = new Font("Tahoma", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            labelControl1.Appearance.Options.UseFont = true;
            labelControl1.Location = new Point(12, 15);
            labelControl1.Margin = new Padding(4, 2, 4, 2);
            labelControl1.Name = "labelControl1";
            labelControl1.Size = new Size(228, 28);
            labelControl1.TabIndex = 0;
            labelControl1.Text = "Διαθέσιμες Υπηρεσίες :";
            // 
            // panelControl5
            // 
            panelControl5.Controls.Add(AddedServicesFlowLayout);
            panelControl5.Controls.Add(panelControl3);
            panelControl5.Dock = DockStyle.Fill;
            panelControl5.Location = new Point(0, 0);
            panelControl5.Margin = new Padding(4, 2, 4, 2);
            panelControl5.Name = "panelControl5";
            panelControl5.Size = new Size(495, 392);
            panelControl5.TabIndex = 6;
            // 
            // panelControl3
            // 
            panelControl3.Controls.Add(servicesInOrderLabel);
            panelControl3.Dock = DockStyle.Top;
            panelControl3.Location = new Point(2, 2);
            panelControl3.Margin = new Padding(4, 2, 4, 2);
            panelControl3.Name = "panelControl3";
            panelControl3.Size = new Size(491, 55);
            panelControl3.TabIndex = 2;
            // 
            // servicesInOrderLabel
            // 
            servicesInOrderLabel.Appearance.Font = new Font("Tahoma", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            servicesInOrderLabel.Appearance.Options.UseFont = true;
            servicesInOrderLabel.Location = new Point(15, 15);
            servicesInOrderLabel.Margin = new Padding(4, 2, 4, 2);
            servicesInOrderLabel.Name = "servicesInOrderLabel";
            servicesInOrderLabel.Size = new Size(120, 28);
            servicesInOrderLabel.TabIndex = 1;
            servicesInOrderLabel.Text = "Σύνολο: 0 €";
            // 
            // xtraScrollableControl1
            // 
            xtraScrollableControl1.Controls.Add(panelControl4);
            xtraScrollableControl1.Controls.Add(panelControl7);
            xtraScrollableControl1.Dock = DockStyle.Fill;
            xtraScrollableControl1.Location = new Point(0, 309);
            xtraScrollableControl1.Margin = new Padding(4);
            xtraScrollableControl1.Name = "xtraScrollableControl1";
            xtraScrollableControl1.Size = new Size(1366, 487);
            xtraScrollableControl1.TabIndex = 9;
            // 
            // panelControl7
            // 
            panelControl7.Controls.Add(xtraTabControl1);
            panelControl7.Controls.Add(panelControl8);
            panelControl7.Dock = DockStyle.Right;
            panelControl7.Location = new Point(865, 0);
            panelControl7.Name = "panelControl7";
            panelControl7.Size = new Size(501, 487);
            panelControl7.TabIndex = 7;
            // 
            // xtraTabControl1
            // 
            xtraTabControl1.Appearance.Options.UseFont = true;
            xtraTabControl1.Dock = DockStyle.Fill;
            xtraTabControl1.Location = new Point(2, 57);
            xtraTabControl1.Name = "xtraTabControl1";
            xtraTabControl1.SelectedTabPage = xtraTabPage1;
            xtraTabControl1.Size = new Size(497, 428);
            xtraTabControl1.TabIndex = 0;
            xtraTabControl1.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] { xtraTabPage1, xtraTabPage2 });
            // 
            // xtraTabPage1
            // 
            xtraTabPage1.Appearance.Header.Font = new Font("Tahoma", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            xtraTabPage1.Appearance.Header.Options.UseFont = true;
            xtraTabPage1.Appearance.HeaderActive.Font = new Font("Tahoma", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            xtraTabPage1.Appearance.HeaderActive.Options.UseFont = true;
            xtraTabPage1.Controls.Add(panelControl5);
            xtraTabPage1.Name = "xtraTabPage1";
            xtraTabPage1.Size = new Size(495, 392);
            xtraTabPage1.Text = "Κάρτα Υπηρεσίας";
            // 
            // xtraTabPage2
            // 
            xtraTabPage2.Appearance.Header.Font = new Font("Tahoma", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            xtraTabPage2.Appearance.Header.Options.UseFont = true;
            xtraTabPage2.Appearance.HeaderActive.Font = new Font("Tahoma", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            xtraTabPage2.Appearance.HeaderActive.Options.UseFont = true;
            xtraTabPage2.Controls.Add(panelControl1);
            xtraTabPage2.Name = "xtraTabPage2";
            xtraTabPage2.Size = new Size(495, 392);
            xtraTabPage2.Text = "Κάρτα Προϊόντα";
            // 
            // panelControl1
            // 
            panelControl1.Controls.Add(AddedProductsFlowLayout);
            panelControl1.Controls.Add(panelControl6);
            panelControl1.Dock = DockStyle.Fill;
            panelControl1.Location = new Point(0, 0);
            panelControl1.Name = "panelControl1";
            panelControl1.Size = new Size(495, 392);
            panelControl1.TabIndex = 10;
            // 
            // AddedProductsFlowLayout
            // 
            AddedProductsFlowLayout.Dock = DockStyle.Fill;
            AddedProductsFlowLayout.Location = new Point(2, 57);
            AddedProductsFlowLayout.Name = "AddedProductsFlowLayout";
            AddedProductsFlowLayout.Size = new Size(491, 333);
            AddedProductsFlowLayout.TabIndex = 1;
            // 
            // panelControl6
            // 
            panelControl6.Controls.Add(labelControl9);
            panelControl6.Dock = DockStyle.Top;
            panelControl6.Location = new Point(2, 2);
            panelControl6.Name = "panelControl6";
            panelControl6.Size = new Size(491, 55);
            panelControl6.TabIndex = 0;
            // 
            // labelControl9
            // 
            labelControl9.Appearance.Font = new Font("Tahoma", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            labelControl9.Appearance.Options.UseFont = true;
            labelControl9.Location = new Point(15, 15);
            labelControl9.Margin = new Padding(4, 2, 4, 2);
            labelControl9.Name = "labelControl9";
            labelControl9.Size = new Size(120, 28);
            labelControl9.TabIndex = 2;
            labelControl9.Text = "Σύνολο: 0 €";
            // 
            // panelControl8
            // 
            panelControl8.Controls.Add(totalPriceLabel);
            panelControl8.Dock = DockStyle.Top;
            panelControl8.Location = new Point(2, 2);
            panelControl8.Name = "panelControl8";
            panelControl8.Size = new Size(497, 55);
            panelControl8.TabIndex = 1;
            // 
            // totalPriceLabel
            // 
            totalPriceLabel.Appearance.Font = new Font("Tahoma", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            totalPriceLabel.Appearance.Options.UseFont = true;
            totalPriceLabel.Location = new Point(18, 15);
            totalPriceLabel.Margin = new Padding(4, 2, 4, 2);
            totalPriceLabel.Name = "totalPriceLabel";
            totalPriceLabel.Size = new Size(191, 28);
            totalPriceLabel.TabIndex = 2;
            totalPriceLabel.Text = "Σύνολο Κάρτα: 0 €";
            // 
            // workspaceManager1
            // 
            workspaceManager1.TargetControl = this;
            workspaceManager1.TransitionType = pushTransition1;
            // 
            // OrderForm
            // 
            AutoScaleDimensions = new SizeF(7F, 16F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1366, 796);
            Controls.Add(xtraScrollableControl1);
            Controls.Add(OrderHeaderPanel);
            Controls.Add(ribbon);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4, 2, 4, 2);
            Name = "OrderForm";
            Ribbon = ribbon;
            FormClosing += OrderForm_FormClosing;
            Load += OrderForm_Load;
            ((System.ComponentModel.ISupportInitialize)ribbon).EndInit();
            ((System.ComponentModel.ISupportInitialize)OrderHeaderPanel).EndInit();
            OrderHeaderPanel.ResumeLayout(false);
            OrderHeaderPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)lookUpEdit1.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)employeeBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)dateEdit1.Properties.CalendarTimeProperties).EndInit();
            ((System.ComponentModel.ISupportInitialize)dateEdit1.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)textEdit4.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)textEdit2.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)textEdit3.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)memoEdit1.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)textEdit1.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)panelControl4).EndInit();
            panelControl4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)panelControl2).EndInit();
            panelControl2.ResumeLayout(false);
            panelControl2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)panelControl5).EndInit();
            panelControl5.ResumeLayout(false);
            panelControl5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)panelControl3).EndInit();
            panelControl3.ResumeLayout(false);
            panelControl3.PerformLayout();
            xtraScrollableControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)panelControl7).EndInit();
            panelControl7.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)xtraTabControl1).EndInit();
            xtraTabControl1.ResumeLayout(false);
            xtraTabPage1.ResumeLayout(false);
            xtraTabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)panelControl1).EndInit();
            panelControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)panelControl6).EndInit();
            panelControl6.ResumeLayout(false);
            panelControl6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)panelControl8).EndInit();
            panelControl8.ResumeLayout(false);
            panelControl8.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbon;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraBars.BarButtonItem addOrderButton;
        private DevExpress.XtraBars.BarButtonItem cancelOrderButton;
        private DevExpress.XtraBars.BarButtonItem paymentButton;
        private DevExpress.XtraBars.BarButtonItem printButton;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup2;
        private DevExpress.XtraEditors.PanelControl OrderHeaderPanel;
        private FlowLayoutPanel AddedServicesFlowLayout;
        private DevExpress.XtraEditors.PanelControl panelControl4;
        private DevExpress.XtraEditors.PanelControl panelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.PanelControl panelControl5;
        private DevExpress.XtraEditors.PanelControl panelControl3;
        private DevExpress.XtraEditors.TextEdit textEdit1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.MemoEdit memoEdit1;
        private DevExpress.XtraEditors.DateEdit dateEdit1;
        private DevExpress.XtraEditors.LookUpEdit lookUpEdit1;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraBars.BarButtonItem closeButton;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup3;
        private DevExpress.XtraBars.BarButtonItem saveOrderButton;
        private FlowLayoutPanel ServicesFlowPanel;
        private DevExpress.XtraEditors.XtraScrollableControl xtraScrollableControl1;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private DevExpress.XtraEditors.TextEdit textEdit2;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.TextEdit textEdit4;
        private DevExpress.XtraEditors.LabelControl labelControl8;
        private DevExpress.XtraEditors.TextEdit textEdit3;
        private DevExpress.XtraBars.BarButtonItem barButtonItem1;
        private DevExpress.Utils.WorkspaceManager workspaceManager1;
        private BindingSource employeeBindingSource;
        private DevExpress.XtraBars.BarButtonItem addProductButton;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.PanelControl panelControl6;
        private DevExpress.XtraEditors.LabelControl labelControl9;
        private FlowLayoutPanel AddedProductsFlowLayout;
        private DevExpress.XtraTab.XtraTabControl xtraTabControl1;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage1;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage2;
        private DevExpress.XtraEditors.PanelControl panelControl7;
        private DevExpress.XtraEditors.PanelControl panelControl8;
        private DevExpress.XtraEditors.LabelControl servicesInOrderLabel;
        private DevExpress.XtraEditors.LabelControl totalPriceLabel;
    }
}