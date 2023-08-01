namespace CED.Data.Entities
{
    public class ProductDepartment
    {
        public Guid PdpId { get; set; }

        public byte[] PdpTimeStamp { get; set; } = null!;

        public Guid PdpProductId { get; set; }

        public Guid PdpDepartmentId { get; set; }

        public DateTime PdpEffectiveDate { get; set; }

        public DateTime? PdpTerminationDate { get; set; }

        public DateTime PdpCreatedDate { get; set; }

        public string? PdpCreatedBy { get; set; }

        public DateTime PdpLastModifiedDate { get; set; }

        public string? PdpLastModifiedBy { get; set; }

        public virtual Department PdpDepartment { get; set; } = null!;

        public virtual Product PdpProduct { get; set; } = null!;
    }
}