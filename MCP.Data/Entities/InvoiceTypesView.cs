namespace CED.Data.Entities
{
    public class InvoiceTypesView
    {
        public Guid Id { get; set; }

        public string Code { get; set; } = null!;

        public bool Inactive { get; set; }

        public string? ShortName { get; set; }

        public string LongName { get; set; } = null!;

        public Guid LegalEntityId { get; set; }

        public string LegalEntityCode { get; set; } = null!;

        public string? LegalEntityAbbreviation { get; set; }

        public string LegalEntityName { get; set; } = null!;

        public string? CreatedBy { get; set; }

        public DateTime CreatedDate { get; set; }

        public string? LastModifiedBy { get; set; }

        public DateTime LastModifiedDate { get; set; }

        public byte[] TimeStamp { get; set; } = null!;
    }
}