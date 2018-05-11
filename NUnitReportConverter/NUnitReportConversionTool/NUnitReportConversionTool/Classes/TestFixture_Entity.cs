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
        private string testCaseCount;
       
        //Within the TestFixture, There are Methods (Parameterized Method).  
        //Each one of these methods can have data sets sent into it (for example, run this method for all 14 grades)
        //Each one of those 14 grades would be considerd a test case, which would be stored inside the parameterized method entity.
        private List<ParameterizedMethod_Entity> listofParameterizedMethods;
        //Test fixtures have their own properties (categories)
        List<Properties_Entity> propertyList;

        public string Type { get { return type; } set { type = value; } }
        public string ID { get { return iD; } set { iD = value; } }
        public string Name { get { return name; } set { name = value; } }
        public string FullName { get { return fullName; } set { fullName = value; } }
        public string ClassName {  get { return className; } set { className = value; } }
        public string RunState { get { return runState; } set { runState = value; } }
        public string TestCaseCount { get { return testCaseCount; }set { testCaseCount = value; } }
        public List<ParameterizedMethod_Entity> ListOfParameterizedMethods { get { return listofParameterizedMethods; }set { listofParameterizedMethods = value; } }
        public List<Properties_Entity> PropertyList { get { return propertyList; } set { propertyList = value; } }

        #region Constructor
        public TestFixture_Entity() {
            listofParameterizedMethods = new List<ParameterizedMethod_Entity>();
            PropertyList = new List<Properties_Entity>();
        }
        #endregion





    }
}
