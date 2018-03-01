using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormCSVGenerator_EnrollFiles {
    public partial class Form1 : Form {
        Random rnd;
        public Form1() {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e) {

        }

        private void label4_Click(object sender, EventArgs e) {

        }

        private void label5_Click(object sender, EventArgs e) {

        }

        private void generateCSVButton_Click(object sender, EventArgs e) {
            //Checks to see if the file exists, if it does it deletes it so we can start fresh each time
            string fullFillePathAndFileName = filePathText.Text + fileName_text.Text;
            if (File.Exists(fullFillePathAndFileName)) {
                File.Delete(fullFillePathAndFileName);
            }
            StringBuilder csvcontent = new StringBuilder();

            //Builds Header Information Based on File Header Text Feild
            csvcontent.AppendLine(file_header_text.Text);

            #region  Build The Student Object From The Form
            List<EnrollStudent> studentsForCSVFileList = new List<EnrollStudent>();
            int trackRollingGradeState = 1;
            for(int i = 0; i < studentsToGenerateNumber.Value; i++) {
                EnrollStudent student = new EnrollStudent();
                if (school_id_text.Text != "") {
                    student.School_Id = school_id_text.Text;
                }
                if (school_name_text.Text != "") {
                    student.School_Name = school_name_text.Text;
                }
                if (sis_id_student_text.Text != "") {
                    student.Sis_Id = sis_id_student_text.Text + i;
                }
                if (last_name_text.Text != "") {
                    student.Last_Name = last_name_text.Text + i;
                }
                if (first_name_text.Text != "") {
                    student.First_Name = first_name_text.Text + i;
                }
                if(middle_name_text.Text != "") {
                    student.Middle_Name = middle_name_text.Text + i;
                }
                #region Grade
                if (rolling_grade_checkbox.Checked) {
                    if(trackRollingGradeState >=0 || trackRollingGradeState <= 14) {
                        student.Grade = GetStudentGradeText(trackRollingGradeState);
                        if(trackRollingGradeState == 14) {
                            trackRollingGradeState = 1;
                        } else {
                            trackRollingGradeState++;
                        }
                    } else {
                        student.Grade = "In generating a grade name, the number was not between 1 and 14 for the db grade ID";
                    }
                } else if (randomize_grade_checkbox.Checked) {
                    rnd = new Random();
                    student.Grade = GetStudentGradeText(rnd.Next(1, 15));
                    System.Threading.Thread.Sleep(5);
                } else {
                    student.Grade = grade_combo_box.Text;
                }
                #endregion

                if (username_text.Text != "") {
                    student.Username = username_text.Text + i;
                }
                if (password_text.Text != "") {
                    student.Password = password_text.Text + i;
                }
                studentsForCSVFileList.Add(student);
            }
            #endregion

            //Adds Each Student To a line in string builder
            foreach(EnrollStudent student in studentsForCSVFileList) {
                csvcontent.AppendLine(student.School_Id + "," + student.School_Name + "," + student.Sis_Id + "," +
                    student.Last_Name + "," + student.First_Name + "," + student.Middle_Name + "," + student.Grade + "," +
                    student.Username + "," + student.Password);
            }

            //Creates the file based on the file path and file name
            File.AppendAllText(fullFillePathAndFileName, csvcontent.ToString());
        }

        private string GetStudentGradeText(int dbGradeID) {
            switch (dbGradeID) {
                case 1:
                    return "Prek";
                case 2:
                   return "K";
                case 3:
                    return "1";
                case 4:
                    return "2";
                case 5:
                    return "3";
                case 6:
                    return "4";                  
                case 7:
                   return "5";
                case 8:
                    return "6";
                case 9:
                   return "7";
                case 10:
                    return "8";
                case 11:
                    return "9";
                case 12:
                    return "10";
                case 13:
                   return "11";
                case 14:
                   return "12";
                default:
                    return "invalid";
            }
        }
        private void label10_Click(object sender, EventArgs e) {

        }

        private void label12_Click(object sender, EventArgs e) {

        }

        private void filePathText_TextChanged(object sender, EventArgs e) {

        }

        private void label10_Click_1(object sender, EventArgs e) {

        }

        private void textBox1_TextChanged(object sender, EventArgs e) {

        }

        private void rolling_grade_checkbox_CheckedChanged(object sender, EventArgs e) {
            if (rolling_grade_checkbox.Checked) {
                grade_combo_box.Enabled = false;
                grade_combo_box.Text = "";
                randomize_grade_checkbox.Checked = false;
                randomize_grade_checkbox.Enabled = false;
            } else {
                grade_combo_box.Enabled = true;
                randomize_grade_checkbox.Enabled = true;
            }
        }

        private void randomize_grade_checkbox_CheckedChanged(object sender, EventArgs e) {
            if (randomize_grade_checkbox.Checked) {
                grade_combo_box.Enabled = false;
                grade_combo_box.Text = "";
                rolling_grade_checkbox.Checked = false;
                rolling_grade_checkbox.Enabled = false;
            } else {
                grade_combo_box.Enabled = true;
                rolling_grade_checkbox.Enabled = true;
            }
           
        }

        private void grade_combo_box_SelectedIndexChanged(object sender, EventArgs e) {
            //If we select an item in this list, we want to grey out the rolling checkbox and random grade checkbox
            if(grade_combo_box.SelectedIndex == 0) {
                rolling_grade_checkbox.Enabled = true;
                randomize_grade_checkbox.Enabled = true;                
            } else {
                rolling_grade_checkbox.Enabled = false;
                randomize_grade_checkbox.Enabled = false;
            }
        }
    }
}
