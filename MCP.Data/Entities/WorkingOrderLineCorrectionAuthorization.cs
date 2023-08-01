namespace CED.Data.Entities
{
    public class WorkingOrderLineCorrectionAuthorization
    {
        public Guid WolcuId { get; set; }

        public byte[] WolcuTimeStamp { get; set; } = null!;

        public Guid WolcuWorkingOrderLineId { get; set; }

        public string WolcuRequiredAutorizationRoleId { get; set; } = null!;

        public DateTime WolcuCreatedDate { get; set; }

        public string? WolcuCreatedBy { get; set; }

        public DateTime WolcuLastModifiedDate { get; set; }

        public string? WolcuLastModifiedBy { get; set; }

        public virtual AuthorizationRole WolcuRequiredAutorizationRole { get; set; } = null!;

        public virtual WorkingOrderLine WolcuWorkingOrderLine { get; set; } = null!;

        public virtual ICollection<WorkingOrderLineCorrectionApproval> WorkingOrderLineCorrectionApprovals { get; } =
            new List<WorkingOrderLineCorrectionApproval>();
    }
}