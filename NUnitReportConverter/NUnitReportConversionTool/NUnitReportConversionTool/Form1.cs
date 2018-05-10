using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Xml.XPath;
using System.Xml.Xsl;

namespace NUnitReportConversionTool {
    public partial class Form1 : Form {
        TestFixture_Entity testFixtureEntity;
        TestCase_Entity testCaseEntity;
        Properties_Entity properties_Entity;

        List<TestFixture_Entity> testFixtureEntityList;
        List<TestCase_Entity> testCaseEntityList;
        List<Properties_Entity> propertiesEntityList;
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
                    foreach (XmlNode testSuiteAttribute in testSuiteElement.Attributes) {
                        //If the node attribute matches the attribute name specified, we store the value in the test fixture object properties
                        switch (testSuiteAttribute.Name.ToString()) {
                            case "type":
                                testFixtureEntity.Type= testSuiteAttribute.Value;
                                break;
                            case "id":
                                testFixtureEntity.ID = testSuiteAttribute.Value;
                                break;
                            case "name":
                                testFixtureEntity.Name = testSuiteAttribute.Value;
                                break;
                            case "fullname":
                                testFixtureEntity.FullName = testSuiteAttribute.Value;
                                break;
                            case "classname":
                                testFixtureEntity.ClassName = testSuiteAttribute.Value;
                                break;
                            case "runstate":
                                testFixtureEntity.RunState = testSuiteAttribute.Value;
                                break;
                            case "testcasecount":
                                testFixtureEntity.TestCaseCount = Convert.ToInt32(testSuiteAttribute.Value);
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
                    #region Test Suite (ParameterizedMethod Level Only) These are the Categories on Each Test
                    XmlNodeList testSuites_ParamMethod = testSuiteElement.SelectNodes("test-suite");
                    #region Get the Properites from the Test Suite (this holds the parameterized methods aka tests)
                    foreach (XmlNode testSuiteParamMethod in testSuites_ParamMethod) {
                        if(testSuiteParamMethod.Attributes["type"].Value == "ParameterizedMethod") {
                            XmlNodeList testSuites_ParamMethodProperties = testSuiteParamMethod.SelectNodes("properties/property");
                            propertiesEntityList = new List<Properties_Entity>();
                            foreach(XmlNode propertyElement in testSuites_ParamMethodProperties) {
                                properties_Entity = new Properties_Entity();
                                properties_Entity.PropName = propertyElement.Attributes["name"].Value.ToString();
                                properties_Entity.PropValue = propertyElement.Attributes["value"].Value.ToString();
                                //All of these properties will be appended to each test case.
                                propertiesEntityList.Add(properties_Entity);
                            }
                            #region Now within the structure of the parameterized test, we need the test cases.  
                            //We are still within the if (Parameterized Method) scope
                            XmlNodeList testCases_WithinParamTypes = testSuiteParamMethod.SelectNodes("test-case");
                            testCaseEntityList = new List<TestCase_Entity>();
                            foreach(XmlNode testCaseElement in testCases_WithinParamTypes) {
                                //Create a new test case and add the properties from the test suite - parameterized method properties
                                testCaseEntity = new TestCase_Entity();
                                testCaseEntity.PropertyList = propertiesEntityList;
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
                            }
                            #endregion
                        } 
                    }
                    #endregion

                    #region Add the Test Cases to the Test Fixture
                    testFixtureEntity.ListOfTestCaseObjects = testCaseEntityList;
                    #endregion
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

            private void ConvertNUnitReport_Click(object sender, EventArgs e) {
            //Takes all the data in the NUnit report (that we specify) and puts it into testfixture objects (which hold test case and property data)
            testFixtureEntityList = ReadAllDataFromXML_PlaceIntoObjects();

            #region Write the data that we want to a file (CSV?)  - basic data
            //Will need to consider how we want this file to look to make it useful.
            #endregion
        }

        //private void label4_Click(object sender, EventArgs e) {

        //}

        //private void textBox1_TextChanged(object sender, EventArgs e) {

        //}
    }
}
