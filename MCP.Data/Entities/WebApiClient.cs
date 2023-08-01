namespace CED.Data.Entities
{
    public class WebApiClient
    {
        public short WacId { get; set; }

        public byte[] WacTimeStamp { get; set; } = null!;

        public string WacName { get; set; } = null!;

        public string WacTokenReturnUrls { get; set; } = null!;

        public Guid? WacImpersonateEmployeeId { get; set; }

        public string? WacSecret { get; set; }

        public bool WacInactive { get; set; }

        public DateTime WacCreatedDate { get; set; }

        public string? WacCreatedBy { get; set; }

        public DateTime WacLastModifiedDate { get; set; }

        public string? WacLastModifiedBy { get; set; }

        public virtual Employee? WacImpersonateEmployee { get; set; }
    }
}