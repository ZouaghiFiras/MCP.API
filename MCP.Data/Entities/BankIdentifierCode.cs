namespace CED.Data.Entities
{
    public class BankIdentifierCode
    {
        public Guid BicId { get; set; }

        public byte[] BicTimeStamp { get; set; } = null!;

        public string BicBic { get; set; } = null!;

        public string BicBankCode { get; set; } = null!;

        public string BicBankName { get; set; } = null!;

        public string? BicRemark { get; set; }

        public string BicCountryCode { get; set; } = null!;

        public bool BicInactive { get; set; }

        public DateTime BicCreatedDate { get; set; }

        public string? BicCreatedBy { get; set; }

        public DateTime BicLastModifiedDate { get; set; }

        public string? BicLastModifiedBy { get; set; }
    }
}