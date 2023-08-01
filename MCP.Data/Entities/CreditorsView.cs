namespace CED.Data.Entities
{
    public class CreditorsView
    {
        public Guid Id { get; set; }

        public string Number { get; set; } = null!;

        public string Name { get; set; } = null!;

        public bool IsCompany { get; set; }

        public string? Phone { get; set; }

        public string? PhoneExt { get; set; }

        public string? Fax { get; set; }

        public string? Email { get; set; }

        public string? HomePage { get; set; }

        public string? VatNumber { get; set; }

        public string? ChamberOfCommerceNumber { get; set; }

        public string? EntrySystem { get; set; }

        public string? EntryNumber { get; set; }

        public string? StreetName { get; set; }

        public string? HouseNo { get; set; }

        public string? HouseNoAddition { get; set; }

        public string? PostalCode { get; set; }

        public string? City { get; set; }

        public string? Province { get; set; }

        public string? CountryCode { get; set; }

        public string? CreatedBy { get; set; }

        public DateTime CreatedDate { get; set; }

        public string? LastModifiedBy { get; set; }

        public DateTime LastModifiedDate { get; set; }

        public byte[] TimeStamp { get; set; } = null!;

        public string? LedgerAccount { get; set; }

        public string? ExactAccountCategory { get; set; }

        public string? ExactPaymentMethod { get; set; }

        public string LegalEntityCode { get; set; } = null!;

        public string? LegalEntityName { get; set; }

        public Guid LegalEntityId { get; set; }

        public Guid? AddressId { get; set; }

        public Guid? BankAccountId { get; set; }

        public string? AccountNumber { get; set; }

        public string? Bic { get; set; }

        public string? BankName { get; set; }

        public string? CurrencyCode { get; set; }

        public string? BankCountryCode { get; set; }

        public string? Iban { get; set; }

        public DateTime? ExactExportDate { get; set; }

        public string? ExactAdministration { get; set; }
    }
}