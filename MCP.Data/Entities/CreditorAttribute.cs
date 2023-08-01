namespace CED.Data.Entities
{
    public class CreditorAttribute
    {
        public Guid CdaId { get; set; }

        public byte[] CdaTimeStamp { get; set; } = null!;

        public Guid CdaCreditorId { get; set; }

        public string CdaAttributeName { get; set; } = null!;

        public string CdaAttributeContent { get; set; } = null!;

        public DateTime CdaCreatedDate { get; set; }

        public string? CdaCreatedBy { get; set; }

        public DateTime CdaLastModifiedDate { get; set; }

        public string? CdaLastModifiedBy { get; set; }

        public virtual Creditor CdaCreditor { get; set; } = null!;
    }
}