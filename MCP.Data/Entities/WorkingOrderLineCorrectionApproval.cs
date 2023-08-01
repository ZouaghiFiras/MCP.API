namespace CED.Data.Entities
{
    public class WorkingOrderLineCorrectionApproval
    {
        public Guid WolapId { get; set; }

        public byte[] WolapTimeStamp { get; set; } = null!;

        public Guid WolapWorkingOrderLineCorrectionAuthorizationId { get; set; }

        public DateTime WolapApprovalDate { get; set; }

        public bool WolapIsApproved { get; set; }

        public string? WolapComment { get; set; }

        public Guid WolapEmployeeId { get; set; }

        public string WolapAutorizationRoleId { get; set; } = null!;

        public DateTime WolapCreatedDate { get; set; }

        public string? WolapCreatedBy { get; set; }

        public DateTime WolapLastModifiedDate { get; set; }

        public string? WolapLastModifiedBy { get; set; }

        public virtual AuthorizationRole WolapAutorizationRole { get; set; } = null!;

        public virtual Employee WolapEmployee { get; set; } = null!;

        public virtual WorkingOrderLineCorrectionAuthorization WolapWorkingOrderLineCorrectionAuthorization
        {
            get;
            set;
        } = null!;
    }
}