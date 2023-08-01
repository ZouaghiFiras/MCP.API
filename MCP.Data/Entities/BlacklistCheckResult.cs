namespace CED.Data.Entities
{
    public class BlacklistCheckResult
    {
        public Guid BcrId { get; set; }

        public byte[] BcrTimeStamp { get; set; } = null!;

        public string? BcrLookupName { get; set; }

        public string? BcrLookupAddress { get; set; }

        public string? BcrLookupId { get; set; }

        public DateTime BcrCheckedDate { get; set; }

        public Guid BcrBlacklistSourceId { get; set; }

        public DateTime BcrCreatedDate { get; set; }

        public string? BcrCreatedBy { get; set; }

        public DateTime BcrLastModifiedDate { get; set; }

        public string? BcrLastModifiedBy { get; set; }

        public virtual BlacklistSource BcrBlacklistSource { get; set; } = null!;

        public virtual ICollection<PossibleMatch> PossibleMatches { get; } = new List<PossibleMatch>();
    }
}