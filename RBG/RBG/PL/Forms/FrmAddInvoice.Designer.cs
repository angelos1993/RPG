﻿namespace RBG.PL.Forms
{
    partial class FrmAddInvoice
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvInvoiceItems = new DevComponents.DotNetBar.Controls.DataGridViewX();
            this.labelX3 = new DevComponents.DotNetBar.LabelX();
            this.dblInTotal = new DevComponents.Editors.DoubleInput();
            this.dblInPaid = new DevComponents.Editors.DoubleInput();
            this.labelX4 = new DevComponents.DotNetBar.LabelX();
            this.dblInRemaining = new DevComponents.Editors.DoubleInput();
            this.labelX5 = new DevComponents.DotNetBar.LabelX();
            this.pnlClient = new DevComponents.DotNetBar.Controls.GroupPanel();
            this.btnAddClient = new DevComponents.DotNetBar.ButtonX();
            this.dtInvoiceDate = new DevComponents.Editors.DateTimeAdv.DateTimeInput();
            this.labelX2 = new DevComponents.DotNetBar.LabelX();
            this.txtClientName = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelX1 = new DevComponents.DotNetBar.LabelX();
            this.pnlMaterial = new DevComponents.DotNetBar.Controls.GroupPanel();
            this.cmbMaterials = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.btnAddMaterial = new DevComponents.DotNetBar.ButtonX();
            this.btnInsertItem = new DevComponents.DotNetBar.ButtonX();
            this.dblInQuantity = new DevComponents.Editors.DoubleInput();
            this.labelX6 = new DevComponents.DotNetBar.LabelX();
            this.labelX7 = new DevComponents.DotNetBar.LabelX();
            this.btnClose = new DevComponents.DotNetBar.ButtonX();
            this.btnSave = new DevComponents.DotNetBar.ButtonX();
            this.btnDeleteItem = new DevComponents.DotNetBar.ButtonX();
            ((System.ComponentModel.ISupportInitialize)(this.ErrorProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInvoiceItems)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dblInTotal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dblInPaid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dblInRemaining)).BeginInit();
            this.pnlClient.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtInvoiceDate)).BeginInit();
            this.pnlMaterial.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dblInQuantity)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvInvoiceItems
            // 
            this.dgvInvoiceItems.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvInvoiceItems.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvInvoiceItems.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvInvoiceItems.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.dgvInvoiceItems.Location = new System.Drawing.Point(12, 136);
            this.dgvInvoiceItems.Name = "dgvInvoiceItems";
            this.dgvInvoiceItems.ReadOnly = true;
            this.dgvInvoiceItems.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dgvInvoiceItems.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvInvoiceItems.Size = new System.Drawing.Size(675, 318);
            this.dgvInvoiceItems.TabIndex = 9;
            // 
            // labelX3
            // 
            // 
            // 
            // 
            this.labelX3.BackgroundStyle.Class = "";
            this.labelX3.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX3.Location = new System.Drawing.Point(590, 463);
            this.labelX3.Name = "labelX3";
            this.labelX3.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.labelX3.Size = new System.Drawing.Size(97, 23);
            this.labelX3.TabIndex = 11;
            this.labelX3.Text = "السعر الإجمالي";
            // 
            // dblInTotal
            // 
            // 
            // 
            // 
            this.dblInTotal.BackgroundStyle.Class = "DateTimeInputBackground";
            this.dblInTotal.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.dblInTotal.ButtonFreeText.Shortcut = DevComponents.DotNetBar.eShortcut.F2;
            this.dblInTotal.Enabled = false;
            this.dblInTotal.Increment = 0.1D;
            this.dblInTotal.Location = new System.Drawing.Point(445, 460);
            this.dblInTotal.MinValue = 0D;
            this.dblInTotal.Name = "dblInTotal";
            this.dblInTotal.ShowUpDown = true;
            this.dblInTotal.Size = new System.Drawing.Size(150, 26);
            this.dblInTotal.TabIndex = 12;
            this.dblInTotal.ValueChanged += new System.EventHandler(this.dblInTotal_ValueChanged);
            // 
            // dblInPaid
            // 
            // 
            // 
            // 
            this.dblInPaid.BackgroundStyle.Class = "DateTimeInputBackground";
            this.dblInPaid.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.dblInPaid.ButtonFreeText.Shortcut = DevComponents.DotNetBar.eShortcut.F2;
            this.dblInPaid.Enabled = false;
            this.dblInPaid.Increment = 0.1D;
            this.dblInPaid.Location = new System.Drawing.Point(218, 460);
            this.dblInPaid.MinValue = 0D;
            this.dblInPaid.Name = "dblInPaid";
            this.dblInPaid.ShowUpDown = true;
            this.dblInPaid.Size = new System.Drawing.Size(150, 26);
            this.dblInPaid.TabIndex = 14;
            this.dblInPaid.ValueChanged += new System.EventHandler(this.dblInPaid_ValueChanged);
            // 
            // labelX4
            // 
            // 
            // 
            // 
            this.labelX4.BackgroundStyle.Class = "";
            this.labelX4.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX4.Location = new System.Drawing.Point(374, 460);
            this.labelX4.Name = "labelX4";
            this.labelX4.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.labelX4.Size = new System.Drawing.Size(54, 23);
            this.labelX4.TabIndex = 13;
            this.labelX4.Text = "المدفوع";
            // 
            // dblInRemaining
            // 
            // 
            // 
            // 
            this.dblInRemaining.BackgroundStyle.Class = "DateTimeInputBackground";
            this.dblInRemaining.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.dblInRemaining.ButtonFreeText.Shortcut = DevComponents.DotNetBar.eShortcut.F2;
            this.dblInRemaining.Enabled = false;
            this.dblInRemaining.Increment = 0.1D;
            this.dblInRemaining.Location = new System.Drawing.Point(12, 460);
            this.dblInRemaining.MinValue = 0D;
            this.dblInRemaining.Name = "dblInRemaining";
            this.dblInRemaining.ShowUpDown = true;
            this.dblInRemaining.Size = new System.Drawing.Size(150, 26);
            this.dblInRemaining.TabIndex = 16;
            // 
            // labelX5
            // 
            // 
            // 
            // 
            this.labelX5.BackgroundStyle.Class = "";
            this.labelX5.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX5.Location = new System.Drawing.Point(168, 460);
            this.labelX5.Name = "labelX5";
            this.labelX5.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.labelX5.Size = new System.Drawing.Size(44, 23);
            this.labelX5.TabIndex = 15;
            this.labelX5.Text = "الباقي";
            // 
            // pnlClient
            // 
            this.pnlClient.CanvasColor = System.Drawing.SystemColors.Control;
            this.pnlClient.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.pnlClient.Controls.Add(this.btnAddClient);
            this.pnlClient.Controls.Add(this.dtInvoiceDate);
            this.pnlClient.Controls.Add(this.labelX2);
            this.pnlClient.Controls.Add(this.txtClientName);
            this.pnlClient.Controls.Add(this.labelX1);
            this.pnlClient.Location = new System.Drawing.Point(12, 12);
            this.pnlClient.Name = "pnlClient";
            this.pnlClient.Size = new System.Drawing.Size(675, 56);
            // 
            // 
            // 
            this.pnlClient.Style.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.pnlClient.Style.BackColorGradientAngle = 90;
            this.pnlClient.Style.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.pnlClient.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.pnlClient.Style.BorderBottomWidth = 1;
            this.pnlClient.Style.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.pnlClient.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.pnlClient.Style.BorderLeftWidth = 1;
            this.pnlClient.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.pnlClient.Style.BorderRightWidth = 1;
            this.pnlClient.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.pnlClient.Style.BorderTopWidth = 1;
            this.pnlClient.Style.Class = "";
            this.pnlClient.Style.CornerDiameter = 4;
            this.pnlClient.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded;
            this.pnlClient.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center;
            this.pnlClient.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.pnlClient.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near;
            // 
            // 
            // 
            this.pnlClient.StyleMouseDown.Class = "";
            this.pnlClient.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.pnlClient.StyleMouseOver.Class = "";
            this.pnlClient.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.pnlClient.TabIndex = 19;
            // 
            // btnAddClient
            // 
            this.btnAddClient.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnAddClient.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnAddClient.Image = global::RBG.Properties.Resources.Add;
            this.btnAddClient.ImageFixedSize = new System.Drawing.Size(20, 20);
            this.btnAddClient.Location = new System.Drawing.Point(249, 13);
            this.btnAddClient.Name = "btnAddClient";
            this.btnAddClient.Size = new System.Drawing.Size(25, 25);
            this.btnAddClient.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnAddClient.TabIndex = 22;
            this.btnAddClient.Click += new System.EventHandler(this.btnAddClient_Click);
            // 
            // dtInvoiceDate
            // 
            // 
            // 
            // 
            this.dtInvoiceDate.BackgroundStyle.Class = "DateTimeInputBackground";
            this.dtInvoiceDate.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.dtInvoiceDate.ButtonDropDown.Shortcut = DevComponents.DotNetBar.eShortcut.AltDown;
            this.dtInvoiceDate.ButtonDropDown.Visible = true;
            this.dtInvoiceDate.Location = new System.Drawing.Point(3, 12);
            // 
            // 
            // 
            this.dtInvoiceDate.MonthCalendar.AnnuallyMarkedDates = new System.DateTime[0];
            // 
            // 
            // 
            this.dtInvoiceDate.MonthCalendar.BackgroundStyle.BackColor = System.Drawing.SystemColors.Window;
            this.dtInvoiceDate.MonthCalendar.BackgroundStyle.Class = "";
            this.dtInvoiceDate.MonthCalendar.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.dtInvoiceDate.MonthCalendar.ClearButtonVisible = true;
            // 
            // 
            // 
            this.dtInvoiceDate.MonthCalendar.CommandsBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground2;
            this.dtInvoiceDate.MonthCalendar.CommandsBackgroundStyle.BackColorGradientAngle = 90;
            this.dtInvoiceDate.MonthCalendar.CommandsBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground;
            this.dtInvoiceDate.MonthCalendar.CommandsBackgroundStyle.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.dtInvoiceDate.MonthCalendar.CommandsBackgroundStyle.BorderTopColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarDockedBorder;
            this.dtInvoiceDate.MonthCalendar.CommandsBackgroundStyle.BorderTopWidth = 1;
            this.dtInvoiceDate.MonthCalendar.CommandsBackgroundStyle.Class = "";
            this.dtInvoiceDate.MonthCalendar.CommandsBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.dtInvoiceDate.MonthCalendar.DisplayMonth = new System.DateTime(2018, 2, 1, 0, 0, 0, 0);
            this.dtInvoiceDate.MonthCalendar.MarkedDates = new System.DateTime[0];
            this.dtInvoiceDate.MonthCalendar.MonthlyMarkedDates = new System.DateTime[0];
            // 
            // 
            // 
            this.dtInvoiceDate.MonthCalendar.NavigationBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.dtInvoiceDate.MonthCalendar.NavigationBackgroundStyle.BackColorGradientAngle = 90;
            this.dtInvoiceDate.MonthCalendar.NavigationBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.dtInvoiceDate.MonthCalendar.NavigationBackgroundStyle.Class = "";
            this.dtInvoiceDate.MonthCalendar.NavigationBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.dtInvoiceDate.MonthCalendar.TodayButtonVisible = true;
            this.dtInvoiceDate.MonthCalendar.WeeklyMarkedDays = new System.DayOfWeek[0];
            this.dtInvoiceDate.Name = "dtInvoiceDate";
            this.dtInvoiceDate.Size = new System.Drawing.Size(183, 26);
            this.dtInvoiceDate.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.dtInvoiceDate.TabIndex = 12;
            // 
            // labelX2
            // 
            this.labelX2.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX2.BackgroundStyle.Class = "";
            this.labelX2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX2.Location = new System.Drawing.Point(192, 12);
            this.labelX2.Name = "labelX2";
            this.labelX2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.labelX2.Size = new System.Drawing.Size(48, 23);
            this.labelX2.TabIndex = 11;
            this.labelX2.Text = "التاريخ";
            // 
            // txtClientName
            // 
            // 
            // 
            // 
            this.txtClientName.Border.Class = "TextBoxBorder";
            this.txtClientName.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtClientName.Location = new System.Drawing.Point(298, 12);
            this.txtClientName.Name = "txtClientName";
            this.txtClientName.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtClientName.Size = new System.Drawing.Size(271, 26);
            this.txtClientName.TabIndex = 9;
            // 
            // labelX1
            // 
            this.labelX1.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX1.BackgroundStyle.Class = "";
            this.labelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX1.Location = new System.Drawing.Point(575, 12);
            this.labelX1.Name = "labelX1";
            this.labelX1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.labelX1.Size = new System.Drawing.Size(86, 23);
            this.labelX1.TabIndex = 10;
            this.labelX1.Text = "اسم العميل";
            // 
            // pnlMaterial
            // 
            this.pnlMaterial.CanvasColor = System.Drawing.SystemColors.Control;
            this.pnlMaterial.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.pnlMaterial.Controls.Add(this.cmbMaterials);
            this.pnlMaterial.Controls.Add(this.btnAddMaterial);
            this.pnlMaterial.Controls.Add(this.btnInsertItem);
            this.pnlMaterial.Controls.Add(this.dblInQuantity);
            this.pnlMaterial.Controls.Add(this.labelX6);
            this.pnlMaterial.Controls.Add(this.labelX7);
            this.pnlMaterial.Location = new System.Drawing.Point(12, 74);
            this.pnlMaterial.Name = "pnlMaterial";
            this.pnlMaterial.Size = new System.Drawing.Size(675, 56);
            // 
            // 
            // 
            this.pnlMaterial.Style.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.pnlMaterial.Style.BackColorGradientAngle = 90;
            this.pnlMaterial.Style.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.pnlMaterial.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.pnlMaterial.Style.BorderBottomWidth = 1;
            this.pnlMaterial.Style.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.pnlMaterial.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.pnlMaterial.Style.BorderLeftWidth = 1;
            this.pnlMaterial.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.pnlMaterial.Style.BorderRightWidth = 1;
            this.pnlMaterial.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.pnlMaterial.Style.BorderTopWidth = 1;
            this.pnlMaterial.Style.Class = "";
            this.pnlMaterial.Style.CornerDiameter = 4;
            this.pnlMaterial.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded;
            this.pnlMaterial.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center;
            this.pnlMaterial.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.pnlMaterial.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near;
            // 
            // 
            // 
            this.pnlMaterial.StyleMouseDown.Class = "";
            this.pnlMaterial.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.pnlMaterial.StyleMouseOver.Class = "";
            this.pnlMaterial.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.pnlMaterial.TabIndex = 20;
            // 
            // cmbMaterials
            // 
            this.cmbMaterials.DisplayMember = "Text";
            this.cmbMaterials.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbMaterials.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbMaterials.FormattingEnabled = true;
            this.cmbMaterials.ItemHeight = 20;
            this.cmbMaterials.Location = new System.Drawing.Point(298, 12);
            this.cmbMaterials.Name = "cmbMaterials";
            this.cmbMaterials.Size = new System.Drawing.Size(271, 26);
            this.cmbMaterials.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.cmbMaterials.TabIndex = 24;
            // 
            // btnAddMaterial
            // 
            this.btnAddMaterial.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnAddMaterial.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnAddMaterial.Image = global::RBG.Properties.Resources.Add;
            this.btnAddMaterial.ImageFixedSize = new System.Drawing.Size(20, 20);
            this.btnAddMaterial.Location = new System.Drawing.Point(249, 13);
            this.btnAddMaterial.Name = "btnAddMaterial";
            this.btnAddMaterial.Size = new System.Drawing.Size(25, 25);
            this.btnAddMaterial.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnAddMaterial.TabIndex = 23;
            this.btnAddMaterial.Click += new System.EventHandler(this.btnAddMaterial_Click);
            // 
            // btnInsertItem
            // 
            this.btnInsertItem.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnInsertItem.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnInsertItem.Image = global::RBG.Properties.Resources.Insert;
            this.btnInsertItem.ImageFixedSize = new System.Drawing.Size(20, 20);
            this.btnInsertItem.Location = new System.Drawing.Point(24, 13);
            this.btnInsertItem.Name = "btnInsertItem";
            this.btnInsertItem.Size = new System.Drawing.Size(25, 25);
            this.btnInsertItem.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnInsertItem.TabIndex = 21;
            this.btnInsertItem.Click += new System.EventHandler(this.btnInsertItem_Click);
            // 
            // dblInQuantity
            // 
            // 
            // 
            // 
            this.dblInQuantity.BackgroundStyle.Class = "DateTimeInputBackground";
            this.dblInQuantity.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.dblInQuantity.ButtonFreeText.Shortcut = DevComponents.DotNetBar.eShortcut.F2;
            this.dblInQuantity.Increment = 0.1D;
            this.dblInQuantity.Location = new System.Drawing.Point(67, 12);
            this.dblInQuantity.MinValue = 0D;
            this.dblInQuantity.Name = "dblInQuantity";
            this.dblInQuantity.ShowUpDown = true;
            this.dblInQuantity.Size = new System.Drawing.Size(97, 26);
            this.dblInQuantity.TabIndex = 21;
            // 
            // labelX6
            // 
            this.labelX6.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX6.BackgroundStyle.Class = "";
            this.labelX6.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX6.Location = new System.Drawing.Point(176, 12);
            this.labelX6.Name = "labelX6";
            this.labelX6.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.labelX6.Size = new System.Drawing.Size(64, 23);
            this.labelX6.TabIndex = 11;
            this.labelX6.Text = "الكمية (م2)";
            // 
            // labelX7
            // 
            this.labelX7.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX7.BackgroundStyle.Class = "";
            this.labelX7.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX7.Location = new System.Drawing.Point(575, 12);
            this.labelX7.Name = "labelX7";
            this.labelX7.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.labelX7.Size = new System.Drawing.Size(86, 23);
            this.labelX7.TabIndex = 10;
            this.labelX7.Text = "المادة / الخامة";
            // 
            // btnClose
            // 
            this.btnClose.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnClose.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnClose.Image = global::RBG.Properties.Resources.Exit;
            this.btnClose.ImageFixedSize = new System.Drawing.Size(30, 30);
            this.btnClose.Location = new System.Drawing.Point(123, 497);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(130, 40);
            this.btnClose.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnClose.TabIndex = 18;
            this.btnClose.Text = "خروج";
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnSave
            // 
            this.btnSave.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnSave.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnSave.Image = global::RBG.Properties.Resources.Save;
            this.btnSave.ImageFixedSize = new System.Drawing.Size(30, 30);
            this.btnSave.Location = new System.Drawing.Point(259, 497);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(130, 40);
            this.btnSave.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnSave.TabIndex = 17;
            this.btnSave.Text = "حفظ";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnDeleteItem
            // 
            this.btnDeleteItem.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnDeleteItem.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnDeleteItem.Enabled = false;
            this.btnDeleteItem.Image = global::RBG.Properties.Resources.Delete;
            this.btnDeleteItem.ImageFixedSize = new System.Drawing.Size(30, 30);
            this.btnDeleteItem.Location = new System.Drawing.Point(395, 497);
            this.btnDeleteItem.Name = "btnDeleteItem";
            this.btnDeleteItem.Size = new System.Drawing.Size(180, 40);
            this.btnDeleteItem.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnDeleteItem.TabIndex = 21;
            this.btnDeleteItem.Text = "حذف المادة / الخامة";
            this.btnDeleteItem.Click += new System.EventHandler(this.btnDeleteItem_Click);
            // 
            // FrmAddInvoice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(699, 549);
            this.Controls.Add(this.btnDeleteItem);
            this.Controls.Add(this.pnlMaterial);
            this.Controls.Add(this.pnlClient);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.dblInRemaining);
            this.Controls.Add(this.labelX5);
            this.Controls.Add(this.dblInPaid);
            this.Controls.Add(this.labelX4);
            this.Controls.Add(this.dblInTotal);
            this.Controls.Add(this.labelX3);
            this.Controls.Add(this.dgvInvoiceItems);
            this.DoubleBuffered = true;
            this.Name = "FrmAddInvoice";
            this.Text = "فاتورة جديدة";
            this.Load += new System.EventHandler(this.FrmAddInvoice_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ErrorProvider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInvoiceItems)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dblInTotal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dblInPaid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dblInRemaining)).EndInit();
            this.pnlClient.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtInvoiceDate)).EndInit();
            this.pnlMaterial.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dblInQuantity)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private DevComponents.DotNetBar.Controls.DataGridViewX dgvInvoiceItems;
        private DevComponents.DotNetBar.LabelX labelX3;
        private DevComponents.Editors.DoubleInput dblInTotal;
        private DevComponents.Editors.DoubleInput dblInPaid;
        private DevComponents.DotNetBar.LabelX labelX4;
        private DevComponents.Editors.DoubleInput dblInRemaining;
        private DevComponents.DotNetBar.LabelX labelX5;
        private DevComponents.DotNetBar.ButtonX btnClose;
        private DevComponents.DotNetBar.ButtonX btnSave;
        private DevComponents.DotNetBar.Controls.GroupPanel pnlClient;
        private DevComponents.Editors.DateTimeAdv.DateTimeInput dtInvoiceDate;
        private DevComponents.DotNetBar.LabelX labelX2;
        private DevComponents.DotNetBar.Controls.TextBoxX txtClientName;
        private DevComponents.DotNetBar.LabelX labelX1;
        private DevComponents.DotNetBar.Controls.GroupPanel pnlMaterial;
        private DevComponents.Editors.DoubleInput dblInQuantity;
        private DevComponents.DotNetBar.LabelX labelX6;
        private DevComponents.DotNetBar.LabelX labelX7;
        private DevComponents.DotNetBar.ButtonX btnInsertItem;
        private DevComponents.DotNetBar.ButtonX btnAddClient;
        private DevComponents.DotNetBar.ButtonX btnAddMaterial;
        private DevComponents.DotNetBar.Controls.ComboBoxEx cmbMaterials;
        private DevComponents.DotNetBar.ButtonX btnDeleteItem;
    }
}