namespace CPTMS_serverV2.Modules.ClassManager.Interfaces
{
    public interface IClassManager
    {
        public bool CreateClass(string className);
        public bool CreateClass(string className, string classID);
        public bool DeleteClass(ClassControlType deleteType, string classNameOrID);
    }
}
