namespace CPTMS_serverV2.Modules.School.Interfaces.ClassManager
{
    public interface ICourseService
    {
        public bool CreateClass(string className);
        public bool CreateClass(string className, string classID);
        public bool DeleteClass(CourseControlType deleteType, string classNameOrID);
        public bool ChangeClassName(CourseControlType nameOrID, string classNameOrID);
        public bool ChangeClassID(CourseControlType nameOrID, string classNameOrID);
    }
}
