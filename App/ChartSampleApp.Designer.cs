﻿namespace BubbleChartSample.App
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
            this.TechnologyGroupBorder.SuspendLayout();
            this.BubbleChartBorder.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BubbleChartPicture)).BeginInit();
            this.HeaderBorder.SuspendLayout();
            this.CollorPatternGroupBorder.SuspendLayout();
            this.ChartStyleGroupBorder.SuspendLayout();
            this.SuspendLayout();
            // 
            // TechnologyGroupBorder
            // 
            this.TechnologyGroupBorder.Controls.Add(this.GroupNameList);
            this.TechnologyGroupBorder.Location = new System.Drawing.Point(12, 73);
            this.TechnologyGroupBorder.Name = "TechnologyGroupBorder";
            this.TechnologyGroupBorder.Size = new System.Drawing.Size(212, 135);
            this.TechnologyGroupBorder.TabIndex = 2;
            this.TechnologyGroupBorder.TabStop = false;
            this.TechnologyGroupBorder.Text = "Technology Groups:";
            // 
            // GroupNameList
            // 
            this.GroupNameList.FormattingEnabled = true;
            this.GroupNameList.Location = new System.Drawing.Point(16, 26);
            this.GroupNameList.Name = "GroupNameList";
            this.GroupNameList.Size = new System.Drawing.Size(179, 95);
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
            this.BubbleChartBorder.Size = new System.Drawing.Size(482, 333);
            this.BubbleChartBorder.TabIndex = 3;
            this.BubbleChartBorder.TabStop = false;
            this.BubbleChartBorder.Text = "Bubble Chart Sample:";
            // 
            // LowCapacityHighSeniorityLabel
            // 
            this.LowCapacityHighSeniorityLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.LowCapacityHighSeniorityLabel.Location = new System.Drawing.Point(275, 304);
            this.LowCapacityHighSeniorityLabel.Name = "LowCapacityHighSeniorityLabel";
            this.LowCapacityHighSeniorityLabel.Size = new System.Drawing.Size(176, 13);
            this.LowCapacityHighSeniorityLabel.TabIndex = 4;
            this.LowCapacityHighSeniorityLabel.Text = "Low Capacity | High Seniority ----->";
            this.LowCapacityHighSeniorityLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LowCapacityLowSeniorityLabel
            // 
            this.LowCapacityLowSeniorityLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.LowCapacityLowSeniorityLabel.Location = new System.Drawing.Point(51, 304);
            this.LowCapacityLowSeniorityLabel.Name = "LowCapacityLowSeniorityLabel";
            this.LowCapacityLowSeniorityLabel.Size = new System.Drawing.Size(172, 13);
            this.LowCapacityLowSeniorityLabel.TabIndex = 3;
            this.LowCapacityLowSeniorityLabel.Text = "<----- Low Capacity | Low Seniority";
            this.LowCapacityLowSeniorityLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // HighCapacityHighSeniorityLabel
            // 
            this.HighCapacityHighSeniorityLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.HighCapacityHighSeniorityLabel.Location = new System.Drawing.Point(275, 31);
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
            this.BubbleChartPicture.Size = new System.Drawing.Size(444, 254);
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
            this.CollorPatternGroupBorder.Location = new System.Drawing.Point(11, 282);
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
            this.ChartStyleGroupBorder.Location = new System.Drawing.Point(12, 214);
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
            // ChartSampleApp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(735, 358);
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
    }
}