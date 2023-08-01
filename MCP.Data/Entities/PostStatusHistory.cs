namespace CED.Data.Entities
{
    public class PostStatusHistory
    {
        public Guid PtshId { get; set; }

        public byte[] PtshTimeStamp { get; set; } = null!;

        public Guid PtshPostId { get; set; }

        public Guid PtshPostStatusId { get; set; }

        public Guid PtshEmployeeId { get; set; }

        public DateTime PtshStartDate { get; set; }

        public DateTime PtshCreatedDate { get; set; }

        public string? PtshCreatedBy { get; set; }

        public DateTime PtshLastModifiedDate { get; set; }

        public string? PtshLastModifiedBy { get; set; }

        public string? PtshReason { get; set; }

        public virtual ICollection<PostCurrentStatus> PostCurrentStatuses { get; } = new List<PostCurrentStatus>();

        public virtual Post PtshPost { get; set; } = null!;

        public virtual PostStatus PtshPostStatus { get; set; } = null!;
    }
}