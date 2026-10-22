namespace CPTMS_serverV2.Modules.School.Entities
{
    public class Student
    {
        public string ID { get; private set; } = Guid.NewGuid().ToString();
        public string Name { get; set; } = "Unknown Student";
        public string LinuxAccountId { get; set; } = "Unknow Student Linux Account ID";

        public List<Enrollment> Enrollments { get; set; } = [];
        public List<Submission> Submissions { get; set; } = [];
    }
}
