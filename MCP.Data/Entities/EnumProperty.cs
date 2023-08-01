namespace CED.Data.Entities
{
    public class EnumProperty
    {
        public string EprId { get; set; } = null!;

        public byte[] EprTimeStamp { get; set; } = null!;

        public DateTime EprCreatedDate { get; set; }

        public string? EprCreatedBy { get; set; }

        public DateTime EprLastModifiedDate { get; set; }

        public string? EprLastModifiedBy { get; set; }
    }
}