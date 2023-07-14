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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OrderForm));
            ribbon = new DevExpress.XtraBars.Ribbon.RibbonControl();
            addOrderButton = new DevExpress.XtraBars.BarButtonItem();
            cancelOrderButton = new DevExpress.XtraBars.BarButtonItem();
            paymentButton = new DevExpress.XtraBars.BarButtonItem();
            printButton = new DevExpress.XtraBars.BarButtonItem();
            closeButton = new DevExpress.XtraBars.BarButtonItem();
            saveOrderButton = new DevExpress.XtraBars.BarButtonItem();
            ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            ribbonPageGroup2 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            ribbonPageGroup3 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            OrderHeaderPanel = new DevExpress.XtraEditors.PanelControl();
            labelControl5 = new DevExpress.XtraEditors.LabelControl();
            labelControl4 = new DevExpress.XtraEditors.LabelControl();
            memoEdit1 = new DevExpress.XtraEditors.MemoEdit();
            dateEdit1 = new DevExpress.XtraEditors.DateEdit();
            lookUpEdit1 = new DevExpress.XtraEditors.LookUpEdit();
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
            labelControl6 = new DevExpress.XtraEditors.LabelControl();
            textEdit2 = new DevExpress.XtraEditors.TextEdit();
            labelControl7 = new DevExpress.XtraEditors.LabelControl();
            textEdit3 = new DevExpress.XtraEditors.TextEdit();
            labelControl8 = new DevExpress.XtraEditors.LabelControl();
            textEdit4 = new DevExpress.XtraEditors.TextEdit();
            ((System.ComponentModel.ISupportInitialize)ribbon).BeginInit();
            ((System.ComponentModel.ISupportInitialize)OrderHeaderPanel).BeginInit();
            OrderHeaderPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)memoEdit1.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dateEdit1.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dateEdit1.Properties.CalendarTimeProperties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)lookUpEdit1.Properties).BeginInit();
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
            ((System.ComponentModel.ISupportInitialize)textEdit2.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)textEdit3.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)textEdit4.Properties).BeginInit();
            SuspendLayout();
            // 
            // ribbon
            // 
            ribbon.ExpandCollapseItem.Id = 0;
            ribbon.Items.AddRange(new DevExpress.XtraBars.BarItem[] { ribbon.ExpandCollapseItem, ribbon.SearchEditItem, addOrderButton, cancelOrderButton, paymentButton, printButton, closeButton, saveOrderButton });
            ribbon.Location = new Point(0, 0);
            ribbon.Margin = new Padding(4, 2, 4, 2);
            ribbon.MaxItemId = 8;
            ribbon.Name = "ribbon";
            ribbon.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] { ribbonPage1 });
            ribbon.Size = new Size(1278, 193);
            // 
            // addOrderButton
            // 
            addOrderButton.Caption = "Add Order";
            addOrderButton.Id = 1;
            addOrderButton.ImageOptions.SvgImage = (DevExpress.Utils.Svg.SvgImage)resources.GetObject("addOrderButton.ImageOptions.SvgImage");
            addOrderButton.Name = "addOrderButton";
            addOrderButton.ItemClick += barButtonItem1_ItemClick;
            // 
            // cancelOrderButton
            // 
            cancelOrderButton.Caption = "Cancel Order";
            cancelOrderButton.Id = 2;
            cancelOrderButton.ImageOptions.SvgImage = (DevExpress.Utils.Svg.SvgImage)resources.GetObject("cancelOrderButton.ImageOptions.SvgImage");
            cancelOrderButton.Name = "cancelOrderButton";
            cancelOrderButton.ItemClick += barButtonItem2_ItemClick;
            // 
            // paymentButton
            // 
            paymentButton.Caption = "Payment";
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
            saveOrderButton.Caption = "Save Order";
            saveOrderButton.Id = 6;
            saveOrderButton.ImageOptions.SvgImage = (DevExpress.Utils.Svg.SvgImage)resources.GetObject("saveOrderButton.ImageOptions.SvgImage");
            saveOrderButton.Name = "saveOrderButton";
            saveOrderButton.ItemClick += saveOrderButton_ItemClick;
            // 
            // ribbonPage1
            // 
            ribbonPage1.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] { ribbonPageGroup1, ribbonPageGroup2, ribbonPageGroup3 });
            ribbonPage1.Name = "ribbonPage1";
            ribbonPage1.Text = "Order";
            // 
            // ribbonPageGroup1
            // 
            ribbonPageGroup1.ItemLinks.Add(addOrderButton);
            ribbonPageGroup1.ItemLinks.Add(saveOrderButton);
            ribbonPageGroup1.ItemLinks.Add(cancelOrderButton);
            ribbonPageGroup1.Name = "ribbonPageGroup1";
            // 
            // ribbonPageGroup2
            // 
            ribbonPageGroup2.ItemLinks.Add(paymentButton);
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
            OrderHeaderPanel.Controls.Add(textEdit4);
            OrderHeaderPanel.Controls.Add(labelControl8);
            OrderHeaderPanel.Controls.Add(textEdit3);
            OrderHeaderPanel.Controls.Add(labelControl7);
            OrderHeaderPanel.Controls.Add(textEdit2);
            OrderHeaderPanel.Controls.Add(labelControl6);
            OrderHeaderPanel.Controls.Add(labelControl5);
            OrderHeaderPanel.Controls.Add(labelControl4);
            OrderHeaderPanel.Controls.Add(memoEdit1);
            OrderHeaderPanel.Controls.Add(dateEdit1);
            OrderHeaderPanel.Controls.Add(lookUpEdit1);
            OrderHeaderPanel.Controls.Add(labelControl3);
            OrderHeaderPanel.Controls.Add(textEdit1);
            OrderHeaderPanel.Controls.Add(labelControl2);
            OrderHeaderPanel.Dock = DockStyle.Top;
            OrderHeaderPanel.Location = new Point(0, 193);
            OrderHeaderPanel.Margin = new Padding(4, 2, 4, 2);
            OrderHeaderPanel.Name = "OrderHeaderPanel";
            OrderHeaderPanel.Size = new Size(1278, 116);
            OrderHeaderPanel.TabIndex = 2;
            // 
            // labelControl5
            // 
            labelControl5.Appearance.Font = new Font("Tahoma", 10F, FontStyle.Regular, GraphicsUnit.Point);
            labelControl5.Appearance.Options.UseFont = true;
            labelControl5.Location = new Point(943, 4);
            labelControl5.Margin = new Padding(4, 4, 4, 4);
            labelControl5.Name = "labelControl5";
            labelControl5.Size = new Size(88, 21);
            labelControl5.TabIndex = 7;
            labelControl5.Text = "Σημειώσεις:";
            // 
            // labelControl4
            // 
            labelControl4.Appearance.Font = new Font("Tahoma", 10F, FontStyle.Regular, GraphicsUnit.Point);
            labelControl4.Appearance.Options.UseFont = true;
            labelControl4.Location = new Point(24, 77);
            labelControl4.Margin = new Padding(4, 4, 4, 4);
            labelControl4.Name = "labelControl4";
            labelControl4.Size = new Size(83, 21);
            labelControl4.TabIndex = 6;
            labelControl4.Text = "Order Date";
            // 
            // memoEdit1
            // 
            memoEdit1.Location = new Point(1039, 6);
            memoEdit1.Margin = new Padding(4, 4, 4, 4);
            memoEdit1.MenuManager = ribbon;
            memoEdit1.Name = "memoEdit1";
            memoEdit1.Size = new Size(233, 106);
            memoEdit1.TabIndex = 5;
            // 
            // dateEdit1
            // 
            dateEdit1.EditValue = null;
            dateEdit1.Location = new Point(115, 78);
            dateEdit1.Margin = new Padding(4, 4, 4, 4);
            dateEdit1.MenuManager = ribbon;
            dateEdit1.Name = "dateEdit1";
            dateEdit1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] { new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo) });
            dateEdit1.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] { new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo) });
            dateEdit1.Size = new Size(117, 22);
            dateEdit1.TabIndex = 4;
            dateEdit1.EditValueChanged += lookUpEdit1_EditValueChanged;
            // 
            // lookUpEdit1
            // 
            lookUpEdit1.Location = new Point(371, 15);
            lookUpEdit1.Margin = new Padding(4, 4, 4, 4);
            lookUpEdit1.MenuManager = ribbon;
            lookUpEdit1.Name = "lookUpEdit1";
            lookUpEdit1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] { new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo) });
            lookUpEdit1.Properties.NullText = "Select Customer";
            lookUpEdit1.Properties.PopupFilterMode = DevExpress.XtraEditors.PopupFilterMode.Contains;
            lookUpEdit1.Properties.SearchMode = DevExpress.XtraEditors.Controls.SearchMode.AutoSuggest;
            lookUpEdit1.Size = new Size(218, 22);
            lookUpEdit1.TabIndex = 3;
            lookUpEdit1.EditValueChanged += lookUpEdit1_EditValueChanged;
            // 
            // labelControl3
            // 
            labelControl3.Appearance.Font = new Font("Tahoma", 10F, FontStyle.Regular, GraphicsUnit.Point);
            labelControl3.Appearance.Options.UseFont = true;
            labelControl3.Location = new Point(276, 17);
            labelControl3.Margin = new Padding(4, 4, 4, 4);
            labelControl3.Name = "labelControl3";
            labelControl3.Size = new Size(79, 21);
            labelControl3.TabIndex = 2;
            labelControl3.Text = "ΕΠΩΝΥΜΟ";
            // 
            // textEdit1
            // 
            textEdit1.Enabled = false;
            textEdit1.Location = new Point(115, 18);
            textEdit1.Margin = new Padding(4, 4, 4, 4);
            textEdit1.MenuManager = ribbon;
            textEdit1.Name = "textEdit1";
            textEdit1.Size = new Size(117, 22);
            textEdit1.TabIndex = 1;
            // 
            // labelControl2
            // 
            labelControl2.Appearance.Font = new Font("Tahoma", 10F, FontStyle.Regular, GraphicsUnit.Point);
            labelControl2.Appearance.Options.UseFont = true;
            labelControl2.Location = new Point(24, 17);
            labelControl2.Margin = new Padding(4, 4, 4, 4);
            labelControl2.Name = "labelControl2";
            labelControl2.Size = new Size(60, 21);
            labelControl2.TabIndex = 0;
            labelControl2.Text = "OrderID";
            // 
            // AddedServicesFlowLayout
            // 
            AddedServicesFlowLayout.AutoScroll = true;
            AddedServicesFlowLayout.Dock = DockStyle.Fill;
            AddedServicesFlowLayout.FlowDirection = FlowDirection.TopDown;
            AddedServicesFlowLayout.Location = new Point(2, 57);
            AddedServicesFlowLayout.Margin = new Padding(4, 2, 4, 2);
            AddedServicesFlowLayout.Name = "AddedServicesFlowLayout";
            AddedServicesFlowLayout.Padding = new Padding(6, 6, 6, 6);
            AddedServicesFlowLayout.Size = new Size(436, 281);
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
            panelControl4.Size = new Size(838, 340);
            panelControl4.TabIndex = 6;
            // 
            // ServicesFlowPanel
            // 
            ServicesFlowPanel.AutoScroll = true;
            ServicesFlowPanel.Dock = DockStyle.Fill;
            ServicesFlowPanel.Location = new Point(2, 57);
            ServicesFlowPanel.Margin = new Padding(4, 4, 4, 4);
            ServicesFlowPanel.Name = "ServicesFlowPanel";
            ServicesFlowPanel.Padding = new Padding(12, 12, 12, 12);
            ServicesFlowPanel.Size = new Size(834, 281);
            ServicesFlowPanel.TabIndex = 3;
            // 
            // panelControl2
            // 
            panelControl2.Controls.Add(labelControl1);
            panelControl2.Dock = DockStyle.Top;
            panelControl2.Location = new Point(2, 2);
            panelControl2.Margin = new Padding(4, 2, 4, 2);
            panelControl2.Name = "panelControl2";
            panelControl2.Size = new Size(834, 55);
            panelControl2.TabIndex = 2;
            // 
            // labelControl1
            // 
            labelControl1.Appearance.Font = new Font("Tahoma", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            labelControl1.Appearance.Options.UseFont = true;
            labelControl1.Location = new Point(12, 15);
            labelControl1.Margin = new Padding(4, 2, 4, 2);
            labelControl1.Name = "labelControl1";
            labelControl1.Size = new Size(178, 28);
            labelControl1.TabIndex = 0;
            labelControl1.Text = "Available Services";
            // 
            // panelControl5
            // 
            panelControl5.Controls.Add(AddedServicesFlowLayout);
            panelControl5.Controls.Add(panelControl3);
            panelControl5.Dock = DockStyle.Right;
            panelControl5.Location = new Point(838, 0);
            panelControl5.Margin = new Padding(4, 2, 4, 2);
            panelControl5.Name = "panelControl5";
            panelControl5.Size = new Size(440, 340);
            panelControl5.TabIndex = 7;
            // 
            // panelControl3
            // 
            panelControl3.Controls.Add(servicesInOrderLabel);
            panelControl3.Dock = DockStyle.Top;
            panelControl3.Location = new Point(2, 2);
            panelControl3.Margin = new Padding(4, 2, 4, 2);
            panelControl3.Name = "panelControl3";
            panelControl3.Size = new Size(436, 55);
            panelControl3.TabIndex = 2;
            // 
            // servicesInOrderLabel
            // 
            servicesInOrderLabel.Appearance.Font = new Font("Tahoma", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            servicesInOrderLabel.Appearance.Options.UseFont = true;
            servicesInOrderLabel.Location = new Point(15, 15);
            servicesInOrderLabel.Margin = new Padding(4, 2, 4, 2);
            servicesInOrderLabel.Name = "servicesInOrderLabel";
            servicesInOrderLabel.Size = new Size(171, 28);
            servicesInOrderLabel.TabIndex = 1;
            servicesInOrderLabel.Text = "Services in Order";
            // 
            // xtraScrollableControl1
            // 
            xtraScrollableControl1.Controls.Add(panelControl4);
            xtraScrollableControl1.Controls.Add(panelControl5);
            xtraScrollableControl1.Dock = DockStyle.Fill;
            xtraScrollableControl1.Location = new Point(0, 309);
            xtraScrollableControl1.Margin = new Padding(4, 4, 4, 4);
            xtraScrollableControl1.Name = "xtraScrollableControl1";
            xtraScrollableControl1.Size = new Size(1278, 340);
            xtraScrollableControl1.TabIndex = 9;
            // 
            // labelControl6
            // 
            labelControl6.Appearance.Font = new Font("Tahoma", 10F, FontStyle.Regular, GraphicsUnit.Point);
            labelControl6.Appearance.Options.UseFont = true;
            labelControl6.Location = new Point(276, 79);
            labelControl6.Margin = new Padding(4);
            labelControl6.Name = "labelControl6";
            labelControl6.Size = new Size(59, 21);
            labelControl6.TabIndex = 8;
            labelControl6.Text = "ΟΝΟΜΑ";
            // 
            // textEdit2
            // 
            textEdit2.Location = new Point(371, 78);
            textEdit2.MenuManager = ribbon;
            textEdit2.Name = "textEdit2";
            textEdit2.Size = new Size(218, 22);
            textEdit2.TabIndex = 9;
            // 
            // labelControl7
            // 
            labelControl7.Appearance.Font = new Font("Tahoma", 10F, FontStyle.Regular, GraphicsUnit.Point);
            labelControl7.Appearance.Options.UseFont = true;
            labelControl7.Location = new Point(627, 17);
            labelControl7.Margin = new Padding(4);
            labelControl7.Name = "labelControl7";
            labelControl7.Size = new Size(37, 21);
            labelControl7.TabIndex = 10;
            labelControl7.Text = "ΤΗΛ.";
            // 
            // textEdit3
            // 
            textEdit3.Location = new Point(682, 18);
            textEdit3.MenuManager = ribbon;
            textEdit3.Name = "textEdit3";
            textEdit3.Size = new Size(218, 22);
            textEdit3.TabIndex = 11;
            // 
            // labelControl8
            // 
            labelControl8.Appearance.Font = new Font("Tahoma", 10F, FontStyle.Regular, GraphicsUnit.Point);
            labelControl8.Appearance.Options.UseFont = true;
            labelControl8.Location = new Point(627, 77);
            labelControl8.Margin = new Padding(4);
            labelControl8.Name = "labelControl8";
            labelControl8.Size = new Size(48, 21);
            labelControl8.TabIndex = 12;
            labelControl8.Text = "EMAIL";
            // 
            // textEdit4
            // 
            textEdit4.Location = new Point(682, 76);
            textEdit4.MenuManager = ribbon;
            textEdit4.Name = "textEdit4";
            textEdit4.Size = new Size(218, 22);
            textEdit4.TabIndex = 13;
            // 
            // OrderForm
            // 
            AutoScaleDimensions = new SizeF(7F, 16F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1278, 649);
            Controls.Add(xtraScrollableControl1);
            Controls.Add(OrderHeaderPanel);
            Controls.Add(ribbon);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4, 2, 4, 2);
            Name = "OrderForm";
            Ribbon = ribbon;
            Load += OrderForm_Load;
            ((System.ComponentModel.ISupportInitialize)ribbon).EndInit();
            ((System.ComponentModel.ISupportInitialize)OrderHeaderPanel).EndInit();
            OrderHeaderPanel.ResumeLayout(false);
            OrderHeaderPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)memoEdit1.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)dateEdit1.Properties.CalendarTimeProperties).EndInit();
            ((System.ComponentModel.ISupportInitialize)dateEdit1.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)lookUpEdit1.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)textEdit1.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)panelControl4).EndInit();
            panelControl4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)panelControl2).EndInit();
            panelControl2.ResumeLayout(false);
            panelControl2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)panelControl5).EndInit();
            panelControl5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)panelControl3).EndInit();
            panelControl3.ResumeLayout(false);
            panelControl3.PerformLayout();
            xtraScrollableControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)textEdit2.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)textEdit3.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)textEdit4.Properties).EndInit();
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
        private DevExpress.XtraEditors.LabelControl servicesInOrderLabel;
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
    }
}