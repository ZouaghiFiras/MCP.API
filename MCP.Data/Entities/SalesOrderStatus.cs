namespace CED.Data.Entities
{
    public class SalesOrderStatus
    {
        public Guid SosId { get; set; }

        public byte[] SosTimeStamp { get; set; } = null!;

        public string SosCode { get; set; } = null!;

        public string? SosShortName { get; set; }

        public string SosLongName { get; set; } = null!;

        public bool SosInactive { get; set; }

        public Guid? SosLocalizableEntryId { get; set; }

        public DateTime SosCreatedDate { get; set; }

        public string? SosCreatedBy { get; set; }

        public DateTime SosLastModifiedDate { get; set; }

        public string? SosLastModifiedBy { get; set; }

        public virtual ICollection<SalesOrderStatusHistory> SalesOrderStatusHistories { get; } =
            new List<SalesOrderStatusHistory>();

        public virtual LocalizableEntry? SosLocalizableEntry { get; set; }
    }
}