﻿namespace WindowsFormCSVGenerator_EnrollFiles {
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
            System.Windows.Forms.Button MB_GenerateRosterFile_BTN;
            this.generateCVSButton = new System.Windows.Forms.Button();
            this.fileName_text = new System.Windows.Forms.TextBox();
            this.file_header_text = new System.Windows.Forms.TextBox();
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
            this.filePathText = new System.Windows.Forms.TextBox();
            this.labelmn = new System.Windows.Forms.Label();
            this.middle_name_text = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.rolling_grade_checkbox = new System.Windows.Forms.CheckBox();
            this.randomize_grade_checkbox = new System.Windows.Forms.CheckBox();
            this.label12 = new System.Windows.Forms.Label();
            this.auto_increment_password_checkbox = new System.Windows.Forms.CheckBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.label11 = new System.Windows.Forms.Label();
            this.label40 = new System.Windows.Forms.Label();
            this.label38 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.MB_RosterFilePath = new System.Windows.Forms.TextBox();
            this.label48 = new System.Windows.Forms.Label();
            this.MB_rosterFileHeaders = new System.Windows.Forms.TextBox();
            this.label47 = new System.Windows.Forms.Label();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.label46 = new System.Windows.Forms.Label();
            this.label45 = new System.Windows.Forms.Label();
            this.label44 = new System.Windows.Forms.Label();
            this.MB_EnrollCSVFacultyOutputFileName = new System.Windows.Forms.TextBox();
            this.label43 = new System.Windows.Forms.Label();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.label42 = new System.Windows.Forms.Label();
            this.MB_GenerateFacultyFileCHBX = new System.Windows.Forms.CheckBox();
            this.MB_GenerateStudentFileCHBX = new System.Windows.Forms.CheckBox();
            this.generate_building_data = new System.Windows.Forms.Button();
            this.MB_FacultyHeader = new System.Windows.Forms.TextBox();
            this.label41 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.MB_Email = new System.Windows.Forms.TextBox();
            this.label = new System.Windows.Forms.Label();
            this.MB_AutoIncrementPW = new System.Windows.Forms.CheckBox();
            this.label19 = new System.Windows.Forms.Label();
            this.MB_RandomGradeCHBX = new System.Windows.Forms.CheckBox();
            this.MB_Rolling_Chbx = new System.Windows.Forms.CheckBox();
            this.MB_MiddleName = new System.Windows.Forms.TextBox();
            this.label20 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.MB_sisIDText = new System.Windows.Forms.TextBox();
            this.MB_LastName = new System.Windows.Forms.TextBox();
            this.label23 = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.MB_FirstName = new System.Windows.Forms.TextBox();
            this.label26 = new System.Windows.Forms.Label();
            this.MB_Grade_ComboBox = new System.Windows.Forms.ComboBox();
            this.label28 = new System.Windows.Forms.Label();
            this.MB_Username = new System.Windows.Forms.TextBox();
            this.label29 = new System.Windows.Forms.Label();
            this.MB_Password = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label31 = new System.Windows.Forms.Label();
            this.label30 = new System.Windows.Forms.Label();
            this.MB_output_xml_path = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.MB_buildingCsvFilePath = new System.Windows.Forms.TextBox();
            this.csv_building_filePath = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.MB_XLargeBldg_Max_NumOfSA = new System.Windows.Forms.NumericUpDown();
            this.label36 = new System.Windows.Forms.Label();
            this.MB_XLargeBldg_Min_NumOfSA = new System.Windows.Forms.NumericUpDown();
            this.label37 = new System.Windows.Forms.Label();
            this.MB_LargeBldg_Max_NumOfSA = new System.Windows.Forms.NumericUpDown();
            this.label34 = new System.Windows.Forms.Label();
            this.MB_LargeBldg_Min_NumOfSA = new System.Windows.Forms.NumericUpDown();
            this.label35 = new System.Windows.Forms.Label();
            this.MB_MediumBldg_Max_NumOfSA = new System.Windows.Forms.NumericUpDown();
            this.label32 = new System.Windows.Forms.Label();
            this.MB_MediumBldg_Min_NumOfSA = new System.Windows.Forms.NumericUpDown();
            this.label33 = new System.Windows.Forms.Label();
            this.MB_SmallBldg_Max_NumOfSA = new System.Windows.Forms.NumericUpDown();
            this.label18 = new System.Windows.Forms.Label();
            this.MB_SmallBldg_Min_NumOfSA = new System.Windows.Forms.NumericUpDown();
            this.label17 = new System.Windows.Forms.Label();
            this.label39 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.MB_StudentFileHeader = new System.Windows.Forms.TextBox();
            this.MB_EnrollCSVStudentOutputFileName = new System.Windows.Forms.TextBox();
            this.label25 = new System.Windows.Forms.Label();
            this.MB_EnrollCSVOutputPath = new System.Windows.Forms.TextBox();
            this.label27 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            MB_GenerateRosterFile_BTN = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.studentsToGenerateNumber)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MB_XLargeBldg_Max_NumOfSA)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MB_XLargeBldg_Min_NumOfSA)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MB_LargeBldg_Max_NumOfSA)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MB_LargeBldg_Min_NumOfSA)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MB_MediumBldg_Max_NumOfSA)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MB_MediumBldg_Min_NumOfSA)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MB_SmallBldg_Max_NumOfSA)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MB_SmallBldg_Min_NumOfSA)).BeginInit();
            this.SuspendLayout();
            // 
            // MB_GenerateRosterFile_BTN
            // 
            MB_GenerateRosterFile_BTN.Location = new System.Drawing.Point(18, 114);
            MB_GenerateRosterFile_BTN.Name = "MB_GenerateRosterFile_BTN";
            MB_GenerateRosterFile_BTN.Size = new System.Drawing.Size(196, 43);
            MB_GenerateRosterFile_BTN.TabIndex = 85;
            MB_GenerateRosterFile_BTN.Text = "Generate Roster Files";
            MB_GenerateRosterFile_BTN.UseVisualStyleBackColor = true;
            MB_GenerateRosterFile_BTN.Click += new System.EventHandler(this.MB_GenerateRosterFile_BTN_Click);
            // 
            // generateCVSButton
            // 
            this.generateCVSButton.Location = new System.Drawing.Point(283, 728);
            this.generateCVSButton.Name = "generateCVSButton";
            this.generateCVSButton.Size = new System.Drawing.Size(257, 23);
            this.generateCVSButton.TabIndex = 19;
            this.generateCVSButton.Text = "GenerateCSV";
            this.generateCVSButton.UseVisualStyleBackColor = true;
            this.generateCVSButton.Click += new System.EventHandler(this.generateCSVButton_Click);
            // 
            // fileName_text
            // 
            this.fileName_text.Location = new System.Drawing.Point(35, 605);
            this.fileName_text.Name = "fileName_text";
            this.fileName_text.Size = new System.Drawing.Size(511, 22);
            this.fileName_text.TabIndex = 23;
            this.fileName_text.Text = "\\testStudentFile1.csv";
            // 
            // file_header_text
            // 
            this.file_header_text.Location = new System.Drawing.Point(35, 670);
            this.file_header_text.Name = "file_header_text";
            this.file_header_text.Size = new System.Drawing.Size(596, 22);
            this.file_header_text.TabIndex = 24;
            this.file_header_text.Text = "school_id,school_name,sis_id,last_name,first_name,middle_name,grade,username,pass" +
    "word";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "school_id";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // school_id_text
            // 
            this.school_id_text.Location = new System.Drawing.Point(141, 20);
            this.school_id_text.Name = "school_id_text";
            this.school_id_text.Size = new System.Drawing.Size(232, 22);
            this.school_id_text.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "school_name";
            // 
            // school_name_text
            // 
            this.school_name_text.Location = new System.Drawing.Point(141, 54);
            this.school_name_text.Name = "school_name_text";
            this.school_name_text.Size = new System.Drawing.Size(232, 22);
            this.school_name_text.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(11, 93);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "sis_id";
            // 
            // sis_id_student_text
            // 
            this.sis_id_student_text.Location = new System.Drawing.Point(141, 93);
            this.sis_id_student_text.Name = "sis_id_student_text";
            this.sis_id_student_text.Size = new System.Drawing.Size(232, 22);
            this.sis_id_student_text.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 137);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 17);
            this.label4.TabIndex = 6;
            this.label4.Text = "last_name";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // last_name_text
            // 
            this.last_name_text.Location = new System.Drawing.Point(141, 131);
            this.last_name_text.Name = "last_name_text";
            this.last_name_text.Size = new System.Drawing.Size(232, 22);
            this.last_name_text.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 173);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(74, 17);
            this.label5.TabIndex = 8;
            this.label5.Text = "first_name";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // first_name_text
            // 
            this.first_name_text.Location = new System.Drawing.Point(141, 173);
            this.first_name_text.Name = "first_name_text";
            this.first_name_text.Size = new System.Drawing.Size(232, 22);
            this.first_name_text.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 250);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(45, 17);
            this.label6.TabIndex = 10;
            this.label6.Text = "grade";
            // 
            // grade_combo_box
            // 
            this.grade_combo_box.FormattingEnabled = true;
            this.grade_combo_box.Items.AddRange(new object[] {
            "Use Random Or Rolling Instead",
            "Prek",
            "K",
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12"});
            this.grade_combo_box.Location = new System.Drawing.Point(142, 241);
            this.grade_combo_box.Name = "grade_combo_box";
            this.grade_combo_box.Size = new System.Drawing.Size(232, 24);
            this.grade_combo_box.TabIndex = 11;
            this.grade_combo_box.SelectedIndexChanged += new System.EventHandler(this.grade_combo_box_SelectedIndexChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 288);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(71, 17);
            this.label7.TabIndex = 12;
            this.label7.Text = "username";
            // 
            // username_text
            // 
            this.username_text.Location = new System.Drawing.Point(142, 288);
            this.username_text.Name = "username_text";
            this.username_text.Size = new System.Drawing.Size(232, 22);
            this.username_text.TabIndex = 13;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(13, 328);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(68, 17);
            this.label8.TabIndex = 14;
            this.label8.Text = "password";
            // 
            // password_text
            // 
            this.password_text.Location = new System.Drawing.Point(142, 328);
            this.password_text.Name = "password_text";
            this.password_text.Size = new System.Drawing.Size(232, 22);
            this.password_text.TabIndex = 15;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(13, 374);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(222, 17);
            this.label9.TabIndex = 16;
            this.label9.Text = "Number Of Students To Generate";
            // 
            // studentsToGenerateNumber
            // 
            this.studentsToGenerateNumber.Location = new System.Drawing.Point(241, 374);
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
            // filePathText
            // 
            this.filePathText.Location = new System.Drawing.Point(33, 538);
            this.filePathText.Name = "filePathText";
            this.filePathText.Size = new System.Drawing.Size(511, 22);
            this.filePathText.TabIndex = 21;
            this.filePathText.Text = "C:\\\\temp";
            this.filePathText.TextChanged += new System.EventHandler(this.filePathText_TextChanged);
            // 
            // labelmn
            // 
            this.labelmn.AutoSize = true;
            this.labelmn.Location = new System.Drawing.Point(12, 207);
            this.labelmn.Name = "labelmn";
            this.labelmn.Size = new System.Drawing.Size(92, 17);
            this.labelmn.TabIndex = 26;
            this.labelmn.Text = "middle_name";
            this.labelmn.Click += new System.EventHandler(this.label10_Click_1);
            // 
            // middle_name_text
            // 
            this.middle_name_text.Location = new System.Drawing.Point(141, 207);
            this.middle_name_text.Name = "middle_name_text";
            this.middle_name_text.Size = new System.Drawing.Size(233, 22);
            this.middle_name_text.TabIndex = 27;
            this.middle_name_text.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(289, 12);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(299, 32);
            this.label10.TabIndex = 28;
            this.label10.Text = "Single Building Form";
            // 
            // rolling_grade_checkbox
            // 
            this.rolling_grade_checkbox.AutoSize = true;
            this.rolling_grade_checkbox.Location = new System.Drawing.Point(397, 243);
            this.rolling_grade_checkbox.Name = "rolling_grade_checkbox";
            this.rolling_grade_checkbox.Size = new System.Drawing.Size(200, 21);
            this.rolling_grade_checkbox.TabIndex = 29;
            this.rolling_grade_checkbox.Text = "Rolling PreK to 12th Grade";
            this.rolling_grade_checkbox.UseVisualStyleBackColor = true;
            this.rolling_grade_checkbox.CheckedChanged += new System.EventHandler(this.rolling_grade_checkbox_CheckedChanged);
            // 
            // randomize_grade_checkbox
            // 
            this.randomize_grade_checkbox.AutoSize = true;
            this.randomize_grade_checkbox.Location = new System.Drawing.Point(603, 241);
            this.randomize_grade_checkbox.Name = "randomize_grade_checkbox";
            this.randomize_grade_checkbox.Size = new System.Drawing.Size(152, 21);
            this.randomize_grade_checkbox.TabIndex = 30;
            this.randomize_grade_checkbox.Text = "Randomize Grades";
            this.randomize_grade_checkbox.UseVisualStyleBackColor = true;
            this.randomize_grade_checkbox.CheckedChanged += new System.EventHandler(this.randomize_grade_checkbox_CheckedChanged);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(603, 218);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(125, 17);
            this.label12.TabIndex = 31;
            this.label12.Text = "Patience Required";
            // 
            // auto_increment_password_checkbox
            // 
            this.auto_increment_password_checkbox.AutoSize = true;
            this.auto_increment_password_checkbox.Location = new System.Drawing.Point(397, 323);
            this.auto_increment_password_checkbox.Name = "auto_increment_password_checkbox";
            this.auto_increment_password_checkbox.Size = new System.Drawing.Size(190, 21);
            this.auto_increment_password_checkbox.TabIndex = 32;
            this.auto_increment_password_checkbox.Text = "Auto Increment Password";
            this.auto_increment_password_checkbox.UseVisualStyleBackColor = true;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(30, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1414, 837);
            this.tabControl1.TabIndex = 33;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.label11);
            this.tabPage1.Controls.Add(this.label40);
            this.tabPage1.Controls.Add(this.label38);
            this.tabPage1.Controls.Add(this.groupBox4);
            this.tabPage1.Controls.Add(this.label10);
            this.tabPage1.Controls.Add(this.file_header_text);
            this.tabPage1.Controls.Add(this.fileName_text);
            this.tabPage1.Controls.Add(this.filePathText);
            this.tabPage1.Controls.Add(this.generateCVSButton);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1406, 808);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Single Building Form";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(32, 641);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(309, 17);
            this.label11.TabIndex = 51;
            this.label11.Text = "What Are The Valid Headers For Each Column?";
            // 
            // label40
            // 
            this.label40.AutoSize = true;
            this.label40.Location = new System.Drawing.Point(32, 574);
            this.label40.Name = "label40";
            this.label40.Size = new System.Drawing.Size(359, 17);
            this.label40.TabIndex = 48;
            this.label40.Text = "What Do You Want Your File Called: (don\'t forget .csv)?";
            // 
            // label38
            // 
            this.label38.AutoSize = true;
            this.label38.Location = new System.Drawing.Point(30, 518);
            this.label38.Name = "label38";
            this.label38.Size = new System.Drawing.Size(356, 17);
            this.label38.TabIndex = 46;
            this.label38.Text = "Where Do You Want Your Finished File Generated To?";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.auto_increment_password_checkbox);
            this.groupBox4.Controls.Add(this.school_name_text);
            this.groupBox4.Controls.Add(this.label12);
            this.groupBox4.Controls.Add(this.label1);
            this.groupBox4.Controls.Add(this.randomize_grade_checkbox);
            this.groupBox4.Controls.Add(this.school_id_text);
            this.groupBox4.Controls.Add(this.rolling_grade_checkbox);
            this.groupBox4.Controls.Add(this.label2);
            this.groupBox4.Controls.Add(this.middle_name_text);
            this.groupBox4.Controls.Add(this.label3);
            this.groupBox4.Controls.Add(this.labelmn);
            this.groupBox4.Controls.Add(this.sis_id_student_text);
            this.groupBox4.Controls.Add(this.last_name_text);
            this.groupBox4.Controls.Add(this.label4);
            this.groupBox4.Controls.Add(this.label5);
            this.groupBox4.Controls.Add(this.first_name_text);
            this.groupBox4.Controls.Add(this.label6);
            this.groupBox4.Controls.Add(this.grade_combo_box);
            this.groupBox4.Controls.Add(this.label7);
            this.groupBox4.Controls.Add(this.studentsToGenerateNumber);
            this.groupBox4.Controls.Add(this.username_text);
            this.groupBox4.Controls.Add(this.label9);
            this.groupBox4.Controls.Add(this.label8);
            this.groupBox4.Controls.Add(this.password_text);
            this.groupBox4.Location = new System.Drawing.Point(17, 62);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(810, 415);
            this.groupBox4.TabIndex = 33;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Student Data:";
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.LightCoral;
            this.tabPage2.Controls.Add(this.MB_RosterFilePath);
            this.tabPage2.Controls.Add(this.label48);
            this.tabPage2.Controls.Add(this.MB_rosterFileHeaders);
            this.tabPage2.Controls.Add(this.label47);
            this.tabPage2.Controls.Add(this.groupBox6);
            this.tabPage2.Controls.Add(this.MB_EnrollCSVFacultyOutputFileName);
            this.tabPage2.Controls.Add(this.label43);
            this.tabPage2.Controls.Add(this.groupBox5);
            this.tabPage2.Controls.Add(this.MB_FacultyHeader);
            this.tabPage2.Controls.Add(this.label41);
            this.tabPage2.Controls.Add(this.groupBox3);
            this.tabPage2.Controls.Add(this.groupBox2);
            this.tabPage2.Controls.Add(this.groupBox1);
            this.tabPage2.Controls.Add(this.label39);
            this.tabPage2.Controls.Add(this.label22);
            this.tabPage2.Controls.Add(this.MB_StudentFileHeader);
            this.tabPage2.Controls.Add(this.MB_EnrollCSVStudentOutputFileName);
            this.tabPage2.Controls.Add(this.label25);
            this.tabPage2.Controls.Add(this.MB_EnrollCSVOutputPath);
            this.tabPage2.Controls.Add(this.label27);
            this.tabPage2.Controls.Add(this.label14);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1406, 808);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Multi Building Form";
            // 
            // MB_RosterFilePath
            // 
            this.MB_RosterFilePath.Location = new System.Drawing.Point(20, 608);
            this.MB_RosterFilePath.Name = "MB_RosterFilePath";
            this.MB_RosterFilePath.Size = new System.Drawing.Size(453, 22);
            this.MB_RosterFilePath.TabIndex = 90;
            this.MB_RosterFilePath.Text = "\\roster.csv";
            // 
            // label48
            // 
            this.label48.AutoSize = true;
            this.label48.Location = new System.Drawing.Point(19, 581);
            this.label48.Name = "label48";
            this.label48.Size = new System.Drawing.Size(408, 17);
            this.label48.TabIndex = 89;
            this.label48.Text = "What Do You Want Your Faculty File Called: (don\'t forget .csv)?";
            // 
            // MB_rosterFileHeaders
            // 
            this.MB_rosterFileHeaders.Location = new System.Drawing.Point(175, 728);
            this.MB_rosterFileHeaders.Name = "MB_rosterFileHeaders";
            this.MB_rosterFileHeaders.Size = new System.Drawing.Size(596, 22);
            this.MB_rosterFileHeaders.TabIndex = 88;
            this.MB_rosterFileHeaders.Text = "student_sis_id, faculty_sis_id ";
            // 
            // label47
            // 
            this.label47.AutoSize = true;
            this.label47.Location = new System.Drawing.Point(21, 733);
            this.label47.Name = "label47";
            this.label47.Size = new System.Drawing.Size(134, 17);
            this.label47.TabIndex = 87;
            this.label47.Text = "Roster File Headers";
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.label46);
            this.groupBox6.Controls.Add(this.label45);
            this.groupBox6.Controls.Add(this.label44);
            this.groupBox6.Controls.Add(MB_GenerateRosterFile_BTN);
            this.groupBox6.Location = new System.Drawing.Point(1066, 593);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(274, 173);
            this.groupBox6.TabIndex = 86;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Generate Roster";
            // 
            // label46
            // 
            this.label46.AutoSize = true;
            this.label46.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label46.Location = new System.Drawing.Point(18, 76);
            this.label46.Name = "label46";
            this.label46.Size = new System.Drawing.Size(183, 20);
            this.label46.TabIndex = 88;
            this.label46.Text = "IF FA<SA Insert FA UN";
            // 
            // label45
            // 
            this.label45.AutoSize = true;
            this.label45.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label45.Location = new System.Drawing.Point(17, 52);
            this.label45.Name = "label45";
            this.label45.Size = new System.Drawing.Size(218, 20);
            this.label45.TabIndex = 87;
            this.label45.Text = "COMPLETE BEFORE THIS";
            // 
            // label44
            // 
            this.label44.AutoSize = true;
            this.label44.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label44.Location = new System.Drawing.Point(18, 28);
            this.label44.Name = "label44";
            this.label44.Size = new System.Drawing.Size(229, 20);
            this.label44.TabIndex = 86;
            this.label44.Text = "FA AND SA FILES MUST BE";
            // 
            // MB_EnrollCSVFacultyOutputFileName
            // 
            this.MB_EnrollCSVFacultyOutputFileName.Location = new System.Drawing.Point(20, 554);
            this.MB_EnrollCSVFacultyOutputFileName.Name = "MB_EnrollCSVFacultyOutputFileName";
            this.MB_EnrollCSVFacultyOutputFileName.Size = new System.Drawing.Size(453, 22);
            this.MB_EnrollCSVFacultyOutputFileName.TabIndex = 84;
            this.MB_EnrollCSVFacultyOutputFileName.Text = "\\faculty.csv";
            // 
            // label43
            // 
            this.label43.AutoSize = true;
            this.label43.Location = new System.Drawing.Point(19, 527);
            this.label43.Name = "label43";
            this.label43.Size = new System.Drawing.Size(408, 17);
            this.label43.TabIndex = 83;
            this.label43.Text = "What Do You Want Your Faculty File Called: (don\'t forget .csv)?";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.label42);
            this.groupBox5.Controls.Add(this.MB_GenerateFacultyFileCHBX);
            this.groupBox5.Controls.Add(this.MB_GenerateStudentFileCHBX);
            this.groupBox5.Controls.Add(this.generate_building_data);
            this.groupBox5.Location = new System.Drawing.Point(834, 593);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(226, 174);
            this.groupBox5.TabIndex = 82;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "File Type To Generate";
            // 
            // label42
            // 
            this.label42.AutoSize = true;
            this.label42.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label42.Location = new System.Drawing.Point(14, 54);
            this.label42.Name = "label42";
            this.label42.Size = new System.Drawing.Size(34, 20);
            this.label42.TabIndex = 81;
            this.label42.Text = "OR";
            // 
            // MB_GenerateFacultyFileCHBX
            // 
            this.MB_GenerateFacultyFileCHBX.AutoSize = true;
            this.MB_GenerateFacultyFileCHBX.Location = new System.Drawing.Point(19, 82);
            this.MB_GenerateFacultyFileCHBX.Name = "MB_GenerateFacultyFileCHBX";
            this.MB_GenerateFacultyFileCHBX.Size = new System.Drawing.Size(165, 21);
            this.MB_GenerateFacultyFileCHBX.TabIndex = 80;
            this.MB_GenerateFacultyFileCHBX.Text = "Generate Faculty File";
            this.MB_GenerateFacultyFileCHBX.UseVisualStyleBackColor = true;
            this.MB_GenerateFacultyFileCHBX.CheckedChanged += new System.EventHandler(this.MB_GenerateFacultyFileCHBX_CheckedChanged);
            // 
            // MB_GenerateStudentFileCHBX
            // 
            this.MB_GenerateStudentFileCHBX.AutoSize = true;
            this.MB_GenerateStudentFileCHBX.Checked = true;
            this.MB_GenerateStudentFileCHBX.CheckState = System.Windows.Forms.CheckState.Checked;
            this.MB_GenerateStudentFileCHBX.Location = new System.Drawing.Point(18, 27);
            this.MB_GenerateStudentFileCHBX.Name = "MB_GenerateStudentFileCHBX";
            this.MB_GenerateStudentFileCHBX.Size = new System.Drawing.Size(169, 21);
            this.MB_GenerateStudentFileCHBX.TabIndex = 79;
            this.MB_GenerateStudentFileCHBX.Text = "Generate Student File";
            this.MB_GenerateStudentFileCHBX.UseVisualStyleBackColor = true;
            this.MB_GenerateStudentFileCHBX.CheckedChanged += new System.EventHandler(this.MB_GenerateStudentFileCHBX_CheckedChanged);
            // 
            // generate_building_data
            // 
            this.generate_building_data.Location = new System.Drawing.Point(15, 115);
            this.generate_building_data.Name = "generate_building_data";
            this.generate_building_data.Size = new System.Drawing.Size(191, 43);
            this.generate_building_data.TabIndex = 10;
            this.generate_building_data.Text = "Generate Data Files";
            this.generate_building_data.UseVisualStyleBackColor = true;
            this.generate_building_data.Click += new System.EventHandler(this.GenerateBuildingData_Click);
            // 
            // MB_FacultyHeader
            // 
            this.MB_FacultyHeader.Location = new System.Drawing.Point(175, 685);
            this.MB_FacultyHeader.Name = "MB_FacultyHeader";
            this.MB_FacultyHeader.Size = new System.Drawing.Size(596, 22);
            this.MB_FacultyHeader.TabIndex = 78;
            this.MB_FacultyHeader.Text = "school_id,school_name,sis_id,last_name,first_name,email,username,password";
            // 
            // label41
            // 
            this.label41.AutoSize = true;
            this.label41.Location = new System.Drawing.Point(17, 690);
            this.label41.Name = "label41";
            this.label41.Size = new System.Drawing.Size(137, 17);
            this.label41.TabIndex = 77;
            this.label41.Text = "Faculty File Headers";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.MB_Email);
            this.groupBox3.Controls.Add(this.label);
            this.groupBox3.Controls.Add(this.MB_AutoIncrementPW);
            this.groupBox3.Controls.Add(this.label19);
            this.groupBox3.Controls.Add(this.MB_RandomGradeCHBX);
            this.groupBox3.Controls.Add(this.MB_Rolling_Chbx);
            this.groupBox3.Controls.Add(this.MB_MiddleName);
            this.groupBox3.Controls.Add(this.label20);
            this.groupBox3.Controls.Add(this.label21);
            this.groupBox3.Controls.Add(this.MB_sisIDText);
            this.groupBox3.Controls.Add(this.MB_LastName);
            this.groupBox3.Controls.Add(this.label23);
            this.groupBox3.Controls.Add(this.label24);
            this.groupBox3.Controls.Add(this.MB_FirstName);
            this.groupBox3.Controls.Add(this.label26);
            this.groupBox3.Controls.Add(this.MB_Grade_ComboBox);
            this.groupBox3.Controls.Add(this.label28);
            this.groupBox3.Controls.Add(this.MB_Username);
            this.groupBox3.Controls.Add(this.label29);
            this.groupBox3.Controls.Add(this.MB_Password);
            this.groupBox3.Location = new System.Drawing.Point(493, 234);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(847, 350);
            this.groupBox3.TabIndex = 76;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "User Data";
            // 
            // MB_Email
            // 
            this.MB_Email.Location = new System.Drawing.Point(187, 297);
            this.MB_Email.Name = "MB_Email";
            this.MB_Email.Size = new System.Drawing.Size(232, 22);
            this.MB_Email.TabIndex = 58;
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Location = new System.Drawing.Point(19, 297);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(114, 17);
            this.label.TabIndex = 57;
            this.label.Text = "email (FA ONLY)";
            // 
            // MB_AutoIncrementPW
            // 
            this.MB_AutoIncrementPW.AutoSize = true;
            this.MB_AutoIncrementPW.Location = new System.Drawing.Point(443, 255);
            this.MB_AutoIncrementPW.Name = "MB_AutoIncrementPW";
            this.MB_AutoIncrementPW.Size = new System.Drawing.Size(190, 21);
            this.MB_AutoIncrementPW.TabIndex = 56;
            this.MB_AutoIncrementPW.Text = "Auto Increment Password";
            this.MB_AutoIncrementPW.UseVisualStyleBackColor = true;
            this.MB_AutoIncrementPW.CheckedChanged += new System.EventHandler(this.MB_AutoIncrementPW_CheckedChanged);
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(649, 150);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(125, 17);
            this.label19.TabIndex = 55;
            this.label19.Text = "Patience Required";
            // 
            // MB_RandomGradeCHBX
            // 
            this.MB_RandomGradeCHBX.AutoSize = true;
            this.MB_RandomGradeCHBX.Location = new System.Drawing.Point(649, 173);
            this.MB_RandomGradeCHBX.Name = "MB_RandomGradeCHBX";
            this.MB_RandomGradeCHBX.Size = new System.Drawing.Size(152, 21);
            this.MB_RandomGradeCHBX.TabIndex = 54;
            this.MB_RandomGradeCHBX.Text = "Randomize Grades";
            this.MB_RandomGradeCHBX.UseVisualStyleBackColor = true;
            this.MB_RandomGradeCHBX.CheckedChanged += new System.EventHandler(this.MB_RandomGradeCHBX_CheckedChanged);
            // 
            // MB_Rolling_Chbx
            // 
            this.MB_Rolling_Chbx.AutoSize = true;
            this.MB_Rolling_Chbx.Location = new System.Drawing.Point(443, 175);
            this.MB_Rolling_Chbx.Name = "MB_Rolling_Chbx";
            this.MB_Rolling_Chbx.Size = new System.Drawing.Size(200, 21);
            this.MB_Rolling_Chbx.TabIndex = 53;
            this.MB_Rolling_Chbx.Text = "Rolling PreK to 12th Grade";
            this.MB_Rolling_Chbx.UseVisualStyleBackColor = true;
            this.MB_Rolling_Chbx.CheckedChanged += new System.EventHandler(this.MB_Rolling_Chbx_CheckedChanged);
            // 
            // MB_MiddleName
            // 
            this.MB_MiddleName.Location = new System.Drawing.Point(187, 139);
            this.MB_MiddleName.Name = "MB_MiddleName";
            this.MB_MiddleName.Size = new System.Drawing.Size(233, 22);
            this.MB_MiddleName.TabIndex = 52;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(19, 25);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(44, 17);
            this.label20.TabIndex = 33;
            this.label20.Text = "sis_id";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(18, 139);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(166, 17);
            this.label21.TabIndex = 51;
            this.label21.Text = "middle_name (SA ONLY)";
            // 
            // MB_sisIDText
            // 
            this.MB_sisIDText.Location = new System.Drawing.Point(187, 25);
            this.MB_sisIDText.Name = "MB_sisIDText";
            this.MB_sisIDText.Size = new System.Drawing.Size(232, 22);
            this.MB_sisIDText.TabIndex = 34;
            // 
            // MB_LastName
            // 
            this.MB_LastName.Location = new System.Drawing.Point(187, 63);
            this.MB_LastName.Name = "MB_LastName";
            this.MB_LastName.Size = new System.Drawing.Size(232, 22);
            this.MB_LastName.TabIndex = 36;
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(18, 69);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(73, 17);
            this.label23.TabIndex = 35;
            this.label23.Text = "last_name";
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Location = new System.Drawing.Point(18, 105);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(74, 17);
            this.label24.TabIndex = 37;
            this.label24.Text = "first_name";
            // 
            // MB_FirstName
            // 
            this.MB_FirstName.Location = new System.Drawing.Point(187, 105);
            this.MB_FirstName.Name = "MB_FirstName";
            this.MB_FirstName.Size = new System.Drawing.Size(232, 22);
            this.MB_FirstName.TabIndex = 38;
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Location = new System.Drawing.Point(18, 182);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(119, 17);
            this.label26.TabIndex = 39;
            this.label26.Text = "grade (SA ONLY)";
            // 
            // MB_Grade_ComboBox
            // 
            this.MB_Grade_ComboBox.FormattingEnabled = true;
            this.MB_Grade_ComboBox.Items.AddRange(new object[] {
            "Use Random Or Rolling Instead",
            "Prek",
            "K",
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12"});
            this.MB_Grade_ComboBox.Location = new System.Drawing.Point(188, 173);
            this.MB_Grade_ComboBox.Name = "MB_Grade_ComboBox";
            this.MB_Grade_ComboBox.Size = new System.Drawing.Size(232, 24);
            this.MB_Grade_ComboBox.TabIndex = 40;
            this.MB_Grade_ComboBox.SelectedIndexChanged += new System.EventHandler(this.MB_Grade_ComboBox_SelectedIndexChanged);
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.Location = new System.Drawing.Point(18, 220);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(71, 17);
            this.label28.TabIndex = 41;
            this.label28.Text = "username";
            // 
            // MB_Username
            // 
            this.MB_Username.Location = new System.Drawing.Point(188, 220);
            this.MB_Username.Name = "MB_Username";
            this.MB_Username.Size = new System.Drawing.Size(232, 22);
            this.MB_Username.TabIndex = 42;
            // 
            // label29
            // 
            this.label29.AutoSize = true;
            this.label29.Location = new System.Drawing.Point(19, 260);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(68, 17);
            this.label29.TabIndex = 43;
            this.label29.Text = "password";
            // 
            // MB_Password
            // 
            this.MB_Password.Location = new System.Drawing.Point(188, 260);
            this.MB_Password.Name = "MB_Password";
            this.MB_Password.Size = new System.Drawing.Size(232, 22);
            this.MB_Password.TabIndex = 44;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label31);
            this.groupBox2.Controls.Add(this.label30);
            this.groupBox2.Controls.Add(this.MB_output_xml_path);
            this.groupBox2.Controls.Add(this.label15);
            this.groupBox2.Controls.Add(this.MB_buildingCsvFilePath);
            this.groupBox2.Controls.Add(this.csv_building_filePath);
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Controls.Add(this.label16);
            this.groupBox2.Location = new System.Drawing.Point(20, 41);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1320, 187);
            this.groupBox2.TabIndex = 75;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "SETUP Building Data File Location";
            // 
            // label31
            // 
            this.label31.AutoSize = true;
            this.label31.Location = new System.Drawing.Point(198, 138);
            this.label31.Name = "label31";
            this.label31.Size = new System.Drawing.Size(553, 17);
            this.label31.TabIndex = 14;
            this.label31.Text = "This can be the same directory as your building data.  The program generates this" +
    " file.";
            // 
            // label30
            // 
            this.label30.AutoSize = true;
            this.label30.Location = new System.Drawing.Point(198, 48);
            this.label30.Name = "label30";
            this.label30.Size = new System.Drawing.Size(535, 17);
            this.label30.TabIndex = 13;
            this.label30.Text = "**Your computers location of the building CSV file with the proper headers and da" +
    "ta.";
            // 
            // MB_output_xml_path
            // 
            this.MB_output_xml_path.Location = new System.Drawing.Point(197, 113);
            this.MB_output_xml_path.Name = "MB_output_xml_path";
            this.MB_output_xml_path.Size = new System.Drawing.Size(626, 22);
            this.MB_output_xml_path.TabIndex = 12;
            this.MB_output_xml_path.Text = "C:\\\\Users\\swycoff\\Desktop\\CSVGenerationProject";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(14, 117);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(116, 17);
            this.label15.TabIndex = 11;
            this.label15.Text = "Output XML Path";
            // 
            // MB_buildingCsvFilePath
            // 
            this.MB_buildingCsvFilePath.Location = new System.Drawing.Point(201, 23);
            this.MB_buildingCsvFilePath.Name = "MB_buildingCsvFilePath";
            this.MB_buildingCsvFilePath.Size = new System.Drawing.Size(626, 22);
            this.MB_buildingCsvFilePath.TabIndex = 3;
            this.MB_buildingCsvFilePath.Text = "C:\\\\Users\\swycoff\\Desktop\\CSVGenerationProject\\CSVBuildingData.csv";
            // 
            // csv_building_filePath
            // 
            this.csv_building_filePath.AutoSize = true;
            this.csv_building_filePath.Location = new System.Drawing.Point(13, 25);
            this.csv_building_filePath.Name = "csv_building_filePath";
            this.csv_building_filePath.Size = new System.Drawing.Size(182, 17);
            this.csv_building_filePath.TabIndex = 2;
            this.csv_building_filePath.Text = "Building Data CSV File Path";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(197, 68);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(371, 17);
            this.label13.TabIndex = 4;
            this.label13.Text = "Valid column_headers = \"size\" \"school_id\" \"school_name\"";
            this.label13.Click += new System.EventHandler(this.label13_Click);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(198, 88);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(434, 17);
            this.label16.TabIndex = 5;
            this.label16.Text = "Size Values = 1-4 value  1=small, 2=medium, 3=large, 4=extra-large";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.MB_XLargeBldg_Max_NumOfSA);
            this.groupBox1.Controls.Add(this.label36);
            this.groupBox1.Controls.Add(this.MB_XLargeBldg_Min_NumOfSA);
            this.groupBox1.Controls.Add(this.label37);
            this.groupBox1.Controls.Add(this.MB_LargeBldg_Max_NumOfSA);
            this.groupBox1.Controls.Add(this.label34);
            this.groupBox1.Controls.Add(this.MB_LargeBldg_Min_NumOfSA);
            this.groupBox1.Controls.Add(this.label35);
            this.groupBox1.Controls.Add(this.MB_MediumBldg_Max_NumOfSA);
            this.groupBox1.Controls.Add(this.label32);
            this.groupBox1.Controls.Add(this.MB_MediumBldg_Min_NumOfSA);
            this.groupBox1.Controls.Add(this.label33);
            this.groupBox1.Controls.Add(this.MB_SmallBldg_Max_NumOfSA);
            this.groupBox1.Controls.Add(this.label18);
            this.groupBox1.Controls.Add(this.MB_SmallBldg_Min_NumOfSA);
            this.groupBox1.Controls.Add(this.label17);
            this.groupBox1.Location = new System.Drawing.Point(22, 234);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(465, 181);
            this.groupBox1.TabIndex = 74;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "SET Random Number of Users To Create Per Building";
            // 
            // MB_XLargeBldg_Max_NumOfSA
            // 
            this.MB_XLargeBldg_Max_NumOfSA.Location = new System.Drawing.Point(301, 144);
            this.MB_XLargeBldg_Max_NumOfSA.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.MB_XLargeBldg_Max_NumOfSA.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.MB_XLargeBldg_Max_NumOfSA.Name = "MB_XLargeBldg_Max_NumOfSA";
            this.MB_XLargeBldg_Max_NumOfSA.Size = new System.Drawing.Size(128, 22);
            this.MB_XLargeBldg_Max_NumOfSA.TabIndex = 70;
            this.MB_XLargeBldg_Max_NumOfSA.Value = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            // 
            // label36
            // 
            this.label36.AutoSize = true;
            this.label36.Location = new System.Drawing.Point(260, 147);
            this.label36.Name = "label36";
            this.label36.Size = new System.Drawing.Size(32, 17);
            this.label36.TabIndex = 69;
            this.label36.Text = "and";
            // 
            // MB_XLargeBldg_Min_NumOfSA
            // 
            this.MB_XLargeBldg_Min_NumOfSA.Location = new System.Drawing.Point(131, 145);
            this.MB_XLargeBldg_Min_NumOfSA.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.MB_XLargeBldg_Min_NumOfSA.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.MB_XLargeBldg_Min_NumOfSA.Name = "MB_XLargeBldg_Min_NumOfSA";
            this.MB_XLargeBldg_Min_NumOfSA.Size = new System.Drawing.Size(119, 22);
            this.MB_XLargeBldg_Min_NumOfSA.TabIndex = 68;
            this.MB_XLargeBldg_Min_NumOfSA.Value = new decimal(new int[] {
            3201,
            0,
            0,
            0});
            // 
            // label37
            // 
            this.label37.AutoSize = true;
            this.label37.Location = new System.Drawing.Point(11, 147);
            this.label37.Name = "label37";
            this.label37.Size = new System.Drawing.Size(112, 17);
            this.label37.TabIndex = 67;
            this.label37.Text = "XLarge Building:";
            // 
            // MB_LargeBldg_Max_NumOfSA
            // 
            this.MB_LargeBldg_Max_NumOfSA.Location = new System.Drawing.Point(301, 111);
            this.MB_LargeBldg_Max_NumOfSA.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.MB_LargeBldg_Max_NumOfSA.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.MB_LargeBldg_Max_NumOfSA.Name = "MB_LargeBldg_Max_NumOfSA";
            this.MB_LargeBldg_Max_NumOfSA.Size = new System.Drawing.Size(128, 22);
            this.MB_LargeBldg_Max_NumOfSA.TabIndex = 66;
            this.MB_LargeBldg_Max_NumOfSA.Value = new decimal(new int[] {
            3200,
            0,
            0,
            0});
            // 
            // label34
            // 
            this.label34.AutoSize = true;
            this.label34.Location = new System.Drawing.Point(260, 114);
            this.label34.Name = "label34";
            this.label34.Size = new System.Drawing.Size(32, 17);
            this.label34.TabIndex = 65;
            this.label34.Text = "and";
            // 
            // MB_LargeBldg_Min_NumOfSA
            // 
            this.MB_LargeBldg_Min_NumOfSA.Location = new System.Drawing.Point(131, 112);
            this.MB_LargeBldg_Min_NumOfSA.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.MB_LargeBldg_Min_NumOfSA.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.MB_LargeBldg_Min_NumOfSA.Name = "MB_LargeBldg_Min_NumOfSA";
            this.MB_LargeBldg_Min_NumOfSA.Size = new System.Drawing.Size(119, 22);
            this.MB_LargeBldg_Min_NumOfSA.TabIndex = 64;
            this.MB_LargeBldg_Min_NumOfSA.Value = new decimal(new int[] {
            1601,
            0,
            0,
            0});
            // 
            // label35
            // 
            this.label35.AutoSize = true;
            this.label35.Location = new System.Drawing.Point(11, 114);
            this.label35.Name = "label35";
            this.label35.Size = new System.Drawing.Size(103, 17);
            this.label35.TabIndex = 63;
            this.label35.Text = "Large Building:";
            // 
            // MB_MediumBldg_Max_NumOfSA
            // 
            this.MB_MediumBldg_Max_NumOfSA.Location = new System.Drawing.Point(302, 75);
            this.MB_MediumBldg_Max_NumOfSA.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.MB_MediumBldg_Max_NumOfSA.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.MB_MediumBldg_Max_NumOfSA.Name = "MB_MediumBldg_Max_NumOfSA";
            this.MB_MediumBldg_Max_NumOfSA.Size = new System.Drawing.Size(128, 22);
            this.MB_MediumBldg_Max_NumOfSA.TabIndex = 62;
            this.MB_MediumBldg_Max_NumOfSA.Value = new decimal(new int[] {
            1600,
            0,
            0,
            0});
            // 
            // label32
            // 
            this.label32.AutoSize = true;
            this.label32.Location = new System.Drawing.Point(261, 78);
            this.label32.Name = "label32";
            this.label32.Size = new System.Drawing.Size(32, 17);
            this.label32.TabIndex = 61;
            this.label32.Text = "and";
            // 
            // MB_MediumBldg_Min_NumOfSA
            // 
            this.MB_MediumBldg_Min_NumOfSA.Location = new System.Drawing.Point(132, 76);
            this.MB_MediumBldg_Min_NumOfSA.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.MB_MediumBldg_Min_NumOfSA.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.MB_MediumBldg_Min_NumOfSA.Name = "MB_MediumBldg_Min_NumOfSA";
            this.MB_MediumBldg_Min_NumOfSA.Size = new System.Drawing.Size(119, 22);
            this.MB_MediumBldg_Min_NumOfSA.TabIndex = 60;
            this.MB_MediumBldg_Min_NumOfSA.Value = new decimal(new int[] {
            801,
            0,
            0,
            0});
            this.MB_MediumBldg_Min_NumOfSA.ValueChanged += new System.EventHandler(this.MB_MediumBldg_Min_NumOfSA_ValueChanged);
            // 
            // label33
            // 
            this.label33.AutoSize = true;
            this.label33.Location = new System.Drawing.Point(11, 78);
            this.label33.Name = "label33";
            this.label33.Size = new System.Drawing.Size(115, 17);
            this.label33.TabIndex = 59;
            this.label33.Text = "Medium Building:";
            // 
            // MB_SmallBldg_Max_NumOfSA
            // 
            this.MB_SmallBldg_Max_NumOfSA.Location = new System.Drawing.Point(302, 42);
            this.MB_SmallBldg_Max_NumOfSA.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.MB_SmallBldg_Max_NumOfSA.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.MB_SmallBldg_Max_NumOfSA.Name = "MB_SmallBldg_Max_NumOfSA";
            this.MB_SmallBldg_Max_NumOfSA.Size = new System.Drawing.Size(128, 22);
            this.MB_SmallBldg_Max_NumOfSA.TabIndex = 9;
            this.MB_SmallBldg_Max_NumOfSA.Value = new decimal(new int[] {
            800,
            0,
            0,
            0});
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(261, 45);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(32, 17);
            this.label18.TabIndex = 8;
            this.label18.Text = "and";
            // 
            // MB_SmallBldg_Min_NumOfSA
            // 
            this.MB_SmallBldg_Min_NumOfSA.Location = new System.Drawing.Point(132, 43);
            this.MB_SmallBldg_Min_NumOfSA.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.MB_SmallBldg_Min_NumOfSA.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.MB_SmallBldg_Min_NumOfSA.Name = "MB_SmallBldg_Min_NumOfSA";
            this.MB_SmallBldg_Min_NumOfSA.Size = new System.Drawing.Size(119, 22);
            this.MB_SmallBldg_Min_NumOfSA.TabIndex = 7;
            this.MB_SmallBldg_Min_NumOfSA.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(11, 45);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(100, 17);
            this.label17.TabIndex = 6;
            this.label17.Text = "Small Building:";
            // 
            // label39
            // 
            this.label39.AutoSize = true;
            this.label39.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label39.Location = new System.Drawing.Point(451, 3);
            this.label39.Name = "label39";
            this.label39.Size = new System.Drawing.Size(320, 32);
            this.label39.TabIndex = 72;
            this.label39.Text = "Multiple Building Form";
            this.label39.Click += new System.EventHandler(this.label39_Click);
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(17, 650);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(141, 17);
            this.label22.TabIndex = 50;
            this.label22.Text = "Student File Headers";
            this.label22.Click += new System.EventHandler(this.label22_Click);
            // 
            // MB_StudentFileHeader
            // 
            this.MB_StudentFileHeader.Location = new System.Drawing.Point(175, 645);
            this.MB_StudentFileHeader.Name = "MB_StudentFileHeader";
            this.MB_StudentFileHeader.Size = new System.Drawing.Size(596, 22);
            this.MB_StudentFileHeader.TabIndex = 49;
            this.MB_StudentFileHeader.Text = "school_id,school_name,sis_id,last_name,first_name,middle_name,grade,username,pass" +
    "word";
            // 
            // MB_EnrollCSVStudentOutputFileName
            // 
            this.MB_EnrollCSVStudentOutputFileName.Location = new System.Drawing.Point(20, 498);
            this.MB_EnrollCSVStudentOutputFileName.Name = "MB_EnrollCSVStudentOutputFileName";
            this.MB_EnrollCSVStudentOutputFileName.Size = new System.Drawing.Size(453, 22);
            this.MB_EnrollCSVStudentOutputFileName.TabIndex = 48;
            this.MB_EnrollCSVStudentOutputFileName.Text = "\\students.csv";
            this.MB_EnrollCSVStudentOutputFileName.TextChanged += new System.EventHandler(this.MB_EnrollCSVOutputFileName_TextChanged);
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Location = new System.Drawing.Point(19, 473);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(412, 17);
            this.label25.TabIndex = 47;
            this.label25.Text = "What Do You Want Your Student File Called: (don\'t forget .csv)?";
            // 
            // MB_EnrollCSVOutputPath
            // 
            this.MB_EnrollCSVOutputPath.Location = new System.Drawing.Point(22, 444);
            this.MB_EnrollCSVOutputPath.Name = "MB_EnrollCSVOutputPath";
            this.MB_EnrollCSVOutputPath.Size = new System.Drawing.Size(451, 22);
            this.MB_EnrollCSVOutputPath.TabIndex = 46;
            this.MB_EnrollCSVOutputPath.Text = "C:\\\\temp";
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Location = new System.Drawing.Point(19, 420);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(356, 17);
            this.label27.TabIndex = 45;
            this.label27.Text = "Where Do You Want Your Finished File Generated To?";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(281, 32);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(0, 17);
            this.label14.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1671, 1057);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.studentsToGenerateNumber)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MB_XLargeBldg_Max_NumOfSA)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MB_XLargeBldg_Min_NumOfSA)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MB_LargeBldg_Max_NumOfSA)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MB_LargeBldg_Min_NumOfSA)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MB_MediumBldg_Max_NumOfSA)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MB_MediumBldg_Min_NumOfSA)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MB_SmallBldg_Max_NumOfSA)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MB_SmallBldg_Min_NumOfSA)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button generateCVSButton;
        private System.Windows.Forms.TextBox fileName_text;
        private System.Windows.Forms.TextBox file_header_text;
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
        private System.Windows.Forms.TextBox filePathText;
        private System.Windows.Forms.Label labelmn;
        private System.Windows.Forms.TextBox middle_name_text;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.CheckBox rolling_grade_checkbox;
        private System.Windows.Forms.CheckBox randomize_grade_checkbox;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.CheckBox auto_increment_password_checkbox;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox MB_buildingCsvFilePath;
        private System.Windows.Forms.Label csv_building_filePath;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.NumericUpDown MB_SmallBldg_Max_NumOfSA;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.NumericUpDown MB_SmallBldg_Min_NumOfSA;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Button generate_building_data;
        private System.Windows.Forms.TextBox MB_output_xml_path;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.CheckBox MB_AutoIncrementPW;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.CheckBox MB_RandomGradeCHBX;
        private System.Windows.Forms.CheckBox MB_Rolling_Chbx;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.TextBox MB_StudentFileHeader;
        private System.Windows.Forms.TextBox MB_EnrollCSVStudentOutputFileName;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.TextBox MB_EnrollCSVOutputPath;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.Label label29;
        private System.Windows.Forms.TextBox MB_Password;
        private System.Windows.Forms.Label label39;
        private System.Windows.Forms.NumericUpDown MB_XLargeBldg_Max_NumOfSA;
        private System.Windows.Forms.Label label36;
        private System.Windows.Forms.NumericUpDown MB_XLargeBldg_Min_NumOfSA;
        private System.Windows.Forms.Label label37;
        private System.Windows.Forms.NumericUpDown MB_LargeBldg_Max_NumOfSA;
        private System.Windows.Forms.Label label34;
        private System.Windows.Forms.NumericUpDown MB_LargeBldg_Min_NumOfSA;
        private System.Windows.Forms.Label label35;
        private System.Windows.Forms.NumericUpDown MB_MediumBldg_Max_NumOfSA;
        private System.Windows.Forms.Label label32;
        private System.Windows.Forms.NumericUpDown MB_MediumBldg_Min_NumOfSA;
        private System.Windows.Forms.Label label33;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label30;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox MB_MiddleName;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.TextBox MB_sisIDText;
        private System.Windows.Forms.TextBox MB_LastName;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.TextBox MB_FirstName;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.ComboBox MB_Grade_ComboBox;
        private System.Windows.Forms.Label label28;
        private System.Windows.Forms.TextBox MB_Username;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label31;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label40;
        private System.Windows.Forms.Label label38;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TextBox MB_FacultyHeader;
        private System.Windows.Forms.Label label41;
        private System.Windows.Forms.TextBox MB_Email;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Label label42;
        private System.Windows.Forms.CheckBox MB_GenerateFacultyFileCHBX;
        private System.Windows.Forms.CheckBox MB_GenerateStudentFileCHBX;
        private System.Windows.Forms.TextBox MB_EnrollCSVFacultyOutputFileName;
        private System.Windows.Forms.Label label43;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.Label label46;
        private System.Windows.Forms.Label label45;
        private System.Windows.Forms.Label label44;
        private System.Windows.Forms.TextBox MB_rosterFileHeaders;
        private System.Windows.Forms.Label label47;
        private System.Windows.Forms.TextBox MB_RosterFilePath;
        private System.Windows.Forms.Label label48;
    }
}

