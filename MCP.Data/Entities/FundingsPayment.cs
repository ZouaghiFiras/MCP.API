namespace CED.Data.Entities
{
    public class FundingsPayment
    {
        public Guid FupId { get; set; }

        public byte[] FupTimeStamp { get; set; } = null!;

        public Guid FupClientId { get; set; }

        public string? FupDossierNumber { get; set; }

        public Guid? FupDossierId { get; set; }

        public Guid FupBankStatementLineId { get; set; }

        public decimal FupPaymentValue { get; set; }

        public Guid FupLegalEntityId { get; set; }

        public DateTime FupCreatedDate { get; set; }

        public string? FupCreatedBy { get; set; }

        public DateTime FupLastModifiedDate { get; set; }

        public string? FupLastModifiedBy { get; set; }

        public Guid? FupCurrentStatusHistoryId { get; set; }

        public DateTime? FupCurrentStatusHistoryStartDate { get; set; }

        public string? FupCurrentStatusCode { get; set; }

        public virtual ICollection<FundingsPaymentStatusHistory> FundingsPaymentStatusHistories { get; } =
            new List<FundingsPaymentStatusHistory>();

        public virtual BankStatementLine FupBankStatementLine { get; set; } = null!;

        public virtual Client FupClient { get; set; } = null!;

        public virtual Dossier? FupDossier { get; set; }

        public virtual LegalEntity FupLegalEntity { get; set; } = null!;
    }
}