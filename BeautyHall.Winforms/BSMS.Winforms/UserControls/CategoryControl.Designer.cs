namespace BSMS.UserControls
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CategoryControl));
            labelServiceName = new DevExpress.XtraEditors.LabelControl();
            lookUpEdit1 = new DevExpress.XtraEditors.LookUpEdit();
            employeeBindingSource = new BindingSource(components);
            simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            lookUpEdit2 = new DevExpress.XtraEditors.LookUpEdit();
            lookUpEdit3 = new DevExpress.XtraEditors.LookUpEdit();
            ((System.ComponentModel.ISupportInitialize)lookUpEdit1.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)employeeBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)lookUpEdit2.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)lookUpEdit3.Properties).BeginInit();
            SuspendLayout();
            // 
            // labelServiceName
            // 
            labelServiceName.Appearance.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point);
            labelServiceName.Appearance.Options.UseFont = true;
            labelServiceName.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            labelServiceName.Location = new Point(5, 9);
            labelServiceName.Margin = new Padding(4);
            labelServiceName.Name = "labelServiceName";
            labelServiceName.Size = new Size(82, 26);
            labelServiceName.TabIndex = 0;
            labelServiceName.Text = "Category";
            // 
            // lookUpEdit1
            // 
            lookUpEdit1.Location = new Point(350, 11);
            lookUpEdit1.Margin = new Padding(4);
            lookUpEdit1.Name = "lookUpEdit1";
            lookUpEdit1.Properties.Appearance.Font = new Font("Tahoma", 9.8F, FontStyle.Regular, GraphicsUnit.Point);
            lookUpEdit1.Properties.Appearance.Options.UseFont = true;
            lookUpEdit1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] { new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo) });
            lookUpEdit1.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] { new DevExpress.XtraEditors.Controls.LookUpColumnInfo("EmployeeCode", "Code", 50, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Default, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default), new DevExpress.XtraEditors.Controls.LookUpColumnInfo("EmployeeName", "Name", 99, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default), new DevExpress.XtraEditors.Controls.LookUpColumnInfo("EmployeeLastName", "Surname", 126, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default) });
            lookUpEdit1.Properties.DataSource = employeeBindingSource;
            lookUpEdit1.Properties.DisplayMember = "EmployeeCode";
            lookUpEdit1.Properties.NullText = "Κωδ.";
            lookUpEdit1.Properties.PopupFilterMode = DevExpress.XtraEditors.PopupFilterMode.Contains;
            lookUpEdit1.Properties.SearchMode = DevExpress.XtraEditors.Controls.SearchMode.AutoSuggest;
            lookUpEdit1.Properties.ValueMember = "EmployeeId";
            lookUpEdit1.Size = new Size(88, 26);
            lookUpEdit1.TabIndex = 3;
            // 
            // employeeBindingSource
            // 
            employeeBindingSource.DataSource = typeof(Winforms.Models.Employee);
            // 
            // simpleButton1
            // 
            simpleButton1.ImageOptions.SvgImage = (DevExpress.Utils.Svg.SvgImage)resources.GetObject("simpleButton1.ImageOptions.SvgImage");
            simpleButton1.ImageOptions.SvgImageSize = new Size(20, 20);
            simpleButton1.Location = new Point(544, 10);
            simpleButton1.Margin = new Padding(4);
            simpleButton1.Name = "simpleButton1";
            simpleButton1.Size = new Size(79, 29);
            simpleButton1.TabIndex = 6;
            simpleButton1.Text = "Add";
            simpleButton1.Click += simpleButton1_Click;
            // 
            // lookUpEdit2
            // 
            lookUpEdit2.Location = new Point(154, 11);
            lookUpEdit2.Margin = new Padding(4);
            lookUpEdit2.Name = "lookUpEdit2";
            lookUpEdit2.Properties.Appearance.Font = new Font("Tahoma", 9.8F, FontStyle.Regular, GraphicsUnit.Point);
            lookUpEdit2.Properties.Appearance.Options.UseFont = true;
            lookUpEdit2.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] { new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo) });
            lookUpEdit2.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] { new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ServiceDescription", "Service Description", 117, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default) });
            lookUpEdit2.Properties.DataSource = typeof(BeautyHall.Api.SDK.Responses.Service);
            lookUpEdit2.Properties.DisplayMember = "ServiceDescription";
            lookUpEdit2.Properties.NullText = "Επιλογή Υπηρεσίας";
            lookUpEdit2.Properties.PopupFilterMode = DevExpress.XtraEditors.PopupFilterMode.Contains;
            lookUpEdit2.Properties.SearchMode = DevExpress.XtraEditors.Controls.SearchMode.AutoSuggest;
            lookUpEdit2.Properties.ValueMember = "ServiceId";
            lookUpEdit2.Size = new Size(187, 26);
            lookUpEdit2.TabIndex = 8;
            lookUpEdit2.EditValueChanged += lookUpEdit2_EditValueChanged;
            // 
            // lookUpEdit3
            // 
            lookUpEdit3.Location = new Point(446, 11);
            lookUpEdit3.Margin = new Padding(4, 2, 4, 2);
            lookUpEdit3.Name = "lookUpEdit3";
            lookUpEdit3.Properties.Appearance.Font = new Font("Tahoma", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            lookUpEdit3.Properties.Appearance.Options.UseFont = true;
            lookUpEdit3.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] { new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo) });
            lookUpEdit3.Properties.DisplayFormat.FormatString = "c";
            lookUpEdit3.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            lookUpEdit3.Properties.EditFormat.FormatString = "c";
            lookUpEdit3.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            lookUpEdit3.Properties.NullText = "0";
            lookUpEdit3.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            lookUpEdit3.Size = new Size(90, 28);
            lookUpEdit3.TabIndex = 10;
            // 
            // CategoryControl
            // 
            Appearance.BackColor = Color.Gainsboro;
            Appearance.Options.UseBackColor = true;
            AutoScaleDimensions = new SizeF(7F, 16F);
            AutoScaleMode = AutoScaleMode.Font;
            BorderStyle = BorderStyle.Fixed3D;
            Controls.Add(lookUpEdit3);
            Controls.Add(lookUpEdit2);
            Controls.Add(simpleButton1);
            Controls.Add(lookUpEdit1);
            Controls.Add(labelServiceName);
            Margin = new Padding(6);
            Name = "CategoryControl";
            Size = new Size(633, 49);
            Load += ServiceControl_Load;
            ((System.ComponentModel.ISupportInitialize)lookUpEdit1.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)employeeBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)lookUpEdit2.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)lookUpEdit3.Properties).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DevExpress.XtraEditors.LabelControl labelServiceName;
        private DevExpress.XtraEditors.LookUpEdit lookUpEdit1;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private DevExpress.XtraEditors.LookUpEdit lookUpEdit2;
        private DevExpress.XtraEditors.LookUpEdit lookUpEdit3;
        private BindingSource employeeBindingSource;
    }
}
