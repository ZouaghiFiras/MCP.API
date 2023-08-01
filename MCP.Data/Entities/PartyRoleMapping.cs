namespace CED.Data.Entities
{
    public class PartyRoleMapping
    {
        public Guid PrmId { get; set; }

        public string PrmProspectCode { get; set; } = null!;

        public string PrmEiscode { get; set; } = null!;

        public DateTime PrmCreatedDate { get; set; }

        public string? PrmCreatedBy { get; set; }

        public DateTime PrmLastModifiedDate { get; set; }

        public string? PrmLastModifiedBy { get; set; }

        public byte[] PrmTimeStamp { get; set; } = null!;
    }
}