namespace CED.Data.Entities
{
    public class MedicalDossiersView
    {
        public Guid Id { get; set; }

        public DateTime IncidentDate { get; set; }

        public string? IncidentCountryCode { get; set; }

        public string? IncidentCountryName { get; set; }

        public DateTime IntakeDate { get; set; }

        public DateTime? ClosingDate { get; set; }

        public int? NumberOfPassengers { get; set; }

        public bool? ReportedAfterwards { get; set; }

        public bool? AssistanceBeforeConfirmation { get; set; }

        public string? Reason { get; set; }

        public string? Cause { get; set; }

        public string? ExternalComments { get; set; }

        public string? InternalComments { get; set; }

        public string? RoadName { get; set; }

        public double? HectometerPost { get; set; }

        public string? HectometerPostAddition { get; set; }

        public string? Direction { get; set; }

        public string? IncidentStreetName { get; set; }

        public string? IncidentHouseNo { get; set; }

        public string? IncidentHouseNoAddition { get; set; }

        public string? IncidentPostalCode { get; set; }

        public string? IncidentCity { get; set; }

        public string? IncidentProvince { get; set; }

        public double? Latitude { get; set; }

        public double? Longitude { get; set; }

        public string? RoadSectionId { get; set; }

        public string? IncidentRoadLane { get; set; }

        public bool? IncidentLocationIsMainRoad { get; set; }

        public string? IncidentLocationRoadTypeId { get; set; }

        public string? IncidentLocationRoadNumber { get; set; }

        public string? IncidentLocationTypeName { get; set; }

        public string? DossierNumber { get; set; }

        public Guid ClientId { get; set; }

        public string ClientCode { get; set; } = null!;

        public string ClientName { get; set; } = null!;

        public Guid? AgentId { get; set; }

        public string? AgentCode { get; set; }

        public string AgentName { get; set; } = null!;

        public Guid? ContactPersonId { get; set; }

        public string? ContactPersonFullName { get; set; }

        public string? ContactPersonEmail { get; set; }

        public string? ContactPersonMobile { get; set; }

        public string? ContactPersonPhone { get; set; }

        public Guid ProductId { get; set; }

        public string ProductCode { get; set; } = null!;

        public string ProductName { get; set; } = null!;

        public Guid? EmployeeId { get; set; }

        public string? EmployeeFullName { get; set; }

        public string? EmployeeEmail { get; set; }

        public Guid? TenantId { get; set; }

        public short? DossierTypeId { get; set; }

        public string? DossierTypeCode { get; set; }

        public string? DossierTypeName { get; set; }

        public string? EntrySystem { get; set; }

        public string? EntryNumber { get; set; }

        public string? EntryBatch { get; set; }

        public Guid? DossierHandlerId { get; set; }

        public string? DossierHandlerName { get; set; }

        public Guid? DossierStatusId { get; set; }

        public string? DossierStatusCode { get; set; }

        public string? DossierStatusName { get; set; }

        public string? ApplicationName { get; set; }

        public Guid? MandateId { get; set; }

        public string? MandateCode { get; set; }

        public string MandateName { get; set; } = null!;

        public Guid? DepartmentId { get; set; }

        public string? DepartmentCode { get; set; }

        public string DepartmentName { get; set; } = null!;

        public Guid? LegalEntityId { get; set; }

        public string? LegalEntityCode { get; set; }

        public string LegalEntityName { get; set; } = null!;

        public DateTime CreatedDate { get; set; }

        public string? CreatedBy { get; set; }

        public DateTime LastModifiedDate { get; set; }

        public string? LastModifiedBy { get; set; }
    }
}