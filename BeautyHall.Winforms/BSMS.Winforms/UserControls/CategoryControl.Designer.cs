﻿namespace Demo.UserControls
{
    partial class CategoryControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CategoryControl));
            labelServiceName = new DevExpress.XtraEditors.LabelControl();
            labelControl1 = new DevExpress.XtraEditors.LabelControl();
            lookUpEdit1 = new DevExpress.XtraEditors.LookUpEdit();
            simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            lookUpEdit2 = new DevExpress.XtraEditors.LookUpEdit();
            labelControl3 = new DevExpress.XtraEditors.LabelControl();
            labelControl4 = new DevExpress.XtraEditors.LabelControl();
            lookUpEdit3 = new DevExpress.XtraEditors.LookUpEdit();
            ((System.ComponentModel.ISupportInitialize)lookUpEdit1.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)lookUpEdit2.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)lookUpEdit3.Properties).BeginInit();
            SuspendLayout();
            // 
            // labelServiceName
            // 
            labelServiceName.Appearance.Font = new Font("Tahoma", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            labelServiceName.Appearance.Options.UseFont = true;
            labelServiceName.Location = new Point(80, 10);
            labelServiceName.Margin = new Padding(4);
            labelServiceName.Name = "labelServiceName";
            labelServiceName.Size = new Size(103, 31);
            labelServiceName.TabIndex = 0;
            labelServiceName.Text = "Category";
            // 
            // labelControl1
            // 
            labelControl1.Appearance.Font = new Font("Tahoma", 10.25F, FontStyle.Regular, GraphicsUnit.Point);
            labelControl1.Appearance.Options.UseFont = true;
            labelControl1.Location = new Point(13, 102);
            labelControl1.Margin = new Padding(4);
            labelControl1.Name = "labelControl1";
            labelControl1.Size = new Size(72, 21);
            labelControl1.TabIndex = 2;
            labelControl1.Text = "Employee";
            // 
            // lookUpEdit1
            // 
            lookUpEdit1.Location = new Point(106, 100);
            lookUpEdit1.Margin = new Padding(4);
            lookUpEdit1.Name = "lookUpEdit1";
            lookUpEdit1.Properties.Appearance.Font = new Font("Tahoma", 9.8F, FontStyle.Regular, GraphicsUnit.Point);
            lookUpEdit1.Properties.Appearance.Options.UseFont = true;
            lookUpEdit1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] { new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo) });
            lookUpEdit1.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] { new DevExpress.XtraEditors.Controls.LookUpColumnInfo("EmployeeName", "Employee Name", 99, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default), new DevExpress.XtraEditors.Controls.LookUpColumnInfo("EmployeeLastName", "Employee Last Name", 126, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default), new DevExpress.XtraEditors.Controls.LookUpColumnInfo("EmployeeRole", "Employee Role", 92, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default) });
            lookUpEdit1.Properties.DataSource = typeof(BeautyHall.Api.SDK.Responses.Employee);
            lookUpEdit1.Properties.DisplayMember = "EmployeeName";
            lookUpEdit1.Properties.NullText = "Select employee";
            lookUpEdit1.Properties.PopupFilterMode = DevExpress.XtraEditors.PopupFilterMode.Contains;
            lookUpEdit1.Properties.SearchMode = DevExpress.XtraEditors.Controls.SearchMode.AutoSuggest;
            lookUpEdit1.Properties.ValueMember = "EmployeeId";
            lookUpEdit1.Size = new Size(142, 26);
            lookUpEdit1.TabIndex = 3;
            // 
            // simpleButton1
            // 
            simpleButton1.ImageOptions.SvgImage = (DevExpress.Utils.Svg.SvgImage)resources.GetObject("simpleButton1.ImageOptions.SvgImage");
            simpleButton1.ImageOptions.SvgImageSize = new Size(20, 20);
            simpleButton1.Location = new Point(169, 141);
            simpleButton1.Margin = new Padding(4);
            simpleButton1.Name = "simpleButton1";
            simpleButton1.Size = new Size(79, 28);
            simpleButton1.TabIndex = 6;
            simpleButton1.Text = "Add";
            simpleButton1.Click += simpleButton1_Click;
            // 
            // lookUpEdit2
            // 
            lookUpEdit2.Location = new Point(106, 59);
            lookUpEdit2.Margin = new Padding(4);
            lookUpEdit2.Name = "lookUpEdit2";
            lookUpEdit2.Properties.Appearance.Font = new Font("Tahoma", 9.8F, FontStyle.Regular, GraphicsUnit.Point);
            lookUpEdit2.Properties.Appearance.Options.UseFont = true;
            lookUpEdit2.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] { new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo) });
            lookUpEdit2.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] { new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ServiceDescription", "Service Description", 117, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default) });
            lookUpEdit2.Properties.DataSource = typeof(BeautyHall.Api.SDK.Responses.Service);
            lookUpEdit2.Properties.DisplayMember = "ServiceDescription";
            lookUpEdit2.Properties.NullText = "Select service";
            lookUpEdit2.Properties.PopupFilterMode = DevExpress.XtraEditors.PopupFilterMode.Contains;
            lookUpEdit2.Properties.SearchMode = DevExpress.XtraEditors.Controls.SearchMode.AutoSuggest;
            lookUpEdit2.Properties.ValueMember = "ServiceId";
            lookUpEdit2.Size = new Size(142, 26);
            lookUpEdit2.TabIndex = 8;
            lookUpEdit2.EditValueChanged += lookUpEdit2_EditValueChanged;
            // 
            // labelControl3
            // 
            labelControl3.Appearance.Font = new Font("Tahoma", 10.25F, FontStyle.Regular, GraphicsUnit.Point);
            labelControl3.Appearance.Options.UseFont = true;
            labelControl3.Location = new Point(13, 62);
            labelControl3.Margin = new Padding(4);
            labelControl3.Name = "labelControl3";
            labelControl3.Size = new Size(53, 21);
            labelControl3.TabIndex = 7;
            labelControl3.Text = "Service";
            // 
            // labelControl4
            // 
            labelControl4.Appearance.Font = new Font("Tahoma", 12.25F, FontStyle.Regular, GraphicsUnit.Point);
            labelControl4.Appearance.Options.UseFont = true;
            labelControl4.Location = new Point(18, 142);
            labelControl4.Margin = new Padding(4);
            labelControl4.Name = "labelControl4";
            labelControl4.Size = new Size(11, 24);
            labelControl4.TabIndex = 9;
            labelControl4.Text = "€";
            // 
            // lookUpEdit3
            // 
            lookUpEdit3.Location = new Point(43, 141);
            lookUpEdit3.Name = "lookUpEdit3";
            lookUpEdit3.Properties.Appearance.Font = new Font("Tahoma", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            lookUpEdit3.Properties.Appearance.Options.UseFont = true;
            lookUpEdit3.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] { new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo) });
            lookUpEdit3.Properties.NullText = "0";
            lookUpEdit3.Size = new Size(115, 28);
            lookUpEdit3.TabIndex = 10;
            // 
            // CategoryControl
            // 
            Appearance.BackColor = Color.FromArgb(224, 224, 224);
            Appearance.Options.UseBackColor = true;
            AutoScaleDimensions = new SizeF(7F, 16F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(lookUpEdit3);
            Controls.Add(labelControl4);
            Controls.Add(lookUpEdit2);
            Controls.Add(labelControl3);
            Controls.Add(simpleButton1);
            Controls.Add(lookUpEdit1);
            Controls.Add(labelControl1);
            Controls.Add(labelServiceName);
            Margin = new Padding(4);
            Name = "CategoryControl";
            Size = new Size(263, 181);
            Load += ServiceControl_Load;
            ((System.ComponentModel.ISupportInitialize)lookUpEdit1.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)lookUpEdit2.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)lookUpEdit3.Properties).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DevExpress.XtraEditors.LabelControl labelServiceName;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LookUpEdit lookUpEdit1;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private DevExpress.XtraEditors.LookUpEdit lookUpEdit2;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LookUpEdit lookUpEdit3;
    }
}
