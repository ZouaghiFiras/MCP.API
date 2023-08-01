namespace CED.Data.Entities
{
    public class AssistancePlanLocationsHistory
    {
        public Guid HistoryId { get; set; }

        public string? HistoryTriggeredBy { get; set; }

        public string? HistoryTriggerType { get; set; }

        public DateTime? HistoryTriggerDateTime { get; set; }

        public Guid? AloId { get; set; }

        public Guid? AloAddressId { get; set; }

        public string? AloRoadName { get; set; }

        public double? AloHectometerPost { get; set; }

        public string? AloHectometerPostAddition { get; set; }

        public string? AloDirection { get; set; }

        public string? AloNotes { get; set; }

        public DateTime? AloCreatedDate { get; set; }

        public string? AloCreatedBy { get; set; }

        public DateTime? AloLastModifiedDate { get; set; }

        public string? AloLastModifiedBy { get; set; }

        public bool? AloIsMainRoad { get; set; }

        public string? AloRoadNumber { get; set; }

        public Guid? AloRoadLocationId { get; set; }

        public string? AloRoadLane { get; set; }

        public Guid? AloLocationTypeId { get; set; }

        public string? AloRoadTypeId { get; set; }

        public string? AloRoadSectionId { get; set; }
    }
}