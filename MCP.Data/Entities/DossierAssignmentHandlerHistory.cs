namespace CED.Data.Entities
{
    public class DossierAssignmentHandlerHistory
    {
        public Guid AhhId { get; set; }

        public byte[] AhhTimeStamp { get; set; } = null!;

        public Guid AhhDossierAssignmentId { get; set; }

        public Guid AhhEmployeeId { get; set; }

        public string AhhAssignmentHandlerName { get; set; } = null!;

        public string? AhhAssignmentHandlerPhone { get; set; }

        public string? AhhAssignmentHandlerEmail { get; set; }

        public DateTime AhhStartDate { get; set; }

        public DateTime AhhCreatedDate { get; set; }

        public string? AhhCreatedBy { get; set; }

        public DateTime AhhLastModifiedDate { get; set; }

        public string? AhhLastModifiedBy { get; set; }

        public Guid? AhhDossierAssignmentEmployeeTypeId { get; set; }

        public string? AhhReason { get; set; }

        public virtual DossierAssignment AhhDossierAssignment { get; set; } = null!;

        public virtual DossierAssignmentEmployeeType? AhhDossierAssignmentEmployeeType { get; set; }

        public virtual Employee AhhEmployee { get; set; } = null!;
    }
}