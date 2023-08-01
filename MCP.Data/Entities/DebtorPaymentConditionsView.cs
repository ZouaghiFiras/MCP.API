namespace CED.Data.Entities
{
    public class DebtorPaymentConditionsView
    {
        public Guid Id { get; set; }

        public string Number { get; set; } = null!;

        public string Name { get; set; } = null!;

        public int? DueDays { get; set; }

        public bool? IsDueDateUntilEndOfMonth { get; set; }

        public bool? Inactive { get; set; }

        public Guid LegalEntityId { get; set; }

        public DateTime CreatedDate { get; set; }

        public string? CreatedBy { get; set; }

        public DateTime LastModifiedDate { get; set; }

        public string? LastModifiedBy { get; set; }

        public byte[] TimeStamp { get; set; } = null!;
    }
}