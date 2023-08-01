namespace CED.Data.Entities
{
    public class SalesOrderCorrection
    {
        public Guid SohcId { get; set; }

        public byte[] SohcTimeStamp { get; set; } = null!;

        public Guid SohcSalesOrderId { get; set; }

        public DateTime SohcCorrectionDate { get; set; }

        public DateTime SohcCreatedDate { get; set; }

        public string? SohcCreatedBy { get; set; }

        public DateTime SohcLastModifiedDate { get; set; }

        public string? SohcLastModifiedBy { get; set; }

        public virtual ICollection<SalesOrderCorrectionAuthorization> SalesOrderCorrectionAuthorizations { get; } =
            new List<SalesOrderCorrectionAuthorization>();

        public virtual ICollection<SalesOrderCorrectionLine> SalesOrderCorrectionLines { get; } =
            new List<SalesOrderCorrectionLine>();

        public virtual SalesOrder SohcSalesOrder { get; set; } = null!;
    }
}