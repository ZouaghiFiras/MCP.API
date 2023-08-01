namespace CED.Data.Entities
{
    public class WorkActivityOption
    {
        public Guid WaoId { get; set; }

        public byte[] WaoTimeStamp { get; set; } = null!;

        public Guid WaoWorkActivityId { get; set; }

        public Guid WaoActivityOptionId { get; set; }

        public bool WaoInactive { get; set; }

        public DateTime WaoCreatedDate { get; set; }

        public string? WaoCreatedBy { get; set; }

        public DateTime WaoLastModifiedDate { get; set; }

        public string? WaoLastModifiedBy { get; set; }

        public virtual ActivityOption WaoActivityOption { get; set; } = null!;

        public virtual WorkActivity WaoWorkActivity { get; set; } = null!;
    }
}