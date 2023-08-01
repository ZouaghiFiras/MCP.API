namespace CED.Data.Entities
{
    public class DossierSummaryInfo
    {
        public Guid Id { get; set; }

        public string? DossierNumber { get; set; }

        public string? EntrySystem { get; set; }

        public short? DossierTypeId { get; set; }

        public string? DossierTypeCode { get; set; }

        public string? DossierTypeName { get; set; }

        public Guid ClientId { get; set; }

        public string ClientCode { get; set; } = null!;

        public string ClientName { get; set; } = null!;

        public Guid ProductId { get; set; }

        public string ProductCode { get; set; } = null!;

        public string ProductName { get; set; } = null!;

        public Guid? MandateId { get; set; }

        public string? MandateCode { get; set; }

        public string MandateName { get; set; } = null!;

        public Guid? AgentId { get; set; }

        public string? AgentCode { get; set; }

        public string AgentName { get; set; } = null!;

        public Guid? DepartmentId { get; set; }

        public string? DepartmentCode { get; set; }

        public string DepartmentName { get; set; } = null!;

        public Guid? BusinessUnitId { get; set; }

        public string? BusinessUnitCode { get; set; }

        public string BusinessUnitName { get; set; } = null!;

        public Guid? LegalEntityId { get; set; }

        public string? LegalEntityCode { get; set; }

        public string LegalEntityName { get; set; } = null!;

        public string? DossierStatusCode { get; set; }

        public string? DossierStatusName { get; set; }

        public DateTime? DossierStatusDate { get; set; }

        public string? DossierInsureesName { get; set; }

        public bool? IsDossierInvalid { get; set; }

        public string? DossierInvalidReason { get; set; }

        public string? IncidentCountryCode { get; set; }

        public string? IncidentCountryName { get; set; }

        public bool IsMobility { get; set; }

        public bool IsProperty { get; set; }

        public DateTime? DamageDate { get; set; }

        public string? DossierStatusTypeId { get; set; }

        public string? DossierStatusTypeName { get; set; }

        public DateTime? IntakeDate { get; set; }

        public Guid? DamageReasonId { get; set; }

        public string? DamageReasonCode { get; set; }

        public string? DamageReasonName { get; set; }

        public Guid? CauseDamageReasonId { get; set; }

        public string? CauseDamageReasonCode { get; set; }

        public string? CauseDamageReasonName { get; set; }

        public Guid? MainDamageReasonId { get; set; }

        public string? MainDamageReasonCode { get; set; }

        public string? MainDamageReasonName { get; set; }

        public Guid? SubDamageReasonId { get; set; }

        public string? SubDamageReasonCode { get; set; }

        public string? SubDamageReasonName { get; set; }

        public Guid? EmployeeId { get; set; }

        public string? EmployeeFullName { get; set; }

        public Guid? ReporterId { get; set; }

        public string? ReporterCode { get; set; }

        public string ReporterName { get; set; } = null!;

        public DateTime CreatedDate { get; set; }

        public string? CreatedBy { get; set; }

        public DateTime LastModifiedDate { get; set; }

        public string? LastModifiedBy { get; set; }

        public byte[] TimeStamp { get; set; } = null!;
    }
}