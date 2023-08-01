﻿namespace CED.Data.Entities
{
    public class CalculationGroup
    {
        public Guid CagId { get; set; }

        public byte[] CagTimeStamp { get; set; } = null!;

        public string? CagNumber { get; set; }

        public string? CagTitle { get; set; }

        public Guid? CagRepairOrderId { get; set; }

        public string? CagCalculationStatus { get; set; }

        public string? CagCalculationType { get; set; }

        public decimal? CagTotalPurchasePrice { get; set; }

        public decimal? CagTotalSalesPrice { get; set; }

        public DateTime? CagCommitDate { get; set; }

        public DateTime? CagEvaluationDate { get; set; }

        public Guid? CagEvaluatedByEmployeeId { get; set; }

        public DateTime? CagStartWork { get; set; }

        public DateTime? CagEndWork { get; set; }

        public decimal? CagTotalSalesPriceWithoutSurcharge { get; set; }

        public decimal? CagTotalPurchsePriceWithoutSurchare { get; set; }

        public DateTime CagCreatedDate { get; set; }

        public string? CagCreatedBy { get; set; }

        public DateTime CagLastModifiedDate { get; set; }

        public string? CagLastModifiedBy { get; set; }

        public virtual RepairOrder? CagRepairOrder { get; set; }
    }
}