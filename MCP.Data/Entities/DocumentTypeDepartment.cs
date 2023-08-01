namespace CED.Data.Entities
{
    public class DocumentTypeDepartment
    {
        public Guid DtdId { get; set; }

        public byte[] DtdTimeStamp { get; set; } = null!;

        public Guid DtdDocumentTypeId { get; set; }

        public Guid DtdDepartmentId { get; set; }

        public DateTime DtdEffectiveDate { get; set; }

        public DateTime DtdTerminationDate { get; set; }

        public DateTime DtdCreatedDate { get; set; }

        public string? DtdCreatedBy { get; set; }

        public DateTime DtdLastModifiedDate { get; set; }

        public string? DtdLastModifiedBy { get; set; }

        public virtual Department DtdDepartment { get; set; } = null!;

        public virtual DocumentType DtdDocumentType { get; set; } = null!;
    }
}