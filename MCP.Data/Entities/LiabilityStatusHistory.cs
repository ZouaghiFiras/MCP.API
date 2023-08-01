namespace CED.Data.Entities
{
    public class LiabilityStatusHistory
    {
        public Guid LshId { get; set; }

        public byte[] LshTimeStamp { get; set; } = null!;

        public Guid LshDossierPartyId { get; set; }

        public Guid LshLiabilityStatusId { get; set; }

        public bool LshIsLiabilityConfirmed { get; set; }

        public Guid LshEmployeeId { get; set; }

        public DateTime LshStartDate { get; set; }

        public DateTime LshCreatedDate { get; set; }

        public string? LshCreatedBy { get; set; }

        public DateTime LshLastModifiedDate { get; set; }

        public string? LshLastModifiedBy { get; set; }

        public virtual DossierParty LshDossierParty { get; set; } = null!;

        public virtual LiabilityStatus LshLiabilityStatus { get; set; } = null!;
    }
}