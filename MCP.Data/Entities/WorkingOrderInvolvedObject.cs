namespace CED.Data.Entities
{
    public class WorkingOrderInvolvedObject
    {
        public Guid WoioId { get; set; }

        public Guid WoioWorkingOrderId { get; set; }

        public Guid? WoioDossierAssignmentInvolvedObjectId { get; set; }

        public Guid WoioInvolvedObjectId { get; set; }

        public DateTime WoioCreatedDate { get; set; }

        public string? WoioCreatedBy { get; set; }

        public DateTime WoioLastModifiedDate { get; set; }

        public string? WoioLastModifiedBy { get; set; }

        public virtual DossierAssignmentInvolvedObject? WoioDossierAssignmentInvolvedObject { get; set; }

        public virtual InvolvedObject WoioInvolvedObject { get; set; } = null!;

        public virtual WorkingOrder WoioWorkingOrder { get; set; } = null!;

        public virtual ICollection<WorkingOrderLineInvolvedObject> WorkingOrderLineInvolvedObjects { get; } =
            new List<WorkingOrderLineInvolvedObject>();
    }
}