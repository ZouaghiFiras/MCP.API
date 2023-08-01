﻿namespace CED.Data.Entities
{
    public class FundingsPaymentsView
    {
        public Guid Id { get; set; }

        public Guid ClientId { get; set; }

        public string ClientNumber { get; set; } = null!;

        public string? DossierNumber { get; set; }

        public Guid? DossierId { get; set; }

        public Guid BankId { get; set; }

        public string BankAccountNumber { get; set; } = null!;

        public int BankstatementNumber { get; set; }

        public int BankstatementLineNumber { get; set; }

        public DateTime PaymentDate { get; set; }

        public decimal PaymentValue { get; set; }

        public string CurrencyCode { get; set; } = null!;

        public string? RemittanceInformation { get; set; }

        public string? Notes { get; set; }

        public string LegalEntityCode { get; set; } = null!;

        public string PaymentStatus { get; set; } = null!;

        public string? DebtorNumber { get; set; }

        public string? CreditorNumber { get; set; }

        public string? EntryNumber { get; set; }

        public string EntrySystem { get; set; } = null!;

        public string? CreatedBy { get; set; }

        public DateTime CreatedDate { get; set; }

        public string? LastModifiedBy { get; set; }

        public DateTime LastModifiedDate { get; set; }

        public byte[] TimeStamp { get; set; } = null!;
    }
}