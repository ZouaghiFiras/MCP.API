namespace CED.Data.Entities
{
    public class BankAccount1
    {
        public Guid BacId { get; set; }

        public byte[] BacTimeStamp { get; set; } = null!;

        public string BacAccountNumber { get; set; } = null!;

        public string? BacAccountAbbreviation { get; set; }

        public string BacAccountName { get; set; } = null!;

        public string? BacAccountAddressLine1 { get; set; }

        public string? BacAccountAddressLine2 { get; set; }

        public string? BacBankName { get; set; }

        public string? BacIban { get; set; }

        public string? BacBic { get; set; }

        public string BacCurrencyCode { get; set; } = null!;

        public string BacCountryCode { get; set; } = null!;

        public string? BacAccountIdentifier { get; set; }

        public bool BacIsSepaAccount { get; set; }

        public bool BacIsBlockedAccount { get; set; }

        public bool BacIsValidated { get; set; }

        public bool BacInactive { get; set; }

        public DateTime BacCreatedDate { get; set; }

        public string? BacCreatedBy { get; set; }

        public DateTime BacLastModifiedDate { get; set; }

        public string? BacLastModifiedBy { get; set; }

        public double BacLaborCostPercentage { get; set; }
    }
}