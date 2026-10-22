using CPTMS_serverV2.Modules.School.Interfaces.ClassManager;

namespace CPTMS_serverV2.Modules.School.Services.ClassManager
{
    public class DefaultCourseService : ICourseService
    {
        private string GenerateClassID()
        {
            throw new NotImplementedException();
        }

        public bool CreateClass(string className)
        {
            return CreateClass(className, GenerateClassID());
        }

        public bool CreateClass(string className, string classID)
        {

            return false;
        }

        public bool DeleteClass(CourseControlType deleteType, string classNameOrID)
        {

            return false;
        }

        public bool ChangeClassName(CourseControlType nameOrID, string classNameOrID)
        {
            throw new NotImplementedException();
        }

        public bool ChangeClassID(CourseControlType nameOrID, string classNameOrID)
        {
            throw new NotImplementedException();
        }
    }
}
