namespace CED.Data.Entities
{
    public class Task
    {
        public Guid TaskId { get; set; }

        public byte[] TaskTimeStamp { get; set; } = null!;

        public string TaskTaskNumber { get; set; } = null!;

        public string TaskDescription { get; set; } = null!;

        public DateTime TaskStartDate { get; set; }

        public DateTime? TaskDueDate { get; set; }

        public string? TaskAuthorizationGroupRoleId { get; set; }

        public DateTime TaskCreatedDate { get; set; }

        public string? TaskCreatedBy { get; set; }

        public DateTime TaskLastModifiedDate { get; set; }

        public string? TaskLastModifiedBy { get; set; }

        public virtual AuthorizationGroupRole? TaskAuthorizationGroupRole { get; set; }

        public virtual ICollection<TaskCompletion> TaskCompletions { get; } = new List<TaskCompletion>();

        public virtual ICollection<TaskMember> TaskMembers { get; } = new List<TaskMember>();

        public virtual ICollection<TaskNote> TaskNotes { get; } = new List<TaskNote>();
    }
}