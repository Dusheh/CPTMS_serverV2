namespace CPTMS_serverV2.Modules.School.Entities
{
    public class Course
    {
        public string ID { get; private set; } = Guid.NewGuid().ToString();
        public string Name { get; set; } = "Unknown Class";
        public string LinuxGroupId { get; set; } = "UntitleLinuxGroup";
        public string SharedDirectory { get; set; } = "Unset Directory";
        public bool HomeworkDownOrUploadEnabled { get; set; }

        public List<Enrollment> Enrollments { get; set; } = [];
        public List<Assignment> Assignment { get; set; } = [];
    }
}
