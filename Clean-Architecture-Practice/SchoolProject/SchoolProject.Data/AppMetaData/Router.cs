

namespace SchoolProject.Data.AppMetaData
{
    public static class Router
    {
        public const string SingleRoute = "/{id}"; 

        public const string Root = "Api";
        public const string Version = "V1";
        public const string Rule = Root + "/" + Version + "/";

        public static class StudentRouting
        {
            public const string Prefix = Rule + "Student";

            // Routes
            public const string List = Prefix + "/List";     
            public const string GetById = Prefix + SingleRoute;
            public const string Create = Prefix + "/Create"; 
            public const string Edit = Prefix + "/Edit";     
            public const string Delete = Prefix + SingleRoute; 
            public const string Paginated = Prefix + "/Paginated"; 
        }

        public static class DepartmentRouting
        {
            public const string Prefix = Rule + "Department";
            public const string GetById = Prefix + SingleRoute;
        }
    }
}