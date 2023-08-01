namespace CED.Data.Entities
{
    public class Person
    {
        public Guid PerId { get; set; }

        public byte[] PerTimeStamp { get; set; } = null!;

        public string? PerPersonNumber { get; set; }

        public string? PerInitials { get; set; }

        public string? PerFirstName { get; set; }

        public string? PerPrefixLastName { get; set; }

        public string? PerLastName { get; set; }

        public string PerFullName { get; set; } = null!;

        public string? PerStreetName { get; set; }

        public string? PerHouseNumber { get; set; }

        public string? PerHouseNumberAddition { get; set; }

        public string? PerPostalCode { get; set; }

        public string? PerCity { get; set; }

        public string? PerProvince { get; set; }

        public string PerCountryCode { get; set; } = null!;

        public string? PerFullAddress { get; set; }

        public Guid? PerSalutationId { get; set; }

        public short? PerGenderId { get; set; }

        public DateTime? PerDateOfBirth { get; set; }

        public string? PerPhoneNumber { get; set; }

        public string? PerPhoneNumber2 { get; set; }

        public string? PerPhoneNumber3 { get; set; }

        public string? PerEmail { get; set; }

        public DateTime PerCreatedDate { get; set; }

        public string? PerCreatedBy { get; set; }

        public DateTime PerLastModifiedDate { get; set; }

        public string? PerLastModifiedBy { get; set; }

        public virtual InvolvedObject Per { get; set; } = null!;

        public virtual Salutation? PerSalutation { get; set; }
    }
}