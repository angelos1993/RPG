namespace RBG.PL.Forms
{
    partial class FrmInvoices
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
            this.dgvInvoices = new DevComponents.DotNetBar.Controls.DataGridViewX();
            this.btnClose = new DevComponents.DotNetBar.ButtonX();
            this.txtClientName = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelX1 = new DevComponents.DotNetBar.LabelX();
            this.pnlDate = new DevComponents.DotNetBar.Controls.GroupPanel();
            this.dtInvoiceDate = new DevComponents.Editors.DateTimeAdv.DateTimeInput();
            this.radSpesificDate = new System.Windows.Forms.RadioButton();
            this.radThisMonth = new System.Windows.Forms.RadioButton();
            this.radThisDay = new System.Windows.Forms.RadioButton();
            this.pnlInvoiceState = new DevComponents.DotNetBar.Controls.GroupPanel();
            this.radRemainingInvoices = new System.Windows.Forms.RadioButton();
            this.radPaidInvoices = new System.Windows.Forms.RadioButton();
            this.radAllInvoices = new System.Windows.Forms.RadioButton();
            this.pnlClient = new DevComponents.DotNetBar.Controls.GroupPanel();
            ((System.ComponentModel.ISupportInitialize)(this.ErrorProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInvoices)).BeginInit();
            this.pnlDate.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtInvoiceDate)).BeginInit();
            this.pnlInvoiceState.SuspendLayout();
            this.pnlClient.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvInvoices
            // 
            this.dgvInvoices.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvInvoices.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvInvoices.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvInvoices.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.dgvInvoices.Location = new System.Drawing.Point(12, 93);
            this.dgvInvoices.Name = "dgvInvoices";
            this.dgvInvoices.ReadOnly = true;
            this.dgvInvoices.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dgvInvoices.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvInvoices.Size = new System.Drawing.Size(1000, 499);
            this.dgvInvoices.TabIndex = 10;
            this.dgvInvoices.DoubleClick += new System.EventHandler(this.dgvInvoices_DoubleClick);
            // 
            // btnClose
            // 
            this.btnClose.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnClose.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnClose.Image = global::RBG.Properties.Resources.Exit;
            this.btnClose.ImageFixedSize = new System.Drawing.Size(30, 30);
            this.btnClose.Location = new System.Drawing.Point(447, 598);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(130, 40);
            this.btnClose.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnClose.TabIndex = 19;
            this.btnClose.Text = "خروج";
            // 
            // txtClientName
            // 
            // 
            // 
            // 
            this.txtClientName.Border.Class = "TextBoxBorder";
            this.txtClientName.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtClientName.Location = new System.Drawing.Point(3, 10);
            this.txtClientName.Name = "txtClientName";
            this.txtClientName.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtClientName.Size = new System.Drawing.Size(274, 26);
            this.txtClientName.TabIndex = 9;
            this.txtClientName.TextChanged += new System.EventHandler(this.txtClientName_TextChanged);
            // 
            // labelX1
            // 
            this.labelX1.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX1.BackgroundStyle.Class = "";
            this.labelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX1.Location = new System.Drawing.Point(269, 10);
            this.labelX1.Name = "labelX1";
            this.labelX1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.labelX1.Size = new System.Drawing.Size(73, 23);
            this.labelX1.TabIndex = 10;
            this.labelX1.Text = "اسم العميل";
            // 
            // pnlDate
            // 
            this.pnlDate.CanvasColor = System.Drawing.SystemColors.Control;
            this.pnlDate.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.pnlDate.Controls.Add(this.dtInvoiceDate);
            this.pnlDate.Controls.Add(this.radSpesificDate);
            this.pnlDate.Controls.Add(this.radThisMonth);
            this.pnlDate.Controls.Add(this.radThisDay);
            this.pnlDate.Location = new System.Drawing.Point(272, 12);
            this.pnlDate.Name = "pnlDate";
            this.pnlDate.Size = new System.Drawing.Size(383, 75);
            // 
            // 
            // 
            this.pnlDate.Style.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.pnlDate.Style.BackColorGradientAngle = 90;
            this.pnlDate.Style.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.pnlDate.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.pnlDate.Style.BorderBottomWidth = 1;
            this.pnlDate.Style.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.pnlDate.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.pnlDate.Style.BorderLeftWidth = 1;
            this.pnlDate.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.pnlDate.Style.BorderRightWidth = 1;
            this.pnlDate.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.pnlDate.Style.BorderTopWidth = 1;
            this.pnlDate.Style.Class = "";
            this.pnlDate.Style.CornerDiameter = 4;
            this.pnlDate.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded;
            this.pnlDate.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center;
            this.pnlDate.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.pnlDate.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near;
            // 
            // 
            // 
            this.pnlDate.StyleMouseDown.Class = "";
            this.pnlDate.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.pnlDate.StyleMouseOver.Class = "";
            this.pnlDate.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.pnlDate.TabIndex = 21;
            this.pnlDate.Text = "بحث بالتاريخ";
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
            this.dtInvoiceDate.Location = new System.Drawing.Point(9, 10);
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
            this.dtInvoiceDate.Size = new System.Drawing.Size(129, 26);
            this.dtInvoiceDate.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.dtInvoiceDate.TabIndex = 13;
            this.dtInvoiceDate.ValueChanged += new System.EventHandler(this.dtInvoiceDate_ValueChanged);
            // 
            // radSpesificDate
            // 
            this.radSpesificDate.AutoSize = true;
            this.radSpesificDate.BackColor = System.Drawing.Color.Transparent;
            this.radSpesificDate.Location = new System.Drawing.Point(144, 10);
            this.radSpesificDate.Name = "radSpesificDate";
            this.radSpesificDate.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.radSpesificDate.Size = new System.Drawing.Size(83, 24);
            this.radSpesificDate.TabIndex = 3;
            this.radSpesificDate.Text = "تاريخ معين";
            this.radSpesificDate.UseVisualStyleBackColor = false;
            this.radSpesificDate.CheckedChanged += new System.EventHandler(this.radInvoiceDate_CheckedChanged);
            // 
            // radThisMonth
            // 
            this.radThisMonth.AutoSize = true;
            this.radThisMonth.BackColor = System.Drawing.Color.Transparent;
            this.radThisMonth.Location = new System.Drawing.Point(233, 10);
            this.radThisMonth.Name = "radThisMonth";
            this.radThisMonth.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.radThisMonth.Size = new System.Drawing.Size(77, 24);
            this.radThisMonth.TabIndex = 2;
            this.radThisMonth.Text = "هذا الشهر";
            this.radThisMonth.UseVisualStyleBackColor = false;
            this.radThisMonth.CheckedChanged += new System.EventHandler(this.radInvoiceDate_CheckedChanged);
            // 
            // radThisDay
            // 
            this.radThisDay.AutoSize = true;
            this.radThisDay.BackColor = System.Drawing.Color.Transparent;
            this.radThisDay.Location = new System.Drawing.Point(316, 10);
            this.radThisDay.Name = "radThisDay";
            this.radThisDay.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.radThisDay.Size = new System.Drawing.Size(50, 24);
            this.radThisDay.TabIndex = 1;
            this.radThisDay.Text = "اليوم";
            this.radThisDay.UseVisualStyleBackColor = false;
            this.radThisDay.CheckedChanged += new System.EventHandler(this.radInvoiceDate_CheckedChanged);
            // 
            // pnlInvoiceState
            // 
            this.pnlInvoiceState.CanvasColor = System.Drawing.SystemColors.Control;
            this.pnlInvoiceState.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.pnlInvoiceState.Controls.Add(this.radRemainingInvoices);
            this.pnlInvoiceState.Controls.Add(this.radPaidInvoices);
            this.pnlInvoiceState.Controls.Add(this.radAllInvoices);
            this.pnlInvoiceState.Location = new System.Drawing.Point(12, 12);
            this.pnlInvoiceState.Name = "pnlInvoiceState";
            this.pnlInvoiceState.Size = new System.Drawing.Size(254, 75);
            // 
            // 
            // 
            this.pnlInvoiceState.Style.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.pnlInvoiceState.Style.BackColorGradientAngle = 90;
            this.pnlInvoiceState.Style.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.pnlInvoiceState.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.pnlInvoiceState.Style.BorderBottomWidth = 1;
            this.pnlInvoiceState.Style.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.pnlInvoiceState.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.pnlInvoiceState.Style.BorderLeftWidth = 1;
            this.pnlInvoiceState.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.pnlInvoiceState.Style.BorderRightWidth = 1;
            this.pnlInvoiceState.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.pnlInvoiceState.Style.BorderTopWidth = 1;
            this.pnlInvoiceState.Style.Class = "";
            this.pnlInvoiceState.Style.CornerDiameter = 4;
            this.pnlInvoiceState.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded;
            this.pnlInvoiceState.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center;
            this.pnlInvoiceState.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.pnlInvoiceState.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near;
            // 
            // 
            // 
            this.pnlInvoiceState.StyleMouseDown.Class = "";
            this.pnlInvoiceState.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.pnlInvoiceState.StyleMouseOver.Class = "";
            this.pnlInvoiceState.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.pnlInvoiceState.TabIndex = 22;
            this.pnlInvoiceState.Text = "بحث بحالة الفاتورة";
            // 
            // radRemainingInvoices
            // 
            this.radRemainingInvoices.AutoSize = true;
            this.radRemainingInvoices.BackColor = System.Drawing.Color.Transparent;
            this.radRemainingInvoices.Location = new System.Drawing.Point(3, 10);
            this.radRemainingInvoices.Name = "radRemainingInvoices";
            this.radRemainingInvoices.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.radRemainingInvoices.Size = new System.Drawing.Size(118, 24);
            this.radRemainingInvoices.TabIndex = 2;
            this.radRemainingInvoices.Text = "غير خالص (باقي)";
            this.radRemainingInvoices.UseVisualStyleBackColor = false;
            this.radRemainingInvoices.CheckedChanged += new System.EventHandler(this.radInvoiceState_CheckedChanged);
            // 
            // radPaidInvoices
            // 
            this.radPaidInvoices.AutoSize = true;
            this.radPaidInvoices.BackColor = System.Drawing.Color.Transparent;
            this.radPaidInvoices.Location = new System.Drawing.Point(127, 10);
            this.radPaidInvoices.Name = "radPaidInvoices";
            this.radPaidInvoices.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.radPaidInvoices.Size = new System.Drawing.Size(59, 24);
            this.radPaidInvoices.TabIndex = 1;
            this.radPaidInvoices.Text = "خالص";
            this.radPaidInvoices.UseVisualStyleBackColor = false;
            this.radPaidInvoices.CheckedChanged += new System.EventHandler(this.radInvoiceState_CheckedChanged);
            // 
            // radAllInvoices
            // 
            this.radAllInvoices.AutoSize = true;
            this.radAllInvoices.BackColor = System.Drawing.Color.Transparent;
            this.radAllInvoices.Checked = true;
            this.radAllInvoices.Location = new System.Drawing.Point(192, 10);
            this.radAllInvoices.Name = "radAllInvoices";
            this.radAllInvoices.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.radAllInvoices.Size = new System.Drawing.Size(48, 24);
            this.radAllInvoices.TabIndex = 0;
            this.radAllInvoices.TabStop = true;
            this.radAllInvoices.Text = "الكل";
            this.radAllInvoices.UseVisualStyleBackColor = false;
            this.radAllInvoices.CheckedChanged += new System.EventHandler(this.radInvoiceState_CheckedChanged);
            // 
            // pnlClient
            // 
            this.pnlClient.CanvasColor = System.Drawing.SystemColors.Control;
            this.pnlClient.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.pnlClient.Controls.Add(this.txtClientName);
            this.pnlClient.Controls.Add(this.labelX1);
            this.pnlClient.Location = new System.Drawing.Point(661, 12);
            this.pnlClient.Name = "pnlClient";
            this.pnlClient.Size = new System.Drawing.Size(351, 75);
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
            this.pnlClient.TabIndex = 23;
            this.pnlClient.Text = "بحث بالعميل";
            // 
            // FrmInvoices
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1024, 650);
            this.Controls.Add(this.pnlClient);
            this.Controls.Add(this.pnlInvoiceState);
            this.Controls.Add(this.pnlDate);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.dgvInvoices);
            this.DoubleBuffered = true;
            this.Name = "FrmInvoices";
            this.Text = "كل الفواتير";
            this.Load += new System.EventHandler(this.FrmInvoices_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ErrorProvider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInvoices)).EndInit();
            this.pnlDate.ResumeLayout(false);
            this.pnlDate.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtInvoiceDate)).EndInit();
            this.pnlInvoiceState.ResumeLayout(false);
            this.pnlInvoiceState.PerformLayout();
            this.pnlClient.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.Controls.DataGridViewX dgvInvoices;
        private DevComponents.DotNetBar.ButtonX btnClose;
        private DevComponents.DotNetBar.Controls.TextBoxX txtClientName;
        private DevComponents.DotNetBar.LabelX labelX1;
        private DevComponents.DotNetBar.Controls.GroupPanel pnlDate;
        private DevComponents.DotNetBar.Controls.GroupPanel pnlInvoiceState;
        private DevComponents.DotNetBar.Controls.GroupPanel pnlClient;
        private System.Windows.Forms.RadioButton radRemainingInvoices;
        private System.Windows.Forms.RadioButton radPaidInvoices;
        private System.Windows.Forms.RadioButton radAllInvoices;
        private System.Windows.Forms.RadioButton radThisMonth;
        private System.Windows.Forms.RadioButton radThisDay;
        private System.Windows.Forms.RadioButton radSpesificDate;
        private DevComponents.Editors.DateTimeAdv.DateTimeInput dtInvoiceDate;
    }
}