namespace CED.Data.Entities
{
    public class PurchaseInvoiceClaimReservesInfo
    {
        public Guid Id { get; set; }

        public Guid ClaimReserveId { get; set; }

        public string? ClaimReserveNumber { get; set; }

        public bool IsCredit { get; set; }

        public Guid ClaimReserveTypeId { get; set; }

        public string ClaimReserveTypeCode { get; set; } = null!;

        public string ClaimReserveTypeName { get; set; } = null!;

        public string? CoverageNumber { get; set; }

        public string? CoverageProductCode { get; set; }

        public string? CoverageProductName { get; set; }

        public string? CoverageProductCommercialName { get; set; }

        public Guid? ClientId { get; set; }

        public string? ClientCode { get; set; }

        public string ClientName { get; set; } = null!;

        public Guid? ChargedExpensesInvoiceRecipientId { get; set; }

        public string? ChargedExpensesInvoiceRecipientCode { get; set; }

        public string ChargedExpensesInvoiceRecipientName { get; set; } = null!;

        public decimal? OpenAmount { get; set; }
    }
}