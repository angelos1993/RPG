namespace RPG.PL.Forms
{
    partial class FrmPayPurchaseInvoice
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvInvoices = new DevComponents.DotNetBar.Controls.DataGridViewX();
            this.btnClose = new DevComponents.DotNetBar.ButtonX();
            this.btnPay = new DevComponents.DotNetBar.ButtonX();
            this.btnShowInvoices = new DevComponents.DotNetBar.ButtonX();
            this.pnlClient = new DevComponents.DotNetBar.Controls.GroupPanel();
            this.txtSupplierName = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelX3 = new DevComponents.DotNetBar.LabelX();
            this.groupPanel1 = new DevComponents.DotNetBar.Controls.GroupPanel();
            this.dblInRemaining = new DevComponents.Editors.DoubleInput();
            this.labelX5 = new DevComponents.DotNetBar.LabelX();
            this.dblInPaid = new DevComponents.Editors.DoubleInput();
            this.labelX4 = new DevComponents.DotNetBar.LabelX();
            this.dblInTotal = new DevComponents.Editors.DoubleInput();
            this.labelX1 = new DevComponents.DotNetBar.LabelX();
            this.dtPaymentDate = new DevComponents.Editors.DateTimeAdv.DateTimeInput();
            this.labelX2 = new DevComponents.DotNetBar.LabelX();
            ((System.ComponentModel.ISupportInitialize)(this.ErrorProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInvoices)).BeginInit();
            this.pnlClient.SuspendLayout();
            this.groupPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dblInRemaining)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dblInPaid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dblInTotal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtPaymentDate)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvInvoices
            // 
            this.dgvInvoices.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvInvoices.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvInvoices.DefaultCellStyle = dataGridViewCellStyle1;
            this.dgvInvoices.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.dgvInvoices.Location = new System.Drawing.Point(12, 74);
            this.dgvInvoices.MultiSelect = false;
            this.dgvInvoices.Name = "dgvInvoices";
            this.dgvInvoices.ReadOnly = true;
            this.dgvInvoices.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dgvInvoices.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvInvoices.Size = new System.Drawing.Size(1000, 354);
            this.dgvInvoices.TabIndex = 25;
            this.dgvInvoices.DoubleClick += new System.EventHandler(this.dgvInvoices_DoubleClick);
            // 
            // btnClose
            // 
            this.btnClose.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnClose.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnClose.Image = global::RPG.Properties.Resources.Exit;
            this.btnClose.ImageFixedSize = new System.Drawing.Size(30, 30);
            this.btnClose.Location = new System.Drawing.Point(379, 496);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(130, 40);
            this.btnClose.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnClose.TabIndex = 4;
            this.btnClose.Text = "خروج";
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnPay
            // 
            this.btnPay.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnPay.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnPay.Enabled = false;
            this.btnPay.Image = global::RPG.Properties.Resources.Pay;
            this.btnPay.ImageFixedSize = new System.Drawing.Size(30, 30);
            this.btnPay.Location = new System.Drawing.Point(515, 496);
            this.btnPay.Name = "btnPay";
            this.btnPay.Size = new System.Drawing.Size(130, 40);
            this.btnPay.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnPay.TabIndex = 3;
            this.btnPay.Text = "دفع";
            this.btnPay.Click += new System.EventHandler(this.btnPay_Click);
            // 
            // btnShowInvoices
            // 
            this.btnShowInvoices.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnShowInvoices.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnShowInvoices.Image = global::RPG.Properties.Resources.Search;
            this.btnShowInvoices.ImageFixedSize = new System.Drawing.Size(20, 20);
            this.btnShowInvoices.Location = new System.Drawing.Point(369, 13);
            this.btnShowInvoices.Name = "btnShowInvoices";
            this.btnShowInvoices.Size = new System.Drawing.Size(203, 26);
            this.btnShowInvoices.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnShowInvoices.TabIndex = 1;
            this.btnShowInvoices.Text = "عرض الفواتير";
            this.btnShowInvoices.Click += new System.EventHandler(this.btnShowInvoices_Click);
            // 
            // pnlClient
            // 
            this.pnlClient.CanvasColor = System.Drawing.SystemColors.Control;
            this.pnlClient.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.pnlClient.Controls.Add(this.txtSupplierName);
            this.pnlClient.Controls.Add(this.labelX3);
            this.pnlClient.Controls.Add(this.btnShowInvoices);
            this.pnlClient.Location = new System.Drawing.Point(12, 12);
            this.pnlClient.Name = "pnlClient";
            this.pnlClient.Size = new System.Drawing.Size(1000, 56);
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
            this.pnlClient.TabIndex = 28;
            // 
            // txtSupplierName
            // 
            // 
            // 
            // 
            this.txtSupplierName.Border.Class = "TextBoxBorder";
            this.txtSupplierName.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtSupplierName.Location = new System.Drawing.Point(612, 13);
            this.txtSupplierName.Name = "txtSupplierName";
            this.txtSupplierName.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtSupplierName.Size = new System.Drawing.Size(271, 26);
            this.txtSupplierName.TabIndex = 0;
            // 
            // labelX3
            // 
            this.labelX3.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX3.BackgroundStyle.Class = "";
            this.labelX3.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX3.Location = new System.Drawing.Point(889, 13);
            this.labelX3.Name = "labelX3";
            this.labelX3.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.labelX3.Size = new System.Drawing.Size(86, 23);
            this.labelX3.TabIndex = 10;
            this.labelX3.Text = "اسم المُورد";
            // 
            // groupPanel1
            // 
            this.groupPanel1.CanvasColor = System.Drawing.SystemColors.Control;
            this.groupPanel1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.groupPanel1.Controls.Add(this.dblInRemaining);
            this.groupPanel1.Controls.Add(this.labelX5);
            this.groupPanel1.Controls.Add(this.dblInPaid);
            this.groupPanel1.Controls.Add(this.labelX4);
            this.groupPanel1.Controls.Add(this.dblInTotal);
            this.groupPanel1.Controls.Add(this.labelX1);
            this.groupPanel1.Controls.Add(this.dtPaymentDate);
            this.groupPanel1.Controls.Add(this.labelX2);
            this.groupPanel1.Location = new System.Drawing.Point(12, 434);
            this.groupPanel1.Name = "groupPanel1";
            this.groupPanel1.Size = new System.Drawing.Size(1000, 56);
            // 
            // 
            // 
            this.groupPanel1.Style.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.groupPanel1.Style.BackColorGradientAngle = 90;
            this.groupPanel1.Style.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.groupPanel1.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel1.Style.BorderBottomWidth = 1;
            this.groupPanel1.Style.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.groupPanel1.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel1.Style.BorderLeftWidth = 1;
            this.groupPanel1.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel1.Style.BorderRightWidth = 1;
            this.groupPanel1.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel1.Style.BorderTopWidth = 1;
            this.groupPanel1.Style.Class = "";
            this.groupPanel1.Style.CornerDiameter = 4;
            this.groupPanel1.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded;
            this.groupPanel1.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center;
            this.groupPanel1.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.groupPanel1.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near;
            // 
            // 
            // 
            this.groupPanel1.StyleMouseDown.Class = "";
            this.groupPanel1.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.groupPanel1.StyleMouseOver.Class = "";
            this.groupPanel1.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.groupPanel1.TabIndex = 29;
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
            this.dblInRemaining.Location = new System.Drawing.Point(3, 13);
            this.dblInRemaining.MinValue = 0D;
            this.dblInRemaining.Name = "dblInRemaining";
            this.dblInRemaining.ShowUpDown = true;
            this.dblInRemaining.Size = new System.Drawing.Size(150, 26);
            this.dblInRemaining.TabIndex = 20;
            // 
            // labelX5
            // 
            this.labelX5.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX5.BackgroundStyle.Class = "";
            this.labelX5.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX5.Location = new System.Drawing.Point(159, 14);
            this.labelX5.Name = "labelX5";
            this.labelX5.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.labelX5.Size = new System.Drawing.Size(36, 23);
            this.labelX5.TabIndex = 19;
            this.labelX5.Text = "باقي";
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
            this.dblInPaid.Location = new System.Drawing.Point(220, 13);
            this.dblInPaid.MinValue = 0D;
            this.dblInPaid.Name = "dblInPaid";
            this.dblInPaid.ShowUpDown = true;
            this.dblInPaid.Size = new System.Drawing.Size(150, 26);
            this.dblInPaid.TabIndex = 1;
            this.dblInPaid.ValueChanged += new System.EventHandler(this.dblInPaid_ValueChanged);
            // 
            // labelX4
            // 
            this.labelX4.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX4.BackgroundStyle.Class = "";
            this.labelX4.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX4.Location = new System.Drawing.Point(376, 16);
            this.labelX4.Name = "labelX4";
            this.labelX4.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.labelX4.Size = new System.Drawing.Size(36, 23);
            this.labelX4.TabIndex = 17;
            this.labelX4.Text = "دفع";
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
            this.dblInTotal.Location = new System.Drawing.Point(435, 13);
            this.dblInTotal.MinValue = 0D;
            this.dblInTotal.Name = "dblInTotal";
            this.dblInTotal.ShowUpDown = true;
            this.dblInTotal.Size = new System.Drawing.Size(150, 26);
            this.dblInTotal.TabIndex = 16;
            this.dblInTotal.ValueChanged += new System.EventHandler(this.dblInTotal_ValueChanged);
            // 
            // labelX1
            // 
            this.labelX1.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX1.BackgroundStyle.Class = "";
            this.labelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX1.Location = new System.Drawing.Point(591, 14);
            this.labelX1.Name = "labelX1";
            this.labelX1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.labelX1.Size = new System.Drawing.Size(56, 23);
            this.labelX1.TabIndex = 15;
            this.labelX1.Text = "الإجمالي";
            // 
            // dtPaymentDate
            // 
            // 
            // 
            // 
            this.dtPaymentDate.BackgroundStyle.Class = "DateTimeInputBackground";
            this.dtPaymentDate.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.dtPaymentDate.ButtonDropDown.Shortcut = DevComponents.DotNetBar.eShortcut.AltDown;
            this.dtPaymentDate.ButtonDropDown.Visible = true;
            this.dtPaymentDate.Location = new System.Drawing.Point(754, 14);
            // 
            // 
            // 
            this.dtPaymentDate.MonthCalendar.AnnuallyMarkedDates = new System.DateTime[0];
            // 
            // 
            // 
            this.dtPaymentDate.MonthCalendar.BackgroundStyle.BackColor = System.Drawing.SystemColors.Window;
            this.dtPaymentDate.MonthCalendar.BackgroundStyle.Class = "";
            this.dtPaymentDate.MonthCalendar.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.dtPaymentDate.MonthCalendar.ClearButtonVisible = true;
            // 
            // 
            // 
            this.dtPaymentDate.MonthCalendar.CommandsBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground2;
            this.dtPaymentDate.MonthCalendar.CommandsBackgroundStyle.BackColorGradientAngle = 90;
            this.dtPaymentDate.MonthCalendar.CommandsBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground;
            this.dtPaymentDate.MonthCalendar.CommandsBackgroundStyle.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.dtPaymentDate.MonthCalendar.CommandsBackgroundStyle.BorderTopColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarDockedBorder;
            this.dtPaymentDate.MonthCalendar.CommandsBackgroundStyle.BorderTopWidth = 1;
            this.dtPaymentDate.MonthCalendar.CommandsBackgroundStyle.Class = "";
            this.dtPaymentDate.MonthCalendar.CommandsBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.dtPaymentDate.MonthCalendar.DisplayMonth = new System.DateTime(2018, 2, 1, 0, 0, 0, 0);
            this.dtPaymentDate.MonthCalendar.MarkedDates = new System.DateTime[0];
            this.dtPaymentDate.MonthCalendar.MonthlyMarkedDates = new System.DateTime[0];
            // 
            // 
            // 
            this.dtPaymentDate.MonthCalendar.NavigationBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.dtPaymentDate.MonthCalendar.NavigationBackgroundStyle.BackColorGradientAngle = 90;
            this.dtPaymentDate.MonthCalendar.NavigationBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.dtPaymentDate.MonthCalendar.NavigationBackgroundStyle.Class = "";
            this.dtPaymentDate.MonthCalendar.NavigationBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.dtPaymentDate.MonthCalendar.TodayButtonVisible = true;
            this.dtPaymentDate.MonthCalendar.WeeklyMarkedDays = new System.DayOfWeek[0];
            this.dtPaymentDate.Name = "dtPaymentDate";
            this.dtPaymentDate.Size = new System.Drawing.Size(183, 26);
            this.dtPaymentDate.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.dtPaymentDate.TabIndex = 2;
            // 
            // labelX2
            // 
            this.labelX2.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX2.BackgroundStyle.Class = "";
            this.labelX2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX2.Location = new System.Drawing.Point(943, 14);
            this.labelX2.Name = "labelX2";
            this.labelX2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.labelX2.Size = new System.Drawing.Size(48, 23);
            this.labelX2.TabIndex = 13;
            this.labelX2.Text = "التاريخ";
            // 
            // FrmPayPurchaseInvoice
            // 
            this.AcceptButton = this.btnPay;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnClose;
            this.ClientSize = new System.Drawing.Size(1024, 548);
            this.Controls.Add(this.groupPanel1);
            this.Controls.Add(this.pnlClient);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnPay);
            this.Controls.Add(this.dgvInvoices);
            this.DoubleBuffered = true;
            this.Name = "FrmPayPurchaseInvoice";
            this.Text = "دفع";
            this.Load += new System.EventHandler(this.FrmPayInvoice_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ErrorProvider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInvoices)).EndInit();
            this.pnlClient.ResumeLayout(false);
            this.groupPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dblInRemaining)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dblInPaid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dblInTotal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtPaymentDate)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private DevComponents.DotNetBar.ButtonX btnShowInvoices;
        private DevComponents.DotNetBar.Controls.DataGridViewX dgvInvoices;
        private DevComponents.DotNetBar.ButtonX btnClose;
        private DevComponents.DotNetBar.ButtonX btnPay;
        private DevComponents.DotNetBar.Controls.GroupPanel pnlClient;
        private DevComponents.DotNetBar.Controls.TextBoxX txtSupplierName;
        private DevComponents.DotNetBar.LabelX labelX3;
        private DevComponents.DotNetBar.Controls.GroupPanel groupPanel1;
        private DevComponents.Editors.DateTimeAdv.DateTimeInput dtPaymentDate;
        private DevComponents.DotNetBar.LabelX labelX2;
        private DevComponents.Editors.DoubleInput dblInRemaining;
        private DevComponents.DotNetBar.LabelX labelX5;
        private DevComponents.Editors.DoubleInput dblInPaid;
        private DevComponents.DotNetBar.LabelX labelX4;
        private DevComponents.Editors.DoubleInput dblInTotal;
        private DevComponents.DotNetBar.LabelX labelX1;
    }
}