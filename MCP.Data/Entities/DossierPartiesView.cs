namespace CED.Data.Entities
{
    public class DossierPartiesView
    {
        public Guid Id { get; set; }

        public Guid DossierId { get; set; }

        public Guid? AssignmentId { get; set; }

        public string? DossierNumber { get; set; }

        public Guid? InvolvedPartyId { get; set; }

        public string? InvolvedPartyFullName { get; set; }

        public string? InvolvedPartyNumber { get; set; }

        public long? InvolvedPartyBankAccountNumber { get; set; }

        public string? InvolvedPartyBankAccountIban { get; set; }

        public string? InvolvedPartyBankAccountBic { get; set; }

        public Guid InvolvedPartyRoleId { get; set; }

        public string? InvolvedPartyRoleCode { get; set; }

        public string? InvolvedPartyRoleName { get; set; }

        public Guid? InvolvedPartySubRoleId { get; set; }

        public string? InvolvedPartySubRoleCode { get; set; }

        public string? InvolvedPartySubRoleName { get; set; }

        public string? InvolvedPartyStreetName { get; set; }

        public string? InvolvedPartyHouseNumber { get; set; }

        public string? InvolvedPartyHouseNumberAddition { get; set; }

        public string? InvolvedPartyCity { get; set; }

        public string? InvolvedPartyPostalCode { get; set; }

        public string? InvolvedPartyCountryCode { get; set; }

        public string? InvolvedPartyFullAddress { get; set; }

        public string? InvolvedPartyEmail { get; set; }

        public string? InvolvedPartyPhoneNumber { get; set; }

        public DateTime? InvolvedPartyDateOfBirth { get; set; }

        public string? InvolvedPartyGender { get; set; }

        public bool? InvolvedPartyIsCompany { get; set; }

        public bool? InvolvedPartyHomeOwnerAssociation { get; set; }

        public string? InvolvedPartyVatNumber { get; set; }

        public string? InvolvedPartyChamberOfCommerceNumber { get; set; }

        public Guid? InvolvedCoverageId { get; set; }

        public bool? NoFraud { get; set; }

        public string? CrcommunityAddress { get; set; }

        public bool? IsActive { get; set; }

        public bool? IsClearinghuisParticipant { get; set; }

        public Guid? KnownOrganizationUnitId { get; set; }

        public string? Fax { get; set; }

        public int? PartyOrder { get; set; }

        public Guid? ReferalDossierPartyId { get; set; }

        public string? Reference { get; set; }

        public Guid? LiabilityStatusId { get; set; }

        public string? LiabilityStatusCode { get; set; }

        public string? LiabilityStatusName { get; set; }

        public bool? IsLiabilityConfirmed { get; set; }

        public bool IsDossierPartyInsuree { get; set; }

        public bool IsDossierPartyMedical { get; set; }

        public DateTime CreatedDate { get; set; }

        public string? CreatedBy { get; set; }

        public DateTime LastModifiedDate { get; set; }

        public string? LastModifiedBy { get; set; }

        public byte[] TimeStamp { get; set; } = null!;
    }
}