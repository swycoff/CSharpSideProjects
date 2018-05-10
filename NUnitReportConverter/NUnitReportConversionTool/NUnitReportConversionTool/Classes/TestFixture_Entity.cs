using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NUnitReportConversionTool {
    public class TestFixture_Entity {
        private string type;
        private string iD;
        private string name;
        private string fullName;
        private string className;
        private string runState;
        private int testCaseCount;
        private string description;  // This is only a description at the test fixture level which we don't do often.  Its stored as a property in the XML

        //This represents the TestFixture (class) that contains 1 or more tests.  Each test is a test case.
        private List<TestCase_Entity> listOfTestCaseObjects;
        //Test fixtures have their own properties (categories)
        List<Properties_Entity> propertyList;

        public string Type { get { return type; } set { type = value; } }
        public string ID { get { return iD; } set { iD = value; } }
        public string Name { get { return name; } set { name = value; } }
        public string FullName { get { return fullName; } set { fullName = value; } }
        public string ClassName {  get { return className; } set { className = value; } }
        public string RunState { get { return runState; } set { runState = value; } }
        public int TestCaseCount { get { return testCaseCount; }set { testCaseCount = value; } }
        public string Description { get { return description; } set { description = value; } }
        public List<TestCase_Entity> ListOfTestCaseObjects { get { return listOfTestCaseObjects; }set { listOfTestCaseObjects = value; } }
        public List<Properties_Entity> PropertyList { get { return propertyList; } set { propertyList = value; } }

        #region Constructor
        public TestFixture_Entity() {
            ListOfTestCaseObjects = new List<TestCase_Entity>();
            PropertyList = new List<Properties_Entity>();
        }
        #endregion





    }
}
