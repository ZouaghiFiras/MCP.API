namespace CED.Data.Entities
{
    public class DossierAssignmentInvolvedObject
    {
        public Guid DaioId { get; set; }

        public byte[] DaioTimeStamp { get; set; } = null!;

        public Guid DaioDossierAssignmentId { get; set; }

        public Guid DaioInvolvedObjectId { get; set; }

        public DateTime DaioCreatedDate { get; set; }

        public string? DaioCreatedBy { get; set; }

        public DateTime DaioLastModifiedDate { get; set; }

        public string? DaioLastModifiedBy { get; set; }

        public virtual DossierAssignment DaioDossierAssignment { get; set; } = null!;

        public virtual InvolvedObject DaioInvolvedObject { get; set; } = null!;

        public virtual ICollection<WorkingOrderInvolvedObject> WorkingOrderInvolvedObjects { get; } =
            new List<WorkingOrderInvolvedObject>();
    }
}