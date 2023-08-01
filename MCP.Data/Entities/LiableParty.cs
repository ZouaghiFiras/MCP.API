namespace CED.Data.Entities
{
    public class LiableParty
    {
        public Guid LipId { get; set; }

        public byte[] LipTimeStamp { get; set; } = null!;

        public string LipCode { get; set; } = null!;

        public string? LipShortName { get; set; }

        public string LipLongName { get; set; } = null!;

        public bool LipInactive { get; set; }

        public DateTime LipCreatedDate { get; set; }

        public string? LipCreatedBy { get; set; }

        public DateTime LipLastModifiedDate { get; set; }

        public string? LipLastModifiedBy { get; set; }

        public virtual ICollection<ClaimDossier> ClaimDossiers { get; } = new List<ClaimDossier>();
    }
}