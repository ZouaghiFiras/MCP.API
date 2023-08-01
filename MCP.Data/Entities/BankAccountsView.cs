namespace CED.Data.Entities
{
    public class BankAccountsView
    {
        public Guid Id { get; set; }

        public string? AccountAddressLine1 { get; set; }

        public string? AccountAddressLine2 { get; set; }

        public string? AccountIdentifier { get; set; }

        public string AccountName { get; set; } = null!;

        public string? AccountAbbreviation { get; set; }

        public string? Bic { get; set; }

        public string CountryCode { get; set; } = null!;

        public string CurrencyCode { get; set; } = null!;

        public string? Iban { get; set; }

        public bool Inactive { get; set; }

        public bool IsBlockedAccount { get; set; }

        public bool IsSepaAccount { get; set; }

        public string? BankName { get; set; }

        public string AccountNumber { get; set; } = null!;

        public Guid LegalEntityId { get; set; }

        public string LegalEntityCode { get; set; } = null!;

        public string? CreatedBy { get; set; }

        public DateTime CreatedDate { get; set; }

        public string? LastModifiedBy { get; set; }

        public DateTime LastModifiedDate { get; set; }

        public byte[] TimeStamp { get; set; } = null!;
    }
}