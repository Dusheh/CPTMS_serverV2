using CPTMS_serverV2.Modules.School.StudentManager;

namespace CPTMS_serverV2.Modules.School.ClassManager
{
    public class Course
    {
        public string Id { get; }
        public string Name { get; set; }
        public string LinuxGroupId { get; set; }
        public string SharedDirectory { get; set; }
        public List<Student> Students { get; } 
        public bool homeworkDownOrUploadEnabled { get; set; }
    }
}
