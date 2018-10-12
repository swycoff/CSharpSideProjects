using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NUnitReportConversionTool {
    public enum CategoryTypes {
        Null,
        Role,
        PermissionType,
        GradeScope,
        Priority,
        AppArea,
        Unknown //May need to be added to the list
    }
    public enum Roles {
        Null,
        SA,
        FA,
        BS,
        BA,
        DA,
        NonRole
    }
    public enum PermissionTypes {        
        Null,
        Reader,
        Books,
        SharedLogin,
        NewsOnly,
        ThirdPartyDisneyOnly,
        SpecialCollectionOnly,
        UpperElementaryOnly,
        EarlyReadersOnly,
        ElementaryOnly,
        LexileOnly,        
        NoPermissions,
        Other
    }
    public enum GradeScopes {
        Null,
        AllGrades,
        UpperLevelAllGrades,
        LowerLevelAllGrades,
        UpperLevelOneGrade,
        LowerLevelOneGrade,
        Other
    }
    public enum Priority {
        Null,
        Priority1=1,
        Priority2=2,
        Priority3=3,
        Priority4=4,
        Priority5=5,
        Priority6=6,
        Priority7=7,
        Priority8=8,
        Priority9=9,
        Priority10=10,
        Priority11=11,
        Priority12 =12,
        Priority13=13,
        Priority14 =14,
        Priority15 =15,
        VisualValidationPriority1 = 1,
        VisualValidationPriority2 = 2,
        VisualValidationPriority3 = 3,
        VisualValidationPriority4 = 4,
        VisualValidationPriority5 = 5,
        VisualValidationPriority6 = 6,
        VisualValidationPriority7 = 7,
        VisualValidationPriority8 = 8,
        VisualValidationPriority9 = 9,
        VisualValidationPriority10 = 10,
        VisualValidationPriority11 = 11,
        VisualValidationPriority12 = 12,
        VisualValidationPriority13 = 13,
        VisualValidationPriority14 = 14,
        VisualValidationPriority15 = 15,        
    }
    public enum AppArea {
        Null,
        AppAreaHomePage,
        AppAreaLogin,
        AppAreaDashboard,
        AppAreaRecommended,
        AppAreaBrowse,
        AppAreaMyList,
        AppAreaSearch,
        AppAreaBookPlayer,
        AppAreaTopNavigation,
        AppAreaNews,
        AppAreaReports,
        AppAreaProjects,
        AppAreaUserInfo,
        AppAreaPlacementFromLogin,
        AppAreaPlacementFromProjectTask,
        AppAreaBenchmarkFromEnvelope,
        AppAreaBenchmarkFromPostBook,
        AppAreaBenchmarkFromProjectTask
}
    public class Category_Entity {
        private CategoryTypes categoryType;
        private Roles role;
        private PermissionTypes permissionType;
        private GradeScopes gradeScope;
        private Priority priority;
        private AppArea appArea;
        private string categoryName;
        
        public CategoryTypes CategoryType { get { return categoryType; } set { categoryType = value; } }
        public PermissionTypes PermissionType { get { return permissionType; } set { permissionType = value; } }
        public GradeScopes GradeScope { get { return gradeScope; } set { gradeScope = value; } }
        public Roles Role { get { return role; } set { role = value; } }
        public Priority Priority { get { return priority; } set { priority = value; } }
        public AppArea AppArea { get { return appArea; } set { appArea = value; } }
        public string CategoryName { get { return categoryName; } set { categoryName = value; } }

        public void setCategoryInfoBasedOnTextName(string categoryName) {
            CategoryName = categoryName;
            switch (categoryName.ToLower()) {
                case "sa":                   
                    CategoryType = CategoryTypes.Role;
                    Role = Roles.SA;
                    break;
                case "fa":
                    CategoryType = CategoryTypes.Role;
                    Role = Roles.FA;
                    break;
                case "bs":
                    CategoryType = CategoryTypes.Role;
                    Role = Roles.BS;
                    break;
                case "ba":
                    CategoryType = CategoryTypes.Role;
                    Role = Roles.BA;
                    break;
                case "da":
                    CategoryType = CategoryTypes.Role;
                    Role = Roles.DA;
                    break;
                case "nonrole":
                    CategoryType = CategoryTypes.Role;
                    Role = Roles.NonRole;
                    break;
                case "reader":
                    CategoryType = CategoryTypes.PermissionType;
                    PermissionType = PermissionTypes.Reader;
                    break;
                case "permissionnopermission":
                    CategoryType = CategoryTypes.PermissionType;
                    PermissionType = PermissionTypes.Reader;
                    break;
                case "permission3rdpartydisney":
                    CategoryType = CategoryTypes.PermissionType;
                    PermissionType = PermissionTypes.ThirdPartyDisneyOnly;
                    break;
                case "permissionbooks4core":
                    CategoryType = CategoryTypes.PermissionType;
                    PermissionType = PermissionTypes.Books;
                    break;
                case "permissioncorespecial":
                    CategoryType = CategoryTypes.PermissionType;
                    PermissionType = PermissionTypes.SpecialCollectionOnly;
                    break;
                case "permissioncoreupperelementary":
                    CategoryType = CategoryTypes.PermissionType;
                    PermissionType = PermissionTypes.UpperElementaryOnly;
                    break;
                case "permissioncoreearlyreaders":
                    CategoryType = CategoryTypes.PermissionType;
                    PermissionType = PermissionTypes.EarlyReadersOnly;
                    break;
                case "permissioncoreelementary":
                    CategoryType = CategoryTypes.PermissionType;
                    PermissionType = PermissionTypes.ElementaryOnly;
                    break;
                case "permissionlexileonly":
                    CategoryType = CategoryTypes.PermissionType;
                    PermissionType = PermissionTypes.LexileOnly;
                    break;
                case "permissionnewsonly":
                    CategoryType = CategoryTypes.PermissionType;
                    PermissionType = PermissionTypes.NewsOnly;
                    break;
                case "permissionreader4corepluslexile":
                    CategoryType = CategoryTypes.PermissionType;
                    PermissionType = PermissionTypes.Reader;
                    break;
                case "permissionsharedlogin":
                    CategoryType = CategoryTypes.PermissionType;
                    PermissionType = PermissionTypes.SharedLogin;
                    break;
                case "gradelowerlevelall":
                    CategoryType = CategoryTypes.GradeScope;
                    gradeScope = GradeScopes.LowerLevelAllGrades;
                    break;
                case "gradeupperlevelall":
                    CategoryType = CategoryTypes.GradeScope;
                    gradeScope = GradeScopes.UpperLevelAllGrades;
                    break;
                case "1upperlevelgrade":
                    CategoryType = CategoryTypes.GradeScope;
                    gradeScope = GradeScopes.UpperLevelOneGrade;
                    break;
                case "1lowerlevelgrade":
                    CategoryType = CategoryTypes.GradeScope;
                    gradeScope = GradeScopes.LowerLevelOneGrade;
                    break;
                case "gradeallgrades":
                    CategoryType = CategoryTypes.GradeScope;
                    gradeScope = GradeScopes.AllGrades;
                    break;
                case "priority1":
                    CategoryType = CategoryTypes.Priority;
                     Priority= Priority.Priority1;
                    break;
                case "priority2":
                    CategoryType = CategoryTypes.Priority;
                    Priority = Priority.Priority2;
                    break;
                case "priority3":
                    CategoryType = CategoryTypes.Priority;
                    Priority = Priority.Priority3;
                    break;
                case "priority4":
                    CategoryType = CategoryTypes.Priority;
                    Priority = Priority.Priority4;
                    break;
                case "priority5":
                    CategoryType = CategoryTypes.Priority;
                    Priority = Priority.Priority5;
                    break;
                case "priority6":
                    CategoryType = CategoryTypes.Priority;
                    Priority = Priority.Priority6;
                    break;
                case "priority7":
                    CategoryType = CategoryTypes.Priority;
                    Priority = Priority.Priority7;
                    break;
                case "priority8":
                    CategoryType = CategoryTypes.Priority;
                    Priority = Priority.Priority8;
                    break;
                case "priority9":
                    CategoryType = CategoryTypes.Priority;
                    Priority = Priority.Priority9;
                    break;
                case "priority10":
                    CategoryType = CategoryTypes.Priority;
                    Priority = Priority.Priority10;
                    break;
                case "priority11":
                    CategoryType = CategoryTypes.Priority;
                    Priority = Priority.Priority11;
                    break;
                case "priority12":
                    CategoryType = CategoryTypes.Priority;
                    Priority = Priority.Priority12;
                    break;
                case "priority13":
                    CategoryType = CategoryTypes.Priority;
                    Priority = Priority.Priority13;
                    break;
                case "priority14":
                    CategoryType = CategoryTypes.Priority;
                    Priority = Priority.Priority14;
                    break;
                case "priority15":
                    CategoryType = CategoryTypes.Priority;
                    Priority = Priority.Priority15;
                    break;
                case "visualvalidationp1":
                    CategoryType = CategoryTypes.Priority;
                    Priority = Priority.VisualValidationPriority1;
                    break;
                case "visualvalidationp2":
                    CategoryType = CategoryTypes.Priority;
                    Priority = Priority.VisualValidationPriority2;
                    break;
                case "visualvalidationp3":
                    CategoryType = CategoryTypes.Priority;
                    Priority = Priority.VisualValidationPriority3;
                    break;
                case "visualvalidationp4":
                    CategoryType = CategoryTypes.Priority;
                    Priority = Priority.VisualValidationPriority4;
                    break;
                case "visualvalidationp5":
                    CategoryType = CategoryTypes.Priority;
                    Priority = Priority.VisualValidationPriority5;
                    break;
                case "visualvalidationp6":
                    CategoryType = CategoryTypes.Priority;
                    Priority = Priority.VisualValidationPriority6;
                    break;
                case "visualvalidationp7":
                    CategoryType = CategoryTypes.Priority;
                    Priority = Priority.VisualValidationPriority7;
                    break;
                case "visualvalidationp8":
                    CategoryType = CategoryTypes.Priority;
                    Priority = Priority.VisualValidationPriority8;
                    break;
                case "visualvalidationp9":
                    CategoryType = CategoryTypes.Priority;
                    Priority = Priority.VisualValidationPriority9;
                    break;
                case "visualvalidationp10":
                    CategoryType = CategoryTypes.Priority;
                    Priority = Priority.VisualValidationPriority10;
                    break;
                case "visualvalidationp11":
                    CategoryType = CategoryTypes.Priority;
                    Priority = Priority.VisualValidationPriority11;
                    break;
                case "visualvalidationp12":
                    CategoryType = CategoryTypes.Priority;
                    Priority = Priority.VisualValidationPriority12;
                    break;
                case "visualvalidationp13":
                    CategoryType = CategoryTypes.Priority;
                    Priority = Priority.VisualValidationPriority13;
                    break;
                case "visualvalidationp14":
                    CategoryType = CategoryTypes.Priority;
                    Priority = Priority.VisualValidationPriority14;
                    break;
                case "visualvalidationp15":
                    CategoryType = CategoryTypes.Priority;
                    Priority = Priority.VisualValidationPriority15;
                    break;
                case "appareahomepage":
                    CategoryType = CategoryTypes.AppArea;
                    AppArea = AppArea.AppAreaHomePage;
                    break;
                case "apparealogin":
                    CategoryType = CategoryTypes.AppArea;
                    AppArea = AppArea.AppAreaLogin;
                    break;
                case "appareadashboard":
                    CategoryType = CategoryTypes.AppArea;
                    AppArea = AppArea.AppAreaDashboard;
                    break;
                case "apparearecommended":
                    CategoryType = CategoryTypes.AppArea;
                    AppArea = AppArea.AppAreaRecommended;
                    break;
                case "appareabrowse":
                    CategoryType = CategoryTypes.AppArea;
                    AppArea = AppArea.AppAreaBrowse;
                    break;
                case "appareamylist":
                    CategoryType = CategoryTypes.AppArea;
                    AppArea = AppArea.AppAreaMyList;
                    break;
                case "appareasearch":
                    CategoryType = CategoryTypes.AppArea;
                    AppArea = AppArea.AppAreaSearch;
                    break;
                case "appareabookplayer":
                    CategoryType = CategoryTypes.AppArea;
                    AppArea = AppArea.AppAreaBookPlayer;
                    break;
                case "appareatopnavigation":
                    CategoryType = CategoryTypes.AppArea;
                    AppArea = AppArea.AppAreaTopNavigation;
                    break;
                case "appareanews":
                    CategoryType = CategoryTypes.AppArea;
                    AppArea = AppArea.AppAreaNews;
                    break;
                case "appareareports":
                    CategoryType = CategoryTypes.AppArea;
                    AppArea = AppArea.AppAreaReports;
                    break;
                case "appareaprojects":
                    CategoryType = CategoryTypes.AppArea;
                    AppArea = AppArea.AppAreaProjects;
                    break;
                case "appareauserinfo":
                    CategoryType = CategoryTypes.AppArea;
                    AppArea = AppArea.AppAreaUserInfo;
                    break;
                default:
                    CategoryType = CategoryTypes.Null; //This means we don't have the specified category in the switch and enums above 
                    //It may need to be added
                    break;

            }
        }
       
    }
}
