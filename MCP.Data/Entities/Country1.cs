namespace CED.Data.Entities
{
    public class Country1
    {
        public string CntId { get; set; } = null!;

        public byte[] CntTimeStamp { get; set; } = null!;

        public string CntIso3Code { get; set; } = null!;

        public string CntName { get; set; } = null!;

        public bool CntInactive { get; set; }

        public Guid? CntLocalizableEntryId { get; set; }

        public DateTime CntCreatedDate { get; set; }

        public string? CntCreatedBy { get; set; }

        public DateTime CntLastModifiedDate { get; set; }

        public string? CntLastModifiedBy { get; set; }
    }
}