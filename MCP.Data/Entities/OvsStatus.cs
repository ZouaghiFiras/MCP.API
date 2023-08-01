namespace CED.Data.Entities
{
    public class OvsStatus
    {
        public Guid OstId { get; set; }

        public byte[] OstTimeStamp { get; set; } = null!;

        public string OstCode { get; set; } = null!;

        public string? OstShortName { get; set; }

        public string OstLongName { get; set; } = null!;

        public bool OstInactive { get; set; }

        public DateTime OstCreatedDate { get; set; }

        public string? OstCreatedBy { get; set; }

        public DateTime OstLastModifiedDate { get; set; }

        public string? OstLastModifiedBy { get; set; }

        public virtual ICollection<OvsRegresStatus> OvsRegresStatuses { get; } = new List<OvsRegresStatus>();
    }
}