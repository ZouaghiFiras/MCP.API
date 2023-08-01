namespace CED.Data.Entities
{
    public class InsuranceCoverageHierarchy
    {
        public Guid IchId { get; set; }

        public byte[] IchTimeStamp { get; set; } = null!;

        public Guid IchParentInsuranceCoverageId { get; set; }

        public DateTime IchStartDate { get; set; }

        public DateTime IchEndDate { get; set; }

        public DateTime IchCreatedDate { get; set; }

        public string? IchCreatedBy { get; set; }

        public DateTime IchLastModifiedDate { get; set; }

        public string? IchLastModifiedBy { get; set; }

        public virtual InsuranceCoverage IchParentInsuranceCoverage { get; set; } = null!;
    }
}