using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NUnitReportConversionTool {
    public class SimpleTestData_Entity {
        private string testName;
        private string testDescription;
        private Category_Entity category_Entity;
       
        public string TestName { get { return testName; } set { testName = value; } }
        public string TestDescription { get { return testDescription; } set { testDescription = value; } }
        public Category_Entity Category_Entity { get { return category_Entity; } set { category_Entity = value; } }
        
    }
}
