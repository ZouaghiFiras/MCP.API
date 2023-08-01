namespace CED.Data.Entities
{
    public class TaxCode
    {
        public string TxcId { get; set; } = null!;

        public byte[] TxcTimeStamp { get; set; } = null!;

        public string TxcDescription { get; set; } = null!;

        public short TxcTaxTypeId { get; set; }

        public DateTime TxcCreatedDate { get; set; }

        public string? TxcCreatedBy { get; set; }

        public DateTime TxcLastModifiedDate { get; set; }

        public string? TxcLastModifiedBy { get; set; }

        public virtual TaxType TxcTaxType { get; set; } = null!;
    }
}