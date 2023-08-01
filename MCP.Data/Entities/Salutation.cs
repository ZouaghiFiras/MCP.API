namespace CED.Data.Entities
{
    public class Salutation
    {
        public Guid SalId { get; set; }

        public byte[] SalTimeStamp { get; set; } = null!;

        public string? SalValue { get; set; }

        public string SalTitle { get; set; } = null!;

        public bool SalInactive { get; set; }

        public Guid? SalSalutationLocalizableEntryId { get; set; }

        public Guid? SalTitleLocalizableEntryId { get; set; }

        public DateTime SalCreatedDate { get; set; }

        public string? SalCreatedBy { get; set; }

        public DateTime SalLastModifiedDate { get; set; }

        public string? SalLastModifiedBy { get; set; }

        public virtual ICollection<Employee> Employees { get; } = new List<Employee>();

        public virtual ICollection<InvolvedParty> InvolvedParties { get; } = new List<InvolvedParty>();

        public virtual ICollection<Person> People { get; } = new List<Person>();

        public virtual LocalizableEntry? SalSalutationLocalizableEntry { get; set; }

        public virtual LocalizableEntry? SalTitleLocalizableEntry { get; set; }
    }
}