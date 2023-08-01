namespace CED.Data.Entities
{
    public class ActivityOptionType
    {
        public Guid AotId { get; set; }

        public byte[] AotTimeStamp { get; set; } = null!;

        public string? AotShortName { get; set; }

        public string AotLongName { get; set; } = null!;

        public bool AotInactive { get; set; }

        public DateTime AotCreatedDate { get; set; }

        public string? AotCreatedBy { get; set; }

        public DateTime AotLastModifiedDate { get; set; }

        public string? AotLastModifiedBy { get; set; }

        public virtual ICollection<ActivityOption> ActivityOptions { get; } = new List<ActivityOption>();
    }
}