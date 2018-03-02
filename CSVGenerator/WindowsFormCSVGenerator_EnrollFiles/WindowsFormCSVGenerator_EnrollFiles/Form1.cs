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
        List<EnrollStudent> studentsForCSVFileListMediumBuilding;
        List<EnrollStudent> studentsForCSVFileListLargeBuilding;
        List<EnrollStudent> studentsForCSVFileListXLargeBuilding;
        List<EnrollFaculty> facultyForCSVFileListSmallBuilding;
        List<EnrollFaculty> facultyForCSVFileListMediumBuilding;
        List<EnrollFaculty> facultyForCSVFileListLargeBuilding;
        List<EnrollFaculty> facultyForCSVFileListXLargeBuilding;
        EnrollStudent enrollStudent;
        List<EnrollBuilding> smallBuildingsList;
        List<EnrollBuilding> mediumBuildingsList;
        List<EnrollBuilding> largeBuildingsList;
        List<EnrollBuilding> extraLargeBuildingsList;
        StringBuilder csvcontent;
        EnrollFaculty enrollFaculty;


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
            #region File Check and StringBuilder Setup
            //Checks to see if the file exists, if it does it deletes it so we can start fresh each time
            string studentFullFillePathAndFileName = MB_EnrollCSVOutputPath.Text + MB_EnrollCSVStudentOutputFileName.Text;
            string facultyFullFillePathAndFileName = MB_EnrollCSVOutputPath.Text + MB_EnrollCSVFacultyOutputFileName.Text;

            //TODO This just hangs after clicking ok on the message box - figure out how to let the user try again sometime in the future.
            //checks to see which type of file we are creating
            //bool studentORFacultyChbxSelected = false;
            //while (!studentORFacultyChbxSelected) {
            //    studentORFacultyChbxSelected = checkForStudentOrFacultyCheckboxSelectedOneReq(studentFullFillePathAndFileName, facultyFullFillePathAndFileName);
            //    return;
            //}


            //MB_EnrollCSVFacultyOutputFileName
            csvcontent = new StringBuilder();
            #endregion

            #region Builds Header Information Into StringBuilder (csvcontent)
            ////Builds Header Information Based on File Header Text Feild
                if (MB_GenerateStudentFileCHBX.Checked) {
                    csvcontent.AppendLine(MB_StudentFileHeader.Text);                    
                } else if (MB_GenerateFacultyFileCHBX.Checked) {
                    csvcontent.AppendLine(MB_FacultyHeader.Text);
                }
            #endregion

            #region  Build The Student Object From The Form (FOR EACH BUILDING LIST BY SIZE)

            #region SMALL BUILDINGS
            int smallBuildingMinRange = Convert.ToInt32(MB_SmallBldg_Min_NumOfSA.Value);
            int smallBuildingMaxRange = Convert.ToInt32(MB_SmallBldg_Max_NumOfSA.Value + 1);
            if (MB_GenerateStudentFileCHBX.Checked) {                
                studentsForCSVFileListSmallBuilding = GenerateListOfEnrollStudentsWithBldgData(smallBuildingsList, 
                    smallBuildingMinRange, smallBuildingMaxRange);
            } else if (MB_GenerateFacultyFileCHBX.Checked) {
                facultyForCSVFileListSmallBuilding = GenerateListOfEnrollFacultyWithBldgData(smallBuildingsList, 
                    smallBuildingMinRange, smallBuildingMaxRange);
            }

            //int trackRollingGradeStateSmallBldg = 1;
            //studentsForCSVFileListSmallBuilding = new List<EnrollStudent>();
            //foreach (EnrollBuilding enrollBuilding in smallBuildingsList) {
            //    rnd = new Random();
            //    int smallBuildingMinRange = Convert.ToInt32(MB_SmallBldg_Min_NumOfSA.Value);
            //    int smallBuildingMaxRange = Convert.ToInt32(MB_SmallBldg_Max_NumOfSA.Value + 1);
            //    int numberOfStudentsToGenerateForThisBldg = rnd.Next(smallBuildingMinRange, smallBuildingMaxRange);
            //    System.Threading.Thread.Sleep(50);

            //    for (int i = 0; i < numberOfStudentsToGenerateForThisBldg; i++) {
            //        enrollStudent = new EnrollStudent();
            //        if (enrollBuilding.School_Id != "") {
            //            enrollStudent.School_Id = enrollBuilding.School_Id;
            //        }
            //        if (enrollBuilding.School_Name != "") {
            //            enrollStudent.School_Name = enrollBuilding.School_Name;
            //        }
            //        if (MB_sisIDText.Text != "") {
            //            enrollStudent.Sis_Id = MB_sisIDText.Text + i;
            //        }
            //        if (MB_LastName.Text != "") {
            //            enrollStudent.Last_Name = MB_LastName.Text + i;
            //        }
            //        if (MB_FirstName.Text != "") {
            //            enrollStudent.First_Name = MB_FirstName.Text + i;
            //        }
            //        if (MB_MiddleName.Text != "") {
            //            enrollStudent.Middle_Name = MB_MiddleName.Text + i;
            //        }
            //        #region Grade
            //        if (MB_Rolling_Chbx.Checked) {
            //            if (trackRollingGradeStateSmallBldg >= 0 || trackRollingGradeStateSmallBldg <= 14) {
            //                enrollStudent.Grade = GetStudentGradeText(trackRollingGradeStateSmallBldg);
            //                if (trackRollingGradeStateSmallBldg == 14) {
            //                    trackRollingGradeStateSmallBldg = 1;
            //                } else {
            //                    trackRollingGradeStateSmallBldg++;
            //                }
            //            } else {
            //                enrollStudent.Grade = "In generating a grade name, the number was not between 1 and 14 for the db grade ID";
            //            }
            //        } else if (MB_RandomGradeCHBX.Checked) {
            //            rnd = new Random();
            //            enrollStudent.Grade = GetStudentGradeText(rnd.Next(1, 15));
            //            System.Threading.Thread.Sleep(5);
            //        } else {
            //            enrollStudent.Grade = MB_Grade_ComboBox.Text;
            //        }
            //        #endregion

            //        if (MB_Username.Text != "") {
            //            enrollStudent.Username = MB_Username.Text + i;
            //        }
            //        if (MB_Password.Text != "") {
            //            if (MB_AutoIncrementPW.Checked) {
            //                enrollStudent.Password = MB_Password.Text + i;
            //            } else {
            //                enrollStudent.Password = MB_Password.Text;
            //            }
            //        }
            //        studentsForCSVFileListSmallBuilding.Add(enrollStudent);
            //    }
            //}//Ends Foreach

            //    //Adds Each Student To a line in string builder
            //    foreach (EnrollStudent student in studentsForCSVFileListSmallBuilding) {
            //        csvcontent.AppendLine(student.School_Id + "," + student.School_Name + "," + student.Sis_Id + "," +
            //            student.Last_Name + "," + student.First_Name + "," + student.Middle_Name + "," + student.Grade + "," +
            //            student.Username + "," + student.Password);
            //    }
            #endregion

            #region MEDIUM BUILDINGS     
            int medBuildingMinRange = Convert.ToInt32(MB_MediumBldg_Min_NumOfSA.Value);
            int medBuildingMaxRange = Convert.ToInt32(MB_MediumBldg_Min_NumOfSA.Value + 1);
            if (MB_GenerateStudentFileCHBX.Checked) {               
                studentsForCSVFileListMediumBuilding= GenerateListOfEnrollStudentsWithBldgData(mediumBuildingsList, 
                    medBuildingMinRange, medBuildingMaxRange);
            } else if (MB_GenerateFacultyFileCHBX.Checked) {
                facultyForCSVFileListMediumBuilding = GenerateListOfEnrollFacultyWithBldgData(mediumBuildingsList,
                 medBuildingMinRange, medBuildingMaxRange);
            }

            //int trackRollingGradeStateMedBldg = 1;
            //studentsForCSVFileListMediumBuilding = new List<EnrollStudent>();
            //foreach (EnrollBuilding enrollBuildingMed in mediumBuildingsList) {
            //    rnd = new Random();
            //    int medBuildingMinRange = Convert.ToInt32(MB_MediumBldg_Min_NumOfSA.Value);
            //    int medBuildingMaxRange = Convert.ToInt32(MB_MediumBldg_Min_NumOfSA.Value + 1);
            //    int numberOfStudentsToGenerateForThisMediumBldg = rnd.Next(medBuildingMinRange, medBuildingMaxRange);
            //    System.Threading.Thread.Sleep(100);

            //    for (int i = 0; i < numberOfStudentsToGenerateForThisMediumBldg; i++) {
            //        enrollStudent = new EnrollStudent();
            //        if (enrollBuildingMed.School_Id != "") {
            //            enrollStudent.School_Id = enrollBuildingMed.School_Id;
            //        }
            //        if (enrollBuildingMed.School_Name != "") {
            //            enrollStudent.School_Name = enrollBuildingMed.School_Name;
            //        }
            //        if (MB_sisIDText.Text != "") {
            //            enrollStudent.Sis_Id = MB_sisIDText.Text + i;
            //        }
            //        if (MB_LastName.Text != "") {
            //            enrollStudent.Last_Name = MB_LastName.Text + i;
            //        }
            //        if (MB_FirstName.Text != "") {
            //            enrollStudent.First_Name = MB_FirstName.Text + i;
            //        }
            //        if (MB_MiddleName.Text != "") {
            //            enrollStudent.Middle_Name = MB_MiddleName.Text + i;
            //        }
            //        #region Grade
            //        if (MB_Rolling_Chbx.Checked) {
            //            if (trackRollingGradeStateMedBldg >= 0 || trackRollingGradeStateMedBldg <= 14) {
            //                enrollStudent.Grade = GetStudentGradeText(trackRollingGradeStateMedBldg);
            //                if (trackRollingGradeStateMedBldg == 14) {
            //                    trackRollingGradeStateMedBldg = 1;
            //                } else {
            //                    trackRollingGradeStateMedBldg++;
            //                }
            //            } else {
            //                enrollStudent.Grade = "In generating a grade name, the number was not between 1 and 14 for the db grade ID";
            //            }
            //        } else if (MB_RandomGradeCHBX.Checked) {
            //            rnd = new Random();
            //            enrollStudent.Grade = GetStudentGradeText(rnd.Next(1, 15));
            //            System.Threading.Thread.Sleep(5);
            //        } else {
            //            enrollStudent.Grade = MB_Grade_ComboBox.Text;
            //        }
            //        #endregion

            //        if (MB_Username.Text != "") {
            //            enrollStudent.Username = MB_Username.Text + i;
            //        }
            //        if (MB_Password.Text != "") {
            //            if (MB_AutoIncrementPW.Checked) {
            //                enrollStudent.Password = MB_Password.Text + i;
            //            } else {
            //                enrollStudent.Password = MB_Password.Text;
            //            }
            //        }
            //        studentsForCSVFileListMediumBuilding.Add(enrollStudent);
            //    }
            //}//Ends Foreach Building

            ////Adds Each Student To a line in string builder
            //foreach (EnrollStudent student in studentsForCSVFileListMediumBuilding) {
            //    csvcontent.AppendLine(student.School_Id + "," + student.School_Name + "," + student.Sis_Id + "," +
            //        student.Last_Name + "," + student.First_Name + "," + student.Middle_Name + "," + student.Grade + "," +
            //        student.Username + "," + student.Password);
            //}
            #endregion

            #region LARGE BUILDINGS
            int largeBuildingMinRange = Convert.ToInt32(MB_LargeBldg_Min_NumOfSA.Value);
            int largeBuildingMaxRange = Convert.ToInt32(MB_LargeBldg_Max_NumOfSA.Value + 1);
            if (MB_GenerateStudentFileCHBX.Checked) {               
                studentsForCSVFileListLargeBuilding= GenerateListOfEnrollStudentsWithBldgData(largeBuildingsList, 
                    largeBuildingMinRange, largeBuildingMaxRange);
            } else if (MB_GenerateFacultyFileCHBX.Checked) {
                facultyForCSVFileListLargeBuilding = GenerateListOfEnrollFacultyWithBldgData(largeBuildingsList,
                    largeBuildingMinRange, largeBuildingMaxRange);

            }
            //int trackRollingGradeStateLargeBldg = 1;
            //studentsForCSVFileListLargeBuilding = new List<EnrollStudent>();
            //foreach (EnrollBuilding enrollBuildingLarge in largeBuildingsList) {
            //    rnd = new Random();
            //    int largeBuildingMinRange = Convert.ToInt32(MB_LargeBldg_Min_NumOfSA.Value);
            //    int largeBuildingMaxRange = Convert.ToInt32(MB_LargeBldg_Max_NumOfSA.Value + 1);
            //    int numberOfStudentsToGenerateForThisLargeBldg = rnd.Next(largeBuildingMinRange, largeBuildingMaxRange);
            //    System.Threading.Thread.Sleep(50);

            //    for (int i = 0; i < numberOfStudentsToGenerateForThisLargeBldg; i++) {
            //        enrollStudent = new EnrollStudent();
            //        if (enrollBuildingLarge.School_Id != "") {
            //            enrollStudent.School_Id = enrollBuildingLarge.School_Id;
            //        }
            //        if (enrollBuildingLarge.School_Name != "") {
            //            enrollStudent.School_Name = enrollBuildingLarge.School_Name;
            //        }
            //        if (MB_sisIDText.Text != "") {
            //            enrollStudent.Sis_Id = MB_sisIDText.Text + i;
            //        }
            //        if (MB_LastName.Text != "") {
            //            enrollStudent.Last_Name = MB_LastName.Text + i;
            //        }
            //        if (MB_FirstName.Text != "") {
            //            enrollStudent.First_Name = MB_FirstName.Text + i;
            //        }
            //        if (MB_MiddleName.Text != "") {
            //            enrollStudent.Middle_Name = MB_MiddleName.Text + i;
            //        }
            //        #region Grade
            //        if (MB_Rolling_Chbx.Checked) {
            //            if (trackRollingGradeStateLargeBldg >= 0 || trackRollingGradeStateLargeBldg <= 14) {
            //                enrollStudent.Grade = GetStudentGradeText(trackRollingGradeStateLargeBldg);
            //                if (trackRollingGradeStateLargeBldg == 14) {
            //                    trackRollingGradeStateLargeBldg = 1;
            //                } else {
            //                    trackRollingGradeStateLargeBldg++;
            //                }
            //            } else {
            //                enrollStudent.Grade = "In generating a grade name, the number was not between 1 and 14 for the db grade ID";
            //            }
            //        } else if (MB_RandomGradeCHBX.Checked) {
            //            rnd = new Random();
            //            enrollStudent.Grade = GetStudentGradeText(rnd.Next(1, 15));
            //            System.Threading.Thread.Sleep(5);
            //        } else {
            //            enrollStudent.Grade = MB_Grade_ComboBox.Text;
            //        }
            //        #endregion

            //        if (MB_Username.Text != "") {
            //            enrollStudent.Username = MB_Username.Text + i;
            //        }
            //        if (MB_Password.Text != "") {
            //            if (MB_AutoIncrementPW.Checked) {
            //                enrollStudent.Password = MB_Password.Text + i;
            //            } else {
            //                enrollStudent.Password = MB_Password.Text;
            //            }
            //        }
            //        studentsForCSVFileListLargeBuilding.Add(enrollStudent);
            //    }
            //}//Ends Foreach Building
            // //Adds Each Student To a line in string builder
            //foreach (EnrollStudent student in studentsForCSVFileListLargeBuilding) {
            //    csvcontent.AppendLine(student.School_Id + "," + student.School_Name + "," + student.Sis_Id + "," +
            //        student.Last_Name + "," + student.First_Name + "," + student.Middle_Name + "," + student.Grade + "," +
            //        student.Username + "," + student.Password);
            //}
            #endregion

            #region XL BUILDINGS
            int XLargeBuildingMinRange = Convert.ToInt32(MB_XLargeBldg_Min_NumOfSA.Value);
            int XLargeBuildingMaxRange = Convert.ToInt32(MB_XLargeBldg_Max_NumOfSA.Value + 1);
            if (MB_GenerateStudentFileCHBX.Checked) {              
                studentsForCSVFileListXLargeBuilding= GenerateListOfEnrollStudentsWithBldgData(extraLargeBuildingsList, 
                    XLargeBuildingMinRange, XLargeBuildingMaxRange);
            } else if (MB_GenerateFacultyFileCHBX.Checked) {
                facultyForCSVFileListXLargeBuilding = GenerateListOfEnrollFacultyWithBldgData(extraLargeBuildingsList,
                    XLargeBuildingMinRange, XLargeBuildingMaxRange);
            }

            //int trackRollingGradeStateXLargeBldg = 1;
            //studentsForCSVFileListXLargeBuilding = new List<EnrollStudent>();
            //foreach (EnrollBuilding enrollBuildingXLarge in extraLargeBuildingsList) {
            //    rnd = new Random();
            //    int XLargeBuildingMinRange = Convert.ToInt32(MB_XLargeBldg_Min_NumOfSA.Value);
            //    int XLargeBuildingMaxRange = Convert.ToInt32(MB_XLargeBldg_Max_NumOfSA.Value + 1);
            //    int numberOfStudentsToGenerateForThisLargeBldg = rnd.Next(XLargeBuildingMinRange, XLargeBuildingMaxRange);
            //    System.Threading.Thread.Sleep(50);

            //    for (int i = 0; i < numberOfStudentsToGenerateForThisLargeBldg; i++) {
            //        enrollStudent = new EnrollStudent();
            //        if (enrollBuildingXLarge.School_Id != "") {
            //            enrollStudent.School_Id = enrollBuildingXLarge.School_Id;
            //        }
            //        if (enrollBuildingXLarge.School_Name != "") {
            //            enrollStudent.School_Name = enrollBuildingXLarge.School_Name;
            //        }
            //        if (MB_sisIDText.Text != "") {
            //            enrollStudent.Sis_Id = MB_sisIDText.Text + i;
            //        }
            //        if (MB_LastName.Text != "") {
            //            enrollStudent.Last_Name = MB_LastName.Text + i;
            //        }
            //        if (MB_FirstName.Text != "") {
            //            enrollStudent.First_Name = MB_FirstName.Text + i;
            //        }
            //        if (MB_MiddleName.Text != "") {
            //            enrollStudent.Middle_Name = MB_MiddleName.Text + i;
            //        }
            //        #region Grade
            //        if (MB_Rolling_Chbx.Checked) {
            //            if (trackRollingGradeStateXLargeBldg >= 0 || trackRollingGradeStateXLargeBldg <= 14) {
            //                enrollStudent.Grade = GetStudentGradeText(trackRollingGradeStateXLargeBldg);
            //                if (trackRollingGradeStateXLargeBldg == 14) {
            //                    trackRollingGradeStateXLargeBldg = 1;
            //                } else {
            //                    trackRollingGradeStateXLargeBldg++;
            //                }
            //            } else {
            //                enrollStudent.Grade = "In generating a grade name, the number was not between 1 and 14 for the db grade ID";
            //            }
            //        } else if (MB_RandomGradeCHBX.Checked) {
            //            rnd = new Random();
            //            enrollStudent.Grade = GetStudentGradeText(rnd.Next(1, 15));
            //            System.Threading.Thread.Sleep(5);
            //        } else {
            //            enrollStudent.Grade = MB_Grade_ComboBox.Text;
            //        }
            //        #endregion

            //        if (MB_Username.Text != "") {
            //            enrollStudent.Username = MB_Username.Text + i;
            //        }
            //        if (MB_Password.Text != "") {
            //            if (MB_AutoIncrementPW.Checked) {
            //                enrollStudent.Password = MB_Password.Text + i;
            //            } else {
            //                enrollStudent.Password = MB_Password.Text;
            //            }
            //        }
            //        studentsForCSVFileListXLargeBuilding.Add(enrollStudent);
            //    }
            //}//Ends Foreach Building

            ////Adds Each Student To a line in string builder
            //foreach (EnrollStudent student in studentsForCSVFileListXLargeBuilding) {
            //    csvcontent.AppendLine(student.School_Id + "," + student.School_Name + "," + student.Sis_Id + "," +
            //        student.Last_Name + "," + student.First_Name + "," + student.Middle_Name + "," + student.Grade + "," +
            //        student.Username + "," + student.Password);
            //}
            #endregion
            #endregion  Build Student Object                          
            #endregion Actions on Building Data

            #region Add All Information To the CSV
            if (MB_GenerateStudentFileCHBX.Checked) {
                File.AppendAllText(studentFullFillePathAndFileName, csvcontent.ToString());
            } else if (MB_GenerateFacultyFileCHBX.Checked) {
                File.AppendAllText(facultyFullFillePathAndFileName, csvcontent.ToString());
            }
            
            #endregion
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

        private List<EnrollStudent> GenerateListOfEnrollStudentsWithBldgData(List<EnrollBuilding> buildingsList, 
            int numberOfStudentsMIN, int numberOfStudentsMax) {
            int trackRollingGradeState = 1;
            List<EnrollStudent>ListOfStudents = new List<EnrollStudent>();
            foreach (EnrollBuilding enrollBuilding in buildingsList) {
                rnd = new Random();              
                int numberOfStudentsToGenerateForThisBldg = rnd.Next(numberOfStudentsMIN, numberOfStudentsMax);
                System.Threading.Thread.Sleep(50);

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
                    ListOfStudents.Add(enrollStudent);

                }
            }//Ends Foreach           

            //Adds Each Student To a line in string builder
            foreach (EnrollStudent student in ListOfStudents) {
                csvcontent.AppendLine(student.School_Id + "," + student.School_Name + "," + student.Sis_Id + "," +
                    student.Last_Name + "," + student.First_Name + "," + student.Middle_Name + "," + student.Grade + "," +
                    student.Username + "," + student.Password);
            }
            return ListOfStudents;

        }
        private List<EnrollFaculty> GenerateListOfEnrollFacultyWithBldgData(List<EnrollBuilding> buildingsList, 
           int numberOfFacultyMIN, int numberOfFacultyMax) {
            List<EnrollFaculty> ListOfFaculty = new List<EnrollFaculty>();
            foreach (EnrollBuilding enrollBuilding in buildingsList) {
                rnd = new Random();
                int numberFacultyToGenerateForThisBldg = rnd.Next(numberOfFacultyMIN, numberOfFacultyMax);
                System.Threading.Thread.Sleep(50);

                for (int i = 0; i < numberFacultyToGenerateForThisBldg; i++) {
                    enrollFaculty = new EnrollFaculty();
                    if (enrollBuilding.School_Id != "") {
                        enrollFaculty.School_Id = enrollBuilding.School_Id;
                    }
                    if (enrollBuilding.School_Name != "") {
                        enrollFaculty.School_Name = enrollBuilding.School_Name;
                    }
                    if (MB_sisIDText.Text != "") {
                        enrollFaculty.Sis_Id = MB_sisIDText.Text + i;
                    }
                    if (MB_LastName.Text != "") {
                        enrollFaculty.Last_Name = MB_LastName.Text + i;
                    }
                    if (MB_FirstName.Text != "") {
                        enrollFaculty.First_Name = MB_FirstName.Text + i;
                    }
                    if (MB_Email.Text != "") {
                        enrollFaculty.Email = MB_Email.Text + i;
                    }
                    if (MB_Username.Text != "") {
                        enrollFaculty.Username = MB_Username.Text + i;
                    }
                    if (MB_Password.Text != "") {
                        if (MB_AutoIncrementPW.Checked) {
                            enrollFaculty.Password = MB_Password.Text + i;
                        } else {
                            enrollFaculty.Password = MB_Password.Text;
                        }
                    }
                    ListOfFaculty.Add(enrollFaculty);

                }//Ends For
            }//Ends Foreach           

            //Adds Each Student To a line in string builder
            foreach (EnrollFaculty faculty in ListOfFaculty) {
                csvcontent.AppendLine(faculty.School_Id + "," + faculty.School_Name + "," + faculty.Sis_Id + "," +
                    faculty.Last_Name + "," + faculty.First_Name + "," + faculty.Email + "," +
                    faculty.Username + "," + faculty.Password);
            }
            return ListOfFaculty;

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

        private void MB_MediumBldg_Min_NumOfSA_ValueChanged(object sender, EventArgs e) {

        }

        private void label22_Click(object sender, EventArgs e) {

        }

        private void MB_GenerateStudentFileCHBX_CheckedChanged(object sender, EventArgs e) {
            if (MB_GenerateStudentFileCHBX.Checked) {
                MB_GenerateFacultyFileCHBX.Enabled = false;
            } else {
                MB_GenerateFacultyFileCHBX.Enabled = true;
            }
        }

        private void MB_GenerateFacultyFileCHBX_CheckedChanged(object sender, EventArgs e) {
            if (MB_GenerateFacultyFileCHBX.Checked) {
                MB_GenerateStudentFileCHBX.Enabled = false;
            } else {
                MB_GenerateStudentFileCHBX.Enabled = true;
            }
        }

        private void MB_EnrollCSVOutputFileName_TextChanged(object sender, EventArgs e) {

        }

        private bool checkForStudentOrFacultyCheckboxSelectedOneReq(string studentFilePathAndName, string facultyFilePathAndName) {
            if (MB_GenerateStudentFileCHBX.Checked) {
                if (File.Exists(studentFilePathAndName)) {
                    File.Delete(studentFilePathAndName);
                }
                return true;
            } else if (MB_GenerateFacultyFileCHBX.Checked) {
                if (File.Exists(facultyFilePathAndName)) {
                    File.Delete(facultyFilePathAndName);
                }
                return true;
            } else {
                MessageBox.Show("Please select a checkbox to generate a student file or faculty file");
                return false;
            }
        }

        private void MB_GenerateRosterFile_BTN_Click(object sender, EventArgs e) {
            string facultyFilePathName = MB_EnrollCSVOutputPath.Text + MB_EnrollCSVFacultyOutputFileName.Text;
            string studentFilePathName = MB_EnrollCSVOutputPath.Text + MB_EnrollCSVStudentOutputFileName.Text;
            if (File.Exists(facultyFilePathName) && File.Exists(studentFilePathName)) {

                //Read the XML file and build a roster object, then write it to its own Roster.CSV file
                
            } else {
                //figure out error prompting for user                
                return;
            }
        }
    }
}
