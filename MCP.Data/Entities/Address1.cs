namespace CED.Data.Entities
{
    public class Address1
    {
        public Guid AdrId { get; set; }

        public byte[] AdrTimeStamp { get; set; } = null!;

        public string? AdrStreetName { get; set; }

        public string? AdrHouseNo { get; set; }

        public string? AdrHouseNoAddition { get; set; }

        public string? AdrPostalCode { get; set; }

        public string? AdrCity { get; set; }

        public string? AdrProvince { get; set; }

        public string AdrCountryCode { get; set; } = null!;

        public double? AdrLongitude { get; set; }

        public double? AdrLatitude { get; set; }

        public string? AdrFreeField1 { get; set; }

        public string? AdrFreeField2 { get; set; }

        public string? AdrFreeField3 { get; set; }

        public DateTime AdrCreatedDate { get; set; }

        public string? AdrCreatedBy { get; set; }

        public DateTime AdrLastModifiedDate { get; set; }

        public string? AdrLastModifiedBy { get; set; }
    }
}