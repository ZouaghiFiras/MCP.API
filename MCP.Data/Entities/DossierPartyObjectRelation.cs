namespace CED.Data.Entities
{
    public class DossierPartyObjectRelation
    {
        public Guid DpoId { get; set; }

        public byte[] DpoTimeStamp { get; set; } = null!;

        public Guid DpoDossierPartyId { get; set; }

        public Guid DpoInvolvedObjectId { get; set; }

        public DateTime DpoCreatedDate { get; set; }

        public string? DpoCreatedBy { get; set; }

        public DateTime DpoLastModifiedDate { get; set; }

        public string? DpoLastModifiedBy { get; set; }

        public virtual DossierParty DpoDossierParty { get; set; } = null!;

        public virtual InvolvedObject DpoInvolvedObject { get; set; } = null!;
    }
}