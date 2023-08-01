namespace CED.Data.Entities
{
    public class DossierWorkActivitiesView
    {
        public Guid Id { get; set; }

        public Guid DossierId { get; set; }

        public Guid? DossierAssignmentId { get; set; }

        public Guid? DossierPartyId { get; set; }

        public Guid? InvolvedObjectId { get; set; }

        public Guid? InvolvedCoverageId { get; set; }

        public Guid? FeeInvoiceRecipientId { get; set; }

        public Guid WorkActivitityId { get; set; }

        public string WorkActivityName { get; set; } = null!;

        public string WorkActivityCode { get; set; } = null!;

        public string? ActivityOptionCode { get; set; }

        public string? ActivityOptionName { get; set; }

        public string? ActivityExecutionCode { get; set; }

        public string? ActivityExecutionName { get; set; }

        public Guid ProductId { get; set; }

        public string ProductName { get; set; } = null!;

        public string ProductCode { get; set; } = null!;

        public bool Inactive { get; set; }

        public string? VehicleLicensePlate { get; set; }

        public string? VehicleLicensePlateCountryCode { get; set; }

        public DateTime CreatedDate { get; set; }

        public string? CreatedBy { get; set; }

        public DateTime LastModifiedDate { get; set; }

        public string? LastModifiedBy { get; set; }

        public byte[] TimeStamp { get; set; } = null!;
    }
}