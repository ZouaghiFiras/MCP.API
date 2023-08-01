namespace CED.Data.Entities
{
    public class DamageReasonMapping
    {
        public Guid DrmId { get; set; }

        public string DrmProspectCode { get; set; } = null!;

        public string DrmEiscode { get; set; } = null!;

        public DateTime DrmCreatedDate { get; set; }

        public string? DrmCreatedBy { get; set; }

        public DateTime DrmLastModifiedDate { get; set; }

        public string? DrmLastModifiedBy { get; set; }

        public byte[] DrmTimeStamp { get; set; } = null!;

        public bool DrmDefaultEis { get; set; }

        public bool DrmDefaultProspect { get; set; }
    }
}