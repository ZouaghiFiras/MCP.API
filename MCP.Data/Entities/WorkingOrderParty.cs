namespace CED.Data.Entities
{
    public class WorkingOrderParty
    {
        public Guid WopId { get; set; }

        public byte[] WopTimeStamp { get; set; } = null!;

        public Guid? WopDossierAssignmentPartyId { get; set; }

        public Guid WopDossierPartyId { get; set; }

        public Guid WopWorkingOrderId { get; set; }

        public DateTime WopCreatedDate { get; set; }

        public string? WopCreatedBy { get; set; }

        public DateTime WopLastModifiedDate { get; set; }

        public string? WopLastModifiedBy { get; set; }

        public virtual DossierAssignmentParty? WopDossierAssignmentParty { get; set; }

        public virtual DossierParty WopDossierParty { get; set; } = null!;

        public virtual WorkingOrder WopWorkingOrder { get; set; } = null!;

        public virtual ICollection<WorkingOrderLineParty> WorkingOrderLineParties { get; } =
            new List<WorkingOrderLineParty>();
    }
}