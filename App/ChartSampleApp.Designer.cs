namespace BubbleChartSample.App
{
    partial class ChartSampleApp
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ChartSampleApp));
            this.TechnologyGroupBorder = new System.Windows.Forms.GroupBox();
            this.GroupNameList = new System.Windows.Forms.ListBox();
            this.BubbleChartBorder = new System.Windows.Forms.GroupBox();
            this.LowCapacityHighSeniorityLabel = new System.Windows.Forms.Label();
            this.LowCapacityLowSeniorityLabel = new System.Windows.Forms.Label();
            this.HighCapacityHighSeniorityLabel = new System.Windows.Forms.Label();
            this.HighCapacityLowSeniorityLabel = new System.Windows.Forms.Label();
            this.BubbleChartPicture = new System.Windows.Forms.PictureBox();
            this.HeaderBorder = new System.Windows.Forms.GroupBox();
            this.RunInteropExcel = new System.Windows.Forms.Button();
            this.CollorPatternGroupBorder = new System.Windows.Forms.GroupBox();
            this.CollorPatternCombo = new System.Windows.Forms.ComboBox();
            this.ChartStyleGroupBorder = new System.Windows.Forms.GroupBox();
            this.ChartStyleCombo = new System.Windows.Forms.ComboBox();
            this.ExcelApplicationGroupBorder = new System.Windows.Forms.GroupBox();
            this.DisplayAlertsCheckBox = new System.Windows.Forms.CheckBox();
            this.IsVisibleCheckBox = new System.Windows.Forms.CheckBox();
            this.CloseAfterCompleteCheckBox = new System.Windows.Forms.CheckBox();
            this.TechnologyGroupBorder.SuspendLayout();
            this.BubbleChartBorder.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BubbleChartPicture)).BeginInit();
            this.HeaderBorder.SuspendLayout();
            this.CollorPatternGroupBorder.SuspendLayout();
            this.ChartStyleGroupBorder.SuspendLayout();
            this.ExcelApplicationGroupBorder.SuspendLayout();
            this.SuspendLayout();
            // 
            // TechnologyGroupBorder
            // 
            this.TechnologyGroupBorder.Controls.Add(this.GroupNameList);
            this.TechnologyGroupBorder.Location = new System.Drawing.Point(11, 155);
            this.TechnologyGroupBorder.Name = "TechnologyGroupBorder";
            this.TechnologyGroupBorder.Size = new System.Drawing.Size(212, 106);
            this.TechnologyGroupBorder.TabIndex = 2;
            this.TechnologyGroupBorder.TabStop = false;
            this.TechnologyGroupBorder.Text = "Technology Groups:";
            // 
            // GroupNameList
            // 
            this.GroupNameList.FormattingEnabled = true;
            this.GroupNameList.Location = new System.Drawing.Point(16, 26);
            this.GroupNameList.Name = "GroupNameList";
            this.GroupNameList.Size = new System.Drawing.Size(179, 69);
            this.GroupNameList.TabIndex = 2;
            // 
            // BubbleChartBorder
            // 
            this.BubbleChartBorder.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BubbleChartBorder.Controls.Add(this.LowCapacityHighSeniorityLabel);
            this.BubbleChartBorder.Controls.Add(this.LowCapacityLowSeniorityLabel);
            this.BubbleChartBorder.Controls.Add(this.HighCapacityHighSeniorityLabel);
            this.BubbleChartBorder.Controls.Add(this.HighCapacityLowSeniorityLabel);
            this.BubbleChartBorder.Controls.Add(this.BubbleChartPicture);
            this.BubbleChartBorder.Location = new System.Drawing.Point(241, 12);
            this.BubbleChartBorder.Name = "BubbleChartBorder";
            this.BubbleChartBorder.Size = new System.Drawing.Size(586, 385);
            this.BubbleChartBorder.TabIndex = 3;
            this.BubbleChartBorder.TabStop = false;
            this.BubbleChartBorder.Text = "Bubble Chart Sample:";
            // 
            // LowCapacityHighSeniorityLabel
            // 
            this.LowCapacityHighSeniorityLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.LowCapacityHighSeniorityLabel.Location = new System.Drawing.Point(379, 356);
            this.LowCapacityHighSeniorityLabel.Name = "LowCapacityHighSeniorityLabel";
            this.LowCapacityHighSeniorityLabel.Size = new System.Drawing.Size(176, 13);
            this.LowCapacityHighSeniorityLabel.TabIndex = 4;
            this.LowCapacityHighSeniorityLabel.Text = "Low Capacity | High Seniority ----->";
            this.LowCapacityHighSeniorityLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LowCapacityLowSeniorityLabel
            // 
            this.LowCapacityLowSeniorityLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.LowCapacityLowSeniorityLabel.Location = new System.Drawing.Point(51, 356);
            this.LowCapacityLowSeniorityLabel.Name = "LowCapacityLowSeniorityLabel";
            this.LowCapacityLowSeniorityLabel.Size = new System.Drawing.Size(172, 13);
            this.LowCapacityLowSeniorityLabel.TabIndex = 3;
            this.LowCapacityLowSeniorityLabel.Text = "<----- Low Capacity | Low Seniority";
            this.LowCapacityLowSeniorityLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // HighCapacityHighSeniorityLabel
            // 
            this.HighCapacityHighSeniorityLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.HighCapacityHighSeniorityLabel.Location = new System.Drawing.Point(379, 31);
            this.HighCapacityHighSeniorityLabel.Name = "HighCapacityHighSeniorityLabel";
            this.HighCapacityHighSeniorityLabel.Size = new System.Drawing.Size(174, 13);
            this.HighCapacityHighSeniorityLabel.TabIndex = 2;
            this.HighCapacityHighSeniorityLabel.Text = "High Capacity | High Seniority ----->";
            this.HighCapacityHighSeniorityLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // HighCapacityLowSeniorityLabel
            // 
            this.HighCapacityLowSeniorityLabel.Location = new System.Drawing.Point(51, 31);
            this.HighCapacityLowSeniorityLabel.Name = "HighCapacityLowSeniorityLabel";
            this.HighCapacityLowSeniorityLabel.Size = new System.Drawing.Size(174, 13);
            this.HighCapacityLowSeniorityLabel.TabIndex = 1;
            this.HighCapacityLowSeniorityLabel.Text = "<----- High Capacity | Low Seniority ";
            this.HighCapacityLowSeniorityLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // BubbleChartPicture
            // 
            this.BubbleChartPicture.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BubbleChartPicture.InitialImage = ((System.Drawing.Image)(resources.GetObject("BubbleChartPicture.InitialImage")));
            this.BubbleChartPicture.Location = new System.Drawing.Point(18, 47);
            this.BubbleChartPicture.Name = "BubbleChartPicture";
            this.BubbleChartPicture.Size = new System.Drawing.Size(548, 306);
            this.BubbleChartPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.BubbleChartPicture.TabIndex = 0;
            this.BubbleChartPicture.TabStop = false;
            // 
            // HeaderBorder
            // 
            this.HeaderBorder.Controls.Add(this.RunInteropExcel);
            this.HeaderBorder.Location = new System.Drawing.Point(12, 12);
            this.HeaderBorder.Name = "HeaderBorder";
            this.HeaderBorder.Size = new System.Drawing.Size(212, 55);
            this.HeaderBorder.TabIndex = 4;
            this.HeaderBorder.TabStop = false;
            // 
            // RunInteropExcel
            // 
            this.RunInteropExcel.Location = new System.Drawing.Point(16, 19);
            this.RunInteropExcel.Name = "RunInteropExcel";
            this.RunInteropExcel.Size = new System.Drawing.Size(179, 23);
            this.RunInteropExcel.TabIndex = 1;
            this.RunInteropExcel.Text = "Run Excel Interop";
            this.RunInteropExcel.UseVisualStyleBackColor = true;
            this.RunInteropExcel.Click += new System.EventHandler(this.RunInteropExcel_Click);
            // 
            // CollorPatternGroupBorder
            // 
            this.CollorPatternGroupBorder.Controls.Add(this.CollorPatternCombo);
            this.CollorPatternGroupBorder.Location = new System.Drawing.Point(11, 335);
            this.CollorPatternGroupBorder.Name = "CollorPatternGroupBorder";
            this.CollorPatternGroupBorder.Size = new System.Drawing.Size(212, 62);
            this.CollorPatternGroupBorder.TabIndex = 5;
            this.CollorPatternGroupBorder.TabStop = false;
            this.CollorPatternGroupBorder.Text = "Collor Pattern:";
            // 
            // CollorPatternCombo
            // 
            this.CollorPatternCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CollorPatternCombo.FormattingEnabled = true;
            this.CollorPatternCombo.Location = new System.Drawing.Point(17, 26);
            this.CollorPatternCombo.Name = "CollorPatternCombo";
            this.CollorPatternCombo.Size = new System.Drawing.Size(178, 21);
            this.CollorPatternCombo.TabIndex = 0;
            // 
            // ChartStyleGroupBorder
            // 
            this.ChartStyleGroupBorder.Controls.Add(this.ChartStyleCombo);
            this.ChartStyleGroupBorder.Location = new System.Drawing.Point(12, 267);
            this.ChartStyleGroupBorder.Name = "ChartStyleGroupBorder";
            this.ChartStyleGroupBorder.Size = new System.Drawing.Size(212, 62);
            this.ChartStyleGroupBorder.TabIndex = 6;
            this.ChartStyleGroupBorder.TabStop = false;
            this.ChartStyleGroupBorder.Text = "Chart Style:";
            // 
            // ChartStyleCombo
            // 
            this.ChartStyleCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ChartStyleCombo.FormattingEnabled = true;
            this.ChartStyleCombo.Location = new System.Drawing.Point(17, 26);
            this.ChartStyleCombo.Name = "ChartStyleCombo";
            this.ChartStyleCombo.Size = new System.Drawing.Size(178, 21);
            this.ChartStyleCombo.TabIndex = 0;
            // 
            // ExcelApplicationGroupBorder
            // 
            this.ExcelApplicationGroupBorder.Controls.Add(this.DisplayAlertsCheckBox);
            this.ExcelApplicationGroupBorder.Controls.Add(this.IsVisibleCheckBox);
            this.ExcelApplicationGroupBorder.Controls.Add(this.CloseAfterCompleteCheckBox);
            this.ExcelApplicationGroupBorder.Location = new System.Drawing.Point(12, 73);
            this.ExcelApplicationGroupBorder.Name = "ExcelApplicationGroupBorder";
            this.ExcelApplicationGroupBorder.Size = new System.Drawing.Size(212, 76);
            this.ExcelApplicationGroupBorder.TabIndex = 9;
            this.ExcelApplicationGroupBorder.TabStop = false;
            this.ExcelApplicationGroupBorder.Text = "Excel Application:";
            // 
            // DisplayAlertsCheckBox
            // 
            this.DisplayAlertsCheckBox.AutoSize = true;
            this.DisplayAlertsCheckBox.Checked = true;
            this.DisplayAlertsCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.DisplayAlertsCheckBox.Location = new System.Drawing.Point(88, 26);
            this.DisplayAlertsCheckBox.Name = "DisplayAlertsCheckBox";
            this.DisplayAlertsCheckBox.Size = new System.Drawing.Size(89, 17);
            this.DisplayAlertsCheckBox.TabIndex = 11;
            this.DisplayAlertsCheckBox.Text = "Display Alerts";
            this.DisplayAlertsCheckBox.UseVisualStyleBackColor = true;
            // 
            // IsVisibleCheckBox
            // 
            this.IsVisibleCheckBox.AutoSize = true;
            this.IsVisibleCheckBox.Checked = true;
            this.IsVisibleCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.IsVisibleCheckBox.Location = new System.Drawing.Point(15, 26);
            this.IsVisibleCheckBox.Name = "IsVisibleCheckBox";
            this.IsVisibleCheckBox.Size = new System.Drawing.Size(67, 17);
            this.IsVisibleCheckBox.TabIndex = 10;
            this.IsVisibleCheckBox.Text = "Is Visible";
            this.IsVisibleCheckBox.UseVisualStyleBackColor = true;
            // 
            // CloseAfterCompleteCheckBox
            // 
            this.CloseAfterCompleteCheckBox.AutoSize = true;
            this.CloseAfterCompleteCheckBox.Checked = true;
            this.CloseAfterCompleteCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.CloseAfterCompleteCheckBox.Location = new System.Drawing.Point(15, 49);
            this.CloseAfterCompleteCheckBox.Name = "CloseAfterCompleteCheckBox";
            this.CloseAfterCompleteCheckBox.Size = new System.Drawing.Size(124, 17);
            this.CloseAfterCompleteCheckBox.TabIndex = 9;
            this.CloseAfterCompleteCheckBox.Text = "Close After Complete";
            this.CloseAfterCompleteCheckBox.UseVisualStyleBackColor = true;
            // 
            // ChartSampleApp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(839, 410);
            this.Controls.Add(this.ExcelApplicationGroupBorder);
            this.Controls.Add(this.ChartStyleGroupBorder);
            this.Controls.Add(this.CollorPatternGroupBorder);
            this.Controls.Add(this.HeaderBorder);
            this.Controls.Add(this.BubbleChartBorder);
            this.Controls.Add(this.TechnologyGroupBorder);
            this.KeyPreview = true;
            this.Name = "ChartSampleApp";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ChartSampleApp";
            this.Load += new System.EventHandler(this.ChartSampleApp_Load);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.ChartSampleApp_KeyUp);
            this.TechnologyGroupBorder.ResumeLayout(false);
            this.BubbleChartBorder.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.BubbleChartPicture)).EndInit();
            this.HeaderBorder.ResumeLayout(false);
            this.CollorPatternGroupBorder.ResumeLayout(false);
            this.ChartStyleGroupBorder.ResumeLayout(false);
            this.ExcelApplicationGroupBorder.ResumeLayout(false);
            this.ExcelApplicationGroupBorder.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox TechnologyGroupBorder;
        private System.Windows.Forms.ListBox GroupNameList;
        private System.Windows.Forms.GroupBox BubbleChartBorder;
        private System.Windows.Forms.PictureBox BubbleChartPicture;
        private System.Windows.Forms.GroupBox HeaderBorder;
        private System.Windows.Forms.Button RunInteropExcel;
        private System.Windows.Forms.Label LowCapacityHighSeniorityLabel;
        private System.Windows.Forms.Label LowCapacityLowSeniorityLabel;
        private System.Windows.Forms.Label HighCapacityHighSeniorityLabel;
        private System.Windows.Forms.Label HighCapacityLowSeniorityLabel;
        private System.Windows.Forms.GroupBox CollorPatternGroupBorder;
        private System.Windows.Forms.ComboBox CollorPatternCombo;
        private System.Windows.Forms.GroupBox ChartStyleGroupBorder;
        private System.Windows.Forms.ComboBox ChartStyleCombo;
        private System.Windows.Forms.GroupBox ExcelApplicationGroupBorder;
        private System.Windows.Forms.CheckBox IsVisibleCheckBox;
        private System.Windows.Forms.CheckBox CloseAfterCompleteCheckBox;
        private System.Windows.Forms.CheckBox DisplayAlertsCheckBox;
    }
}