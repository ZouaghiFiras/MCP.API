namespace CED.Data.Entities
{
    public class ServicesView
    {
        public Guid Id { get; set; }

        public string Code { get; set; } = null!;

        public bool Inactive { get; set; }

        public string? ShortName { get; set; }

        public string LongName { get; set; } = null!;

        public Guid? MainServiceGroupId { get; set; }

        public Guid? SubServiceGroupId { get; set; }

        public string? MainServiceGroupCode { get; set; }

        public string? MainServiceGroupShortName { get; set; }

        public string? MainServiceGroupLongName { get; set; }

        public string? SubServiceGroupCode { get; set; }

        public string? SubServiceGroupShortName { get; set; }

        public string? SubServiceGroupLongName { get; set; }

        public string? EntrySystem { get; set; }

        public string? CreatedBy { get; set; }

        public DateTime CreatedDate { get; set; }

        public string? LastModifiedBy { get; set; }

        public DateTime LastModifiedDate { get; set; }

        public byte[] TimeStamp { get; set; } = null!;
    }
}