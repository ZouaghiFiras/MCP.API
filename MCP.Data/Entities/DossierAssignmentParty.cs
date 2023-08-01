namespace CED.Data.Entities
{
    public class DossierAssignmentParty
    {
        public Guid DapId { get; set; }

        public byte[] DapTimeStamp { get; set; } = null!;

        public Guid DapDossierPartyId { get; set; }

        public Guid DapDossierAssignmentId { get; set; }

        public DateTime DapCreatedDate { get; set; }

        public string? DapCreatedBy { get; set; }

        public DateTime DapLastModifiedDate { get; set; }

        public string? DapLastModifiedBy { get; set; }

        public virtual DossierAssignment DapDossierAssignment { get; set; } = null!;

        public virtual DossierParty DapDossierParty { get; set; } = null!;

        public virtual ICollection<WorkingOrderParty> WorkingOrderParties { get; } = new List<WorkingOrderParty>();
    }
}