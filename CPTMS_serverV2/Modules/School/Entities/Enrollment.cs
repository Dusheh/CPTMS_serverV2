namespace CPTMS_serverV2.Modules.School.Entities
{
    public class Enrollment
    {
        public string ID { get; private set; } = Guid.NewGuid().ToString();

        public string StudentID { get; set; } = "Unset StudentID";
        public Student? Student { get; set; }

        public string CourseID { get; set; } = "Unset CourseID";
        public Course? Course { get; set; }

        public DateTime JoinTime { get; set; } = DateTime.UtcNow;
    }
}
