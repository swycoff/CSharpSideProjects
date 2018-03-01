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

            //Build The Student Object From The Form
            List<EnrollStudent> studentsForCSVFileList = new List<EnrollStudent>();
            for(int i = 0; i < studentsToGenerateNumber.Value; i++) {
                EnrollStudent student = new EnrollStudent();
                student.School_Id = school_id_text.Text;
                student.School_Name = school_name_text.Text;
                student.Sis_Id = sis_id_student_text.Text;
                student.Last_Name = last_name_text.Text;
                student.First_Name = first_name_text.Text;
                student.Middle_Name = middle_name_text.Text;
                student.Grade = grade_combo_box.Text;
                student.Username = username_text.Text;
                student.Password = password_text.Text;
                studentsForCSVFileList.Add(student);
            }

            //Adds Each Student To a line in string builder
            foreach(EnrollStudent student in studentsForCSVFileList) {
                csvcontent.AppendLine(student.School_Id + "," + student.School_Name + "," + student.Sis_Id + "," +
                    student.Last_Name + "," + student.First_Name + "," + student.Middle_Name + "," + student.Grade + "," +
                    student.Username + "," + student.Password);
            }

            //Creates the file based on the file path and file name
            File.AppendAllText(fullFillePathAndFileName, csvcontent.ToString());
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
    }
}
