namespace CED.Data.Entities
{
    public class VisitInformation
    {
        public Guid VifId { get; set; }

        public byte[] VifTimeStamp { get; set; } = null!;

        public string? VifLocationObjectX { get; set; }

        public DateTime? VifVisitDate { get; set; }

        public string? VifContactPerson { get; set; }

        public bool? VifPriority { get; set; }

        public bool? VifCallToday { get; set; }

        public string? VifAddressLevel1 { get; set; }

        public string? VifAddressLevel2 { get; set; }

        public string? VifCountry { get; set; }

        public string? VifZipCode { get; set; }

        public string? VifState { get; set; }

        public Guid VifDossierId { get; set; }

        public bool? VifLocationUnknow { get; set; }

        public Guid? VifTimeSoltId { get; set; }

        public Guid? VifInvolvedPartyId { get; set; }

        public string? VifTypeOfContact { get; set; }

        public bool VifIsActive { get; set; }

        public string? VifReason { get; set; }

        public Guid? VifEmployeeId { get; set; }

        public string? VifPhoneNumber { get; set; }

        public string? VifHouseNumberAddition { get; set; }

        public DateTime VifCreatedDate { get; set; }

        public string? VifCreatedBy { get; set; }

        public DateTime VifLastModifiedDate { get; set; }

        public string? VifLastModifiedBy { get; set; }

        public DateTime? VifVisitRangeStartDate { get; set; }

        public DateTime? VifVisitRangeEndDate { get; set; }

        public int? VifAppointmentTime { get; set; }

        public int? VifReportingTime { get; set; }

        public TimeSpan? VifExpectedArrival { get; set; }

        public bool? VifFixedHandler { get; set; }

        public int? VifExternalId { get; set; }

        public int? VifDrivingTime { get; set; }

        public int? VifDistance { get; set; }

        public int? VifSequence { get; set; }

        public string? VifAdditionalInformation { get; set; }

        public DateTime? VifPostponedTo { get; set; }

        public string? VifExternalUrl { get; set; }

        public decimal? VifDamageAmountEstimate { get; set; }

        public virtual ICollection<DossierAssignmentVisitInformation> DossierAssignmentVisitInformations { get; } =
            new List<DossierAssignmentVisitInformation>();

        public virtual Dossier VifDossier { get; set; } = null!;

        public virtual Employee? VifEmployee { get; set; }

        public virtual InvolvedParty? VifInvolvedParty { get; set; }

        public virtual ICollection<VisitInformationLogHistory> VisitInformationLogHistories { get; } =
            new List<VisitInformationLogHistory>();

        public virtual ICollection<VisitInformationStatusHistory> VisitInformationStatusHistories { get; } =
            new List<VisitInformationStatusHistory>();

        public virtual ICollection<WorkingOrderVisitInformation> WorkingOrderVisitInformations { get; } =
            new List<WorkingOrderVisitInformation>();
    }
}