using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NUnitReportConversionTool {
    public class TestCase_Entity {
        private string iD;
        private string name;
        private string fullName;
        private string methodName;
        private string className;
        private string runState;
        private string seed;


        public string Id { get { return iD; }set { iD = value; } }
        public string Name { get { return name; } set { name = value; } }
        public string FullName { get { return fullName; } set { fullName = value; } }
        public string MethodName { get { return methodName; }set { methodName = value; } }
        public string ClassName { get { return className; }set { className = value; } }
        public string RunState { get { return runState; }set { runState = value; } }
        public string Seed { get { return seed; }set { seed = value; } }


    
    }
}
