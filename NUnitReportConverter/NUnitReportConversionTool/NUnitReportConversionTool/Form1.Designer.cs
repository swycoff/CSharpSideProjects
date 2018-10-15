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
            this.Category3FormBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.Category2FormBox = new System.Windows.Forms.TextBox();
            this.Cat2And3_ANDORSelector = new System.Windows.Forms.ComboBox();
            this.Cat1And2_ANDORSelector = new System.Windows.Forms.ComboBox();
            this.priorityANDORSelector = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.makePretty = new System.Windows.Forms.CheckBox();
            this.excludeTestCasesChbox = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Category1FormBox = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.richTextBox2 = new System.Windows.Forms.RichTextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // PathNUnitExploreFileToAnalyze
            // 
            this.PathNUnitExploreFileToAnalyze.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PathNUnitExploreFileToAnalyze.Location = new System.Drawing.Point(15, 46);
            this.PathNUnitExploreFileToAnalyze.Name = "PathNUnitExploreFileToAnalyze";
            this.PathNUnitExploreFileToAnalyze.Size = new System.Drawing.Size(692, 23);
            this.PathNUnitExploreFileToAnalyze.TabIndex = 1;
            this.PathNUnitExploreFileToAnalyze.Text = "C:\\Users\\siwycoff\\Documents\\GitHub\\myon_qa_suite\\myON\\packages\\NUnit.ConsoleRunne" +
    "r.3.8.0\\tools\\NUnit3";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(777, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "(PATH) --Explore Output File From NUnit, usually called NUNIT3 in the packages > " +
    "NUnit.Console Runner x > Tools Folder";
            // 
            // ExportLocationForReport
            // 
            this.ExportLocationForReport.AutoSize = true;
            this.ExportLocationForReport.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExportLocationForReport.Location = new System.Drawing.Point(15, 78);
            this.ExportLocationForReport.Name = "ExportLocationForReport";
            this.ExportLocationForReport.Size = new System.Drawing.Size(174, 17);
            this.ExportLocationForReport.TabIndex = 3;
            this.ExportLocationForReport.Text = "Generate Report to (Path)";
            // 
            // GenerateReportToPath
            // 
            this.GenerateReportToPath.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GenerateReportToPath.Location = new System.Drawing.Point(15, 105);
            this.GenerateReportToPath.Name = "GenerateReportToPath";
            this.GenerateReportToPath.Size = new System.Drawing.Size(692, 23);
            this.GenerateReportToPath.TabIndex = 4;
            this.GenerateReportToPath.Text = "C:\\Users\\siwycoff\\Desktop\\temp\\nunitreporting";
            // 
            // ReportOutputName
            // 
            this.ReportOutputName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ReportOutputName.Location = new System.Drawing.Point(15, 154);
            this.ReportOutputName.Margin = new System.Windows.Forms.Padding(2);
            this.ReportOutputName.Name = "ReportOutputName";
            this.ReportOutputName.Size = new System.Drawing.Size(692, 23);
            this.ReportOutputName.TabIndex = 7;
            this.ReportOutputName.Text = "TestName";
            this.ReportOutputName.TextChanged += new System.EventHandler(this.ReportOutputName_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(15, 136);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(194, 17);
            this.label3.TabIndex = 8;
            this.label3.Text = "Name The Report Output File";
            // 
            // ConvertNUnitReport
            // 
            this.ConvertNUnitReport.Location = new System.Drawing.Point(9, 301);
            this.ConvertNUnitReport.Name = "ConvertNUnitReport";
            this.ConvertNUnitReport.Size = new System.Drawing.Size(262, 23);
            this.ConvertNUnitReport.TabIndex = 0;
            this.ConvertNUnitReport.Text = "Run Report";
            this.ConvertNUnitReport.UseVisualStyleBackColor = true;
            this.ConvertNUnitReport.Click += new System.EventHandler(this.ConvertNUnitReport_SelectedDataForAllTests);
            // 
            // Category3FormBox
            // 
            this.Category3FormBox.Location = new System.Drawing.Point(9, 243);
            this.Category3FormBox.Margin = new System.Windows.Forms.Padding(2);
            this.Category3FormBox.Name = "Category3FormBox";
            this.Category3FormBox.Size = new System.Drawing.Size(210, 20);
            this.Category3FormBox.TabIndex = 14;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(10, 218);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(91, 13);
            this.label5.TabIndex = 15;
            this.label5.Text = "Select Category 3";
            // 
            // Category2FormBox
            // 
            this.Category2FormBox.Location = new System.Drawing.Point(10, 135);
            this.Category2FormBox.Margin = new System.Windows.Forms.Padding(2);
            this.Category2FormBox.Name = "Category2FormBox";
            this.Category2FormBox.Size = new System.Drawing.Size(210, 20);
            this.Category2FormBox.TabIndex = 13;
            // 
            // Cat2And3_ANDORSelector
            // 
            this.Cat2And3_ANDORSelector.FormattingEnabled = true;
            this.Cat2And3_ANDORSelector.Items.AddRange(new object[] {
            "",
            "and",
            "or"});
            this.Cat2And3_ANDORSelector.Location = new System.Drawing.Point(10, 187);
            this.Cat2And3_ANDORSelector.Margin = new System.Windows.Forms.Padding(2);
            this.Cat2And3_ANDORSelector.Name = "Cat2And3_ANDORSelector";
            this.Cat2And3_ANDORSelector.Size = new System.Drawing.Size(92, 21);
            this.Cat2And3_ANDORSelector.TabIndex = 16;
            // 
            // Cat1And2_ANDORSelector
            // 
            this.Cat1And2_ANDORSelector.FormattingEnabled = true;
            this.Cat1And2_ANDORSelector.Items.AddRange(new object[] {
            "",
            "and",
            "or"});
            this.Cat1And2_ANDORSelector.Location = new System.Drawing.Point(10, 83);
            this.Cat1And2_ANDORSelector.Margin = new System.Windows.Forms.Padding(2);
            this.Cat1And2_ANDORSelector.Name = "Cat1And2_ANDORSelector";
            this.Cat1And2_ANDORSelector.Size = new System.Drawing.Size(92, 21);
            this.Cat1And2_ANDORSelector.TabIndex = 17;
            // 
            // priorityANDORSelector
            // 
            this.priorityANDORSelector.AutoSize = true;
            this.priorityANDORSelector.Location = new System.Drawing.Point(10, 65);
            this.priorityANDORSelector.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.priorityANDORSelector.Name = "priorityANDORSelector";
            this.priorityANDORSelector.Size = new System.Drawing.Size(204, 13);
            this.priorityANDORSelector.TabIndex = 18;
            this.priorityANDORSelector.Text = "If Cat1 + Cat2 Entered, And/Or is required";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(10, 22);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(85, 13);
            this.label7.TabIndex = 20;
            this.label7.Text = "Type Category 1";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(8, 112);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(133, 13);
            this.label8.TabIndex = 21;
            this.label8.Text = "Type Category 2 (Optional)";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(45, 27);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(0, 13);
            this.label9.TabIndex = 22;
            // 
            // richTextBox1
            // 
            this.richTextBox1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.richTextBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBox1.Location = new System.Drawing.Point(40, 65);
            this.richTextBox1.Margin = new System.Windows.Forms.Padding(2);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.ReadOnly = true;
            this.richTextBox1.Size = new System.Drawing.Size(692, 111);
            this.richTextBox1.TabIndex = 23;
            this.richTextBox1.Text = resources.GetString("richTextBox1.Text");
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(160, 11);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(553, 44);
            this.label10.TabIndex = 24;
            this.label10.Text = "NUnit Report Conversion Tool";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.makePretty);
            this.groupBox1.Controls.Add(this.excludeTestCasesChbox);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.Category1FormBox);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.priorityANDORSelector);
            this.groupBox1.Controls.Add(this.Cat1And2_ANDORSelector);
            this.groupBox1.Controls.Add(this.Cat2And3_ANDORSelector);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.Category3FormBox);
            this.groupBox1.Controls.Add(this.Category2FormBox);
            this.groupBox1.Controls.Add(this.ConvertNUnitReport);
            this.groupBox1.Location = new System.Drawing.Point(382, 419);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(381, 340);
            this.groupBox1.TabIndex = 25;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Section 2";
            // 
            // makePretty
            // 
            this.makePretty.AutoSize = true;
            this.makePretty.Checked = true;
            this.makePretty.CheckState = System.Windows.Forms.CheckState.Checked;
            this.makePretty.Location = new System.Drawing.Point(135, 272);
            this.makePretty.Name = "makePretty";
            this.makePretty.Size = new System.Drawing.Size(83, 17);
            this.makePretty.TabIndex = 25;
            this.makePretty.Text = "Make Pretty";
            this.makePretty.UseVisualStyleBackColor = true;
            // 
            // excludeTestCasesChbox
            // 
            this.excludeTestCasesChbox.AutoSize = true;
            this.excludeTestCasesChbox.Checked = true;
            this.excludeTestCasesChbox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.excludeTestCasesChbox.Location = new System.Drawing.Point(10, 273);
            this.excludeTestCasesChbox.Margin = new System.Windows.Forms.Padding(2);
            this.excludeTestCasesChbox.Name = "excludeTestCasesChbox";
            this.excludeTestCasesChbox.Size = new System.Drawing.Size(120, 17);
            this.excludeTestCasesChbox.TabIndex = 24;
            this.excludeTestCasesChbox.Text = "Exclude Test Cases";
            this.excludeTestCasesChbox.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 162);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(204, 13);
            this.label2.TabIndex = 23;
            this.label2.Text = "If Cat2 + Cat3 Entered, And/Or is required";
            // 
            // Category1FormBox
            // 
            this.Category1FormBox.Location = new System.Drawing.Point(10, 38);
            this.Category1FormBox.Margin = new System.Windows.Forms.Padding(2);
            this.Category1FormBox.Name = "Category1FormBox";
            this.Category1FormBox.Size = new System.Drawing.Size(205, 20);
            this.Category1FormBox.TabIndex = 22;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.PathNUnitExploreFileToAnalyze);
            this.groupBox2.Controls.Add(this.ExportLocationForReport);
            this.groupBox2.Controls.Add(this.GenerateReportToPath);
            this.groupBox2.Controls.Add(this.ReportOutputName);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Location = new System.Drawing.Point(28, 217);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox2.Size = new System.Drawing.Size(735, 190);
            this.groupBox2.TabIndex = 26;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Section 1";
            // 
            // richTextBox2
            // 
            this.richTextBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBox2.Location = new System.Drawing.Point(28, 419);
            this.richTextBox2.Margin = new System.Windows.Forms.Padding(2);
            this.richTextBox2.Name = "richTextBox2";
            this.richTextBox2.ReadOnly = true;
            this.richTextBox2.Size = new System.Drawing.Size(342, 162);
            this.richTextBox2.TabIndex = 27;
            this.richTextBox2.Text = resources.GetString("richTextBox2.Text");
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(846, 781);
            this.Controls.Add(this.richTextBox2);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.label9);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
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
        private System.Windows.Forms.TextBox Category3FormBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox Category2FormBox;
        private System.Windows.Forms.ComboBox Cat2And3_ANDORSelector;
        private System.Windows.Forms.ComboBox Cat1And2_ANDORSelector;
        private System.Windows.Forms.Label priorityANDORSelector;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RichTextBox richTextBox2;
        private System.Windows.Forms.TextBox Category1FormBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox excludeTestCasesChbox;
        private System.Windows.Forms.CheckBox makePretty;
    }
}

