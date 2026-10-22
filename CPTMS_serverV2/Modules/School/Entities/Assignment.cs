namespace CPTMS_serverV2.Modules.School.Entities
{
    // 作业批次/任务
    public class Assignment
    {
        public string ID { get; private set; } = Guid.NewGuid().ToString();
        public string Title { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public DateTime? Deadline { get; set; }
        public string CourseID { get; set; } = string.Empty;
        public Course? Course { get; set; }
        public string CollectedFilePath { get; set; } = string.Empty;

        public List<Submission> Submissions { get; set; } = new();
    }
}
