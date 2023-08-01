namespace CED.Data.Entities
{
    public class WorkingOrderCurrentStatus
    {
        public Guid WocsId { get; set; }

        public byte[] WocsTimeStamp { get; set; } = null!;

        public Guid WocsCurrentStatusHistoryId { get; set; }

        public DateTime WocsCurrentStatusHistoryStartDate { get; set; }

        public string WocsCurrentStatusCode { get; set; } = null!;

        public string WocsCurrentStatusName { get; set; } = null!;

        public string? WocsCurrentStatusTypeId { get; set; }

        public DateTime WocsCreatedDate { get; set; }

        public string? WocsCreatedBy { get; set; }

        public DateTime WocsLastModifiedDate { get; set; }

        public string? WocsLastModifiedBy { get; set; }

        public virtual WorkingOrder Wocs { get; set; } = null!;

        public virtual WorkingOrderStatusHistory WocsCurrentStatusHistory { get; set; } = null!;

        public virtual WorkingOrderStatusType? WocsCurrentStatusType { get; set; }
    }
}