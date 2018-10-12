using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NUnitReportConversionTool {
    public class SimpleTestData_Entity {
        private string testName;
        private string testDescription;
        private List<Category_Entity> category_EntityList;

        public SimpleTestData_Entity() {
            category_EntityList = new List<Category_Entity>();
        }

        public string TestName { get { return testName; } set { testName = value; } }
        public string TestDescription { get { return testDescription; } set { testDescription = value; } }
        public List<Category_Entity> Category_EntityList { get { return category_EntityList; } set { category_EntityList = value; } }
        
    }
}
