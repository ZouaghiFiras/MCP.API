namespace CED.Data.Entities
{
    public class Gender
    {
        public short GndId { get; set; }

        public byte[] GndTimeStamp { get; set; } = null!;

        public string GndName { get; set; } = null!;

        public string? GndExactCode { get; set; }

        public string? GndCreditManagerCode { get; set; }

        public bool GndInactive { get; set; }

        public Guid? GndLocalizableEntryId { get; set; }

        public DateTime GndCreatedDate { get; set; }

        public string? GndCreatedBy { get; set; }

        public DateTime GndLastModifiedDate { get; set; }

        public string? GndLastModifiedBy { get; set; }

        public virtual ICollection<ContactPerson> ContactPeople { get; } = new List<ContactPerson>();

        public virtual ICollection<Creditor> Creditors { get; } = new List<Creditor>();

        public virtual ICollection<Debtor> Debtors { get; } = new List<Debtor>();

        public virtual LocalizableEntry? GndLocalizableEntry { get; set; }
    }
}