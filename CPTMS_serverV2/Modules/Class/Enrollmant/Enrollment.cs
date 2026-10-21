using CPTMS_serverV2.Modules.School.ClassManager;
using CPTMS_serverV2.Modules.School.StudentManager;

namespace CPTMS_serverV2.Modules.School.Enrollmant
{
    public class Enrollment
    {
        public string ID { get; set; }

        public string StudentID { get; set; }
        public Student? student { get; set; }

        public string CourseID { get; set; }
        public Course course { get; set; }

        public DateTime joinTime;
    }
}
