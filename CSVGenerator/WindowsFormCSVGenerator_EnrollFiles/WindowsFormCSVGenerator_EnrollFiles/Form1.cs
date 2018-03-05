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
        List<EnrollRoster> enrollRosterList;
        EnrollRoster enrollRoster;
        string buildingXMLFileName = "\\BuildingXMLData.xml";
        string studentXMLFileName = "\\StudentCSVData.xml";
        string facultyXMLFileName = "\\FacultyCSVData.xml";
        int trackingStudentRollingID= 0;
        int trackingFacultyRollingID = 0;

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
                    enrollStudent.Sis_Id = sis_id_student_text.Text + trackingStudentRollingID;
                }
                if (last_name_text.Text != "") {
                    enrollStudent.Last_Name = last_name_text.Text + trackingStudentRollingID;
                }
                if (first_name_text.Text != "") {
                    enrollStudent.First_Name = first_name_text.Text + trackingStudentRollingID;
                }
                if(middle_name_text.Text != "") {
                    enrollStudent.Middle_Name = middle_name_text.Text + trackingStudentRollingID;
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
                    enrollStudent.Username = username_text.Text + trackingStudentRollingID;
                }
                if (password_text.Text != "") {
                    if (auto_increment_password_checkbox.Checked) {
                        enrollStudent.Password = password_text.Text + trackingStudentRollingID;
                    } else {
                        enrollStudent.Password = password_text.Text;
                    }                    
                }
                studentsForCSVFileListSmallBuilding.Add(enrollStudent);
                trackingStudentRollingID++;
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
            xml.Save(MB_output_xml_path.Text + buildingXMLFileName);
            #endregion

            #region Takes XML, parses into elements of XML that allows us to build a list of what we need
            // Xpath loads the XML document into a list of objects we can enumerate over
            XElement xelement;
            IEnumerable<XElement> enrollBuildingsInXML;
            xelement = XElement.Load(MB_output_xml_path.Text + buildingXMLFileName);
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
            #endregion
            #endregion  Build Student Object                          
            #endregion Actions on Building Data

            #region Add All Information To the CSV / Generate Roster XML for Later
            if (MB_GenerateStudentFileCHBX.Checked) {
                File.AppendAllText(studentFullFillePathAndFileName, csvcontent.ToString());

                #region Generate the Student Roster XML File for later parsing            
                string[] studentLines = File.ReadAllLines(studentFullFillePathAndFileName);
                XElement studentXml = studentDataCSVStructure(studentLines);
                studentXml.Save(MB_output_xml_path.Text + studentXMLFileName);
                #endregion

            } else if (MB_GenerateFacultyFileCHBX.Checked) {
                File.AppendAllText(facultyFullFillePathAndFileName, csvcontent.ToString());

                #region Generate the Faculty Roster XML File for later parsing            
                string[] facultyLines = File.ReadAllLines(facultyFullFillePathAndFileName);
                XElement facultyXml = facultyDataCSVStructure(facultyLines);
                facultyXml.Save(MB_output_xml_path.Text + facultyXMLFileName);
                #endregion
            }
            if (MB_GenerateStudentFileCHBX.Checked) {
                MessageBox.Show("Student File Was Created");
            } else if (MB_GenerateFacultyFileCHBX.Checked){
                MessageBox.Show("Faculty File Was Created");
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
        /// <summary>
        /// Converts a student CSV to XML - called by the generateStudentData Method
        /// </summary>
        /// <param name="lines"></param>
        /// <returns></returns>
        public XElement studentDataCSVStructure(string[] lines) {
            XElement studentXml = new XElement("Root",
                from str in lines
                let columns = str.Split(',')
                select new XElement("Building",
                    new XElement("school_id", columns[0]),
                    new XElement("school_name", columns[1]),
                    new XElement("sis_id", columns[2]),
                    new XElement("last_name", columns[3]),
                    new XElement("first_name", columns[4]),
                    new XElement("middle_name", columns[5]),
                    new XElement("grade", columns[6]),
                    new XElement("username", columns[7]),
                    new XElement("password", columns[8])
                      )
            );
            return studentXml;
        }
        /// <summary>
        /// Converts a Faculty CSV to XML - called by the generateStudentData Method
        /// </summary>
        /// <param name="lines"></param>
        /// <returns></returns>
        public XElement facultyDataCSVStructure(string[] lines) {
            XElement xml = new XElement("Root",
                from str in lines
                let columns = str.Split(',')
                select new XElement("Building",
                    new XElement("school_id", columns[0]),
                    new XElement("school_name", columns[1]),
                    new XElement("sis_id", columns[2]),
                    new XElement("last_name", columns[3]),
                    new XElement("first_name", columns[4]),
                    new XElement("email", columns[5]),
                    new XElement("username", columns[6]),
                    new XElement("password", columns[7])
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
                        enrollStudent.Sis_Id = MB_sisIDText.Text + trackingStudentRollingID;
                    }
                    if (MB_LastName.Text != "") {
                        enrollStudent.Last_Name = MB_LastName.Text + trackingStudentRollingID;
                    }
                    if (MB_FirstName.Text != "") {
                        enrollStudent.First_Name = MB_FirstName.Text + trackingStudentRollingID;
                    }
                    if (MB_MiddleName.Text != "") {
                        enrollStudent.Middle_Name = MB_MiddleName.Text + trackingStudentRollingID;
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
                        enrollStudent.Username = MB_Username.Text + trackingStudentRollingID;
                    }
                    if (MB_Password.Text != "") {
                        if (MB_AutoIncrementPW.Checked) {
                            enrollStudent.Password = MB_Password.Text + trackingStudentRollingID;
                        } else {
                            enrollStudent.Password = MB_Password.Text;
                        }
                    }
                    ListOfStudents.Add(enrollStudent);
                    trackingStudentRollingID++;
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
                        enrollFaculty.Sis_Id = MB_sisIDText.Text + trackingFacultyRollingID;
                    }
                    if (MB_LastName.Text != "") {
                        enrollFaculty.Last_Name = MB_LastName.Text + trackingFacultyRollingID;
                    }
                    if (MB_FirstName.Text != "") {
                        enrollFaculty.First_Name = MB_FirstName.Text + trackingFacultyRollingID;
                    }
                    if (MB_Email.Text != "") {
                        enrollFaculty.Email = MB_Email.Text + trackingFacultyRollingID;
                    }
                    if (MB_Username.Text != "") {
                        enrollFaculty.Username = MB_Username.Text + trackingFacultyRollingID;
                    }
                    if (MB_Password.Text != "") {
                        if (MB_AutoIncrementPW.Checked) {
                            enrollFaculty.Password = MB_Password.Text + trackingFacultyRollingID;
                        } else {
                            enrollFaculty.Password = MB_Password.Text;
                        }
                    }
                    ListOfFaculty.Add(enrollFaculty);
                    trackingFacultyRollingID++;
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
        private void MB_EnrollCSVOutputFileName_TextChanged(object sender, EventArgs e) {

        }

        private void MB_MediumBldg_Min_NumOfSA_ValueChanged(object sender, EventArgs e) {

        }

        private void label22_Click(object sender, EventArgs e) {

        }
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
            enrollRosterList = new List<EnrollRoster>();
            string facultyFilePathName = MB_output_xml_path.Text + facultyXMLFileName;
            string studentFilePathName = MB_output_xml_path.Text + studentXMLFileName;
            string rosterOutputFilePathName = MB_EnrollCSVOutputPath.Text + MB_RosterFilePath.Text;
            //Make sure that the student and faculty XML are created
            if (File.Exists(facultyFilePathName) && File.Exists(studentFilePathName)) {
                if (File.Exists(rosterOutputFilePathName)) {
                    //If the roster file is created - delete it
                    File.Delete(rosterOutputFilePathName);
                }
                // Xpath loads the XML document into a list of objects we can enumerate over
                XElement xelementStudents;
                IEnumerable<XElement> enrollStudentsInXML;
                xelementStudents = XElement.Load(studentFilePathName);
                enrollStudentsInXML = xelementStudents.Elements();

                // Xpath loads the XML document into a list of objects we can enumerate over
                XElement xelementFaculty;
                IEnumerable<XElement> enrollFacultyInXML;
                xelementFaculty = XElement.Load(facultyFilePathName);
                enrollFacultyInXML = xelementFaculty.Elements();

                int numOfFac = enrollFacultyInXML.Count();
                int numOfStudents = enrollStudentsInXML.Count();
                int shortFaculty = numOfStudents - numOfFac;

                //Make the List<EnrollRoster>
                foreach(var student in enrollStudentsInXML) { 
                    enrollRoster = new EnrollRoster();
                    enrollRoster.Student_SISID = student.Element("sis_id").Value;
                    enrollRosterList.Add(enrollRoster);
                }
                //Now we have all the students in the roster list, but no faculty
                int rosterCount = 0;
                foreach (var faculty in enrollFacultyInXML) {
                    enrollRosterList[rosterCount].Faculty_SISID = faculty.Element("sis_id").Value;
                    rosterCount++;                
                }

                int i = 0;
                trackingFacultyRollingID = rosterCount-1;
                while (shortFaculty >0) {
                    //continues where faculty need to be filled in
                    //User must specify FA username if they want one that isn't numbers for filling in the roster.                   
                    enrollRosterList[rosterCount].Faculty_SISID = MB_Username.Text + trackingFacultyRollingID;
                    rosterCount++;
                    trackingFacultyRollingID++;
                    shortFaculty--;
                    i++;
                }
            }
                StringBuilder csvcontentRoster = new StringBuilder();

            //adds header info to the csv content
            csvcontentRoster.AppendLine(MB_rosterFileHeaders.Text);
            //Now we need to add the XML to the string builder so we can write the file
            //Adds Each Student To a line in string builder
            int j = 1;
            foreach (EnrollRoster rosterLine in enrollRosterList) {
                if (j != 1) {
                    csvcontentRoster.AppendLine(rosterLine.Student_SISID + "," + rosterLine.Faculty_SISID);
                } else {
                    //skips the sis_id headers row
                }
                j++;

            }
            File.AppendAllText(rosterOutputFilePathName, csvcontentRoster.ToString());
            MessageBox.Show("Roster File Was Created");
        }
    }
}
