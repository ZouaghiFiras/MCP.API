namespace CED.Data.Entities
{
    public class SummaryStatementPeriod
    {
        public Guid SspId { get; set; }

        public byte[] SspTimeStamp { get; set; } = null!;

        public string SspLongName { get; set; } = null!;

        public DateTime SspCreatedDate { get; set; }

        public string? SspCreatedBy { get; set; }

        public DateTime SspLastModifiedDate { get; set; }

        public string? SspLastModifiedBy { get; set; }

        public virtual ICollection<Debtor> Debtors { get; } = new List<Debtor>();
    }
}