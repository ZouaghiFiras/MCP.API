namespace CED.Data.Entities
{
    public class AssistanceDossiersOpenView
    {
        public Guid Id { get; set; }

        public DateTime IncidentDate { get; set; }

        public DateTime? IntakeDate { get; set; }

        public bool? Lcm { get; set; }

        public string? DossierNumber { get; set; }

        public string? EntrySystem { get; set; }

        public string? DossierTypeName { get; set; }

        public string? DossierStatusCode { get; set; }

        public string? DossierStatusName { get; set; }

        public string? DossierStatusType { get; set; }

        public bool? FeeSalesInvoice { get; set; }

        public byte[] TimeStamp { get; set; } = null!;

        public DateTime CreatedDate { get; set; }

        public string? CreatedBy { get; set; }

        public DateTime LastModifiedDate { get; set; }

        public string? LastModifiedBy { get; set; }
    }
}