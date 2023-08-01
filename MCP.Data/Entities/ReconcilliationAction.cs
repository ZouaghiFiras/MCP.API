namespace CED.Data.Entities
{
    public class ReconcilliationAction
    {
        public Guid RacId { get; set; }

        public byte[] RacTimeStamp { get; set; } = null!;

        public string RacEntryCode { get; set; } = null!;

        public string RacEntrySystem { get; set; } = null!;

        public string RacEntryDescription { get; set; } = null!;

        public short RacReconcilliationActionTypeId { get; set; }

        public string RacJournalId { get; set; } = null!;

        public string RacGeneralLedgerId { get; set; } = null!;

        public bool? RacDebitValue { get; set; }

        public bool? RacCreditValue { get; set; }

        public string? RacDebtorNumber { get; set; }

        public string? RacCreditorNumber { get; set; }

        public string? RacDisplayOrder { get; set; }

        public DateTime RacCreatedDate { get; set; }

        public string? RacCreatedBy { get; set; }

        public DateTime RacLastModifiedDate { get; set; }

        public string? RacLastModifiedBy { get; set; }

        public virtual Journal RacJournal { get; set; } = null!;

        public virtual ReconcilliationActionType RacReconcilliationActionType { get; set; } = null!;
    }
}