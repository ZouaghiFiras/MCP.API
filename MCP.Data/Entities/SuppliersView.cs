namespace CED.Data.Entities
{
    public class SuppliersView
    {
        public Guid Id { get; set; }

        public string? ExternalCode { get; set; }

        public Guid? AddressId { get; set; }

        public string? StreetName { get; set; }

        public string? HouseNo { get; set; }

        public string? HouseNoAddition { get; set; }

        public string? PostalCode { get; set; }

        public string? City { get; set; }

        public string? Province { get; set; }

        public string? CountryCode { get; set; }

        public string? VatCountryCode { get; set; }

        public string? CreatedBy { get; set; }

        public DateTime CreatedDate { get; set; }

        public string? LastModifiedBy { get; set; }

        public DateTime LastModifiedDate { get; set; }

        public byte[] TimeStamp { get; set; } = null!;

        public string SupplierCode { get; set; } = null!;

        public string? SupplierAbbreviatedName { get; set; }

        public string SupplierName { get; set; } = null!;

        public Guid? BankAccountId { get; set; }

        public bool? IsBlockedAccount { get; set; }

        public string? ChamberOfCommerceNumber { get; set; }

        public string? Email { get; set; }

        public string? Website { get; set; }

        public string? Phone { get; set; }

        public Guid? PostOfficeBoxId { get; set; }

        public Guid? TenantId { get; set; }

        public string? VatNumber { get; set; }

        public string? Iban { get; set; }

        public string? AccountNumber { get; set; }

        public string? Bic { get; set; }

        public string? AccountName { get; set; }

        public string? BankName { get; set; }

        public bool? Inactive { get; set; }

        public string? CultureCodePreferredLanguage { get; set; }

        public bool? IsPreferredSupplier { get; set; }

        public string? CurrencyCode { get; set; }

        public string? CountryCurrencyCode { get; set; }
    }
}