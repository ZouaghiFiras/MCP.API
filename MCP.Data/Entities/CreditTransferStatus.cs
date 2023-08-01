namespace CED.Data.Entities
{
    public class CreditTransferStatus
    {
        public Guid CtsId { get; set; }

        public byte[] CtsTimeStamp { get; set; } = null!;

        public string CtsCode { get; set; } = null!;

        public string? CtsShortName { get; set; }

        public string CtsLongName { get; set; } = null!;

        public bool CtsInactive { get; set; }

        public DateTime CtsCreatedDate { get; set; }

        public string? CtsCreatedBy { get; set; }

        public DateTime CtsLastModifiedDate { get; set; }

        public string? CtsLastModifiedBy { get; set; }

        public virtual ICollection<CreditTransferStatusHistory> CreditTransferStatusHistories { get; } =
            new List<CreditTransferStatusHistory>();
    }
}