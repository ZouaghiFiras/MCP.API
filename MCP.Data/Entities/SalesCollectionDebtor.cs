namespace CED.Data.Entities
{
    public class SalesCollectionDebtor
    {
        public Guid ScdId { get; set; }

        public byte[] ScdTimeStamp { get; set; } = null!;

        public Guid ScdSalesCollectionId { get; set; }

        public int ScdLineNumber { get; set; }

        public Guid ScdDebtorId { get; set; }

        public DateTime ScdCreatedDate { get; set; }

        public string? ScdCreatedBy { get; set; }

        public DateTime ScdLastModifiedDate { get; set; }

        public string? ScdLastModifiedBy { get; set; }

        public virtual ICollection<SalesCollectionLine> SalesCollectionLines { get; } = new List<SalesCollectionLine>();

        public virtual Debtor ScdDebtor { get; set; } = null!;

        public virtual SalesCollection ScdSalesCollection { get; set; } = null!;
    }
}