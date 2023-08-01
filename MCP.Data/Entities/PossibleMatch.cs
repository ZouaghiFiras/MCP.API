namespace CED.Data.Entities
{
    public class PossibleMatch
    {
        public Guid PsmId { get; set; }

        public byte[] PsmTimeStamp { get; set; } = null!;

        public string PsmName { get; set; } = null!;

        public string? PsmTitle { get; set; }

        public string? PsmAliases { get; set; }

        public string PsmBlacklist { get; set; } = null!;

        public string? PsmFollowUp { get; set; }

        public string? PsmImageUri { get; set; }

        public string? PsmNotes { get; set; }

        public Guid PsmBlacklistCheckResultId { get; set; }

        public DateTime PsmCreatedDate { get; set; }

        public string? PsmCreatedBy { get; set; }

        public DateTime PsmLastModifiedDate { get; set; }

        public string? PsmLastModifiedBy { get; set; }

        public virtual BlacklistCheckResult PsmBlacklistCheckResult { get; set; } = null!;
    }
}