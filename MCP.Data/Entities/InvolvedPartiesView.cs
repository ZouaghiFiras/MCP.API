namespace CED.Data.Entities
{
    public class InvolvedPartiesView
    {
        public Guid Id { get; set; }

        public string? PartyNumber { get; set; }

        public string? Initials { get; set; }

        public string? FirstName { get; set; }

        public string? PrefixLastName { get; set; }

        public string? LastName { get; set; }

        public string FullName { get; set; } = null!;

        public string? Iban { get; set; }

        public string? Bic { get; set; }

        public long? BankAccountNumber { get; set; }

        public string? StreetName { get; set; }

        public string? HouseNumber { get; set; }

        public string? HouseNumberAddition { get; set; }

        public string? PostalCode { get; set; }

        public string? City { get; set; }

        public string? Province { get; set; }

        public string CountryCode { get; set; } = null!;

        public string? FullAddress { get; set; }

        public string? PhoneNumber { get; set; }

        public string? Email { get; set; }

        public DateTime? DateOfBirth { get; set; }

        public string? PartyGender { get; set; }

        public bool? IsTaxExempted { get; set; }

        public string? ExemptNumber { get; set; }

        public int? PartyOrder { get; set; }

        public Guid DossierId { get; set; }

        public Guid? AssignmentId { get; set; }

        public string? Reference { get; set; }

        public bool? IsActive { get; set; }

        public bool? IsClearinghuisParticipant { get; set; }

        public bool? NoFraud { get; set; }

        public string InvolvedPartyRoleCode { get; set; } = null!;

        public string InvolvedPartyRoleName { get; set; } = null!;

        public string? InvolvedPartySubRoleCode { get; set; }

        public string? InvolvedPartySubRoleName { get; set; }

        public DateTime CreatedDate { get; set; }

        public string? CreatedBy { get; set; }

        public DateTime LastModifiedDate { get; set; }

        public string? LastModifiedBy { get; set; }

        public byte[] TimeStamp { get; set; } = null!;
    }
}