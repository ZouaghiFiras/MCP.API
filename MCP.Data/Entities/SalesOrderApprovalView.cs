namespace CED.Data.Entities
{
    public class SalesOrderApprovalView
    {
        public Guid Id { get; set; }

        public Guid? SalesOrderAuthorizationId { get; set; }

        public Guid? SalesOrderApprovalId { get; set; }

        public DateTime? ApprovalDate { get; set; }

        public string ApprovalStatus { get; set; } = null!;

        public bool? IsApproved { get; set; }

        public string? Comment { get; set; }

        public Guid? EmployeeId { get; set; }

        public string? EmployeeName { get; set; }

        public string? AutorizationRoleId { get; set; }

        public string? AutorizationRoleTypeId { get; set; }

        public DateTime CreatedDate { get; set; }

        public string? CreatedBy { get; set; }

        public DateTime LastModifiedDate { get; set; }

        public string? LastModifiedBy { get; set; }

        public byte[] TimeStamp { get; set; } = null!;
    }
}