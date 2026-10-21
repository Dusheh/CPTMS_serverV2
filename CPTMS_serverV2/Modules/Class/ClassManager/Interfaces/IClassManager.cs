namespace CPTMS_serverV2.Modules.School.ClassManager.Interfaces
{
    public interface IClassManager
    {
        public bool CreateClass(string className);
        public bool CreateClass(string className, string classID);
        public bool DeleteClass(ClassControlType deleteType, string classNameOrID);
        public bool ChangeClassName(ClassControlType nameOrID, string classNameOrID);
        public bool ChangeClassID(ClassControlType nameOrID, string classNameOrID);
    }
}
