namespace CED.Data.Entities
{
    public class DepartmentsView
    {
        public Guid Id { get; set; }

        public string DepartmentCode { get; set; } = null!;

        public string? DepartmentAbbreviation { get; set; }

        public string DepartmentName { get; set; } = null!;

        public Guid? CostUnitId { get; set; }

        public string? CostUnitCode { get; set; }

        public string? CostUnitName { get; set; }

        public Guid BusinessUnitId { get; set; }

        public string BusinessUnitCode { get; set; } = null!;

        public string BusinessUnitName { get; set; } = null!;

        public Guid LegalEntityId { get; set; }

        public string LegalEntityCode { get; set; } = null!;

        public string LegalEntityName { get; set; } = null!;

        public bool Inactive { get; set; }

        public string? CreatedBy { get; set; }

        public DateTime CreatedDate { get; set; }

        public string? LastModifiedBy { get; set; }

        public DateTime LastModifiedDate { get; set; }

        public byte[] TimeStamp { get; set; } = null!;
    }
}