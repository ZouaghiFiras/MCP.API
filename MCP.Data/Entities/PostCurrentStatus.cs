namespace CED.Data.Entities
{
    public class PostCurrentStatus
    {
        public Guid PtcsId { get; set; }

        public byte[] PtcsTimeStamp { get; set; } = null!;

        public Guid PtcsCurrentStatusHistoryId { get; set; }

        public DateTime PtcsCurrentStatusHistoryStartDate { get; set; }

        public string PtcsCurrentStatusCode { get; set; } = null!;

        public string PtcsCurrentStatusName { get; set; } = null!;

        public DateTime PtcsCreatedDate { get; set; }

        public string? PtcsCreatedBy { get; set; }

        public DateTime PtcsLastModifiedDate { get; set; }

        public string? PtcsLastModifiedBy { get; set; }

        public virtual Post Ptcs { get; set; } = null!;

        public virtual PostStatusHistory PtcsCurrentStatusHistory { get; set; } = null!;
    }
}