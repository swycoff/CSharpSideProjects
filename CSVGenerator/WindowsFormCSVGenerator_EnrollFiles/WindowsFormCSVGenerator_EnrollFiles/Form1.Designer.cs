namespace WindowsFormCSVGenerator_EnrollFiles {
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
            this.label1 = new System.Windows.Forms.Label();
            this.school_id_text = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.school_name_text = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.sis_id_student_text = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.last_name_text = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.first_name_text = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.grade_combo_box = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.username_text = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.password_text = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.studentsToGenerateNumber = new System.Windows.Forms.NumericUpDown();
            this.generateCVSButton = new System.Windows.Forms.Button();
            this.file_path_text = new System.Windows.Forms.Label();
            this.filePathText = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.fileName_text = new System.Windows.Forms.TextBox();
            this.file_header_text = new System.Windows.Forms.TextBox();
            this.fileHeaders = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.studentsToGenerateNumber)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(35, 72);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "school_id";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // school_id_text
            // 
            this.school_id_text.Location = new System.Drawing.Point(165, 72);
            this.school_id_text.Name = "school_id_text";
            this.school_id_text.Size = new System.Drawing.Size(232, 22);
            this.school_id_text.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(33, 112);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "school_name";
            // 
            // school_name_text
            // 
            this.school_name_text.Location = new System.Drawing.Point(165, 106);
            this.school_name_text.Name = "school_name_text";
            this.school_name_text.Size = new System.Drawing.Size(232, 22);
            this.school_name_text.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(35, 149);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "sis_id";
            // 
            // sis_id_student_text
            // 
            this.sis_id_student_text.Location = new System.Drawing.Point(165, 149);
            this.sis_id_student_text.Name = "sis_id_student_text";
            this.sis_id_student_text.Size = new System.Drawing.Size(232, 22);
            this.sis_id_student_text.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(36, 189);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 17);
            this.label4.TabIndex = 6;
            this.label4.Text = "last_name";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // last_name_text
            // 
            this.last_name_text.Location = new System.Drawing.Point(165, 183);
            this.last_name_text.Name = "last_name_text";
            this.last_name_text.Size = new System.Drawing.Size(232, 22);
            this.last_name_text.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(36, 225);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(74, 17);
            this.label5.TabIndex = 8;
            this.label5.Text = "first_name";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // first_name_text
            // 
            this.first_name_text.Location = new System.Drawing.Point(165, 225);
            this.first_name_text.Name = "first_name_text";
            this.first_name_text.Size = new System.Drawing.Size(232, 22);
            this.first_name_text.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(35, 265);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(45, 17);
            this.label6.TabIndex = 10;
            this.label6.Text = "grade";
            // 
            // grade_combo_box
            // 
            this.grade_combo_box.FormattingEnabled = true;
            this.grade_combo_box.Items.AddRange(new object[] {
            "GradePrek = DBValue 1",
            "GradeK = DBValue 2",
            "Grade1 = DBValue 3",
            "Grade2 = DBValue 4",
            "Grade3 = DBValue 5",
            "Grade4 = DBValue 6",
            "Grade5 = DBValue 7",
            "Grade6 = DBValue 8",
            "Grade7 = DBValue 9",
            "Grade8 = DBValue 10",
            "Grade9 = DBValue 11",
            "Grade10 = DBValue 12",
            "Grade11 = DBValue 13",
            "Grade12 = DBValue 14"});
            this.grade_combo_box.Location = new System.Drawing.Point(165, 256);
            this.grade_combo_box.Name = "grade_combo_box";
            this.grade_combo_box.Size = new System.Drawing.Size(232, 24);
            this.grade_combo_box.TabIndex = 11;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(35, 303);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(71, 17);
            this.label7.TabIndex = 12;
            this.label7.Text = "username";
            // 
            // username_text
            // 
            this.username_text.Location = new System.Drawing.Point(165, 303);
            this.username_text.Name = "username_text";
            this.username_text.Size = new System.Drawing.Size(232, 22);
            this.username_text.TabIndex = 13;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(36, 343);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(68, 17);
            this.label8.TabIndex = 14;
            this.label8.Text = "password";
            // 
            // password_text
            // 
            this.password_text.Location = new System.Drawing.Point(165, 343);
            this.password_text.Name = "password_text";
            this.password_text.Size = new System.Drawing.Size(232, 22);
            this.password_text.TabIndex = 15;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(36, 389);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(222, 17);
            this.label9.TabIndex = 16;
            this.label9.Text = "Number Of Students To Generate";
            // 
            // studentsToGenerateNumber
            // 
            this.studentsToGenerateNumber.Location = new System.Drawing.Point(264, 389);
            this.studentsToGenerateNumber.Maximum = new decimal(new int[] {
            10000000,
            0,
            0,
            0});
            this.studentsToGenerateNumber.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.studentsToGenerateNumber.Name = "studentsToGenerateNumber";
            this.studentsToGenerateNumber.Size = new System.Drawing.Size(219, 22);
            this.studentsToGenerateNumber.TabIndex = 18;
            this.studentsToGenerateNumber.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // generateCVSButton
            // 
            this.generateCVSButton.Location = new System.Drawing.Point(175, 544);
            this.generateCVSButton.Name = "generateCVSButton";
            this.generateCVSButton.Size = new System.Drawing.Size(257, 23);
            this.generateCVSButton.TabIndex = 19;
            this.generateCVSButton.Text = "GenerateCSV";
            this.generateCVSButton.UseVisualStyleBackColor = true;
            this.generateCVSButton.Click += new System.EventHandler(this.generateCSVButton_Click);
            // 
            // file_path_text
            // 
            this.file_path_text.AutoSize = true;
            this.file_path_text.Location = new System.Drawing.Point(35, 427);
            this.file_path_text.Name = "file_path_text";
            this.file_path_text.Size = new System.Drawing.Size(59, 17);
            this.file_path_text.TabIndex = 20;
            this.file_path_text.Text = "FilePath";
            this.file_path_text.Click += new System.EventHandler(this.label10_Click);
            // 
            // filePathText
            // 
            this.filePathText.Location = new System.Drawing.Point(130, 427);
            this.filePathText.Name = "filePathText";
            this.filePathText.Size = new System.Drawing.Size(511, 22);
            this.filePathText.TabIndex = 21;
            this.filePathText.Text = "C:\\\\temp";
            this.filePathText.TextChanged += new System.EventHandler(this.filePathText_TextChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(36, 468);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(67, 17);
            this.label11.TabIndex = 22;
            this.label11.Text = "FileName";
            // 
            // fileName_text
            // 
            this.fileName_text.Location = new System.Drawing.Point(130, 465);
            this.fileName_text.Name = "fileName_text";
            this.fileName_text.Size = new System.Drawing.Size(511, 22);
            this.fileName_text.TabIndex = 23;
            this.fileName_text.Text = "\\testStudentFile1.csv";
            // 
            // file_header_text
            // 
            this.file_header_text.Location = new System.Drawing.Point(130, 498);
            this.file_header_text.Name = "file_header_text";
            this.file_header_text.Size = new System.Drawing.Size(511, 22);
            this.file_header_text.TabIndex = 24;
            this.file_header_text.Text = "school_id,school_name,sis_id,last_name,first_name,grade,username,password";
            // 
            // fileHeaders
            // 
            this.fileHeaders.AutoSize = true;
            this.fileHeaders.Location = new System.Drawing.Point(36, 498);
            this.fileHeaders.Name = "fileHeaders";
            this.fileHeaders.Size = new System.Drawing.Size(88, 17);
            this.fileHeaders.TabIndex = 25;
            this.fileHeaders.Text = "File Headers";
            this.fileHeaders.Click += new System.EventHandler(this.label12_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1240, 857);
            this.Controls.Add(this.fileHeaders);
            this.Controls.Add(this.file_header_text);
            this.Controls.Add(this.fileName_text);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.filePathText);
            this.Controls.Add(this.file_path_text);
            this.Controls.Add(this.generateCVSButton);
            this.Controls.Add(this.studentsToGenerateNumber);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.password_text);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.username_text);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.grade_combo_box);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.first_name_text);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.last_name_text);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.sis_id_student_text);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.school_name_text);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.school_id_text);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.studentsToGenerateNumber)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox school_id_text;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox school_name_text;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox sis_id_student_text;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox last_name_text;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox first_name_text;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox grade_combo_box;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox username_text;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox password_text;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.NumericUpDown studentsToGenerateNumber;
        private System.Windows.Forms.Button generateCVSButton;
        private System.Windows.Forms.Label file_path_text;
        private System.Windows.Forms.TextBox filePathText;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox fileName_text;
        private System.Windows.Forms.TextBox file_header_text;
        private System.Windows.Forms.Label fileHeaders;
    }
}

