namespace CED.Data.Entities
{
    public class DossiersView
    {
        public Guid DossierId { get; set; }

        public string? DossierNumber { get; set; }

        public string? Status { get; set; }

        public string? EmployeeId { get; set; }

        public string? EmployeeEmail { get; set; }

        public int? Priority { get; set; }

        public string? Products { get; set; }

        public string? MainActivities { get; set; }
    }
}