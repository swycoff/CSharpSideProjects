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
        
        public string ReportOnSimpleTestData() {
            //This reports all the information for this object onto a line assuming a reporting structure set in the main program
            StringBuilder simpleTestString = new StringBuilder();
            string role = ", , , , , , , "; ; //default in case there isn't a role in the list
            string permissionType = ", , , , ,";
            string gradeScope = "";

            foreach (Category_Entity cat in category_EntityList) {
                if(cat.CategoryType == CategoryTypes.Role) {
                    //Category Order SA,FA,BS,BA,DA
                    switch (cat.Role) {
                        case Roles.SA:
                            role = "x, , , , , , , ";
                            break;
                        case Roles.FA:
                            role = ",x , , , , , ,";
                            break;
                        case Roles.BS:
                            role = ", ,x , , , , ,";
                            break;
                        case Roles.BA:
                            role = ", , ,x , , , ,";
                            break;
                        case Roles.DA:
                            role=", , , ,x, , ,";
                            break;
                        case Roles.NonRole:
                            role = ", , , , ,x, ,";
                            break;
                        default:
                            role = role = ", , , , , ,x,";
                            break;
                    }                    
                }
                if (cat.CategoryType == CategoryTypes.PermissionType) {
                    switch (cat.PermissionType) {
                        case PermissionTypes.Reader:
                            permissionType = "x, , , , ,";
                            break;
                        case PermissionTypes.Books:
                            permissionType = ",x , , , ,";
                            break;
                        case PermissionTypes.SharedLogin:
                            permissionType = ", ,x , , ,";
                            break;
                        case PermissionTypes.NewsOnly:
                            permissionType = ", , ,x , ,";
                            break;
                        default:
                            permissionType = ", , , ,x,";
                            break;
                            //    //Maybe report on these later - otherwise report will be to long
                            //case PermissionTypes.EarlyReadersOnly:
                            //    roles = ", , , ,x ,";
                            //    break;
                            //case PermissionTypes.ElementaryOnly:
                            //    roles = ", , , , ,x,";
                            //    break;
                            //case PermissionTypes.LexileOnly:
                            //    roles = ", , , , , ,x,";
                            //    break;
                            //case PermissionTypes.NoPermissions:
                            //    roles = ", , , , , , ,x,";
                            //    break;
                            //case PermissionTypes.Other:
                            //    roles = ", , , , , , , ,x";
                            //    break;
                    }
                }
                if (cat.CategoryType == CategoryTypes.GradeScope) {
                    switch (cat.GradeScope) {
                        case GradeScopes.AllGrades:
                            gradeScope = "x, ,, , , , ";
                            break;
                        case GradeScopes.LowerLevelOneGrade:
                            gradeScope = ",x,, , , , ";
                            break;
                        case GradeScopes.UpperLevelOneGrade:
                            gradeScope = ", ,x, , , , ";
                            break;                    
                        case GradeScopes.LowerLevelAllGrades:
                            gradeScope = ", , ,x, , , , ";
                            break;
                        case GradeScopes.UpperLevelAllGrades:
                            gradeScope = ", , , ,x, , , ";
                            break;
                        case GradeScopes.Random:
                            gradeScope = ", , , , ,x, , ";
                            break;
                        default:
                            gradeScope = ", , , , , ,x,";
                            break;
                    }
                }
            }//End Foreach Category
            simpleTestString.Append(role);
            simpleTestString.Append(permissionType);
            simpleTestString.Append(gradeScope);
            return simpleTestString.ToString();
        }
    }
}
