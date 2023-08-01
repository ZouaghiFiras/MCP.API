namespace CED.Data.Entities
{
    public class PurchaseTaxRate
    {
        public Guid TxrId { get; set; }

        public byte[] TxrTimeStamp { get; set; } = null!;

        public Guid TxrLegalEntityId { get; set; }

        public string TxrTaxCode { get; set; } = null!;

        public decimal TxrTaxRate { get; set; }

        public bool TxrTaxExempted { get; set; }

        public bool TxrTaxReversedCharge { get; set; }

        public bool TxrTaxImport { get; set; }

        public bool? TxrTaxValidation { get; set; }

        public DateTime TxrValidFrom { get; set; }

        public DateTime? TxrValidUntil { get; set; }

        public bool TxrTaxBeforeDiscount { get; set; }

        public string TxrDescription { get; set; } = null!;

        public string? TxrLedgerAccount { get; set; }

        public string? TxrProductTaxCodeId { get; set; }

        public string? TxrInvoiceFromTaxCodeId { get; set; }

        public string? TxrInvoiceToTaxCodeId { get; set; }

        public string? TxrShipFromTaxCodeId { get; set; }

        public string? TxrShipToTaxCodeId { get; set; }

        public DateTime TxrCreatedDate { get; set; }

        public string? TxrCreatedBy { get; set; }

        public DateTime TxrLastModifiedDate { get; set; }

        public string? TxrLastModifiedBy { get; set; }

        public string? TxrObjectClassificationsName { get; set; }

        public bool? TxrIsSubContractor { get; set; }

        public virtual LegalEntity TxrLegalEntity { get; set; } = null!;
    }
}