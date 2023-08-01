namespace CED.Data.Entities
{
    public class WorkingOrderLineCurrentStatus
    {
        public Guid WlcsId { get; set; }

        public byte[] WlcsTimeStamp { get; set; } = null!;

        public Guid WlcsCurrentStatusHistoryId { get; set; }

        public DateTime WlcsCurrentStatusHistoryStartDate { get; set; }

        public string WlcsCurrentStatusCode { get; set; } = null!;

        public string WlcsCurrentStatusName { get; set; } = null!;

        public DateTime WlcsCreatedDate { get; set; }

        public string? WlcsCreatedBy { get; set; }

        public DateTime WlcsLastModifiedDate { get; set; }

        public string? WlcsLastModifiedBy { get; set; }

        public string? WlcsCurrentStatusTypeId { get; set; }

        public virtual WorkingOrderLine Wlcs { get; set; } = null!;

        public virtual WorkingOrderLineStatusHistory WlcsCurrentStatusHistory { get; set; } = null!;

        public virtual WorkingOrderLineStatusType? WlcsCurrentStatusType { get; set; }
    }
}