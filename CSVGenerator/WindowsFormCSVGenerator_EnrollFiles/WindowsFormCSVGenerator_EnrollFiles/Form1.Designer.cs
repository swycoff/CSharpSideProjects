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
            this.generateCVSButton = new System.Windows.Forms.Button();
            this.fileName_text = new System.Windows.Forms.TextBox();
            this.file_header_text = new System.Windows.Forms.TextBox();
            this.fileHeaders = new System.Windows.Forms.Label();
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
            this.file_path_text = new System.Windows.Forms.Label();
            this.filePathText = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.labelmn = new System.Windows.Forms.Label();
            this.middle_name_text = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.rolling_grade_checkbox = new System.Windows.Forms.CheckBox();
            this.randomize_grade_checkbox = new System.Windows.Forms.CheckBox();
            this.label12 = new System.Windows.Forms.Label();
            this.auto_increment_password_checkbox = new System.Windows.Forms.CheckBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.MB_AutoIncrementPW = new System.Windows.Forms.CheckBox();
            this.label19 = new System.Windows.Forms.Label();
            this.MB_RandomGradeCHBX = new System.Windows.Forms.CheckBox();
            this.MB_Rolling_Chbx = new System.Windows.Forms.CheckBox();
            this.MB_MiddleName = new System.Windows.Forms.TextBox();
            this.label20 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.MB_sisIDText = new System.Windows.Forms.TextBox();
            this.label22 = new System.Windows.Forms.Label();
            this.MB_LastName = new System.Windows.Forms.TextBox();
            this.MB_FileHeaderLine = new System.Windows.Forms.TextBox();
            this.label23 = new System.Windows.Forms.Label();
            this.MB_EnrollCSVOutputFileName = new System.Windows.Forms.TextBox();
            this.label24 = new System.Windows.Forms.Label();
            this.label25 = new System.Windows.Forms.Label();
            this.MB_FirstName = new System.Windows.Forms.TextBox();
            this.MB_EnrollCSVOutputPath = new System.Windows.Forms.TextBox();
            this.label26 = new System.Windows.Forms.Label();
            this.label27 = new System.Windows.Forms.Label();
            this.MB_Grade_ComboBox = new System.Windows.Forms.ComboBox();
            this.label28 = new System.Windows.Forms.Label();
            this.MB_Username = new System.Windows.Forms.TextBox();
            this.label29 = new System.Windows.Forms.Label();
            this.MB_Password = new System.Windows.Forms.TextBox();
            this.MB_output_xml_path = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.generate_building_data = new System.Windows.Forms.Button();
            this.MB_SmallBldg_Max_NumOfSA = new System.Windows.Forms.NumericUpDown();
            this.label18 = new System.Windows.Forms.Label();
            this.MB_SmallBldg_Min_NumOfSA = new System.Windows.Forms.NumericUpDown();
            this.label17 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.MB_buildingCsvFilePath = new System.Windows.Forms.TextBox();
            this.csv_building_filePath = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.studentsToGenerateNumber)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MB_SmallBldg_Max_NumOfSA)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MB_SmallBldg_Min_NumOfSA)).BeginInit();
            this.SuspendLayout();
            // 
            // generateCVSButton
            // 
            this.generateCVSButton.Location = new System.Drawing.Point(167, 570);
            this.generateCVSButton.Name = "generateCVSButton";
            this.generateCVSButton.Size = new System.Drawing.Size(257, 23);
            this.generateCVSButton.TabIndex = 19;
            this.generateCVSButton.Text = "GenerateCSV";
            this.generateCVSButton.UseVisualStyleBackColor = true;
            this.generateCVSButton.Click += new System.EventHandler(this.generateCSVButton_Click);
            // 
            // fileName_text
            // 
            this.fileName_text.Location = new System.Drawing.Point(122, 491);
            this.fileName_text.Name = "fileName_text";
            this.fileName_text.Size = new System.Drawing.Size(511, 22);
            this.fileName_text.TabIndex = 23;
            this.fileName_text.Text = "\\testStudentFile1.csv";
            // 
            // file_header_text
            // 
            this.file_header_text.Location = new System.Drawing.Point(122, 524);
            this.file_header_text.Name = "file_header_text";
            this.file_header_text.Size = new System.Drawing.Size(596, 22);
            this.file_header_text.TabIndex = 24;
            this.file_header_text.Text = "school_id,school_name,sis_id,last_name,first_name,middle_name,grade,username,pass" +
    "word";
            // 
            // fileHeaders
            // 
            this.fileHeaders.AutoSize = true;
            this.fileHeaders.Location = new System.Drawing.Point(28, 524);
            this.fileHeaders.Name = "fileHeaders";
            this.fileHeaders.Size = new System.Drawing.Size(88, 17);
            this.fileHeaders.TabIndex = 25;
            this.fileHeaders.Text = "File Headers";
            this.fileHeaders.Click += new System.EventHandler(this.label12_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "school_id";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // school_id_text
            // 
            this.school_id_text.Location = new System.Drawing.Point(156, 57);
            this.school_id_text.Name = "school_id_text";
            this.school_id_text.Size = new System.Drawing.Size(232, 22);
            this.school_id_text.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 97);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "school_name";
            // 
            // school_name_text
            // 
            this.school_name_text.Location = new System.Drawing.Point(156, 91);
            this.school_name_text.Name = "school_name_text";
            this.school_name_text.Size = new System.Drawing.Size(232, 22);
            this.school_name_text.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(26, 134);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "sis_id";
            // 
            // sis_id_student_text
            // 
            this.sis_id_student_text.Location = new System.Drawing.Point(156, 134);
            this.sis_id_student_text.Name = "sis_id_student_text";
            this.sis_id_student_text.Size = new System.Drawing.Size(232, 22);
            this.sis_id_student_text.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(27, 178);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 17);
            this.label4.TabIndex = 6;
            this.label4.Text = "last_name";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // last_name_text
            // 
            this.last_name_text.Location = new System.Drawing.Point(156, 172);
            this.last_name_text.Name = "last_name_text";
            this.last_name_text.Size = new System.Drawing.Size(232, 22);
            this.last_name_text.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(27, 214);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(74, 17);
            this.label5.TabIndex = 8;
            this.label5.Text = "first_name";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // first_name_text
            // 
            this.first_name_text.Location = new System.Drawing.Point(156, 214);
            this.first_name_text.Name = "first_name_text";
            this.first_name_text.Size = new System.Drawing.Size(232, 22);
            this.first_name_text.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(27, 291);
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
            this.grade_combo_box.Location = new System.Drawing.Point(157, 282);
            this.grade_combo_box.Name = "grade_combo_box";
            this.grade_combo_box.Size = new System.Drawing.Size(232, 24);
            this.grade_combo_box.TabIndex = 11;
            this.grade_combo_box.SelectedIndexChanged += new System.EventHandler(this.grade_combo_box_SelectedIndexChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(27, 329);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(71, 17);
            this.label7.TabIndex = 12;
            this.label7.Text = "username";
            // 
            // username_text
            // 
            this.username_text.Location = new System.Drawing.Point(157, 329);
            this.username_text.Name = "username_text";
            this.username_text.Size = new System.Drawing.Size(232, 22);
            this.username_text.TabIndex = 13;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(28, 369);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(68, 17);
            this.label8.TabIndex = 14;
            this.label8.Text = "password";
            // 
            // password_text
            // 
            this.password_text.Location = new System.Drawing.Point(157, 369);
            this.password_text.Name = "password_text";
            this.password_text.Size = new System.Drawing.Size(232, 22);
            this.password_text.TabIndex = 15;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(28, 415);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(222, 17);
            this.label9.TabIndex = 16;
            this.label9.Text = "Number Of Students To Generate";
            // 
            // studentsToGenerateNumber
            // 
            this.studentsToGenerateNumber.Location = new System.Drawing.Point(256, 415);
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
            // file_path_text
            // 
            this.file_path_text.AutoSize = true;
            this.file_path_text.Location = new System.Drawing.Point(27, 453);
            this.file_path_text.Name = "file_path_text";
            this.file_path_text.Size = new System.Drawing.Size(59, 17);
            this.file_path_text.TabIndex = 20;
            this.file_path_text.Text = "FilePath";
            this.file_path_text.Click += new System.EventHandler(this.label10_Click);
            // 
            // filePathText
            // 
            this.filePathText.Location = new System.Drawing.Point(122, 453);
            this.filePathText.Name = "filePathText";
            this.filePathText.Size = new System.Drawing.Size(511, 22);
            this.filePathText.TabIndex = 21;
            this.filePathText.Text = "C:\\\\temp";
            this.filePathText.TextChanged += new System.EventHandler(this.filePathText_TextChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(28, 494);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(67, 17);
            this.label11.TabIndex = 22;
            this.label11.Text = "FileName";
            // 
            // labelmn
            // 
            this.labelmn.AutoSize = true;
            this.labelmn.Location = new System.Drawing.Point(27, 248);
            this.labelmn.Name = "labelmn";
            this.labelmn.Size = new System.Drawing.Size(92, 17);
            this.labelmn.TabIndex = 26;
            this.labelmn.Text = "middle_name";
            this.labelmn.Click += new System.EventHandler(this.label10_Click_1);
            // 
            // middle_name_text
            // 
            this.middle_name_text.Location = new System.Drawing.Point(156, 248);
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
            this.rolling_grade_checkbox.Location = new System.Drawing.Point(412, 284);
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
            this.randomize_grade_checkbox.Location = new System.Drawing.Point(618, 282);
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
            this.label12.Location = new System.Drawing.Point(618, 259);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(125, 17);
            this.label12.TabIndex = 31;
            this.label12.Text = "Patience Required";
            // 
            // auto_increment_password_checkbox
            // 
            this.auto_increment_password_checkbox.AutoSize = true;
            this.auto_increment_password_checkbox.Location = new System.Drawing.Point(412, 364);
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
            this.tabControl1.Size = new System.Drawing.Size(1618, 837);
            this.tabControl1.TabIndex = 33;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.label10);
            this.tabPage1.Controls.Add(this.auto_increment_password_checkbox);
            this.tabPage1.Controls.Add(this.school_name_text);
            this.tabPage1.Controls.Add(this.label12);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.randomize_grade_checkbox);
            this.tabPage1.Controls.Add(this.school_id_text);
            this.tabPage1.Controls.Add(this.rolling_grade_checkbox);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.middle_name_text);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.labelmn);
            this.tabPage1.Controls.Add(this.sis_id_student_text);
            this.tabPage1.Controls.Add(this.fileHeaders);
            this.tabPage1.Controls.Add(this.last_name_text);
            this.tabPage1.Controls.Add(this.file_header_text);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.fileName_text);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.label11);
            this.tabPage1.Controls.Add(this.first_name_text);
            this.tabPage1.Controls.Add(this.filePathText);
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Controls.Add(this.file_path_text);
            this.tabPage1.Controls.Add(this.grade_combo_box);
            this.tabPage1.Controls.Add(this.generateCVSButton);
            this.tabPage1.Controls.Add(this.label7);
            this.tabPage1.Controls.Add(this.studentsToGenerateNumber);
            this.tabPage1.Controls.Add(this.username_text);
            this.tabPage1.Controls.Add(this.label9);
            this.tabPage1.Controls.Add(this.label8);
            this.tabPage1.Controls.Add(this.password_text);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1610, 808);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Single Building Form";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.MB_AutoIncrementPW);
            this.tabPage2.Controls.Add(this.label19);
            this.tabPage2.Controls.Add(this.MB_RandomGradeCHBX);
            this.tabPage2.Controls.Add(this.MB_Rolling_Chbx);
            this.tabPage2.Controls.Add(this.MB_MiddleName);
            this.tabPage2.Controls.Add(this.label20);
            this.tabPage2.Controls.Add(this.label21);
            this.tabPage2.Controls.Add(this.MB_sisIDText);
            this.tabPage2.Controls.Add(this.label22);
            this.tabPage2.Controls.Add(this.MB_LastName);
            this.tabPage2.Controls.Add(this.MB_FileHeaderLine);
            this.tabPage2.Controls.Add(this.label23);
            this.tabPage2.Controls.Add(this.MB_EnrollCSVOutputFileName);
            this.tabPage2.Controls.Add(this.label24);
            this.tabPage2.Controls.Add(this.label25);
            this.tabPage2.Controls.Add(this.MB_FirstName);
            this.tabPage2.Controls.Add(this.MB_EnrollCSVOutputPath);
            this.tabPage2.Controls.Add(this.label26);
            this.tabPage2.Controls.Add(this.label27);
            this.tabPage2.Controls.Add(this.MB_Grade_ComboBox);
            this.tabPage2.Controls.Add(this.label28);
            this.tabPage2.Controls.Add(this.MB_Username);
            this.tabPage2.Controls.Add(this.label29);
            this.tabPage2.Controls.Add(this.MB_Password);
            this.tabPage2.Controls.Add(this.MB_output_xml_path);
            this.tabPage2.Controls.Add(this.label15);
            this.tabPage2.Controls.Add(this.generate_building_data);
            this.tabPage2.Controls.Add(this.MB_SmallBldg_Max_NumOfSA);
            this.tabPage2.Controls.Add(this.label18);
            this.tabPage2.Controls.Add(this.MB_SmallBldg_Min_NumOfSA);
            this.tabPage2.Controls.Add(this.label17);
            this.tabPage2.Controls.Add(this.label16);
            this.tabPage2.Controls.Add(this.label13);
            this.tabPage2.Controls.Add(this.MB_buildingCsvFilePath);
            this.tabPage2.Controls.Add(this.csv_building_filePath);
            this.tabPage2.Controls.Add(this.label14);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1610, 808);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Multi Building Form";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // MB_AutoIncrementPW
            // 
            this.MB_AutoIncrementPW.AutoSize = true;
            this.MB_AutoIncrementPW.Location = new System.Drawing.Point(419, 605);
            this.MB_AutoIncrementPW.Name = "MB_AutoIncrementPW";
            this.MB_AutoIncrementPW.Size = new System.Drawing.Size(190, 21);
            this.MB_AutoIncrementPW.TabIndex = 56;
            this.MB_AutoIncrementPW.Text = "Auto Increment Password";
            this.MB_AutoIncrementPW.UseVisualStyleBackColor = true;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(625, 500);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(125, 17);
            this.label19.TabIndex = 55;
            this.label19.Text = "Patience Required";
            // 
            // MB_RandomGradeCHBX
            // 
            this.MB_RandomGradeCHBX.AutoSize = true;
            this.MB_RandomGradeCHBX.Location = new System.Drawing.Point(625, 523);
            this.MB_RandomGradeCHBX.Name = "MB_RandomGradeCHBX";
            this.MB_RandomGradeCHBX.Size = new System.Drawing.Size(152, 21);
            this.MB_RandomGradeCHBX.TabIndex = 54;
            this.MB_RandomGradeCHBX.Text = "Randomize Grades";
            this.MB_RandomGradeCHBX.UseVisualStyleBackColor = true;
            // 
            // MB_Rolling_Chbx
            // 
            this.MB_Rolling_Chbx.AutoSize = true;
            this.MB_Rolling_Chbx.Location = new System.Drawing.Point(419, 525);
            this.MB_Rolling_Chbx.Name = "MB_Rolling_Chbx";
            this.MB_Rolling_Chbx.Size = new System.Drawing.Size(200, 21);
            this.MB_Rolling_Chbx.TabIndex = 53;
            this.MB_Rolling_Chbx.Text = "Rolling PreK to 12th Grade";
            this.MB_Rolling_Chbx.UseVisualStyleBackColor = true;
            // 
            // MB_MiddleName
            // 
            this.MB_MiddleName.Location = new System.Drawing.Point(163, 489);
            this.MB_MiddleName.Name = "MB_MiddleName";
            this.MB_MiddleName.Size = new System.Drawing.Size(233, 22);
            this.MB_MiddleName.TabIndex = 52;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(33, 375);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(44, 17);
            this.label20.TabIndex = 33;
            this.label20.Text = "sis_id";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(34, 489);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(92, 17);
            this.label21.TabIndex = 51;
            this.label21.Text = "middle_name";
            // 
            // MB_sisIDText
            // 
            this.MB_sisIDText.Location = new System.Drawing.Point(163, 375);
            this.MB_sisIDText.Name = "MB_sisIDText";
            this.MB_sisIDText.Size = new System.Drawing.Size(232, 22);
            this.MB_sisIDText.TabIndex = 34;
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(35, 765);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(88, 17);
            this.label22.TabIndex = 50;
            this.label22.Text = "File Headers";
            // 
            // MB_LastName
            // 
            this.MB_LastName.Location = new System.Drawing.Point(163, 413);
            this.MB_LastName.Name = "MB_LastName";
            this.MB_LastName.Size = new System.Drawing.Size(232, 22);
            this.MB_LastName.TabIndex = 36;
            // 
            // MB_FileHeaderLine
            // 
            this.MB_FileHeaderLine.Location = new System.Drawing.Point(129, 765);
            this.MB_FileHeaderLine.Name = "MB_FileHeaderLine";
            this.MB_FileHeaderLine.Size = new System.Drawing.Size(596, 22);
            this.MB_FileHeaderLine.TabIndex = 49;
            this.MB_FileHeaderLine.Text = "school_id,school_name,sis_id,last_name,first_name,middle_name,grade,username,pass" +
    "word";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(34, 419);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(73, 17);
            this.label23.TabIndex = 35;
            this.label23.Text = "last_name";
            // 
            // MB_EnrollCSVOutputFileName
            // 
            this.MB_EnrollCSVOutputFileName.Location = new System.Drawing.Point(129, 732);
            this.MB_EnrollCSVOutputFileName.Name = "MB_EnrollCSVOutputFileName";
            this.MB_EnrollCSVOutputFileName.Size = new System.Drawing.Size(511, 22);
            this.MB_EnrollCSVOutputFileName.TabIndex = 48;
            this.MB_EnrollCSVOutputFileName.Text = "\\testStudentFile1.csv";
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Location = new System.Drawing.Point(34, 455);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(74, 17);
            this.label24.TabIndex = 37;
            this.label24.Text = "first_name";
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Location = new System.Drawing.Point(35, 735);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(67, 17);
            this.label25.TabIndex = 47;
            this.label25.Text = "FileName";
            // 
            // MB_FirstName
            // 
            this.MB_FirstName.Location = new System.Drawing.Point(163, 455);
            this.MB_FirstName.Name = "MB_FirstName";
            this.MB_FirstName.Size = new System.Drawing.Size(232, 22);
            this.MB_FirstName.TabIndex = 38;
            // 
            // MB_EnrollCSVOutputPath
            // 
            this.MB_EnrollCSVOutputPath.Location = new System.Drawing.Point(129, 694);
            this.MB_EnrollCSVOutputPath.Name = "MB_EnrollCSVOutputPath";
            this.MB_EnrollCSVOutputPath.Size = new System.Drawing.Size(511, 22);
            this.MB_EnrollCSVOutputPath.TabIndex = 46;
            this.MB_EnrollCSVOutputPath.Text = "C:\\\\temp";
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Location = new System.Drawing.Point(34, 532);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(45, 17);
            this.label26.TabIndex = 39;
            this.label26.Text = "grade";
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Location = new System.Drawing.Point(34, 694);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(59, 17);
            this.label27.TabIndex = 45;
            this.label27.Text = "FilePath";
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
            this.MB_Grade_ComboBox.Location = new System.Drawing.Point(164, 523);
            this.MB_Grade_ComboBox.Name = "MB_Grade_ComboBox";
            this.MB_Grade_ComboBox.Size = new System.Drawing.Size(232, 24);
            this.MB_Grade_ComboBox.TabIndex = 40;
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.Location = new System.Drawing.Point(34, 570);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(71, 17);
            this.label28.TabIndex = 41;
            this.label28.Text = "username";
            // 
            // MB_Username
            // 
            this.MB_Username.Location = new System.Drawing.Point(164, 570);
            this.MB_Username.Name = "MB_Username";
            this.MB_Username.Size = new System.Drawing.Size(232, 22);
            this.MB_Username.TabIndex = 42;
            // 
            // label29
            // 
            this.label29.AutoSize = true;
            this.label29.Location = new System.Drawing.Point(35, 610);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(68, 17);
            this.label29.TabIndex = 43;
            this.label29.Text = "password";
            // 
            // MB_Password
            // 
            this.MB_Password.Location = new System.Drawing.Point(164, 610);
            this.MB_Password.Name = "MB_Password";
            this.MB_Password.Size = new System.Drawing.Size(232, 22);
            this.MB_Password.TabIndex = 44;
            // 
            // MB_output_xml_path
            // 
            this.MB_output_xml_path.Location = new System.Drawing.Point(221, 135);
            this.MB_output_xml_path.Name = "MB_output_xml_path";
            this.MB_output_xml_path.Size = new System.Drawing.Size(626, 22);
            this.MB_output_xml_path.TabIndex = 12;
            this.MB_output_xml_path.Text = "C:\\\\Users\\swycoff\\Desktop\\CSVGenerationProject\\BuildingXMLData.xml";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(34, 140);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(116, 17);
            this.label15.TabIndex = 11;
            this.label15.Text = "Output XML Path";
            // 
            // generate_building_data
            // 
            this.generate_building_data.Location = new System.Drawing.Point(963, 297);
            this.generate_building_data.Name = "generate_building_data";
            this.generate_building_data.Size = new System.Drawing.Size(246, 43);
            this.generate_building_data.TabIndex = 10;
            this.generate_building_data.Text = "Generate Building Data";
            this.generate_building_data.UseVisualStyleBackColor = true;
            this.generate_building_data.Click += new System.EventHandler(this.GenerateBuildingData_Click);
            // 
            // MB_SmallBldg_Max_NumOfSA
            // 
            this.MB_SmallBldg_Max_NumOfSA.Location = new System.Drawing.Point(557, 174);
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
            this.MB_SmallBldg_Max_NumOfSA.Size = new System.Drawing.Size(93, 22);
            this.MB_SmallBldg_Max_NumOfSA.TabIndex = 9;
            this.MB_SmallBldg_Max_NumOfSA.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(497, 174);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(32, 17);
            this.label18.TabIndex = 8;
            this.label18.Text = "and";
            // 
            // MB_SmallBldg_Min_NumOfSA
            // 
            this.MB_SmallBldg_Min_NumOfSA.Location = new System.Drawing.Point(387, 174);
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
            this.MB_SmallBldg_Min_NumOfSA.Size = new System.Drawing.Size(93, 22);
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
            this.label17.Location = new System.Drawing.Point(36, 176);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(345, 17);
            this.label17.TabIndex = 6;
            this.label17.Text = "Small Building: Random Number of Students Between";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(218, 81);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(385, 17);
            this.label16.TabIndex = 5;
            this.label16.Text = "size = 1-4 value  1=small, 2=medium, 3=large, 4=extra-large";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(215, 60);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(336, 17);
            this.label13.TabIndex = 4;
            this.label13.Text = "column_headers = \"size\" \"school_id\" \"school_name\"";
            this.label13.Click += new System.EventHandler(this.label13_Click);
            // 
            // MB_buildingCsvFilePath
            // 
            this.MB_buildingCsvFilePath.Location = new System.Drawing.Point(221, 107);
            this.MB_buildingCsvFilePath.Name = "MB_buildingCsvFilePath";
            this.MB_buildingCsvFilePath.Size = new System.Drawing.Size(626, 22);
            this.MB_buildingCsvFilePath.TabIndex = 3;
            this.MB_buildingCsvFilePath.Text = "C:\\\\Users\\swycoff\\Desktop\\CSVGenerationProject\\CSVBuildingData.csv";
            // 
            // csv_building_filePath
            // 
            this.csv_building_filePath.AutoSize = true;
            this.csv_building_filePath.Location = new System.Drawing.Point(33, 109);
            this.csv_building_filePath.Name = "csv_building_filePath";
            this.csv_building_filePath.Size = new System.Drawing.Size(182, 17);
            this.csv_building_filePath.TabIndex = 2;
            this.csv_building_filePath.Text = "Building Data CSV File Path";
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
            this.ClientSize = new System.Drawing.Size(1338, 872);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.studentsToGenerateNumber)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MB_SmallBldg_Max_NumOfSA)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MB_SmallBldg_Min_NumOfSA)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button generateCVSButton;
        private System.Windows.Forms.TextBox fileName_text;
        private System.Windows.Forms.TextBox file_header_text;
        private System.Windows.Forms.Label fileHeaders;
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
        private System.Windows.Forms.Label file_path_text;
        private System.Windows.Forms.TextBox filePathText;
        private System.Windows.Forms.Label label11;
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
        private System.Windows.Forms.TextBox MB_MiddleName;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.TextBox MB_sisIDText;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.TextBox MB_LastName;
        private System.Windows.Forms.TextBox MB_FileHeaderLine;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.TextBox MB_EnrollCSVOutputFileName;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.TextBox MB_FirstName;
        private System.Windows.Forms.TextBox MB_EnrollCSVOutputPath;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.ComboBox MB_Grade_ComboBox;
        private System.Windows.Forms.Label label28;
        private System.Windows.Forms.TextBox MB_Username;
        private System.Windows.Forms.Label label29;
        private System.Windows.Forms.TextBox MB_Password;
    }
}

