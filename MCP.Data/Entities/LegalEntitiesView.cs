namespace CED.Data.Entities
{
    public class LegalEntitiesView
    {
        public Guid Id { get; set; }

        public string LegalEntityCode { get; set; } = null!;

        public string? LegalEntityAbbreviation { get; set; }

        public string LegalEntityName { get; set; } = null!;

        public string? ExactAdministration { get; set; }

        public string CurrencyCode { get; set; } = null!;

        public string? StreetName { get; set; }

        public string? HouseNo { get; set; }

        public string? HouseNoAddition { get; set; }

        public string? PostalCode { get; set; }

        public string? City { get; set; }

        public string? Province { get; set; }

        public string? CountryCode { get; set; }

        public bool Inactive { get; set; }

        public string? VatNumber { get; set; }

        public Guid? GeneralSupplierId { get; set; }

        public string? CreatedBy { get; set; }

        public DateTime CreatedDate { get; set; }

        public string? LastModifiedBy { get; set; }

        public DateTime LastModifiedDate { get; set; }

        public byte[] TimeStamp { get; set; } = null!;
    }
}