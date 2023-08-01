namespace CED.Data.Entities
{
    public class DossierAssignmentCurrentStatus
    {
        public Guid DacsId { get; set; }

        public byte[] DacsTimeStamp { get; set; } = null!;

        public Guid DacsCurrentStatusHistoryId { get; set; }

        public DateTime DacsCurrentStatusHistoryStartDate { get; set; }

        public string DacsCurrentStatusCode { get; set; } = null!;

        public string DacsCurrentStatusName { get; set; } = null!;

        public string? DacsCurrentStatusTypeId { get; set; }

        public DateTime DacsCreatedDate { get; set; }

        public string? DacsCreatedBy { get; set; }

        public DateTime DacsLastModifiedDate { get; set; }

        public string? DacsLastModifiedBy { get; set; }

        public virtual DossierAssignment Dacs { get; set; } = null!;

        public virtual DossierAssignmentStatusHistory DacsCurrentStatusHistory { get; set; } = null!;
    }
}