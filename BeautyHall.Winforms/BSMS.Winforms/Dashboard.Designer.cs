﻿namespace Demo
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
<<<<<<< HEAD
            Νεος = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            Κωμμοτέ = new DevExpress.XtraBars.Navigation.AccordionControlElement();
=======
            accordionControlElement5 = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            accordionControlElement6 = new DevExpress.XtraBars.Navigation.AccordionControlElement();
>>>>>>> d5073bb563845b48499ac078516cf60c86a8ff84
            productAccordionItem = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            ΥπηΥ = new DevExpress.XtraBars.Navigation.AccordionControlElement();
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
            fluentDesignFormContainer1.Location = new Point(260, 31);
            fluentDesignFormContainer1.Name = "fluentDesignFormContainer1";
<<<<<<< HEAD
            fluentDesignFormContainer1.Size = new Size(893, 465);
=======
            fluentDesignFormContainer1.Size = new Size(1090, 673);
>>>>>>> d5073bb563845b48499ac078516cf60c86a8ff84
            fluentDesignFormContainer1.TabIndex = 0;
            // 
            // DisplayControl
            // 
            DisplayControl.AutoSize = true;
            DisplayControl.Dock = DockStyle.Fill;
            DisplayControl.Location = new Point(0, 0);
            DisplayControl.Margin = new Padding(0);
            DisplayControl.Name = "DisplayControl";
<<<<<<< HEAD
            DisplayControl.Size = new Size(893, 465);
=======
            DisplayControl.Size = new Size(1090, 673);
>>>>>>> d5073bb563845b48499ac078516cf60c86a8ff84
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
            accordionControl1.Location = new Point(0, 31);
            accordionControl1.Name = "accordionControl1";
            accordionControl1.ScrollBarMode = DevExpress.XtraBars.Navigation.ScrollBarMode.Touch;
            accordionControl1.ShowFilterControl = DevExpress.XtraBars.Navigation.ShowFilterControl.Auto;
<<<<<<< HEAD
            accordionControl1.Size = new Size(260, 465);
=======
            accordionControl1.Size = new Size(303, 673);
>>>>>>> d5073bb563845b48499ac078516cf60c86a8ff84
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
<<<<<<< HEAD
            accordionControlElement4.Elements.AddRange(new DevExpress.XtraBars.Navigation.AccordionControlElement[] { Νεος, Κωμμοτέ, productAccordionItem, ΥπηΥ });
=======
            accordionControlElement4.Elements.AddRange(new DevExpress.XtraBars.Navigation.AccordionControlElement[] { accordionControlElement5, accordionControlElement6, productAccordionItem });
>>>>>>> d5073bb563845b48499ac078516cf60c86a8ff84
            accordionControlElement4.Expanded = true;
            accordionControlElement4.Name = "accordionControlElement4";
            accordionControlElement4.Text = "ΕΓΓΡΑΦΕΣ";
            // 
            // Νεος
            // 
            Νεος.Name = "Νεος";
            Νεος.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            Νεος.Text = "Νέος Πελάτης";
            Νεος.Click += accordionControlElement5_Click;
            // 
<<<<<<< HEAD
            // Κωμμοτέ
            // 
            Κωμμοτέ.Name = "Κωμμοτέ";
            Κωμμοτέ.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            Κωμμοτέ.Text = "Κωμμοτές - Υπάλληλοι";
            Κωμμοτέ.Click += accordionControlElement6_Click;
=======
            // accordionControlElement6
            // 
            accordionControlElement6.Name = "accordionControlElement6";
            accordionControlElement6.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            accordionControlElement6.Text = "ΚΩΜΜΟΤΕΣ";
            accordionControlElement6.Click += accordionControlElement6_Click;
>>>>>>> d5073bb563845b48499ac078516cf60c86a8ff84
            // 
            // productAccordionItem
            // 
            productAccordionItem.Name = "productAccordionItem";
            productAccordionItem.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            productAccordionItem.Text = "Προιόντα - Α-Ύλες - Αναλώσιμα";
            productAccordionItem.Click += productAccordionItem_Click;
            // 
            // ΥπηΥ
            // 
            ΥπηΥ.Name = "ΥπηΥ";
            ΥπηΥ.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            ΥπηΥ.Text = "Υπηρεσίες - Τιμές";
            // 
            // accordionControlElement2
            // 
            accordionControlElement2.Elements.AddRange(new DevExpress.XtraBars.Navigation.AccordionControlElement[] { newOrderAccordionItem, accordionControlElement3 });
            accordionControlElement2.Expanded = true;
            accordionControlElement2.Name = "accordionControlElement2";
            accordionControlElement2.Text = "ΥΠΗΡΕΣΙΕΣ";
            // 
            // newOrderAccordionItem
            // 
            newOrderAccordionItem.Name = "newOrderAccordionItem";
            newOrderAccordionItem.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            newOrderAccordionItem.Text = "Νεα Υπηρεσία";
            newOrderAccordionItem.Click += newOrderAccordionItem_Click;
            // 
            // accordionControlElement3
            // 
            accordionControlElement3.Name = "accordionControlElement3";
            accordionControlElement3.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            accordionControlElement3.Text = "Διαχείριση Υπηρεσιών";
            accordionControlElement3.Click += accordionControlElement3_Click;
            // 
            // accordionControlElement8
            // 
            accordionControlElement8.Elements.AddRange(new DevExpress.XtraBars.Navigation.AccordionControlElement[] { accordionControlElement10, accordionControlElement9 });
            accordionControlElement8.Expanded = true;
            accordionControlElement8.Name = "accordionControlElement8";
            accordionControlElement8.Text = "ΣΤΑΤΙΣΤΙΚΑ";
            // 
            // accordionControlElement10
            // 
            accordionControlElement10.Name = "accordionControlElement10";
            accordionControlElement10.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            accordionControlElement10.Text = "Ημερήσιος Υπολογισμός Υπηρεσιών";
            // 
            // accordionControlElement9
            // 
            accordionControlElement9.Name = "accordionControlElement9";
            accordionControlElement9.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            accordionControlElement9.Text = "Ιστορικό";
            // 
            // fluentDesignFormControl1
            // 
            fluentDesignFormControl1.FluentDesignForm = this;
            fluentDesignFormControl1.Location = new Point(0, 0);
            fluentDesignFormControl1.Manager = fluentFormDefaultManager1;
            fluentDesignFormControl1.Name = "fluentDesignFormControl1";
<<<<<<< HEAD
            fluentDesignFormControl1.Size = new Size(1153, 31);
=======
            fluentDesignFormControl1.Size = new Size(1393, 39);
>>>>>>> d5073bb563845b48499ac078516cf60c86a8ff84
            fluentDesignFormControl1.TabIndex = 2;
            fluentDesignFormControl1.TabStop = false;
            // 
            // Dashboard
            // 
            AutoScaleDimensions = new SizeF(6F, 13F);
            AutoScaleMode = AutoScaleMode.Font;
<<<<<<< HEAD
            ClientSize = new Size(1153, 496);
=======
            ClientSize = new Size(1393, 712);
>>>>>>> d5073bb563845b48499ac078516cf60c86a8ff84
            ControlContainer = fluentDesignFormContainer1;
            Controls.Add(fluentDesignFormContainer1);
            Controls.Add(accordionControl1);
            Controls.Add(fluentDesignFormControl1);
            FluentDesignFormControl = fluentDesignFormControl1;
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
<<<<<<< HEAD
        private DevExpress.XtraBars.Navigation.AccordionControlElement Νεος;
        private DevExpress.XtraBars.Navigation.AccordionControlElement Κωμμοτέ;
=======
        private DevExpress.XtraBars.Navigation.AccordionControlElement accordionControlElement5;
        private DevExpress.XtraBars.Navigation.AccordionControlElement accordionControlElement6;
>>>>>>> d5073bb563845b48499ac078516cf60c86a8ff84
        private DevExpress.XtraBars.Navigation.AccordionControlElement productAccordionItem;
        private DevExpress.XtraBars.Navigation.AccordionControlElement newOrderAccordionItem;
        private DevExpress.XtraBars.Navigation.AccordionControlElement accordionControlElement3;
        private DevExpress.XtraBars.Navigation.AccordionControlElement accordionControlElement8;
        private DevExpress.XtraBars.Navigation.AccordionControlElement accordionControlElement10;
        private DevExpress.XtraBars.Navigation.AccordionControlElement accordionControlElement9;
        private DevExpress.XtraEditors.PanelControl DisplayControl;
        private DevExpress.XtraBars.Navigation.AccordionControlElement ΥπηΥ;
    }
}