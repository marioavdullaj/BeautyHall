namespace Demo
{
    partial class Dashboard
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
            DevExpress.XtraSplashScreen.SplashScreenManager splashScreenManager1 = new DevExpress.XtraSplashScreen.SplashScreenManager(this, typeof(LoadingScreen), true, true);
            fluentDesignFormContainer1 = new DevExpress.XtraBars.FluentDesignSystem.FluentDesignFormContainer();
            DisplayControl = new DevExpress.XtraEditors.PanelControl();
            fluentFormDefaultManager1 = new DevExpress.XtraBars.FluentDesignSystem.FluentFormDefaultManager(components);
            accordionControl1 = new DevExpress.XtraBars.Navigation.AccordionControl();
            usernameInfoElement = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            accordionControlElement4 = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            accordionControlElement5 = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            ΩΜΜΟΤΕΣΚ = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            productAccordionItem = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            accordionControlElement2 = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            newOrderAccordionItem = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            accordionControlElement3 = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            accordionControlElement8 = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            accordionControlElement10 = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            accordionControlElement9 = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            fluentDesignFormControl1 = new DevExpress.XtraBars.FluentDesignSystem.FluentDesignFormControl();
            fluentDesignFormContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DisplayControl).BeginInit();
            ((System.ComponentModel.ISupportInitialize)fluentFormDefaultManager1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)accordionControl1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)fluentDesignFormControl1).BeginInit();
            SuspendLayout();
            // 
            // splashScreenManager1
            // 
            splashScreenManager1.ClosingDelay = 500;
            // 
            // fluentDesignFormContainer1
            // 
            fluentDesignFormContainer1.Controls.Add(DisplayControl);
            fluentDesignFormContainer1.Dock = DockStyle.Fill;
            fluentDesignFormContainer1.Location = new Point(303, 39);
            fluentDesignFormContainer1.Margin = new Padding(4);
            fluentDesignFormContainer1.Name = "fluentDesignFormContainer1";
            fluentDesignFormContainer1.Size = new Size(1042, 571);
            fluentDesignFormContainer1.TabIndex = 0;
            // 
            // DisplayControl
            // 
            DisplayControl.AutoSize = true;
            DisplayControl.Dock = DockStyle.Fill;
            DisplayControl.Location = new Point(0, 0);
            DisplayControl.Margin = new Padding(0);
            DisplayControl.Name = "DisplayControl";
            DisplayControl.Size = new Size(1042, 571);
            DisplayControl.TabIndex = 0;
            // 
            // fluentFormDefaultManager1
            // 
            fluentFormDefaultManager1.Form = this;
            // 
            // accordionControl1
            // 
            accordionControl1.Dock = DockStyle.Left;
            accordionControl1.Elements.AddRange(new DevExpress.XtraBars.Navigation.AccordionControlElement[] { usernameInfoElement, accordionControlElement4, accordionControlElement2, accordionControlElement8 });
            accordionControl1.Location = new Point(0, 39);
            accordionControl1.Margin = new Padding(4);
            accordionControl1.Name = "accordionControl1";
            accordionControl1.ScrollBarMode = DevExpress.XtraBars.Navigation.ScrollBarMode.Touch;
            accordionControl1.ShowFilterControl = DevExpress.XtraBars.Navigation.ShowFilterControl.Auto;
            accordionControl1.Size = new Size(303, 571);
            accordionControl1.TabIndex = 1;
            accordionControl1.ViewType = DevExpress.XtraBars.Navigation.AccordionControlViewType.HamburgerMenu;
            accordionControl1.StateChanged += accordionControl1_StateChanged;
            // 
            // usernameInfoElement
            // 
            usernameInfoElement.Appearance.Default.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point);
            usernameInfoElement.Appearance.Default.Options.UseFont = true;
            usernameInfoElement.Expanded = true;
            usernameInfoElement.HeaderTemplate.AddRange(new DevExpress.XtraBars.Navigation.HeaderElementInfo[] { new DevExpress.XtraBars.Navigation.HeaderElementInfo(DevExpress.XtraBars.Navigation.HeaderElementType.Text), new DevExpress.XtraBars.Navigation.HeaderElementInfo(DevExpress.XtraBars.Navigation.HeaderElementType.Image), new DevExpress.XtraBars.Navigation.HeaderElementInfo(DevExpress.XtraBars.Navigation.HeaderElementType.HeaderControl), new DevExpress.XtraBars.Navigation.HeaderElementInfo(DevExpress.XtraBars.Navigation.HeaderElementType.ContextButtons) });
            usernameInfoElement.Name = "usernameInfoElement";
            usernameInfoElement.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            usernameInfoElement.Text = "Hello, {user}";
            usernameInfoElement.Click += usernameInfoElement_Click;
            // 
            // accordionControlElement4
            // 
            accordionControlElement4.Elements.AddRange(new DevExpress.XtraBars.Navigation.AccordionControlElement[] { accordionControlElement5, ΩΜΜΟΤΕΣΚ, productAccordionItem });
            accordionControlElement4.Expanded = true;
            accordionControlElement4.Name = "accordionControlElement4";
            accordionControlElement4.Text = "Registry";
            // 
            // accordionControlElement5
            // 
            accordionControlElement5.Name = "accordionControlElement5";
            accordionControlElement5.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            accordionControlElement5.Text = "ΠΕΛΑΤΕΣ";
            accordionControlElement5.Click += accordionControlElement5_Click;
            // 
            // ΩΜΜΟΤΕΣΚ
            // 
            ΩΜΜΟΤΕΣΚ.Name = "ΩΜΜΟΤΕΣΚ";
            ΩΜΜΟΤΕΣΚ.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            ΩΜΜΟΤΕΣΚ.Text = "ΚΩΜΜΟΤΕΣ";
            ΩΜΜΟΤΕΣΚ.Click += accordionControlElement6_Click;
            // 
            // productAccordionItem
            // 
            productAccordionItem.Name = "productAccordionItem";
            productAccordionItem.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            productAccordionItem.Text = "ΠΡΟΙΟΝΤΑ";
            productAccordionItem.Click += productAccordionItem_Click;
            // 
            // accordionControlElement2
            // 
            accordionControlElement2.Elements.AddRange(new DevExpress.XtraBars.Navigation.AccordionControlElement[] { newOrderAccordionItem, accordionControlElement3 });
            accordionControlElement2.Expanded = true;
            accordionControlElement2.Name = "accordionControlElement2";
            accordionControlElement2.Text = "Orders";
            // 
            // newOrderAccordionItem
            // 
            newOrderAccordionItem.Name = "newOrderAccordionItem";
            newOrderAccordionItem.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            newOrderAccordionItem.Text = "New Order";
            newOrderAccordionItem.Click += newOrderAccordionItem_Click;
            // 
            // accordionControlElement3
            // 
            accordionControlElement3.Name = "accordionControlElement3";
            accordionControlElement3.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            accordionControlElement3.Text = "Manage Orders";
            accordionControlElement3.Click += accordionControlElement3_Click;
            // 
            // accordionControlElement8
            // 
            accordionControlElement8.Elements.AddRange(new DevExpress.XtraBars.Navigation.AccordionControlElement[] { accordionControlElement10, accordionControlElement9 });
            accordionControlElement8.Expanded = true;
            accordionControlElement8.Name = "accordionControlElement8";
            accordionControlElement8.Text = "Summary";
            // 
            // accordionControlElement10
            // 
            accordionControlElement10.Name = "accordionControlElement10";
            accordionControlElement10.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            accordionControlElement10.Text = "Calculate Daily Summary";
            // 
            // accordionControlElement9
            // 
            accordionControlElement9.Name = "accordionControlElement9";
            accordionControlElement9.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            accordionControlElement9.Text = "View History";
            // 
            // fluentDesignFormControl1
            // 
            fluentDesignFormControl1.FluentDesignForm = this;
            fluentDesignFormControl1.Location = new Point(0, 0);
            fluentDesignFormControl1.Manager = fluentFormDefaultManager1;
            fluentDesignFormControl1.Margin = new Padding(4);
            fluentDesignFormControl1.Name = "fluentDesignFormControl1";
            fluentDesignFormControl1.Size = new Size(1345, 39);
            fluentDesignFormControl1.TabIndex = 2;
            fluentDesignFormControl1.TabStop = false;
            // 
            // Dashboard
            // 
            AutoScaleDimensions = new SizeF(7F, 16F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1345, 610);
            ControlContainer = fluentDesignFormContainer1;
            Controls.Add(fluentDesignFormContainer1);
            Controls.Add(accordionControl1);
            Controls.Add(fluentDesignFormControl1);
            FluentDesignFormControl = fluentDesignFormControl1;
            Margin = new Padding(4);
            Name = "Dashboard";
            NavigationControl = accordionControl1;
            Text = "Dashboard";
            FormClosed += OnFormClosed;
            Load += OnLoad;
            Resize += Dashboard_Resize;
            fluentDesignFormContainer1.ResumeLayout(false);
            fluentDesignFormContainer1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)DisplayControl).EndInit();
            ((System.ComponentModel.ISupportInitialize)fluentFormDefaultManager1).EndInit();
            ((System.ComponentModel.ISupportInitialize)accordionControl1).EndInit();
            ((System.ComponentModel.ISupportInitialize)fluentDesignFormControl1).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private DevExpress.XtraBars.FluentDesignSystem.FluentDesignFormContainer fluentDesignFormContainer1;
        private DevExpress.XtraBars.Navigation.AccordionControl accordionControl1;
        private DevExpress.XtraBars.FluentDesignSystem.FluentDesignFormControl fluentDesignFormControl1;
        private DevExpress.XtraBars.Navigation.AccordionControlElement usernameInfoElement;
        private DevExpress.XtraBars.FluentDesignSystem.FluentFormDefaultManager fluentFormDefaultManager1;
        private DevExpress.XtraBars.Navigation.AccordionControlElement accordionControlElement2;
        private DevExpress.XtraBars.Navigation.AccordionControlElement accordionControlElement4;
        private DevExpress.XtraBars.Navigation.AccordionControlElement accordionControlElement5;
        private DevExpress.XtraBars.Navigation.AccordionControlElement ΩΜΜΟΤΕΣΚ;
        private DevExpress.XtraBars.Navigation.AccordionControlElement productAccordionItem;
        private DevExpress.XtraBars.Navigation.AccordionControlElement newOrderAccordionItem;
        private DevExpress.XtraBars.Navigation.AccordionControlElement accordionControlElement3;
        private DevExpress.XtraBars.Navigation.AccordionControlElement accordionControlElement8;
        private DevExpress.XtraBars.Navigation.AccordionControlElement accordionControlElement10;
        private DevExpress.XtraBars.Navigation.AccordionControlElement accordionControlElement9;
        private DevExpress.XtraEditors.PanelControl DisplayControl;
    }
}