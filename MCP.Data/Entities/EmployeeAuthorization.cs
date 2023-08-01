namespace CED.Data.Entities
{
    public class EmployeeAuthorization
    {
        public Guid EauId { get; set; }

        public byte[] EauTimeStamp { get; set; } = null!;

        public Guid EauEmployeeId { get; set; }

        public string EauAuthorizationRoleId { get; set; } = null!;

        public Guid? EauLegalEntityId { get; set; }

        public bool EauOperationCreate { get; set; }

        public bool EauOperationRead { get; set; }

        public bool EauOperationUpdate { get; set; }

        public bool EauOperationDelete { get; set; }

        public bool? EauOperationExecute { get; set; }

        public DateTime EauEffectiveDate { get; set; }

        public DateTime? EauTerminationDate { get; set; }

        public DateTime EauCreatedDate { get; set; }

        public string? EauCreatedBy { get; set; }

        public DateTime EauLastModifiedDate { get; set; }

        public string? EauLastModifiedBy { get; set; }

        public virtual AuthorizationRole EauAuthorizationRole { get; set; } = null!;

        public virtual Employee EauEmployee { get; set; } = null!;

        public virtual LegalEntity? EauLegalEntity { get; set; }
    }
}