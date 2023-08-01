namespace CED.Data.Entities
{
    public class DepartmentOffice
    {
        public Guid DofId { get; set; }

        public byte[] DofTimeStamp { get; set; } = null!;

        public Guid DofDeparmentId { get; set; }

        public Guid DofOfficeId { get; set; }

        public DateTime DofCreatedDate { get; set; }

        public string? DofCreatedBy { get; set; }

        public DateTime DofLastModifiedDate { get; set; }

        public string? DofLastModifiedBy { get; set; }

        public virtual Department DofDeparment { get; set; } = null!;

        public virtual Office DofOffice { get; set; } = null!;
    }
}