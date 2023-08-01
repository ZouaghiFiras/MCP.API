namespace CED.Data.Entities
{
    public class WorkingOrderView
    {
        public Guid DossierId { get; set; }

        public string? DossierNumber { get; set; }

        public Guid WorkingOrderId { get; set; }

        public string? Number { get; set; }

        public Guid? EmployeeId { get; set; }

        public string? EmployeeEmail { get; set; }

        public string? Product { get; set; }

        public string? MainActivityCode { get; set; }

        public string? MainActivityName { get; set; }

        public string? Status { get; set; }

        public string? SubStatus { get; set; }

        public string? Feature { get; set; }

        public string? QualityCheckStatus { get; set; }
    }
}