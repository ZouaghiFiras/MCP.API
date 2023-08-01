namespace CED.Data.Entities
{
    public class GeneralCreditorsView
    {
        public Guid Id { get; set; }

        public Guid CreditorId { get; set; }

        public Guid LegalEntityId { get; set; }

        public DateTime CreatedDate { get; set; }

        public string? CreatedBy { get; set; }

        public DateTime LastModifiedDate { get; set; }

        public string? LastModifiedBy { get; set; }

        public byte[] TimeStamp { get; set; } = null!;
    }
}