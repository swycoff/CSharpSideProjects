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
            //default in case there isn't a anything specified in the list (we need the comma's to make sure it's going into the right columns.
            string role = ", , , , , , "; 
            string permissionType = ", , , , ,";
            string gradeScope = ", , , , , , , ,";
            string priority = ", ";
            string appArea = "Other,";

            foreach (Category_Entity cat in category_EntityList) {
                if(cat.CategoryType == CategoryTypes.Role) {
                    //Category Order SA,FA,BS,BA,DA
                    switch (cat.Role) {
                        case Roles.SA:
                            role = "x, , , , , , ";
                            break;
                        case Roles.FA:
                            role = ",x , , , , , ";
                            break;
                        case Roles.BS:
                            role = ", ,x , , , , ";
                            break;
                        case Roles.BA:
                            role = ", , ,x , , , ";
                            break;
                        case Roles.DA:
                            role=", , , ,x, , ";
                            break;
                        case Roles.NonRole:
                            role = ", , , , ,x, ";
                            break;
                            //It doesn't really make sense to have a default for other - this would only show up if we added a role and didn't finish off the reporter switch statements correctly.
                        //default:
                        //    //The only way it will hit this default is if we added it to the switch to set the category to something else that we didn't have listed here.
                        //    //It would show in the report as other.
                        //    role = ", , , , , ,x,";
                        //    break;
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
                        //If its a different permission, report the text name of the permission in other
                        case PermissionTypes.EarlyReadersOnly:
                            permissionType = ", , , ," + PermissionTypes.EarlyReadersOnly.ToString() + ",";
                            break;
                        case PermissionTypes.ThirdPartyDisneyOnly:
                            permissionType = ", , , ," + PermissionTypes.ThirdPartyDisneyOnly.ToString() + ",";
                            break;
                        case PermissionTypes.SpecialCollectionOnly:
                            permissionType = ", , , ," + PermissionTypes.SpecialCollectionOnly.ToString() + ",";
                            break;
                        case PermissionTypes.UpperElementaryOnly:
                            permissionType = ", , , ," + PermissionTypes.UpperElementaryOnly.ToString() + ",";
                            break;
                        case PermissionTypes.ElementaryOnly:
                            permissionType = ", , , ," + PermissionTypes.ElementaryOnly.ToString() + ",";
                            break;
                        case PermissionTypes.LexileOnly:
                            permissionType = ", , , ," + PermissionTypes.LexileOnly.ToString() + ",";
                            break;
                        case PermissionTypes.NoPermissions:
                            permissionType = ", , , ," + PermissionTypes.NoPermissions.ToString() + ",";
                            break;
                        case PermissionTypes.Other:
                            permissionType = ", , , ,x ,";
                            break;
                        default:
                          //Other Permissoin Types
                            permissionType = ", , , ,x,";
                            break;
                    }
                }
                if (cat.CategoryType == CategoryTypes.GradeScope) {
                    switch (cat.GradeScope) {
                        case GradeScopes.AllGrades:
                            gradeScope = "x, , , , , , , , ";
                            break;
                        case GradeScopes.LowerLevelOneGrade:
                            gradeScope = ",x, , , , , , , ";
                            break;
                        case GradeScopes.UpperLevelOneGrade:
                            gradeScope = ", ,x, , , , , , ";
                            break;                    
                        case GradeScopes.LowerLevelAllGrades:
                            gradeScope = ", , ,x, , , , , ";
                            break;
                        case GradeScopes.UpperLevelAllGrades:
                            gradeScope = ", , , ,x, , , , ";
                            break;
                        case GradeScopes.OneUpperlevelOneLowerLevel:
                            gradeScope = ", , , , ,x, , , ";
                            break;
                        case GradeScopes.Random:
                            gradeScope = ", , , , , ,x, , ";
                            break;
                        default:
                            gradeScope = ", , , , , , ,x, ";
                            break;
                    }
                }
                if (cat.CategoryType == CategoryTypes.Priority) {
                    switch (cat.Priority) {
                        case Priorities.Priority1:
                            priority = "1,";
                            break;
                        case Priorities.Priority2:
                            priority = "2,";
                            break;
                        case Priorities.Priority3:
                            priority = "3,";
                            break;
                        case Priorities.Priority4:
                            priority = "4,";
                            break;
                        case Priorities.Priority5:
                            priority = "5,";
                            break;
                        case Priorities.Priority6:
                            priority = "6,";
                            break;
                        case Priorities.Priority7:
                            priority = "7,";
                            break;
                        case Priorities.Priority8:
                            priority = "8,";
                            break;
                        case Priorities.Priority9:
                            priority = "9,";
                            break;
                        case Priorities.Priority10:
                            priority = "10,";
                            break;
                        case Priorities.Priority11:
                            priority = "11,";
                            break;
                        case Priorities.Priority12:
                            priority = "12,";
                            break;
                        case Priorities.Priority13:
                            priority = "13,";
                            break;
                        case Priorities.Priority14:
                            priority = "14,";
                            break;
                        case Priorities.Priority15:
                            priority = "15,";
                            break;
                        case Priorities.VisualValidationPriority1:
                            priority = "VV1,";
                            break;
                        case Priorities.VisualValidationPriority2:
                            priority = "VV2,";
                            break;
                        case Priorities.VisualValidationPriority3:
                            priority = "VV3,";
                            break;
                        case Priorities.VisualValidationPriority4:
                            priority = "VV4,";
                            break;
                        case Priorities.VisualValidationPriority5:
                            priority = "VV5,";
                            break;
                        case Priorities.VisualValidationPriority6:
                            priority = "VV6,";
                            break;
                        case Priorities.VisualValidationPriority7:
                            priority = "VV7,";
                            break;
                        case Priorities.VisualValidationPriority8:
                            priority = "VV8,";
                            break;
                        case Priorities.VisualValidationPriority9:
                            priority = "VV9,";
                            break;
                        case Priorities.VisualValidationPriority10:
                            priority = "VV10,";
                            break;
                        case Priorities.VisualValidationPriority11:
                            priority = "VV11,";
                            break;
                        case Priorities.VisualValidationPriority12:
                            priority = "VV12,";
                            break;
                        case Priorities.VisualValidationPriority13:
                            priority = "VV13,";
                            break;
                        case Priorities.VisualValidationPriority14:
                            priority = "VV14,";
                            break;
                        case Priorities.VisualValidationPriority15:
                            priority = "VV15,";
                            break;
                        default:
                            priority = "Null";
                            break;
                    }
                }
                if (cat.CategoryType == CategoryTypes.AppArea) {
                    switch (cat.AppArea) {
                        case AppAreas.AppAreaBenchmarkFromEnvelope:
                            appArea = AppAreas.AppAreaBenchmarkFromEnvelope.ToString() + ",";
                            break;
                        case AppAreas.AppAreaBenchmarkFromPostBook:
                            appArea = AppAreas.AppAreaBenchmarkFromPostBook.ToString() + ",";
                            break;
                        case AppAreas.AppAreaBenchmarkFromProjectTask:
                            appArea = AppAreas.AppAreaBenchmarkFromProjectTask.ToString() + ",";
                            break;
                        case AppAreas.AppAreaBookPlayer:
                            appArea = AppAreas.AppAreaBookPlayer.ToString() + ",";
                            break;
                        case AppAreas.AppAreaBrowse:
                            appArea = AppAreas.AppAreaBrowse.ToString() + ",";
                            break;
                        case AppAreas.AppAreaDashboard:
                            appArea = AppAreas.AppAreaDashboard.ToString() + ",";
                            break;
                        case AppAreas.AppAreaHomePage:
                            appArea = AppAreas.AppAreaHomePage.ToString() + ",";
                            break;
                        case AppAreas.AppAreaLogin:
                            appArea = AppAreas.AppAreaLogin.ToString() + ",";
                            break;
                        case AppAreas.AppAreaMyList:
                            appArea = AppAreas.AppAreaMyList.ToString() + ",";
                            break;
                        case AppAreas.AppAreaNews:
                            appArea = AppAreas.AppAreaNews.ToString() + ",";
                            break;
                        case AppAreas.AppAreaPlacementFromLogin:
                            appArea = AppAreas.AppAreaPlacementFromLogin.ToString() + ",";
                            break;
                        case AppAreas.AppAreaPlacementFromProjectTask:
                            appArea = AppAreas.AppAreaPlacementFromProjectTask.ToString() + ",";
                            break;
                        case AppAreas.AppAreaProjects:
                            appArea = AppAreas.AppAreaProjects.ToString() + ",";
                            break;
                        case AppAreas.AppAreaRecommended:
                            appArea = AppAreas.AppAreaRecommended.ToString() + ",";
                            break;
                        case AppAreas.AppAreaReports:
                            appArea = AppAreas.AppAreaReports.ToString() + ",";
                            break;
                        case AppAreas.AppAreaSearch:
                            appArea = AppAreas.AppAreaSearch.ToString() + ",";
                            break;
                        case AppAreas.AppAreaTopNavigation:
                            appArea = AppAreas.AppAreaTopNavigation.ToString() + ",";
                            break;
                        case AppAreas.AppAreaUserInfo:
                            appArea = AppAreas.AppAreaUserInfo.ToString() + ",";
                            break;                        
                        default:
                            appArea = "Other, ";
                            break;
                    }
                }
            }//End Foreach Category
            simpleTestString.Append(role);
            simpleTestString.Append(permissionType);
            simpleTestString.Append(gradeScope);
            simpleTestString.Append(priority);
            simpleTestString.Append(appArea);
            return simpleTestString.ToString();
        }
    }
}
