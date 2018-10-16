using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NUnitReportConversionTool {
    public enum CategoryTypes {
        Null =0,
        Role =1,
        PermissionType =2,
        GradeScope=3,
        Priority=4,
        AppArea=5,
        Unknown=6 //May need to be added to the list
    }
    public enum Roles {
        Null=0,
        SA=1,
        FA=2,
        BS=3,
        BA=4,
        DA=5,
        NonRole=6
    }
    public enum PermissionTypes {        
        Null=0,
        Reader=1,
        Books=2,
        SharedLogin=3,
        NewsOnly=4,
        ThirdPartyDisneyOnly=5,
        SpecialCollectionOnly=6,
        UpperElementaryOnly=7,
        EarlyReadersOnly=8,
        ElementaryOnly=9,
        LexileOnly=10,        
        NoPermissions=11,
        Other=12
    }
    public enum GradeScopes {
        Null=0,
        AllGrades=1,
        UpperLevelAllGrades=2,
        LowerLevelAllGrades=3,
        UpperLevelOneGrade=4,
        LowerLevelOneGrade=5,
        Random=6,
        Other=7
    }
    public enum Priorities {
        Null=0,
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
        VisualValidationPriority1 = 101,
        VisualValidationPriority2 = 102,
        VisualValidationPriority3 = 103,
        VisualValidationPriority4 = 104,
        VisualValidationPriority5 = 105,
        VisualValidationPriority6 = 106,
        VisualValidationPriority7 = 107,
        VisualValidationPriority8 = 108,
        VisualValidationPriority9 = 109,
        VisualValidationPriority10 = 110,
        VisualValidationPriority11 = 111,
        VisualValidationPriority12 = 112,
        VisualValidationPriority13 = 113,
        VisualValidationPriority14 = 114,
        VisualValidationPriority15 = 115,        
    }
    public enum AppAreas {
        Null=0,
        AppAreaHomePage=1,
        AppAreaLogin=2,
        AppAreaDashboard=3,
        AppAreaRecommended=4,
        AppAreaBrowse=5,
        AppAreaMyList=6,
        AppAreaSearch=7,
        AppAreaBookPlayer=8,
        AppAreaTopNavigation=9,
        AppAreaNews=10,
        AppAreaReports=11,
        AppAreaProjects=12,
        AppAreaUserInfo=13,
        AppAreaPlacementFromLogin=14,
        AppAreaPlacementFromProjectTask=15,
        AppAreaBenchmarkFromEnvelope=16,
        AppAreaBenchmarkFromPostBook=17,
        AppAreaBenchmarkFromProjectTask=18
}
    public class Category_Entity {
        private CategoryTypes categoryType;
        private Roles role;
        private PermissionTypes permissionType;
        private GradeScopes gradeScope;
        private Priorities priority;
        private AppAreas appArea;
        private string categoryName;
        
        public CategoryTypes CategoryType { get { return categoryType; } set { categoryType = value; } }
        public PermissionTypes PermissionType { get { return permissionType; } set { permissionType = value; } }
        public GradeScopes GradeScope { get { return gradeScope; } set { gradeScope = value; } }
        public Roles Role { get { return role; } set { role = value; } }
        public Priorities Priority { get { return priority; } set { priority = value; } }
        public AppAreas AppArea { get { return appArea; } set { appArea = value; } }
        public string CategoryName { get { return categoryName; } set { categoryName = value; } }

        public Category_Entity() {
            CategoryType = CategoryTypes.Null;
            PermissionType = PermissionTypes.Null;
            GradeScope = GradeScopes.Null;
            Role = Roles.Null;
            Priority = Priorities.Null;
            AppArea = AppAreas.Null;
            CategoryName = "";
        }

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
                case "permissionnopermission":
                    CategoryType = CategoryTypes.PermissionType;
                    PermissionType = PermissionTypes.NoPermissions;
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
                case "graderandom":
                    CategoryType = CategoryTypes.GradeScope;
                    gradeScope = GradeScopes.Random;
                    break;
                case "priority1":
                    CategoryType = CategoryTypes.Priority;
                     Priority= Priorities.Priority1;
                    break;
                case "priority2":
                    CategoryType = CategoryTypes.Priority;
                    Priority = Priorities.Priority2;
                    break;
                case "priority3":
                    CategoryType = CategoryTypes.Priority;
                    Priority = Priorities.Priority3;
                    break;
                case "priority4":
                    CategoryType = CategoryTypes.Priority;
                    Priority = Priorities.Priority4;
                    break;
                case "priority5":
                    CategoryType = CategoryTypes.Priority;
                    Priority = Priorities.Priority5;
                    break;
                case "priority6":
                    CategoryType = CategoryTypes.Priority;
                    Priority = Priorities.Priority6;
                    break;
                case "priority7":
                    CategoryType = CategoryTypes.Priority;
                    Priority = Priorities.Priority7;
                    break;
                case "priority8":
                    CategoryType = CategoryTypes.Priority;
                    Priority = Priorities.Priority8;
                    break;
                case "priority9":
                    CategoryType = CategoryTypes.Priority;
                    Priority = Priorities.Priority9;
                    break;
                case "priority10":
                    CategoryType = CategoryTypes.Priority;
                    Priority = Priorities.Priority10;
                    break;
                case "priority11":
                    CategoryType = CategoryTypes.Priority;
                    Priority = Priorities.Priority11;
                    break;
                case "priority12":
                    CategoryType = CategoryTypes.Priority;
                    Priority = Priorities.Priority12;
                    break;
                case "priority13":
                    CategoryType = CategoryTypes.Priority;
                    Priority = Priorities.Priority13;
                    break;
                case "priority14":
                    CategoryType = CategoryTypes.Priority;
                    Priority = Priorities.Priority14;
                    break;
                case "priority15":
                    CategoryType = CategoryTypes.Priority;
                    Priority = Priorities.Priority15;
                    break;
                case "visualvalidationp1":
                    CategoryType = CategoryTypes.Priority;
                    Priority = Priorities.VisualValidationPriority1;
                    break;
                case "visualvalidationp2":
                    CategoryType = CategoryTypes.Priority;
                    Priority = Priorities.VisualValidationPriority2;
                    break;
                case "visualvalidationp3":
                    CategoryType = CategoryTypes.Priority;
                    Priority = Priorities.VisualValidationPriority3;
                    break;
                case "visualvalidationp4":
                    CategoryType = CategoryTypes.Priority;
                    Priority = Priorities.VisualValidationPriority4;
                    break;
                case "visualvalidationp5":
                    CategoryType = CategoryTypes.Priority;
                    Priority = Priorities.VisualValidationPriority5;
                    break;
                case "visualvalidationp6":
                    CategoryType = CategoryTypes.Priority;
                    Priority = Priorities.VisualValidationPriority6;
                    break;
                case "visualvalidationp7":
                    CategoryType = CategoryTypes.Priority;
                    Priority = Priorities.VisualValidationPriority7;
                    break;
                case "visualvalidationp8":
                    CategoryType = CategoryTypes.Priority;
                    Priority = Priorities.VisualValidationPriority8;
                    break;
                case "visualvalidationp9":
                    CategoryType = CategoryTypes.Priority;
                    Priority = Priorities.VisualValidationPriority9;
                    break;
                case "visualvalidationp10":
                    CategoryType = CategoryTypes.Priority;
                    Priority = Priorities.VisualValidationPriority10;
                    break;
                case "visualvalidationp11":
                    CategoryType = CategoryTypes.Priority;
                    Priority = Priorities.VisualValidationPriority11;
                    break;
                case "visualvalidationp12":
                    CategoryType = CategoryTypes.Priority;
                    Priority = Priorities.VisualValidationPriority12;
                    break;
                case "visualvalidationp13":
                    CategoryType = CategoryTypes.Priority;
                    Priority = Priorities.VisualValidationPriority13;
                    break;
                case "visualvalidationp14":
                    CategoryType = CategoryTypes.Priority;
                    Priority = Priorities.VisualValidationPriority14;
                    break;
                case "visualvalidationp15":
                    CategoryType = CategoryTypes.Priority;
                    Priority = Priorities.VisualValidationPriority15;
                    break;
                case "appareahomepage":
                    CategoryType = CategoryTypes.AppArea;
                    AppArea = AppAreas.AppAreaHomePage;
                    break;
                case "apparealogin":
                    CategoryType = CategoryTypes.AppArea;
                    AppArea = AppAreas.AppAreaLogin;
                    break;
                case "appareadashboard":
                    CategoryType = CategoryTypes.AppArea;
                    AppArea = AppAreas.AppAreaDashboard;
                    break;
                case "apparearecommended":
                    CategoryType = CategoryTypes.AppArea;
                    AppArea = AppAreas.AppAreaRecommended;
                    break;
                case "appareabrowse":
                    CategoryType = CategoryTypes.AppArea;
                    AppArea = AppAreas.AppAreaBrowse;
                    break;
                case "appareamylist":
                    CategoryType = CategoryTypes.AppArea;
                    AppArea = AppAreas.AppAreaMyList;
                    break;
                case "appareasearch":
                    CategoryType = CategoryTypes.AppArea;
                    AppArea = AppAreas.AppAreaSearch;
                    break;
                case "appareabookplayer":
                    CategoryType = CategoryTypes.AppArea;
                    AppArea = AppAreas.AppAreaBookPlayer;
                    break;
                case "appareatopnavigation":
                    CategoryType = CategoryTypes.AppArea;
                    AppArea = AppAreas.AppAreaTopNavigation;
                    break;
                case "appareanews":
                    CategoryType = CategoryTypes.AppArea;
                    AppArea = AppAreas.AppAreaNews;
                    break;
                case "appareareports":
                    CategoryType = CategoryTypes.AppArea;
                    AppArea = AppAreas.AppAreaReports;
                    break;
                case "appareaprojects":
                    CategoryType = CategoryTypes.AppArea;
                    AppArea = AppAreas.AppAreaProjects;
                    break;
                case "appareauserinfo":
                    CategoryType = CategoryTypes.AppArea;
                    AppArea = AppAreas.AppAreaUserInfo;
                    break;
                case "appareaplacementfromlogin":
                    CategoryType = CategoryTypes.AppArea;
                    AppArea = AppAreas.AppAreaPlacementFromLogin;
                    break;
                case "appareaplacementfromprojecttask":
                    CategoryType = CategoryTypes.AppArea;
                    AppArea = AppAreas.AppAreaPlacementFromProjectTask;
                    break;
                case "appareabenchmarkfromenvelope":
                    CategoryType = CategoryTypes.AppArea;
                    AppArea = AppAreas.AppAreaBenchmarkFromEnvelope;
                    break;
                case "appareabenchmarkfrompostbook":
                    CategoryType = CategoryTypes.AppArea;
                    AppArea = AppAreas.AppAreaBenchmarkFromPostBook;
                    break;
                case "appareabenchmarkfromprojecttask":
                    CategoryType = CategoryTypes.AppArea;
                    AppArea = AppAreas.AppAreaBenchmarkFromProjectTask;
                    break;
                default:
                    CategoryType = CategoryTypes.Null; //This means we don't have the specified category in the switch and enums above 
                    //It may need to be added
                    break;

            }
        }
       
    }
}
