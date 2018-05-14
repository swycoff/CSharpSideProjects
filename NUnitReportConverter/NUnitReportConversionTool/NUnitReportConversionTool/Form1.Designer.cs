namespace NUnitReportConversionTool {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.PathNUnitExploreFileToAnalyze = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.ExportLocationForReport = new System.Windows.Forms.Label();
            this.GenerateReportToPath = new System.Windows.Forms.TextBox();
            this.ReportOutputName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.ConvertNUnitReport = new System.Windows.Forms.Button();
            this.Category2TextBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.prioritySelectBox = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.Category1TextBox = new System.Windows.Forms.TextBox();
            this.ANDORSelectorCategory = new System.Windows.Forms.ComboBox();
            this.ANDORPropertySelector = new System.Windows.Forms.ComboBox();
            this.priorityANDORSelector = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.richTextBox2 = new System.Windows.Forms.RichTextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // PathNUnitExploreFileToAnalyze
            // 
            this.PathNUnitExploreFileToAnalyze.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PathNUnitExploreFileToAnalyze.Location = new System.Drawing.Point(20, 57);
            this.PathNUnitExploreFileToAnalyze.Margin = new System.Windows.Forms.Padding(4);
            this.PathNUnitExploreFileToAnalyze.Name = "PathNUnitExploreFileToAnalyze";
            this.PathNUnitExploreFileToAnalyze.Size = new System.Drawing.Size(922, 27);
            this.PathNUnitExploreFileToAnalyze.TabIndex = 1;
            this.PathNUnitExploreFileToAnalyze.Text = "C:\\Users\\SWycoff\\Documents\\GitHub\\myon_qa_suite\\myON\\packages\\NUnit.ConsoleRunner" +
    ".3.8.0\\tools\\NUnit3";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(17, 27);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(925, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "(PATH) --Explore Output File From NUnit, usually called NUNIT3 in the packages > " +
    "NUnit.Console Runner x > Tools Folder";
            // 
            // ExportLocationForReport
            // 
            this.ExportLocationForReport.AutoSize = true;
            this.ExportLocationForReport.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExportLocationForReport.Location = new System.Drawing.Point(20, 96);
            this.ExportLocationForReport.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ExportLocationForReport.Name = "ExportLocationForReport";
            this.ExportLocationForReport.Size = new System.Drawing.Size(203, 20);
            this.ExportLocationForReport.TabIndex = 3;
            this.ExportLocationForReport.Text = "Generate Report to (Path)";
            // 
            // GenerateReportToPath
            // 
            this.GenerateReportToPath.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GenerateReportToPath.Location = new System.Drawing.Point(20, 129);
            this.GenerateReportToPath.Margin = new System.Windows.Forms.Padding(4);
            this.GenerateReportToPath.Name = "GenerateReportToPath";
            this.GenerateReportToPath.Size = new System.Drawing.Size(922, 27);
            this.GenerateReportToPath.TabIndex = 4;
            this.GenerateReportToPath.Text = "C:\\Users\\SWycoff\\Desktop\\temp";
            // 
            // ReportOutputName
            // 
            this.ReportOutputName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ReportOutputName.Location = new System.Drawing.Point(20, 190);
            this.ReportOutputName.Name = "ReportOutputName";
            this.ReportOutputName.Size = new System.Drawing.Size(922, 27);
            this.ReportOutputName.TabIndex = 7;
            this.ReportOutputName.Text = "myONCurrentLibraryState_Date";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(20, 167);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(228, 20);
            this.label3.TabIndex = 8;
            this.label3.Text = "Name The Report Output File";
            // 
            // ConvertNUnitReport
            // 
            this.ConvertNUnitReport.Location = new System.Drawing.Point(16, 414);
            this.ConvertNUnitReport.Margin = new System.Windows.Forms.Padding(4);
            this.ConvertNUnitReport.Name = "ConvertNUnitReport";
            this.ConvertNUnitReport.Size = new System.Drawing.Size(350, 28);
            this.ConvertNUnitReport.TabIndex = 0;
            this.ConvertNUnitReport.Text = "Run Report";
            this.ConvertNUnitReport.UseVisualStyleBackColor = true;
            this.ConvertNUnitReport.Click += new System.EventHandler(this.ConvertNUnitReport_SelectedDataForAllTests);
            // 
            // Category2TextBox
            // 
            this.Category2TextBox.Location = new System.Drawing.Point(13, 361);
            this.Category2TextBox.Name = "Category2TextBox";
            this.Category2TextBox.Size = new System.Drawing.Size(279, 22);
            this.Category2TextBox.TabIndex = 14;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(11, 335);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(120, 17);
            this.label5.TabIndex = 15;
            this.label5.Text = "Select Category 2";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(117, 17);
            this.label2.TabIndex = 10;
            this.label2.Text = "Choose A Priority";
            // 
            // prioritySelectBox
            // 
            this.prioritySelectBox.FormattingEnabled = true;
            this.prioritySelectBox.Items.AddRange(new object[] {
            "",
            "priority1",
            "priority2",
            "priority3",
            "priority4",
            "priority5",
            "priority6",
            "priority7",
            "priority8",
            "priority9",
            "priority10"});
            this.prioritySelectBox.Location = new System.Drawing.Point(14, 85);
            this.prioritySelectBox.Name = "prioritySelectBox";
            this.prioritySelectBox.Size = new System.Drawing.Size(281, 24);
            this.prioritySelectBox.TabIndex = 11;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(10, 219);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(120, 17);
            this.label4.TabIndex = 12;
            this.label4.Text = "Select Category 1";
            // 
            // Category1TextBox
            // 
            this.Category1TextBox.Location = new System.Drawing.Point(13, 242);
            this.Category1TextBox.Name = "Category1TextBox";
            this.Category1TextBox.Size = new System.Drawing.Size(279, 22);
            this.Category1TextBox.TabIndex = 13;
            // 
            // ANDORSelectorCategory
            // 
            this.ANDORSelectorCategory.FormattingEnabled = true;
            this.ANDORSelectorCategory.Items.AddRange(new object[] {
            "",
            "and",
            "or"});
            this.ANDORSelectorCategory.Location = new System.Drawing.Point(14, 299);
            this.ANDORSelectorCategory.Name = "ANDORSelectorCategory";
            this.ANDORSelectorCategory.Size = new System.Drawing.Size(121, 24);
            this.ANDORSelectorCategory.TabIndex = 16;
            // 
            // ANDORPropertySelector
            // 
            this.ANDORPropertySelector.FormattingEnabled = true;
            this.ANDORPropertySelector.Items.AddRange(new object[] {
            "",
            "and",
            "or"});
            this.ANDORPropertySelector.Location = new System.Drawing.Point(15, 149);
            this.ANDORPropertySelector.Name = "ANDORPropertySelector";
            this.ANDORPropertySelector.Size = new System.Drawing.Size(121, 24);
            this.ANDORPropertySelector.TabIndex = 17;
            // 
            // priorityANDORSelector
            // 
            this.priorityANDORSelector.AutoSize = true;
            this.priorityANDORSelector.Location = new System.Drawing.Point(14, 120);
            this.priorityANDORSelector.Name = "priorityANDORSelector";
            this.priorityANDORSelector.Size = new System.Drawing.Size(363, 17);
            this.priorityANDORSelector.TabIndex = 18;
            this.priorityANDORSelector.Text = "Select AND/OR if you want to combine it with a category.";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(17, 275);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(289, 17);
            this.label6.TabIndex = 19;
            this.label6.Text = "AND/OR (required for more than 1 category)";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(13, 27);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(223, 17);
            this.label7.TabIndex = 20;
            this.label7.Text = "Step 1: Select a Priority (Optional)";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(13, 187);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(269, 17);
            this.label8.TabIndex = 21;
            this.label8.Text = "Step 2: Select Your Categories (Optional)";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(60, 33);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(0, 17);
            this.label9.TabIndex = 22;
            // 
            // richTextBox1
            // 
            this.richTextBox1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.richTextBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBox1.Location = new System.Drawing.Point(53, 80);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.ReadOnly = true;
            this.richTextBox1.Size = new System.Drawing.Size(922, 136);
            this.richTextBox1.TabIndex = 23;
            this.richTextBox1.Text = resources.GetString("richTextBox1.Text");
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("MS Office Symbol Regular", 28.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(213, 14);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(537, 48);
            this.label10.TabIndex = 24;
            this.label10.Text = "NUnit Report Conversion Tool";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.priorityANDORSelector);
            this.groupBox1.Controls.Add(this.ANDORPropertySelector);
            this.groupBox1.Controls.Add(this.ANDORSelectorCategory);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.Category2TextBox);
            this.groupBox1.Controls.Add(this.Category1TextBox);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.ConvertNUnitReport);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.prioritySelectBox);
            this.groupBox1.Location = new System.Drawing.Point(510, 516);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(395, 464);
            this.groupBox1.TabIndex = 25;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Section 2";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.PathNUnitExploreFileToAnalyze);
            this.groupBox2.Controls.Add(this.ExportLocationForReport);
            this.groupBox2.Controls.Add(this.GenerateReportToPath);
            this.groupBox2.Controls.Add(this.ReportOutputName);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Location = new System.Drawing.Point(37, 267);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(980, 234);
            this.groupBox2.TabIndex = 26;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Section 1";
            // 
            // richTextBox2
            // 
            this.richTextBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBox2.Location = new System.Drawing.Point(37, 516);
            this.richTextBox2.Name = "richTextBox2";
            this.richTextBox2.ReadOnly = true;
            this.richTextBox2.Size = new System.Drawing.Size(454, 198);
            this.richTextBox2.TabIndex = 27;
            this.richTextBox2.Text = resources.GetString("richTextBox2.Text");
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1088, 998);
            this.Controls.Add(this.richTextBox2);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.label9);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox PathNUnitExploreFileToAnalyze;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label ExportLocationForReport;
        private System.Windows.Forms.TextBox GenerateReportToPath;
        private System.Windows.Forms.TextBox ReportOutputName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button ConvertNUnitReport;
        private System.Windows.Forms.TextBox Category2TextBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox prioritySelectBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox Category1TextBox;
        private System.Windows.Forms.ComboBox ANDORSelectorCategory;
        private System.Windows.Forms.ComboBox ANDORPropertySelector;
        private System.Windows.Forms.Label priorityANDORSelector;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RichTextBox richTextBox2;
    }
}

