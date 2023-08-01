namespace CED.Data.Entities
{
    public class SalesOrderType
    {
        public Guid SotId { get; set; }

        public byte[] SotTimeStamp { get; set; } = null!;

        public string SotCode { get; set; } = null!;

        public string? SotShortName { get; set; }

        public string SotLongName { get; set; } = null!;

        public bool SotInactive { get; set; }

        public Guid? SotLocalizableEntryId { get; set; }

        public DateTime SotCreatedDate { get; set; }

        public string? SotCreatedBy { get; set; }

        public DateTime SotLastModifiedDate { get; set; }

        public string? SotLastModifiedBy { get; set; }

        public virtual ICollection<SalesOrder> SalesOrders { get; } = new List<SalesOrder>();

        public virtual LocalizableEntry? SotLocalizableEntry { get; set; }
    }
}