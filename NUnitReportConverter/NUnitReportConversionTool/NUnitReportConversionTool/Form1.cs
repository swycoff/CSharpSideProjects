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

        //Pretty Report
        List<SimpleTestData_Entity> simpleTestData_EntityList;
        SimpleTestData_Entity simpleTestData_Entity;
        Category_Entity category_Entity;
        List<Category_Entity> categoryFixture_EntityList;
        List<Category_Entity> categoryTestLevel_EntityList;
        StringBuilder reportAllTests;
        #endregion

        #region StringBuilders
        StringBuilder concatFixtureCategoryList;
        StringBuilder concatParamMethodCategoryList;
        StringBuilder CSV_FullReport;
        StringBuilder CSV_HeaderAndData;
        StringBuilder CSV_RollupReport;
        #endregion

        #region Strings
        //Description is a specific property value reported separately from categories.
        string testParamMethodProperty_Description = "";
        string testFixtureAndParameterizedMethodCategories = "";
        string category1Text = "";
        string category2Text = "";
        string category3Text = "";
        string firstConcatANDORChoice = "";
        string secondConcatANDORChoice = "";
        int countOfFilteredTestCases = 0;
        int countOfFilteredTestMethods = 0;
        //Tracking Variables for each testMethod in the test fixture
        bool testMethodMatchedCat1 = false;
        bool testMethodMatchedCat2 = false;
        bool testMethodMatchedCat3 = false;
        //Tracking Variables for each test fixture
        bool testFixtureMatchedCat1 = false; 
        bool testFixtureMatchedCat2 = false;
        bool testFixtureMatchedCat3 = false;
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
                    /* DEBUG
                     * To simplify the data output for testing, in the if statement above add  && testSuiteElement.Attributes[1].Value == "0-1594" and use the test fixture #
                     */
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

                    }//end foreach param method
                    #region For each Test Fixture after all information is added, we add it to the TestFixtureList
                    testFixtureEntityList.Add(testFixtureEntity);
                    #endregion
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
            foreach (TestFixture_Entity TestFixture in testFixtureEntityList) {
                foreach (var paramMethodEntity in TestFixture.ListOfParameterizedMethods) {
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
            CSV_FullReport = new StringBuilder();
            CSV_RollupReport = new StringBuilder();
            CSV_HeaderAndData = new StringBuilder();
            #endregion
            #region Stats
            int fixtureCount = testFixtureEntityList.Count();
            int parameterizedMethodCount = CountTotalTestParamMethodsInAllTestFixtures();
            int testCaseCount = CountTotalTestCasesInAllTestFixtures();
            #endregion
            #region Headers
            CSV_RollupReport.AppendLine("Whole Library: Fixture Count");
            CSV_RollupReport.AppendLine(fixtureCount.ToString());
            CSV_RollupReport.AppendLine("Whole Library: Parameterized Method Count");
            CSV_RollupReport.AppendLine(parameterizedMethodCount.ToString());
            CSV_RollupReport.AppendLine("Whole Library: Test Case Count");
            CSV_RollupReport.AppendLine(testCaseCount.ToString());
            //We only want this written once so it stays here
            CSV_HeaderAndData.AppendLine("Test Fixture ID, Test Fixture Name, Categories, Param Method ID, Param Method Name, Param Method Description, Test Case Run State, Test Case ID, Test Case Name");
            #endregion
            #region Grab Form Data
            //We get these values from the form            
            if (Category1FormBox.Text != "") {
                category1Text = Category1FormBox.Text.ToLower();
            }
            if (Category2FormBox.Text != "") {
                category2Text = Category2FormBox.Text.ToLower();
            }
            if (Category3FormBox.Text != "") {
                category3Text = Category3FormBox.Text.ToLower();
            }
            if (Cat1And2_ANDORSelector.SelectedItem != null) {
                firstConcatANDORChoice = Cat1And2_ANDORSelector.SelectedItem.ToString();
            }
            if (Cat2And3_ANDORSelector.SelectedItem != null) {
                secondConcatANDORChoice = Cat2And3_ANDORSelector.SelectedItem.ToString();
            }
            #endregion
            #region Fixture and Test Case Data          
            simpleTestData_EntityList = new List<SimpleTestData_Entity>();

            foreach (var testFixture in testFixtureEntityList) {
                testFixtureMatchedCat1 = false;
                testFixtureMatchedCat2 = false;
                testFixtureMatchedCat3 = false;

                concatFixtureCategoryList = new StringBuilder();
                simpleTestData_Entity = new SimpleTestData_Entity();
                
                categoryFixture_EntityList = new List<Category_Entity>();

                foreach (var property in testFixture.PropertyList) {
                    if (property.PropValue != "Self") {
                        //If it meets any category or priority at this point, write it to the concat fixture string for now, we will compare AND/OR Later
                        if (property.PropValue == category1Text) {
                            testFixtureMatchedCat1 = true;
                        } else if (property.PropValue == category2Text) {
                            testFixtureMatchedCat2 = true;
                        } else if (property.PropValue == category3Text) {
                            testFixtureMatchedCat3 = true;
                        }
                        //We still want a list of all the categories regardless of the match to report on if it ends up meeting the criteria.
                        concatFixtureCategoryList.Append(property.PropValue + " | ");

                        //one category entity per category, added to a list
                        category_Entity = new Category_Entity();
                        if (property.PropName == "Category") {
                            category_Entity.setCategoryInfoBasedOnTextName(property.PropValue);
                            categoryFixture_EntityList.Add(category_Entity);
                        }
                    }
                }
                //After we went through all fixture categories we have if it matched the priority/ first or second categories

                //Now this continues in that one fixture adding in parameterized methods in that fixture.
                #region Parameterized Method Data                     
                foreach (var paramMethod in testFixture.ListOfParameterizedMethods) {
                    categoryTestLevel_EntityList = new List<Category_Entity>(); //this has to be new for each parm method (test)  because we are looping over tests in the fixture with different categories
                    testMethodMatchedCat1 = false;
                    testMethodMatchedCat2 = false;
                    testMethodMatchedCat3 = false;
                    concatParamMethodCategoryList = new StringBuilder();
                    testParamMethodProperty_Description = "";
                    foreach (var property in paramMethod.ParamMethodPropertiesList) {
                        //If it matched any priority or category, add it to the list for now.  We will compare AND/OR later
                        if (property.PropName == "Description") {
                            testParamMethodProperty_Description = property.PropValue;
                        } else if (property.PropName == "Category") {
                            if (property.PropValue == category1Text) {
                                testMethodMatchedCat1 = true;
                            } else if (property.PropValue == category2Text) {
                                testMethodMatchedCat2 = true;
                            } else if (property.PropValue == category3Text) {
                                testMethodMatchedCat3 = true;
                            }
                            // We still want a list of ALL categories in case this test matches criteria
                            concatParamMethodCategoryList.Append(property.PropValue + " | ");

                            //one category entity per category, added to a list
                            category_Entity = new Category_Entity();
                            if (property.PropName == "Category") {
                                category_Entity.setCategoryInfoBasedOnTextName(property.PropValue);
                                categoryTestLevel_EntityList.Add(category_Entity);
                            }                            
                        }
                    }

                    //We are still inside the foreach param method (so for each testfixture/test we do this comparison after we get through all parameters)
                    #region Looks at the list of categories/Priorities so far and compares AND/OR Criteria
                    //We want a blank string to concat values to each time
                    testFixtureAndParameterizedMethodCategories = "";

                    //For the pretty report we are only gathering test name (param method name), description and then wanting to format categories differently
                    //So we add it to it's own object for later use
                    simpleTestData_Entity = new SimpleTestData_Entity();

                    //Run the full report, nothing was selected.
                    if (category1Text == "" && firstConcatANDORChoice == "" && category2Text == ""
                        && secondConcatANDORChoice == "" && category3Text == "") {                        
                            //Only writes this for this method if it matched the category on the fixture level or the test parameterized test level.
                            testFixtureAndParameterizedMethodCategories = concatFixtureCategoryList.ToString() + concatParamMethodCategoryList.ToString();
                        simpleTestData_Entity.Category_EntityList.AddRange(categoryFixture_EntityList);
                        simpleTestData_Entity.Category_EntityList.AddRange(categoryTestLevel_EntityList);
                        countOfFilteredTestMethods++;
                        // If we only have one category selected and nothing else.
                    }else if (category1Text !="" && firstConcatANDORChoice == "" && category2Text=="" 
                        && secondConcatANDORChoice == "" && category3Text == "") {
                        if(testFixtureMatchedCat1 || testMethodMatchedCat1) {
                            //Only writes this for this method if it matched the category on the fixture level or the test parameterized test level.
                            testFixtureAndParameterizedMethodCategories = concatFixtureCategoryList.ToString() + concatParamMethodCategoryList.ToString();
                            simpleTestData_Entity.Category_EntityList.AddRange(categoryFixture_EntityList);
                            simpleTestData_Entity.Category_EntityList.AddRange(categoryTestLevel_EntityList);                            
                            countOfFilteredTestMethods++;
                        }
                        //Category 1 && Category2
                    } else if (category1Text != "" && firstConcatANDORChoice == "and" && category2Text != ""
                        && secondConcatANDORChoice == "" && category3Text == "") {
                        if ((testFixtureMatchedCat1 || testMethodMatchedCat1) && (testFixtureMatchedCat2 || testMethodMatchedCat2)) {
                            testFixtureAndParameterizedMethodCategories = concatFixtureCategoryList.ToString() + concatParamMethodCategoryList.ToString();
                            simpleTestData_Entity.Category_EntityList.AddRange(categoryFixture_EntityList);
                            simpleTestData_Entity.Category_EntityList.AddRange(categoryTestLevel_EntityList);
                            countOfFilteredTestMethods++;
                        }
                        //Category 1 || Category 2
                    } else if (category1Text != "" && firstConcatANDORChoice == "or" && category2Text != ""
                        && secondConcatANDORChoice == "" && category3Text == "") {
                        if ((testFixtureMatchedCat1 || testMethodMatchedCat1) || (testFixtureMatchedCat2 || testMethodMatchedCat2)) {
                            testFixtureAndParameterizedMethodCategories = concatFixtureCategoryList.ToString() + concatParamMethodCategoryList.ToString();
                            simpleTestData_Entity.Category_EntityList.AddRange(categoryFixture_EntityList);
                            simpleTestData_Entity.Category_EntityList.AddRange(categoryTestLevel_EntityList);
                            countOfFilteredTestMethods++;
                        }
                        //Category 1 && Category2 && Category3
                    } else if (category1Text != "" && firstConcatANDORChoice == "and" && category2Text != ""
                         && secondConcatANDORChoice == "and" && category3Text != "") {
                        if ((testFixtureMatchedCat1 || testMethodMatchedCat1) && (testFixtureMatchedCat2 || testMethodMatchedCat2)
                            && (testFixtureMatchedCat3 || testMethodMatchedCat3)) {
                            testFixtureAndParameterizedMethodCategories = concatFixtureCategoryList.ToString() + concatParamMethodCategoryList.ToString();
                            simpleTestData_Entity.Category_EntityList.AddRange(categoryFixture_EntityList);
                            simpleTestData_Entity.Category_EntityList.AddRange(categoryTestLevel_EntityList);
                            countOfFilteredTestMethods++;
                        }
                        //Category1 && Category2 || Category3
                    } else if (category1Text != "" && firstConcatANDORChoice == "and" && category2Text != ""
                          && secondConcatANDORChoice == "or" && category3Text != "") {
                        if (((testFixtureMatchedCat1 || testMethodMatchedCat1) && (testFixtureMatchedCat2 || testMethodMatchedCat2))
                            || (testFixtureMatchedCat3 || testMethodMatchedCat3)) {
                            testFixtureAndParameterizedMethodCategories = concatFixtureCategoryList.ToString() + concatParamMethodCategoryList.ToString();
                            simpleTestData_Entity.Category_EntityList.AddRange(categoryFixture_EntityList);
                            simpleTestData_Entity.Category_EntityList.AddRange(categoryTestLevel_EntityList);
                            countOfFilteredTestMethods++;
                        }
                        //Category1 || Category2 && Category3
                    } else if (category1Text != "" && firstConcatANDORChoice == "or" && category2Text != ""
                          && secondConcatANDORChoice == "and" && category3Text != "") {
                        if ((testFixtureMatchedCat1 || testMethodMatchedCat1) || ((testFixtureMatchedCat2 || testMethodMatchedCat2)
                            && (testFixtureMatchedCat3 || testMethodMatchedCat3))) {
                            testFixtureAndParameterizedMethodCategories = concatFixtureCategoryList.ToString() + concatParamMethodCategoryList.ToString();
                            simpleTestData_Entity.Category_EntityList.AddRange(categoryFixture_EntityList);
                            simpleTestData_Entity.Category_EntityList.AddRange(categoryTestLevel_EntityList);
                            countOfFilteredTestMethods++;
                        }
                        //Category1 || Category2 || Category3
                    } else if (category1Text != "" && firstConcatANDORChoice == "or" && category2Text != ""
                           && secondConcatANDORChoice == "or" && category3Text != "") {
                        if ((testFixtureMatchedCat1 || testMethodMatchedCat1) || (testFixtureMatchedCat2 || testMethodMatchedCat2)
                            || (testFixtureMatchedCat3 || testMethodMatchedCat3)) {
                            testFixtureAndParameterizedMethodCategories = concatFixtureCategoryList.ToString() + concatParamMethodCategoryList.ToString();
                            simpleTestData_Entity.Category_EntityList.AddRange(categoryFixture_EntityList);
                            simpleTestData_Entity.Category_EntityList.AddRange(categoryTestLevel_EntityList);
                            countOfFilteredTestMethods++;
                        }
                    }

                        #endregion

                        #region Checks to see based on priorities and categories desired if test should continue to process
                        if (testFixtureAndParameterizedMethodCategories.Length > 0) {
                        //If we found a matching category, we continue, otherwise it skips to the end.       
                        //This continues for this one parameter method to add the associated test cases, before looping back around to get the rest of the parameter methods in the fixture.
                        #region Test Case Data
                        if (excludeTestCasesChbox.Checked) {
                            #region Write Report Line                        
                            StringBuilder reportLine = new StringBuilder();
                            reportLine.Append(testFixture.ID + ",");
                            reportLine.Append(testFixture.Name + ",");
                            reportLine.Append(testFixtureAndParameterizedMethodCategories + ","); //categories we want
                            reportLine.Append(paramMethod.Id + ",");
                            reportLine.Append(paramMethod.Name + ","); // The test name we want
                            simpleTestData_Entity.TestName = paramMethod.Name;
                            string descriptionTemp = testParamMethodProperty_Description.Replace(",", "~"); //The desription we want
                            simpleTestData_Entity.TestDescription = descriptionTemp;
                            reportLine.Append(descriptionTemp + ",");
                            CSV_HeaderAndData.AppendLine(reportLine.ToString());
                            simpleTestData_EntityList.Add(simpleTestData_Entity);
                            #endregion
                        } else {
                            foreach (var testcase in paramMethod.TestCaseEntityList) {
                                //Now that we have the test fixture and test parameterized method data for one test case, we report a line for that test case before repeating
                                // Combine the test fixture and test case categories together
                                #region Write Report Line                        
                                StringBuilder reportLine = new StringBuilder();
                                reportLine.Append(testFixture.ID + ",");
                                reportLine.Append(testFixture.Name + ",");
                                reportLine.Append(testFixtureAndParameterizedMethodCategories + ","); //The categories we want
                                reportLine.Append(paramMethod.Id + ",");
                                reportLine.Append(paramMethod.Name + ","); //The test name we want
                                string descriptionTemp = testParamMethodProperty_Description.Replace(",", "~"); //The description we want
                                reportLine.Append(descriptionTemp + ",");
                                reportLine.Append(testcase.RunState + ",");
                                reportLine.Append(testcase.Id + ",");
                                reportLine.Append(testcase.Name + ",");
                                CSV_HeaderAndData.AppendLine(reportLine.ToString());
                                countOfFilteredTestCases++;
                                #endregion
                            }//Foreach Test Case in TestCaseEntityList
                        }                            
                            #endregion
                        }//End if matching categories found
                        #endregion (Checks to see based on priorities desired if test should continue to process)
                    } // End foreach param method
                    #endregion Parameterized Method Data
                    #endregion (Fixture and Test Case Data)
                    #endregion (Write the Data that we want to a CSV File)
                }  //End Foreach Test Fixture
                #region Add a few more reporting details for filtered test cases
                //eventually get this in the upper part of excel by specifying column and row specifics
                CSV_RollupReport.AppendLine("");
                CSV_RollupReport.AppendLine("Filtered Count of Test Methods: ");
                CSV_RollupReport.AppendLine(countOfFilteredTestMethods.ToString());
                CSV_RollupReport.AppendLine("Filtered Count of Test Cases: ");
                CSV_RollupReport.AppendLine(countOfFilteredTestCases.ToString());
            #endregion

            #region Output Report
            #region Make pretty
            //If Make Pretty Is Checked - we want to read the output file and make a new prettier one
            if (makePretty.Checked && simpleTestData_EntityList.Count > 0) {
                //These are for proper header line wrapping in excel
                string role_SAHeader = "\"" + "Role:" + "\n" + "\"" + "SA" + ",";
                string role_FAHeader = "\"" + "Role:" + "\n" + "\"" + "FA" + ",";
                string role_BSHeader = "\"" + "Role:" + "\n" + "\"" + "BS" + ",";
                string role_BAHeader = "\"" + "Role:" + "\n" + "\"" + "BA" + ",";
                string role_DAHeader = "\"" + "Role:" + "\n" + "\"" + "DA" + ",";
                string role_NRHeader = "\"" + "Role:" + "\n" + "\"" + "NonRole" + ",";
                string permission_ReaderHeader = "\"" + "Perm:" + "\n" + "\"" + "Reader" + ",";
                string permission_BooksHeader = "\"" + "Perm:" + "\n" + "\"" + "Books" + ",";
                string permission_SharedHeader = "\"" + "Perm:" + "\n" + "\"" + "Shared" + ",";
                string permission_NewsHeader = "\"" + "Perm:" + "\n" + "\"" + "News" + ",";
                string permission_OtherHeader = "\"" + "Perm:" + "\n" + "\"" + "OTHER" + ",";
                string gradeScope_AllGradeHeader = "\"" + "Grade Scope:" + "\n" + "\"" + "All Grade" + ",";
                string gradeScope_1LLHeader = "\"" + "Grade Scope:" + "\n" + "\"" + "1LL" + ",";
                string gradeScope_1ULHeader = "\"" + "Grade Scope:" + "\n" + "\"" + "1UL" + ",";
                string gradeScope_LLAllHeader = "\"" + "Grade Scope:" + "\n" + "\"" + "LL ALL" + ",";
                string gradeScope_ULAllHeader = "\"" + "Grade Scope:" + "\n" + "\"" + "UL ALL" + ",";
                string gradeScope_ULANDLL = "\"" + "Grade Scope:" + "\n" + "\"" + "1UL + 1LL" + ",";
                string gradeScope_RndHeader = "\"" + "Grade Scope:" + "\n" + "\"" + "Random" + ",";
                string gradeScope_OtherHeader  = "\"" + "Grade Scope:"  + "\n" + "\"" + "OTHER" + ",";
                string reportPrettyHeaders = "Test Number,Test Name,Test Description,"+ role_SAHeader + role_FAHeader + role_BSHeader + role_BAHeader + role_DAHeader + role_NRHeader
                    + permission_ReaderHeader+ permission_BooksHeader + permission_SharedHeader + permission_NewsHeader + permission_OtherHeader
                    + gradeScope_AllGradeHeader + gradeScope_1LLHeader + gradeScope_1ULHeader +  gradeScope_LLAllHeader + gradeScope_ULAllHeader
                    + gradeScope_ULANDLL + gradeScope_RndHeader + gradeScope_OtherHeader 
                    + "Priority,AppArea,AppAreaSubset,VisualValidationTypeTest";
                reportAllTests = new StringBuilder();
                reportAllTests.AppendLine(reportPrettyHeaders);            
                foreach(SimpleTestData_Entity testData in simpleTestData_EntityList) {
                    //For our report, since we want all related tests to be able to be filered together in excel, we parse the test number and test name separately. .
                    int firstUnderscorePosition = testData.TestName.IndexOf('_');
                    string testNumber = testData.TestName.Substring(0, firstUnderscorePosition);
                    string testName = testData.TestName.Substring(firstUnderscorePosition + 1);
                    string reportTestLine = testNumber + "," + testName +"," + testData.TestDescription + "," + testData.ReportOnSimpleTestData();
                    reportAllTests.AppendLine(reportTestLine);
                }
            }

            #endregion

            //First we need to put together the different stringbuilder methods we have going
            CSV_FullReport.Append(CSV_RollupReport);
                CSV_FullReport.Append(CSV_HeaderAndData);
                string filePath = @GenerateReportToPath.Text + @"\" + @ReportOutputName.Text + ".csv";
                string filePathPretty = @GenerateReportToPath.Text + @"\" + @ReportOutputName.Text + "_Pretty"+ ".csv";
            try {
                    if (!File.Exists(filePath) || !File.Exists(filePathPretty)) {
                        MessageBoxButtons buttonsSuccess = MessageBoxButtons.OK;
                        File.WriteAllText(filePath, CSV_FullReport.ToString());
                        File.WriteAllText(filePathPretty, reportAllTests.ToString());
                        DialogResult successResult = MessageBox.Show("Your file has processed successfully.", "SUCCESS", buttonsSuccess);
                        Application.Exit();
                        return;
                    } else {
                    //The file exists, we should delete it and start fresh.
                    if (!File.Exists(filePath)) {
                        File.Delete(filePath);
                    }
                    if (!File.Exists(filePathPretty)) {
                        File.Delete(filePathPretty);
                    }                        
                        MessageBoxButtons buttonsSuccess = MessageBoxButtons.OK;
                        File.WriteAllText(filePath, CSV_FullReport.ToString());
                        File.WriteAllText(filePathPretty, reportAllTests.ToString());

                    DialogResult successResult = MessageBox.Show("Your file has processed successfully.", "SUCCESS", buttonsSuccess);
                        Application.Exit();
                        return;
                    }
                } catch (Exception ex) {
                    MessageBoxButtons buttons = MessageBoxButtons.RetryCancel;
                    DialogResult result = MessageBox.Show("The file is open (we could not delete it), please close the file", "FILE ACCESS ERROR", buttons);
                    while (result == System.Windows.Forms.DialogResult.Retry) {
                        try {
                            if (!File.Exists(filePath)) {
                                MessageBoxButtons buttonsSuccess = MessageBoxButtons.OK;
                                File.WriteAllText(filePath, CSV_FullReport.ToString());
                                DialogResult successResult = MessageBox.Show("Your file has processed successfully.", "SUCCESS", buttonsSuccess);
                                Application.Exit();
                                return;
                            } else {
                                //The file exists, we should delete it and start fresh.
                                File.Delete(filePath);
                                MessageBoxButtons buttonsSuccess = MessageBoxButtons.OK;
                                File.WriteAllText(filePath, CSV_FullReport.ToString());
                                DialogResult successResult = MessageBox.Show("Your file has processed successfully.", "SUCCESS", buttonsSuccess);
                                Application.Exit();
                                return;
                            }
                        } catch (Exception ex2) {
                            buttons = MessageBoxButtons.RetryCancel;
                            result = MessageBox.Show("The file is open (we could not delete it), please close the file", "FILE ACCESS ERROR", buttons);
                        }


                } //End while                  

            }  //End Catch 
            #endregion

          

        }//End Convert Data For Tests

        private void ReportOutputName_TextChanged(object sender, EventArgs e) {

        }
    }//class

        }//namespace
 