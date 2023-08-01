namespace CED.Data.Entities
{
    public class RoleCode
    {
        public Guid RcId { get; set; }

        public byte[] RcTimeStamp { get; set; } = null!;

        public string RcCode { get; set; } = null!;

        public string? RcShortName { get; set; }

        public string RcLongName { get; set; } = null!;

        public bool RcInactive { get; set; }

        public Guid? RcLocalizableEntryId { get; set; }

        public DateTime RcCreatedDate { get; set; }

        public string? RcCreatedBy { get; set; }

        public DateTime RcLastModifiedDate { get; set; }

        public string? RcLastModifiedBy { get; set; }

        public virtual ICollection<DossierAssignmentLogHistory> DossierAssignmentLogHistories { get; } =
            new List<DossierAssignmentLogHistory>();

        public virtual ICollection<DossierAssignmentNote> DossierAssignmentNotes { get; } =
            new List<DossierAssignmentNote>();

        public virtual ICollection<DossierLogHistory> DossierLogHistories { get; } = new List<DossierLogHistory>();

        public virtual ICollection<DossierNote> DossierNotes { get; } = new List<DossierNote>();

        public virtual ICollection<DossierParty> DossierPartyDopInvolvedPartyRoles { get; } = new List<DossierParty>();

        public virtual ICollection<DossierParty> DossierPartyDopInvolvedPartySubRoles { get; } =
            new List<DossierParty>();

        public virtual ICollection<DossierPartyRole> DossierPartyRoles { get; } = new List<DossierPartyRole>();

        public virtual LocalizableEntry? RcLocalizableEntry { get; set; }

        public virtual ICollection<VisitInformationLogHistory> VisitInformationLogHistories { get; } =
            new List<VisitInformationLogHistory>();

        public virtual ICollection<WorkingOrderLineCostNote> WorkingOrderLineCostNotes { get; } =
            new List<WorkingOrderLineCostNote>();

        public virtual ICollection<WorkingOrderLineCoverageNote> WorkingOrderLineCoverageNotes { get; } =
            new List<WorkingOrderLineCoverageNote>();

        public virtual ICollection<WorkingOrderLineLogHistory> WorkingOrderLineLogHistories { get; } =
            new List<WorkingOrderLineLogHistory>();

        public virtual ICollection<WorkingOrderLineNote> WorkingOrderLineNotes { get; } =
            new List<WorkingOrderLineNote>();

        public virtual ICollection<WorkingOrderLogHistory> WorkingOrderLogHistories { get; } =
            new List<WorkingOrderLogHistory>();

        public virtual ICollection<WorkingOrderNote> WorkingOrderNotes { get; } = new List<WorkingOrderNote>();
    }
}