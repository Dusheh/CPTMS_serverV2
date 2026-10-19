using CPTMS_serverV2.Modules.ClassManager.Interfaces;

namespace CPTMS_serverV2.Modules.ClassManager.Services
{
    public class DefaultClassManager : IClassManager
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

        public bool DeleteClass(ClassControlType deleteType, string classNameOrID)
        {

            return false;
        }
    }
}
