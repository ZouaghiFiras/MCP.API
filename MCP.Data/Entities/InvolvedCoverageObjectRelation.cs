namespace CED.Data.Entities
{
    public class InvolvedCoverageObjectRelation
    {
        public Guid IorId { get; set; }

        public byte[] IorTimeStamp { get; set; } = null!;

        public Guid IorInvolvedCoverageId { get; set; }

        public Guid IorInvolvedObjectId { get; set; }

        public DateTime IorCreatedDate { get; set; }

        public string? IorCreatedBy { get; set; }

        public DateTime IorLastModifiedDate { get; set; }

        public string? IorLastModifiedBy { get; set; }

        public virtual InvolvedCoverage IorInvolvedCoverage { get; set; } = null!;

        public virtual InvolvedObject IorInvolvedObject { get; set; } = null!;
    }
}