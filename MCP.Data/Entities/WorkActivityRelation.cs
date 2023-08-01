namespace CED.Data.Entities
{
    public class WorkActivityRelation
    {
        public Guid WahId { get; set; }

        public byte[] WahTimeStamp { get; set; } = null!;

        public Guid WahChildWorkActivityId { get; set; }

        public Guid WahParentWorkActivityId { get; set; }

        public DateTime WahStartDate { get; set; }

        public DateTime WahEndDate { get; set; }

        public DateTime WahCreatedDate { get; set; }

        public string? WahCreatedBy { get; set; }

        public DateTime WahLastModifiedDate { get; set; }

        public string? WahLastModifiedBy { get; set; }

        public bool WahIsExternal { get; set; }

        public virtual WorkActivity WahChildWorkActivity { get; set; } = null!;

        public virtual WorkActivity WahParentWorkActivity { get; set; } = null!;
    }
}