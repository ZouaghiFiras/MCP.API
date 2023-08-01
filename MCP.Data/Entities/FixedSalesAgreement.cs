namespace CED.Data.Entities
{
    public class FixedSalesAgreement
    {
        public Guid FsaId { get; set; }

        public byte[] FsaTimeStamp { get; set; } = null!;

        public decimal FsaFixedSalesAmount { get; set; }

        public decimal? FsaFixedSalesMarginAmount { get; set; }

        public double? FsaOrderTotalMarginPercentage { get; set; }

        public decimal? FsaOrderTotalMarginAmount { get; set; }

        public DateTime FsaCreatedDate { get; set; }

        public string? FsaCreatedBy { get; set; }

        public DateTime FsaLastModifiedDate { get; set; }

        public string? FsaLastModifiedBy { get; set; }

        public virtual SalesAgreement Fsa { get; set; } = null!;
    }
}