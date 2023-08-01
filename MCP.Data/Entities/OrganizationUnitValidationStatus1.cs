namespace CED.Data.Entities
{
    public class OrganizationUnitValidationStatus1
    {
        public Guid Id { get; set; }

        public string Code { get; set; } = null!;

        public string ShortName { get; set; } = null!;

        public string LongName { get; set; } = null!;

        public string? CreatedBy { get; set; }

        public DateTime CreatedDate { get; set; }

        public string? LastModifiedBy { get; set; }

        public DateTime LastModifiedDate { get; set; }
    }
}