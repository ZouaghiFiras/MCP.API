namespace CED.Data.Entities
{
    public class PaymentMethodsView
    {
        public Guid Id { get; set; }

        public string Code { get; set; } = null!;

        public string? ShortName { get; set; }

        public string LongName { get; set; } = null!;

        public bool Inactive { get; set; }

        public Guid LegalEntityId { get; set; }

        public string LegalEntityCode { get; set; } = null!;

        public string LegalEntityName { get; set; } = null!;

        public DateTime CreatedDate { get; set; }

        public string? CreatedBy { get; set; }

        public DateTime LastModifiedDate { get; set; }

        public string? LastModifiedBy { get; set; }

        public byte[] TimeStamp { get; set; } = null!;
    }
}