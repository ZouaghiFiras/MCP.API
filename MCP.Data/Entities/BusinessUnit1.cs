namespace CED.Data.Entities
{
    public class BusinessUnit1
    {
        public Guid BuId { get; set; }

        public byte[] BuTimeStamp { get; set; } = null!;

        public Guid BuLegalEntityId { get; set; }

        public Guid? BuCostCenterId { get; set; }

        public DateTime BuCreatedDate { get; set; }

        public string? BuCreatedBy { get; set; }

        public DateTime BuLastModifiedDate { get; set; }

        public string? BuLastModifiedBy { get; set; }
    }
}