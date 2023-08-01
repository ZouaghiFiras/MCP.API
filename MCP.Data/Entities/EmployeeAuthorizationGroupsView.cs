namespace CED.Data.Entities
{
    public class EmployeeAuthorizationGroupsView
    {
        public Guid Id { get; set; }

        public Guid? LegalEntityId { get; set; }

        public Guid EmployeeId { get; set; }

        public string AuthorizationRoleId { get; set; } = null!;

        public string? AuthorizationRoleTypeId { get; set; }

        public bool OperationCreate { get; set; }

        public bool OperationRead { get; set; }

        public bool OperationUpdate { get; set; }

        public bool OperationDelete { get; set; }

        public bool OperationExecute { get; set; }

        public DateTime EffectiveDate { get; set; }

        public DateTime? TerminationDate { get; set; }

        public DateTime CreatedDate { get; set; }

        public string? CreatedBy { get; set; }

        public DateTime LastModifiedDate { get; set; }

        public string? LastModifiedBy { get; set; }

        public byte[] TimeStamp { get; set; } = null!;
    }
}