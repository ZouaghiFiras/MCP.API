namespace CED.Data.Entities
{
    public class FlsdispatcherLog
    {
        public Guid Id { get; set; }

        public byte[] TimeStamp { get; set; } = null!;

        public string LogMessage { get; set; } = null!;

        public string? IdentifierName { get; set; }

        public string? IdentifierValue { get; set; }

        public string? RequestBody { get; set; }

        public string? ResponseBody { get; set; }

        public DateTime CreatedDate { get; set; }

        public string? CreatedBy { get; set; }

        public DateTime LastModifiedDate { get; set; }

        public string? LastModifiedBy { get; set; }
    }
}