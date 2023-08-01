namespace CED.Data.Entities
{
    public class DebtorAttribute
    {
        public Guid DbaId { get; set; }

        public byte[] DbaTimeStamp { get; set; } = null!;

        public Guid DbaDebtorId { get; set; }

        public string DbaAttributeName { get; set; } = null!;

        public string DbaAttributeContent { get; set; } = null!;

        public DateTime DbaCreatedDate { get; set; }

        public string? DbaCreatedBy { get; set; }

        public DateTime DbaLastModifiedDate { get; set; }

        public string? DbaLastModifiedBy { get; set; }

        public virtual Debtor DbaDebtor { get; set; } = null!;
    }
}