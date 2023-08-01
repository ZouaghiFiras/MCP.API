namespace CED.Data.Entities
{
    public class SalesOrderNote
    {
        public Guid SonId { get; set; }

        public byte[] SonTimeStamp { get; set; } = null!;

        public Guid SonSalesOrderId { get; set; }

        public string SonNotes { get; set; } = null!;

        public DateTime SonCreatedDate { get; set; }

        public string? SonCreatedBy { get; set; }

        public DateTime SonLastModifiedDate { get; set; }

        public string? SonLastModifiedBy { get; set; }

        public virtual SalesOrder SonSalesOrder { get; set; } = null!;
    }
}