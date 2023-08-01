namespace CED.Data.Entities
{
    public class RepairOrder
    {
        public Guid RohId { get; set; }

        public byte[] RohTimeStamp { get; set; } = null!;

        public string? RohNumber { get; set; }

        public DateTime? RohDate { get; set; }

        public Guid RohRepairerId { get; set; }

        public Guid? RohTenantId { get; set; }

        public DateTime RohCreatedDate { get; set; }

        public string? RohCreatedBy { get; set; }

        public DateTime RohLastModifiedDate { get; set; }

        public string? RohLastModifiedBy { get; set; }

        public bool? RohToyRequired { get; set; }

        public bool? RohToyDelivered { get; set; }

        public bool? RohPreventionBoxRequired { get; set; }

        public bool? RohPreventionBoxDelivered { get; set; }

        public bool? RohSuspectingFraud { get; set; }

        public string? RohMaintenanceStatus { get; set; }

        public bool? RohSituationMatchesAssignment { get; set; }

        public bool? RohCauseMatchesAssignment { get; set; }

        public bool? RohIsAdditionalWork { get; set; }

        public decimal? RohFee { get; set; }

        public bool? RohIsContractorModel { get; set; }

        public Guid? RohCurrentStatusHistoryId { get; set; }

        public DateTime? RohCurrentStatusHistoryStartDate { get; set; }

        public string? RohCurrentStatusCode { get; set; }

        public virtual ICollection<CalculationGroup> CalculationGroups { get; } = new List<CalculationGroup>();

        public virtual ICollection<RepairOrderLine> RepairOrderLines { get; } = new List<RepairOrderLine>();

        public virtual ICollection<RepairOrderStatusHistory> RepairOrderStatusHistories { get; } =
            new List<RepairOrderStatusHistory>();

        public virtual Repairer RohRepairer { get; set; } = null!;

        public virtual Tenant? RohTenant { get; set; }
    }
}