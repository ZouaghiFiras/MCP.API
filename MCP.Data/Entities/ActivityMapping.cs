namespace CED.Data.Entities
{
    public class ActivityMapping
    {
        public Guid AmId { get; set; }

        public Guid? AmActivityId { get; set; }

        public Guid? AmActivityExecutionId { get; set; }

        public Guid? AmReportingFormId { get; set; }

        public string? AmEisActivity { get; set; }

        public DateTime AmCreatedDate { get; set; }

        public string? AmCreatedBy { get; set; }

        public DateTime AmLastModifiedDate { get; set; }

        public string? AmLastModifiedBy { get; set; }

        public byte[] AmTimeStamp { get; set; } = null!;

        public bool AmDefaultEis { get; set; }

        public bool AmDefaultProspect { get; set; }
    }
}