namespace CED.Data.Entities
{
    public class PaymentTransferReport
    {
        public string LegalEntityCode { get; set; } = null!;

        public string LegalEntityName { get; set; } = null!;

        public string Journal { get; set; } = null!;

        public string? BankAccount { get; set; }

        public int BankstatementNumber { get; set; }

        public DateTime BankstatementDate { get; set; }

        public string TransferType { get; set; } = null!;

        public string? AccountHolderName { get; set; }

        public string? Iban { get; set; }

        public string? RemittanceInformation { get; set; }

        public string YourRef { get; set; } = null!;

        public decimal CreditAmount { get; set; }

        public bool? SepaCreated { get; set; }
    }
}