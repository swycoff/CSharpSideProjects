﻿namespace NUnitReportConversionTool {
    partial class Form1 {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.ConvertNUnitReport = new System.Windows.Forms.Button();
            this.PathNUnitExploreFileToAnalyze = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.ExportLocationForReport = new System.Windows.Forms.Label();
            this.GenerateReportToPath = new System.Windows.Forms.TextBox();
            this.ReportOutputName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ConvertNUnitReport
            // 
            this.ConvertNUnitReport.Location = new System.Drawing.Point(36, 265);
            this.ConvertNUnitReport.Margin = new System.Windows.Forms.Padding(4);
            this.ConvertNUnitReport.Name = "ConvertNUnitReport";
            this.ConvertNUnitReport.Size = new System.Drawing.Size(393, 28);
            this.ConvertNUnitReport.TabIndex = 0;
            this.ConvertNUnitReport.Text = "Report: All Test Library Data";
            this.ConvertNUnitReport.UseVisualStyleBackColor = true;
            this.ConvertNUnitReport.Click += new System.EventHandler(this.ConvertNUnitReport_Click);
            // 
            // PathNUnitExploreFileToAnalyze
            // 
            this.PathNUnitExploreFileToAnalyze.Location = new System.Drawing.Point(45, 55);
            this.PathNUnitExploreFileToAnalyze.Margin = new System.Windows.Forms.Padding(4);
            this.PathNUnitExploreFileToAnalyze.Name = "PathNUnitExploreFileToAnalyze";
            this.PathNUnitExploreFileToAnalyze.Size = new System.Drawing.Size(835, 22);
            this.PathNUnitExploreFileToAnalyze.TabIndex = 1;
            this.PathNUnitExploreFileToAnalyze.Text = "C:\\Users\\SWycoff\\Documents\\GitHub\\myon_qa_suite\\myON\\packages\\NUnit.ConsoleRunner" +
    ".3.8.0\\tools\\NUnit3";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(42, 24);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(777, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "(PATH) --Explore Output File From NUnit, usually called NUNIT3 in the packages > " +
    "NUnit.Console Runner x > Tools Folder";
            // 
            // ExportLocationForReport
            // 
            this.ExportLocationForReport.AutoSize = true;
            this.ExportLocationForReport.Location = new System.Drawing.Point(45, 97);
            this.ExportLocationForReport.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ExportLocationForReport.Name = "ExportLocationForReport";
            this.ExportLocationForReport.Size = new System.Drawing.Size(174, 17);
            this.ExportLocationForReport.TabIndex = 3;
            this.ExportLocationForReport.Text = "Generate Report to (Path)";
            // 
            // GenerateReportToPath
            // 
            this.GenerateReportToPath.Location = new System.Drawing.Point(45, 130);
            this.GenerateReportToPath.Margin = new System.Windows.Forms.Padding(4);
            this.GenerateReportToPath.Name = "GenerateReportToPath";
            this.GenerateReportToPath.Size = new System.Drawing.Size(835, 22);
            this.GenerateReportToPath.TabIndex = 4;
            this.GenerateReportToPath.Text = "C:\\Users\\SWycoff\\Desktop\\temp";
            // 
            // ReportOutputName
            // 
            this.ReportOutputName.Location = new System.Drawing.Point(45, 198);
            this.ReportOutputName.Name = "ReportOutputName";
            this.ReportOutputName.Size = new System.Drawing.Size(835, 22);
            this.ReportOutputName.TabIndex = 7;
            this.ReportOutputName.Text = "myONCurrentLibraryState_Date";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(45, 175);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(194, 17);
            this.label3.TabIndex = 8;
            this.label3.Text = "Name The Report Output File";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(36, 323);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(393, 29);
            this.button1.TabIndex = 9;
            this.button1.Text = "Report: Not Implemented Tests";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1760, 886);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.ReportOutputName);
            this.Controls.Add(this.GenerateReportToPath);
            this.Controls.Add(this.ExportLocationForReport);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.PathNUnitExploreFileToAnalyze);
            this.Controls.Add(this.ConvertNUnitReport);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ConvertNUnitReport;
        private System.Windows.Forms.TextBox PathNUnitExploreFileToAnalyze;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label ExportLocationForReport;
        private System.Windows.Forms.TextBox GenerateReportToPath;
        private System.Windows.Forms.TextBox ReportOutputName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
    }
}
