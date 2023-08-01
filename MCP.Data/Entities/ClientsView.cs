namespace CED.Data.Entities
{
    public class ClientsView
    {
        public Guid Id { get; set; }

        public string? ExternalCode { get; set; }

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

        public string ClientCode { get; set; } = null!;

        public string? ClientName { get; set; }
    }
}