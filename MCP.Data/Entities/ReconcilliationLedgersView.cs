namespace CED.Data.Entities
{
    public class ReconcilliationLedgersView
    {
        public string Id { get; set; } = null!;

        public string Description { get; set; } = null!;

        public string? ExactAdministration { get; set; }

        public string? ExactGeneralLedger { get; set; }

        public string Journal { get; set; } = null!;

        public string EntrySystem { get; set; } = null!;

        public string EntryDescription { get; set; } = null!;

        public short ReconcilliationActionType { get; set; }

        public string? ReconcilliationAction { get; set; }

        public bool CreditValue { get; set; }

        public bool DebitValue { get; set; }

        public string? BankAccountIban { get; set; }

        public Guid? BankAccountId { get; set; }

        public string? CreatedBy { get; set; }

        public string? LastModifiedBy { get; set; }

        public DateTime CreatedDate { get; set; }

        public DateTime LastModifiedDate { get; set; }

        public byte[] TimeStamp { get; set; } = null!;
    }
}