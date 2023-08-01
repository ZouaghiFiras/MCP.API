namespace CED.Data.Entities
{
    public class SalesOrderToTimeSheetMapping
    {
        public Guid SotmId { get; set; }

        public byte[] SotmTimeStamp { get; set; } = null!;

        public Guid SotmSalesOrderLineId { get; set; }

        public Guid SotmTimeSheetId { get; set; }

        public string SotmUnitOfMeasureId { get; set; } = null!;

        public decimal SotmQuantity { get; set; }

        public decimal SotmConversionRate { get; set; }

        public DateTime SotmCreatedDate { get; set; }

        public string? SotmCreatedBy { get; set; }

        public DateTime SotmLastModifiedDate { get; set; }

        public string? SotmLastModifiedBy { get; set; }

        public virtual SalesOrderLine SotmSalesOrderLine { get; set; } = null!;

        public virtual TimeSheet SotmTimeSheet { get; set; } = null!;

        public virtual UnitOfMeasure SotmUnitOfMeasure { get; set; } = null!;
    }
}