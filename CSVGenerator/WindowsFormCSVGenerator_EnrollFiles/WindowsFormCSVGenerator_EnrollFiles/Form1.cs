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
using System.Xml.Linq;

namespace WindowsFormCSVGenerator_EnrollFiles {
    public partial class Form1 : Form {
        Random rnd;
        EnrollBuilding enrollBuilding;
        List<EnrollStudent> studentsForCSVFileListSmallBuilding;
        EnrollStudent enrollStudent;
        List<EnrollBuilding> smallBuildingsList;
        List<EnrollBuilding> mediumBuildingsList;
        List<EnrollBuilding> largeBuildingsList;
        List<EnrollBuilding> extraLargeBuildingsList;

        public Form1() {
            InitializeComponent();
        }

        /// <summary>
        /// Single Building Generate CSV Button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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
            studentsForCSVFileListSmallBuilding = new List<EnrollStudent>();
            int trackRollingGradeState = 1;
            for(int i = 0; i < studentsToGenerateNumber.Value; i++) {
                enrollStudent = new EnrollStudent();
                if (school_id_text.Text != "") {
                    enrollStudent.School_Id = school_id_text.Text;
                }
                if (school_name_text.Text != "") {
                    enrollStudent.School_Name = school_name_text.Text;
                }
                if (sis_id_student_text.Text != "") {
                    enrollStudent.Sis_Id = sis_id_student_text.Text + i;
                }
                if (last_name_text.Text != "") {
                    enrollStudent.Last_Name = last_name_text.Text + i;
                }
                if (first_name_text.Text != "") {
                    enrollStudent.First_Name = first_name_text.Text + i;
                }
                if(middle_name_text.Text != "") {
                    enrollStudent.Middle_Name = middle_name_text.Text + i;
                }
                #region Grade
                if (rolling_grade_checkbox.Checked) {
                    if(trackRollingGradeState >=0 || trackRollingGradeState <= 14) {
                        enrollStudent.Grade = GetStudentGradeText(trackRollingGradeState);
                        if(trackRollingGradeState == 14) {
                            trackRollingGradeState = 1;
                        } else {
                            trackRollingGradeState++;
                        }
                    } else {
                        enrollStudent.Grade = "In generating a grade name, the number was not between 1 and 14 for the db grade ID";
                    }
                } else if (randomize_grade_checkbox.Checked) {
                    rnd = new Random();
                    enrollStudent.Grade = GetStudentGradeText(rnd.Next(1, 15));
                    System.Threading.Thread.Sleep(5);
                } else {
                    enrollStudent.Grade = grade_combo_box.Text;
                }
                #endregion

                if (username_text.Text != "") {
                    enrollStudent.Username = username_text.Text + i;
                }
                if (password_text.Text != "") {
                    if (auto_increment_password_checkbox.Checked) {
                        enrollStudent.Password = password_text.Text + i;
                    } else {
                        enrollStudent.Password = password_text.Text;
                    }                    
                }
                studentsForCSVFileListSmallBuilding.Add(enrollStudent);
            }
            #endregion

            //Adds Each Student To a line in string builder
            foreach(EnrollStudent student in studentsForCSVFileListSmallBuilding) {
                csvcontent.AppendLine(student.School_Id + "," + student.School_Name + "," + student.Sis_Id + "," +
                    student.Last_Name + "," + student.First_Name + "," + student.Middle_Name + "," + student.Grade + "," +
                    student.Username + "," + student.Password);
            }

            //Creates the file based on the file path and file name
            File.AppendAllText(fullFillePathAndFileName, csvcontent.ToString());
        }

        /// <summary>
        /// Converts the DB GradeID to the proper text for Enroll
        /// </summary>
        /// <param name="dbGradeID"></param>
        /// <returns></returns>
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
        private void MB_Rolling_Chbx_CheckedChanged(object sender, EventArgs e) {
            if (MB_Rolling_Chbx.Checked) {
                MB_Grade_ComboBox.Enabled = false;
                MB_Grade_ComboBox.Text = "";
                MB_RandomGradeCHBX.Checked = false;
                MB_RandomGradeCHBX.Enabled = false;
            } else {
                MB_Grade_ComboBox.Enabled = true;
                MB_RandomGradeCHBX.Enabled = true;
            }
        }

        private void MB_RandomGradeCHBX_CheckedChanged(object sender, EventArgs e) {
            if (MB_RandomGradeCHBX.Checked) {
                MB_Grade_ComboBox.Enabled = false;
                MB_Grade_ComboBox.Text = "";
                MB_Rolling_Chbx.Checked = false;
                MB_Rolling_Chbx.Enabled = false;
            } else {
                MB_Grade_ComboBox.Enabled = true;
                MB_Rolling_Chbx.Enabled = true;
            }

        }

        private void MB_Grade_ComboBox_SelectedIndexChanged(object sender, EventArgs e) {
            //If we select an item in this list, we want to grey out the rolling checkbox and random grade checkbox
            if (MB_Grade_ComboBox.SelectedIndex == 0) {
                MB_Rolling_Chbx.Enabled = true;
                MB_RandomGradeCHBX.Enabled = true;
            } else {
                MB_Rolling_Chbx.Enabled = false;
                MB_RandomGradeCHBX.Enabled = false;
            }
        }



        private void GenerateBuildingData_Click(object sender, EventArgs e) {
            #region Take the file given and convert it to XML for easy parsing of different district sizes            
            string[] lines = File.ReadAllLines(MB_buildingCsvFilePath.Text);
            XElement xml = buildingDataCSVStructure(lines);
            xml.Save(MB_output_xml_path.Text);
            #endregion

            #region Takes XML, parses into elements of XML that allows us to build a list of what we need
            // Xpath loads the XML document into a list of objects we can enumerate over
            XElement xelement;
            IEnumerable<XElement> enrollBuildingsInXML;
            xelement = XElement.Load(MB_output_xml_path.Text);
            enrollBuildingsInXML = xelement.Elements();

            #region List of building objects to hold XML data sorted by size           
            smallBuildingsList = new List<EnrollBuilding>();
            mediumBuildingsList = new List<EnrollBuilding>();
            largeBuildingsList = new List<EnrollBuilding>();
            extraLargeBuildingsList = new List<EnrollBuilding>();
            #endregion

            #region  This goes over every building that was in the XML file
            foreach (var building in enrollBuildingsInXML) {
                enrollBuilding = new EnrollBuilding();
                #region Debugging
                string size = building.Element("size").Value;
                string school_id = building.Element("school_id").Value;
                string school_name = building.Element("school_name").Value;
                #endregion

                if (building.Element("size").Value == "1") {
                    //These are the small buildings
                    enrollBuilding.Size = building.Element("size").Value;
                    enrollBuilding.School_Id = building.Element("school_id").Value;
                    enrollBuilding.School_Name = building.Element("school_name").Value;
                    smallBuildingsList.Add(enrollBuilding);
                }
                if(building.Element("size").Value == "2") {
                    //These are medium buildings
                    enrollBuilding.Size = building.Element("size").Value;
                    enrollBuilding.School_Id = building.Element("school_id").Value;
                    enrollBuilding.School_Name = building.Element("school_name").Value;
                    mediumBuildingsList.Add(enrollBuilding);
                }
                if (building.Element("size").Value == "3") {
                    //These are large buildings
                    enrollBuilding.Size = building.Element("size").Value;
                    enrollBuilding.School_Id = building.Element("school_id").Value;
                    enrollBuilding.School_Name = building.Element("school_name").Value;
                    largeBuildingsList.Add(enrollBuilding);
                }
                if (building.Element("size").Value == "4") {
                    //These are XL buildings
                    enrollBuilding.Size = building.Element("size").Value;
                    enrollBuilding.School_Id = building.Element("school_id").Value;
                    enrollBuilding.School_Name = building.Element("school_name").Value;
                    extraLargeBuildingsList.Add(enrollBuilding);
                }
              
            }//End foreach
            #endregion
            #endregion

            #region At this point we have a list of buildings for all sizes of districts / Perform Actions On That Data
            //Checks to see if the file exists, if it does it deletes it so we can start fresh each time
            string fullFillePathAndFileName = MB_EnrollCSVOutputPath.Text + MB_EnrollCSVOutputFileName.Text;
            if (File.Exists(fullFillePathAndFileName)) {
                File.Delete(fullFillePathAndFileName);
            }
            StringBuilder csvcontent = new StringBuilder();

            ////Builds Header Information Based on File Header Text Feild
            csvcontent.AppendLine(MB_FileHeaderLine.Text);

            //#region  Build The Student Object From The Form (FOR EACH BUILDING LIST BY SIZE)
            int trackRollingGradeState = 1;
            //Small Buildings
            studentsForCSVFileListSmallBuilding = new List<EnrollStudent>();
            foreach (EnrollBuilding enrollBuilding in smallBuildingsList) {
                rnd = new Random();
                int smallBuildingMinRange = Convert.ToInt32(MB_SmallBldg_Min_NumOfSA.Value);
                int smallBuildingMaxRange = Convert.ToInt32(MB_SmallBldg_Max_NumOfSA.Value + 1);
                int numberOfStudentsToGenerateForThisBldg = rnd.Next(smallBuildingMinRange, smallBuildingMaxRange);

                for (int i = 0; i < numberOfStudentsToGenerateForThisBldg; i++) {
                    enrollStudent = new EnrollStudent();
                    if (enrollBuilding.School_Id != "") {
                        enrollStudent.School_Id = enrollBuilding.School_Id;
                    }
                    if (enrollBuilding.School_Name != "") {
                        enrollStudent.School_Name = enrollBuilding.School_Name;
                    }
                    if (MB_sisIDText.Text != "") {
                        enrollStudent.Sis_Id = MB_sisIDText.Text + i;
                    }
                    if (MB_LastName.Text != "") {
                        enrollStudent.Last_Name = MB_LastName.Text + i;
                    }
                    if (MB_FirstName.Text != "") {
                        enrollStudent.First_Name = MB_FirstName.Text + i;
                    }
                    if (MB_MiddleName.Text != "") {
                        enrollStudent.Middle_Name = MB_MiddleName.Text + i;
                    }
                    #region Grade
                    if (MB_Rolling_Chbx.Checked) {
                        if (trackRollingGradeState >= 0 || trackRollingGradeState <= 14) {
                            enrollStudent.Grade = GetStudentGradeText(trackRollingGradeState);
                            if (trackRollingGradeState == 14) {
                                trackRollingGradeState = 1;
                            } else {
                                trackRollingGradeState++;
                            }
                        } else {
                            enrollStudent.Grade = "In generating a grade name, the number was not between 1 and 14 for the db grade ID";
                        }
                    } else if (MB_RandomGradeCHBX.Checked) {
                        rnd = new Random();
                        enrollStudent.Grade = GetStudentGradeText(rnd.Next(1, 15));
                        System.Threading.Thread.Sleep(5);
                    } else {
                        enrollStudent.Grade = MB_Grade_ComboBox.Text;
                    }
                    #endregion

                    if (MB_Username.Text != "") {
                        enrollStudent.Username = MB_Username.Text + i;
                    }
                    if (MB_Password.Text != "") {
                        if (MB_AutoIncrementPW.Checked) {
                            enrollStudent.Password = MB_Password.Text + i;
                        } else {
                            enrollStudent.Password = MB_Password.Text;
                        }
                    }
                    studentsForCSVFileListSmallBuilding.Add(enrollStudent);
                }


                //Adds Each Student To a line in string builder
                foreach (EnrollStudent student in studentsForCSVFileListSmallBuilding) {
                    csvcontent.AppendLine(student.School_Id + "," + student.School_Name + "," + student.Sis_Id + "," +
                        student.Last_Name + "," + student.First_Name + "," + student.Middle_Name + "," + student.Grade + "," +
                        student.Username + "," + student.Password);
                }
                #endregion
            }
            //Should be able to se the foreach (enrollStudent student in ..... med building just above this to continue to append lines for each building)




            //Creates the file based on the file path and file name (after all buildings and students are added to the list.
            File.AppendAllText(fullFillePathAndFileName, csvcontent.ToString());

        }

        /// <summary>
        /// Converts a building CSV to XML - called by the generateBuildingData Method
        /// </summary>
        /// <param name="lines"></param>
        /// <returns></returns>
        public XElement buildingDataCSVStructure(string[] lines) {
            XElement xml = new XElement("Root",
                from str in lines
                let columns = str.Split(',')
                select new XElement("Building",
                    new XElement("size", columns[0]),
                    new XElement("school_id", columns[1]),
                    new XElement("school_name", columns[2])
                      )
            );
            return xml;
        }



        #region Unused Methods - designer freaks out if deleted
        private void label1_Click(object sender, EventArgs e) {

        }

        private void label4_Click(object sender, EventArgs e) {

        }

        private void label5_Click(object sender, EventArgs e) {

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
        private void label13_Click(object sender, EventArgs e) {

        }
        private void label30_Click(object sender, EventArgs e) {

        }

        private void label39_Click(object sender, EventArgs e) {

        }

        private void label38_Click(object sender, EventArgs e) {

        }

        private void MB_AutoIncrementPW_CheckedChanged(object sender, EventArgs e) {

        }

        #endregion


    }
}
