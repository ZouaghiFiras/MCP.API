namespace CED.Data.Entities
{
    public class SupplierTaxCodesView
    {
        public Guid? Id { get; set; }

        public Guid LegalEntityId { get; set; }

        public Guid SupplierId { get; set; }

        public string? PartyTaxCode { get; set; }

        public string? AppNumber { get; set; }

        public DateTime CreatedDate { get; set; }

        public string? CreatedBy { get; set; }

        public DateTime LastModifiedDate { get; set; }

        public string? LastModifiedBy { get; set; }

        public byte[] TimeStamp { get; set; } = null!;
    }
}