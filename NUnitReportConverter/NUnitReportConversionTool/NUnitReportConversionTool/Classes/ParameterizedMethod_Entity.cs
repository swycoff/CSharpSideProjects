using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NUnitReportConversionTool {
    public class ParameterizedMethod_Entity {

        private string type;
        private string id;
        private string name;
        private string fullName;
        private string className;
        private string runState;
        private string testCaseCount;
        List<TestCase_Entity> testCaseEntityList;
        List<Properties_Entity> paramMethodPropertiesList;

        public string Type { get { return type; } set { type = value; } }
        public string Id { get { return id; } set { id = value; } }
        public string Name { get { return name; } set { name = value; } }
        public string FullName { get { return fullName; } set { fullName = value; } }
        public string ClassName { get { return className; } set { className = value; } }
        public string RunState { get { return runState; } set { runState = value; } }
        public string TestCaseCount { get { return testCaseCount; } set { testCaseCount = value; } }
        public List<TestCase_Entity> TestCaseEntityList { get { return testCaseEntityList; } set { testCaseEntityList = value; } }
        public List<Properties_Entity> ParamMethodPropertiesList { get { return paramMethodPropertiesList; } set { paramMethodPropertiesList = value; } }
    }
}
