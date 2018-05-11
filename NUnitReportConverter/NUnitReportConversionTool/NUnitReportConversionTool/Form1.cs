using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Xml.XPath;
using System.Xml.Xsl;

namespace NUnitReportConversionTool {
    public partial class Form1 : Form {

        #region Entities and Lists
        TestFixture_Entity testFixtureEntity;
        ParameterizedMethod_Entity parameterizedMethodEntity;
        TestCase_Entity testCaseEntity;
        Properties_Entity properties_Entity;

        List<TestFixture_Entity> testFixtureEntityList;
        List<ParameterizedMethod_Entity> parameterizedMethodEntityList;
        List<TestCase_Entity> testCaseEntityList;
        List<Properties_Entity> propertiesEntityList;
        #endregion

        #region StringBuilders
        StringBuilder concatFixtureCategoryList;
        StringBuilder concatParamMethodCategoryList;
        StringBuilder fullreportCSV;
        #endregion

        #region Strings
        //Description is a specific property value reported separately from categories.
        string testParamMethodProperty_Description = "";
        #endregion

        public Form1() {
            InitializeComponent();
        }

        private List<TestFixture_Entity> ReadAllDataFromXML_PlaceIntoObjects() {
            //Tests with their associated test fixtures will be stored in this list.
            testFixtureEntityList = new List<TestFixture_Entity>();
            #region Load XML Document
            XmlDocument xmlDoc = new XmlDocument();
            xmlDoc.Load(PathNUnitExploreFileToAnalyze.Text);
            #endregion
            #region Get the test-suite elements and filter out all related information
            XmlNodeList testSuiteElements = xmlDoc.SelectNodes("//test-suite");
            foreach (XmlNode testSuiteElement in testSuiteElements) {
                #region  Checks to see if we are at the element that is the top of the data (TestFixture) that starts off the test fixture and its tests.
                if (testSuiteElement.Attributes[0].Value == "TestFixture") {
                    //Each Time We Find a Test Fixture, We Need a new TestFixture Object
                    testFixtureEntity = new TestFixture_Entity();
                    //Looks at each attribute in the text fixture node
                    #region Test Suite Attributes (Test Fixture Level Only)
                    foreach (XmlNode testSuiteFixtureAttribute in testSuiteElement.Attributes) {
                        //If the node attribute matches the attribute name specified, we store the value in the test fixture object properties
                        switch (testSuiteFixtureAttribute.Name.ToString()) {
                            case "type":
                                testFixtureEntity.Type = testSuiteFixtureAttribute.Value;
                                break;
                            case "id":
                                testFixtureEntity.ID = testSuiteFixtureAttribute.Value;
                                break;
                            case "name":
                                testFixtureEntity.Name = testSuiteFixtureAttribute.Value;
                                break;
                            case "fullname":
                                testFixtureEntity.FullName = testSuiteFixtureAttribute.Value;
                                break;
                            case "classname":
                                testFixtureEntity.ClassName = testSuiteFixtureAttribute.Value;
                                break;
                            case "runstate":
                                testFixtureEntity.RunState = testSuiteFixtureAttribute.Value;
                                break;
                            case "testcasecount":
                                testFixtureEntity.TestCaseCount = testSuiteFixtureAttribute.Value;
                                break;
                        }
                    }
                    #endregion
                    #region Test Suite Properties (Test Fixture Level Only)
                    //We are still working with the same text fixture and all its child elements, now moving onto the fixture properties
                    XmlNodeList testFixturePropertyElements = testSuiteElement.SelectNodes("properties/property");
                    //Now we are looking at each property element (in relation to the test fixture) and storing it in a fresh properties list
                    propertiesEntityList = new List<Properties_Entity>();
                    foreach (XmlNode propertyElement in testFixturePropertyElements) {
                        //Now we want to look at each attribute in the property element currently being processed.                      
                        properties_Entity = new Properties_Entity();
                        properties_Entity.PropName = propertyElement.Attributes["name"].Value.ToString();
                        properties_Entity.PropValue = propertyElement.Attributes["value"].Value.ToString();
                        //Then add each properties object to the properties list
                        propertiesEntityList.Add(properties_Entity);
                    }
                    //Now we store that list of properties into the test fixture object 
                    testFixtureEntity.PropertyList = propertiesEntityList;
                    #endregion
                    #region Test Suite (ParameterizedMethod Level Only) Parameterized Method = Method + Test Case = Each scenario you feed into the method (aka grade)
                    //This should get all the parameterized methods
                    XmlNodeList testSuitesWithinTestFixtureElement = testSuiteElement.SelectNodes("test-suite");
                    #region Get Parameterized Method Information
                    parameterizedMethodEntityList = new List<ParameterizedMethod_Entity>();
                    foreach (XmlNode testSuiteParameterizedMethods in testSuitesWithinTestFixtureElement) {
                        if (testSuiteParameterizedMethods.Attributes["type"].Value == "ParameterizedMethod") {
                            parameterizedMethodEntity = new ParameterizedMethod_Entity();
                            #region Attributes
                            foreach (XmlNode testSuiteParamMethodAttribute in testSuiteParameterizedMethods.Attributes) {
                                //If the node attribute matches the attribute name specified, we store the value in the test fixture object properties
                                switch (testSuiteParamMethodAttribute.Name.ToString()) {
                                    case "type":
                                        parameterizedMethodEntity.Type = testSuiteParamMethodAttribute.Value;
                                        break;
                                    case "id":
                                        parameterizedMethodEntity.Id = testSuiteParamMethodAttribute.Value;
                                        break;
                                    case "name":
                                        parameterizedMethodEntity.Name = testSuiteParamMethodAttribute.Value;
                                        break;
                                    case "fullname":
                                        parameterizedMethodEntity.FullName = testSuiteParamMethodAttribute.Value;
                                        break;
                                    case "classname":
                                        parameterizedMethodEntity.ClassName = testSuiteParamMethodAttribute.Value;
                                        break;
                                    case "runstate":
                                        parameterizedMethodEntity.RunState = testSuiteParamMethodAttribute.Value;
                                        break;
                                    case "testcasecount":
                                        parameterizedMethodEntity.TestCaseCount = testSuiteParamMethodAttribute.Value;
                                        break;
                                }
                            }
                            #endregion
                            #region Properties From The Parameterized Methods
                            XmlNodeList testSuites_ParamMethodProperties = testSuiteParameterizedMethods.SelectNodes("properties/property");
                            propertiesEntityList = new List<Properties_Entity>();
                            foreach (XmlNode propertyElement in testSuites_ParamMethodProperties) {
                                properties_Entity = new Properties_Entity();
                                properties_Entity.PropName = propertyElement.Attributes["name"].Value.ToString();
                                properties_Entity.PropValue = propertyElement.Attributes["value"].Value.ToString();
                                //All of these properties will be appended to each test case.
                                propertiesEntityList.Add(properties_Entity);
                            }
                            //Now that we have all the properties for the parameterized method, we associate that list to the parameterized method entity object
                            parameterizedMethodEntity.ParamMethodPropertiesList = propertiesEntityList;
                            #endregion
                            #region Param Method > Test Cases  
                            //We are still within the if (Parameterized Method) scope
                            XmlNodeList testCases_WithinParamTypes = testSuiteParameterizedMethods.SelectNodes("test-case");
                            testCaseEntityList = new List<TestCase_Entity>();
                            foreach (XmlNode testCaseElement in testCases_WithinParamTypes) {
                                testCaseEntity = new TestCase_Entity();
                                #region Attributes
                                foreach (XmlNode testCaseAttribute in testCaseElement.Attributes) {
                                    switch (testCaseAttribute.Name.ToString()) {
                                        case "id":
                                            testCaseEntity.Id = testCaseAttribute.Value;
                                            break;
                                        case "name":
                                            testCaseEntity.Name = testCaseAttribute.Value;
                                            break;
                                        case "fullname":
                                            testCaseEntity.FullName = testCaseAttribute.Value;
                                            break;
                                        case "methodname":
                                            testCaseEntity.MethodName = testCaseAttribute.Value;
                                            break;
                                        case "classname":
                                            testCaseEntity.ClassName = testCaseAttribute.Value;
                                            break;
                                        case "runstate":
                                            testCaseEntity.RunState = testCaseAttribute.Value;
                                            break;
                                        case "seed":
                                            testCaseEntity.Seed = testCaseAttribute.Value;
                                            break;
                                    }
                                }//Attributes of the test case have been added                                
                                //Add the test case to the list of test cases
                                testCaseEntityList.Add(testCaseEntity);
                                #endregion
                            }
                            //Now that we hae the list of test cases, we add that to the parameterized method entity
                            parameterizedMethodEntity.TestCaseEntityList = testCaseEntityList;
                            //Now we can add the complete Parameterized Method Entity to the List of ParameterizedMethods in the text fixture
                            parameterizedMethodEntityList.Add(parameterizedMethodEntity);
                        }
                        #endregion
                        #region Add the Test Param Methods to the Test Fixture
                        testFixtureEntity.ListOfParameterizedMethods = parameterizedMethodEntityList;
                        #endregion
                        #region For each Test Fixture after all information is added, we add it to the TestFixtureList
                        testFixtureEntityList.Add(testFixtureEntity);
                        #endregion
                    }
                }
            }
                return testFixtureEntityList;
            
            #endregion
            #endregion
            #endregion
        }
        private int CountTotalTestParamMethodsInAllTestFixtures() {
            int totalParamMethods = 0;
            foreach (TestFixture_Entity TestFixture in testFixtureEntityList) {
                int count = TestFixture.ListOfParameterizedMethods.Count;
                totalParamMethods += count;
            }
            return totalParamMethods;
        }
        private int CountTotalTestCasesInAllTestFixtures() {
            int totalTestCases = 0;
            foreach(TestFixture_Entity TestFixture in testFixtureEntityList) {
                    foreach(var paramMethodEntity in TestFixture.ListOfParameterizedMethods) {
                        int count = paramMethodEntity.TestCaseEntityList.Count;
                        totalTestCases += count;
                    }             
            }
            return totalTestCases;
        }

            private void ConvertNUnitReport_SelectedDataForAllTests(object sender, EventArgs e) {
            //Takes all the data in the NUnit report (that we specify) and puts it into testfixture objects 
            //TestFixture>ParamMethods
            //TestFixture > Properties
            //Param Methods > TestCases
            //Param Methods > Properties
            testFixtureEntityList = ReadAllDataFromXML_PlaceIntoObjects();

            #region Write the data that we want to a CSV File
            fullreportCSV = new StringBuilder();

            #region Stats
            int fixtureCount = testFixtureEntityList.Count();
            int parameterizedMethodCount = CountTotalTestParamMethodsInAllTestFixtures();
            int testCaseCount = CountTotalTestCasesInAllTestFixtures();
            #endregion
            #region Headers
            fullreportCSV.AppendLine("FixtureCount");
            fullreportCSV.AppendLine(fixtureCount.ToString());
            fullreportCSV.AppendLine("ParameterizedMethodCount");
            fullreportCSV.AppendLine(parameterizedMethodCount.ToString());
            fullreportCSV.AppendLine("TestCaseCount");
            fullreportCSV.AppendLine(testCaseCount.ToString());
            //We only want this written once so it stays here
            fullreportCSV.AppendLine("TestFixtureID, TestFixtureName, Categories, ParamMethodID, ParamMethodName, TestCaseRunState, TestCaseID, TestCaseName, Test Case Description");
            #endregion
            #region Fixture and Test Case Data            
            foreach (var testFixture in testFixtureEntityList) {
                concatFixtureCategoryList = new StringBuilder();
                foreach (var property in testFixture.PropertyList) {
                    if(property.PropValue != "Self") {
                        concatFixtureCategoryList.Append(property.PropValue + " | ");
                    }                    
                }
                #region Parameterized Method Data                
                foreach (var paramMethod in testFixture.ListOfParameterizedMethods) {               
                    concatParamMethodCategoryList = new StringBuilder();
                    foreach (var property in paramMethod.ParamMethodPropertiesList) {
                        if (property.PropName == "Description") {
                            testParamMethodProperty_Description = property.PropValue;
                        } else if(property.PropName == "Category"){
                            concatParamMethodCategoryList.Append(property.PropValue + " | ");
                        }
                    }
                    #endregion
                    #region Test Case Data
                    foreach (var testcase in paramMethod.TestCaseEntityList) {
                        //Now lets combine the test fixture and test case categories together
                        string testFixtureAndParameterizedMethodCategories = concatFixtureCategoryList.ToString() + concatParamMethodCategoryList.ToString();

                        //Now that we have the test fixture and test parameterized method data for one test case, we report a line for that test case before repeating
                        // Combine the test fixture and test case categories together

                        #region Write Report Line
                        StringBuilder reportLine = new StringBuilder();
                        reportLine.Append(testFixture.ID + ",");
                        reportLine.Append(testFixture.Name + ",");
                        reportLine.Append(testFixtureAndParameterizedMethodCategories + ",");
                        reportLine.Append(paramMethod.Id + ",");
                        reportLine.Append(paramMethod.Name + ",");
                        reportLine.Append(testcase.RunState + ",");
                        reportLine.Append(testcase.Id + ",");
                        reportLine.Append(testcase.Name + ",");
                        reportLine.Append(testParamMethodProperty_Description);
                        fullreportCSV.AppendLine(reportLine.ToString());
                    
                        

                        //fullreportCSV.AppendLine(testFixture.ID + "," + testFixture.Name + "," + testFixtureAndParameterizedMethodCategories + "," + paramMethod.Id + ","+ paramMethod.Name + "," + testCaseEntity.RunState + "," + testCaseEntity.Name + "," + testParamMethodProperty_Description);
                        #endregion

                }
                    #endregion
                } // End foreach param method
                #endregion
            }
            #endregion

            #region Output Report
            string filePath = @GenerateReportToPath.Text + @"\" + @ReportOutputName.Text + ".csv";
            try {
                if (!File.Exists(filePath)) {
                    MessageBoxButtons buttonsSuccess = MessageBoxButtons.OK;
                    File.WriteAllText(filePath, fullreportCSV.ToString());
                    DialogResult successResult = MessageBox.Show("Your file has processed successfully.", "SUCCESS", buttonsSuccess);
                    return;
                } else {
                    //The file exists, we should delete it and start fresh.
                    File.Delete(filePath);
                    MessageBoxButtons buttonsSuccess = MessageBoxButtons.OK;
                    File.WriteAllText(filePath, fullreportCSV.ToString());
                    DialogResult successResult = MessageBox.Show("Your file has processed successfully.", "SUCCESS", buttonsSuccess);
                    return;
                }
            } catch (Exception ex) {
                MessageBoxButtons buttons = MessageBoxButtons.RetryCancel;
                DialogResult result = MessageBox.Show("The file is open (we could not delete it), please close the file", "FILE ACCESS ERROR", buttons);
                while (result == System.Windows.Forms.DialogResult.Retry) {
                    try {
                        if (!File.Exists(filePath)) {
                            MessageBoxButtons buttonsSuccess = MessageBoxButtons.OK;
                            File.WriteAllText(filePath, fullreportCSV.ToString());
                            DialogResult successResult = MessageBox.Show("Your file has processed successfully.", "SUCCESS", buttonsSuccess);
                            return;
                        } else {
                            //The file exists, we should delete it and start fresh.
                            File.Delete(filePath);
                            MessageBoxButtons buttonsSuccess = MessageBoxButtons.OK;
                            File.WriteAllText(filePath, fullreportCSV.ToString());
                            DialogResult successResult = MessageBox.Show("Your file has processed successfully.", "SUCCESS", buttonsSuccess);
                            return;
                        }
                    } catch (Exception ex2) {
                        buttons = MessageBoxButtons.RetryCancel;
                        result = MessageBox.Show("The file is open (we could not delete it), please close the file", "FILE ACCESS ERROR", buttons);
                    }
                }







                //    if (!File.Exists(filePath)) {
                //        MessageBoxButtons buttonsSuccess = MessageBoxButtons.OK;
                //        File.WriteAllText(filePath, fullreportCSV.ToString());
                //        DialogResult successResult = MessageBox.Show("Your file has processed successfully.", "SUCCESS", buttonsSuccess);
                //    } else {
                //        try {                           
                //        } catch (System.IO.IOException ex2) {
                //            result = MessageBox.Show("The file is open, please close the file", "FILE ACCESS ERROR", buttons);
                //        }
                //    }
                //}
            //} else {
            //    MessageBoxButtons buttons = MessageBoxButtons.RetryCancel;
            //    DialogResult result = MessageBox.Show("The file is open, please close the file", "FILE ACCESS ERROR", buttons);
            //    while (result == System.Windows.Forms.DialogResult.Retry) {
            //        if (!File.Exists(filePath)) {
            //            MessageBoxButtons buttonsSuccess = MessageBoxButtons.OK;
            //            File.WriteAllText(filePath, fullreportCSV.ToString());
            //            DialogResult successResult = MessageBox.Show("Your file has processed successfully.", "SUCCESS", buttonsSuccess);
            //        } else {
            //            result = MessageBox.Show("The file is open, please close the file", "FILE ACCESS ERROR", buttons);
            //        }
            //     }
        }
            //} catch(System.IO.IOException ex) {
            //    MessageBoxButtons buttons = MessageBoxButtons.RetryCancel;
            //    DialogResult result = MessageBox.Show("The file is open, please close the file", "FILE ACCESS ERROR", buttons);                
            //    while (result == System.Windows.Forms.DialogResult.Retry) {
            //        if (!File.Exists(filePath)) {
            //            MessageBoxButtons buttonsSuccess = MessageBoxButtons.OK;
            //            File.WriteAllText(filePath, fullreportCSV.ToString());
            //            DialogResult successResult = MessageBox.Show("Your file has processed successfully.", "SUCCESS", buttonsSuccess);
            //        } else {
            //            try {
            //                File.Delete(filePath);
            //                File.WriteAllText(filePath, fullreportCSV.ToString());
            //            } catch(System.IO.IOException ex2) {
            //                result = MessageBox.Show("The file is open, please close the file", "FILE ACCESS ERROR", buttons);
            //            }                       
            //        }
            //    } 

           // }
            
            #endregion

            #endregion
        }

    }
}
