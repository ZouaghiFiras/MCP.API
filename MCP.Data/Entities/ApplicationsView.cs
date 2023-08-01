namespace CED.Data.Entities
{
    public class ApplicationsView
    {
        public Guid Id { get; set; }

        public string Name { get; set; } = null!;

        public string Number { get; set; } = null!;

        public bool? Inactive { get; set; }

        public Guid? LocalizableEntryId { get; set; }

        public DateTime CreatedDate { get; set; }

        public string? CreatedBy { get; set; }

        public DateTime LastModifiedDate { get; set; }

        public string? LastModifiedBy { get; set; }

        public byte[] TimeStamp { get; set; } = null!;
    }
}