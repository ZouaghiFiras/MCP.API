namespace CED.Data.Entities
{
    public class JournalSetting
    {
        public Guid JlsId { get; set; }

        public byte[] JlsTimeStamp { get; set; } = null!;

        public Guid JlsLegalEntityId { get; set; }

        public string JlsEntrySystem { get; set; } = null!;

        public string JlsJournalSettingTypeId { get; set; } = null!;

        public string JlsJournalId { get; set; } = null!;

        public string? JlsGeneralLedgerId { get; set; }

        public DateTime JlsEffectiveDate { get; set; }

        public DateTime? JlsTerminationDate { get; set; }

        public string? JlsZeroRateForeignTaxCode { get; set; }

        public DateTime JlsCreatedDate { get; set; }

        public string? JlsCreatedBy { get; set; }

        public DateTime JlsLastModifiedDate { get; set; }

        public string? JlsLastModifiedBy { get; set; }

        public virtual Journal JlsJournal { get; set; } = null!;

        public virtual JournalSettingType JlsJournalSettingType { get; set; } = null!;

        public virtual LegalEntity JlsLegalEntity { get; set; } = null!;
    }
}