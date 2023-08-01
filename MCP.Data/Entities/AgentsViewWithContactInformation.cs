namespace CED.Data.Entities
{
    public class AgentsViewWithContactInformation
    {
        public Guid Id { get; set; }

        public byte[] TimeStamp { get; set; } = null!;

        public string OgCode { get; set; } = null!;

        public string? NaamKort { get; set; }

        public string NaamCpl { get; set; } = null!;

        public string? TypeTpVerzOfVolmacht { get; set; }

        public string Type { get; set; } = null!;

        public string? ParentBovenliggendeType { get; set; }

        public string? NiveauPlekInStructuur { get; set; }

        public string? Porcode { get; set; }

        public string? ExterneCode { get; set; }

        public string? Adres { get; set; }

        public string? Huisnr { get; set; }

        public string? Toevoeging { get; set; }

        public string? Postcode { get; set; }

        public string? Woonplaats { get; set; }

        public string? Provincie { get; set; }

        public string? Landcode { get; set; }

        public string? Postbus { get; set; }

        public string? PostcodePostbus { get; set; }

        public string? WoonplaatsPostbus { get; set; }

        public string? ProvinciePostbus { get; set; }

        public string? LandcodePostbus { get; set; }

        public DateTime? Startdatum { get; set; }

        public DateTime? Einddatum { get; set; }

        public string Actief { get; set; } = null!;

        public string? Email { get; set; }

        public string? PhoneNumber { get; set; }

        public DateTime CreatedDate { get; set; }

        public string? CreatedBy { get; set; }

        public DateTime LastModifiedDate { get; set; }

        public string? LastModifiedBy { get; set; }
    }
}