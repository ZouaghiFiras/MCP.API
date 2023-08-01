namespace CED.Data.Entities
{
    public class ClientsMissingDebtorsView
    {
        public Guid Id { get; set; }

        public string Code { get; set; } = null!;

        public string? ShortName { get; set; }

        public string LongName { get; set; } = null!;

        public DateTime CreatedDate { get; set; }

        public string? CreatedBy { get; set; }

        public string? LastModifiedBy { get; set; }

        public DateTime LastModifiedDate { get; set; }

        public byte[] TimeStamp { get; set; } = null!;
    }
}