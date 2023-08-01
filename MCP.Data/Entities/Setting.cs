namespace CED.Data.Entities
{
    public class Setting
    {
        public short SetId { get; set; }

        public byte[] SetTimeStamp { get; set; } = null!;

        public string SetKey { get; set; } = null!;

        public string SetValue { get; set; } = null!;

        public string SetContext { get; set; } = null!;

        public bool SetIsSystem { get; set; }

        public DateTime SetCreatedDate { get; set; }

        public string? SetCreatedBy { get; set; }

        public DateTime SetLastModifiedDate { get; set; }

        public string? SetLastModifiedBy { get; set; }
    }
}