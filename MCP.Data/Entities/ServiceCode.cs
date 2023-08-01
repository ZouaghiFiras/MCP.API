namespace CED.Data.Entities
{
    public class ServiceCode
    {
        public Guid SicId { get; set; }

        public byte[] SicTimeStamp { get; set; } = null!;

        public Guid SicServiceId { get; set; }

        public Guid SicServiceCodeTypeId { get; set; }

        public string SicCode { get; set; } = null!;

        public DateTime? SicValidFromDate { get; set; }

        public DateTime? SicValidUntilDate { get; set; }

        public DateTime SicCreatedDate { get; set; }

        public string? SicCreatedBy { get; set; }

        public DateTime SicLastModifiedDate { get; set; }

        public string? SicLastModifiedBy { get; set; }

        public virtual Service SicService { get; set; } = null!;

        public virtual ServiceCodeType SicServiceCodeType { get; set; } = null!;
    }
}