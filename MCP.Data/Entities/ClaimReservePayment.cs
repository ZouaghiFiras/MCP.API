namespace CED.Data.Entities
{
    public class ClaimReservePayment
    {
        public Guid CrpId { get; set; }

        public byte[] CrpTimeStamp { get; set; } = null!;

        public Guid CrpClaimReserveId { get; set; }

        public DateTime CrpTransactionDate { get; set; }

        public Guid CrpPurchaseInvoiceLineId { get; set; }

        public bool CrpIsCredit { get; set; }

        public string CrpPaymentCurrencyCode { get; set; } = null!;

        public decimal CrpClaimValue { get; set; }

        public double CrpLeadExchangeRate { get; set; }

        public Guid? CvrLeadExchangeRateId { get; set; }

        public decimal CrpLeadClaimValue { get; set; }

        public double CrpClientExchangeRate { get; set; }

        public Guid? CvrClientExchangeRateId { get; set; }

        public decimal CrpClientClaimValue { get; set; }

        public bool CrpIsManualTransaction { get; set; }

        public string? CrpTransactionReason { get; set; }

        public DateTime CrpCreatedDate { get; set; }

        public string? CrpCreatedBy { get; set; }

        public DateTime CrpLastModifiedDate { get; set; }

        public string? CrpLastModifiedBy { get; set; }

        public virtual ClaimReserf CrpClaimReserve { get; set; } = null!;

        public virtual PurchaseInvoiceLine CrpPurchaseInvoiceLine { get; set; } = null!;
    }
}