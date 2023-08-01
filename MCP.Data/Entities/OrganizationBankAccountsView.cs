﻿namespace CED.Data.Entities
{
    public class OrganizationBankAccountsView
    {
        public Guid Id { get; set; }

        public string AccountNumber { get; set; } = null!;

        public string? AccountAbbreviation { get; set; }

        public string AccountName { get; set; } = null!;

        public string? AccountAddressLine1 { get; set; }

        public string? AccountAddressLine2 { get; set; }

        public string? BankName { get; set; }

        public Guid? BankId { get; set; }

        public string? Iban { get; set; }

        public string? Bic { get; set; }

        public string CurrencyCode { get; set; } = null!;

        public string CountryCode { get; set; } = null!;

        public string? AccountIdentifier { get; set; }

        public bool IsSepaAccount { get; set; }

        public bool IsBlockedAccount { get; set; }

        public bool Inactive { get; set; }

        public bool? IsApproved { get; set; }

        public Guid OrganizationUnitId { get; set; }

        public string OrganizationUnitCode { get; set; } = null!;

        public string OrganizationUnitName { get; set; } = null!;

        public DateTime CreatedDate { get; set; }

        public string? CreatedBy { get; set; }

        public DateTime LastModifiedDate { get; set; }

        public string? LastModifiedBy { get; set; }

        public byte[] TimeStamp { get; set; } = null!;
    }
}