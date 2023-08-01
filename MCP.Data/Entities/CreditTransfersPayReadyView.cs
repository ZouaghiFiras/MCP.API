namespace CED.Data.Entities
{
    public class CreditTransfersPayReadyView
    {
        public Guid PaymentId { get; set; }

        public string PaymentNumber { get; set; } = null!;

        public Guid BankAccountId { get; set; }

        public string AccountName { get; set; } = null!;

        public string? AccountIban { get; set; }

        public decimal CreditAmount { get; set; }

        public string CurrencyCode { get; set; } = null!;

        public DateTime? ExecutionDate { get; set; }

        public bool UrgentTransfer { get; set; }

        public string? RecipientName { get; set; }

        public string? RecipientIban { get; set; }

        public string? RecipientBic { get; set; }

        public string? RemittanceInformation { get; set; }

        public Guid? LegalEntityId { get; set; }

        public string? LegalEntityCode { get; set; }

        public bool? IsSelected { get; set; }

        public string? SelectedBy { get; set; }

        public DateTime CreatedDate { get; set; }

        public string? CreatedBy { get; set; }

        public DateTime LastModifiedDate { get; set; }

        public string? LastModifiedBy { get; set; }

        public byte[] TimeStamp { get; set; } = null!;
    }
}