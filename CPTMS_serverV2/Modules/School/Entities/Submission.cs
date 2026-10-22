namespace CPTMS_serverV2.Modules.School.Entities
{
    // 学生提交记录
    public class Submission
    {
        public string ID { get; private set; } = Guid.NewGuid().ToString();

        public string StudentID { get; set; } = string.Empty;
        public Student? Student { get; set; }

        public string AssignmentID { get; set; } = string.Empty;
        public Assignment? Assignment { get; set; }

        public string StudentFilePath { get; set; } = string.Empty;

        public SubmissionStatus Status { get; set; } = SubmissionStatus.NotSubmitted;

        public DateTime? SubmittedTime { get; set; }
    }

    public enum SubmissionStatus
    {
        NotSubmitted,
        Submitted,
        Late,
        Graded
    }
}
