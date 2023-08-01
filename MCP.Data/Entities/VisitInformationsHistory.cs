namespace CED.Data.Entities
{
    public class VisitInformationsHistory
    {
        public Guid HistoryId { get; set; }

        public string? HistoryTriggeredBy { get; set; }

        public string? HistoryTriggerType { get; set; }

        public DateTime? HistoryTriggerDateTime { get; set; }

        public Guid? VifId { get; set; }

        public string? VifLocationObjectX { get; set; }

        public DateTime? VifVisitDate { get; set; }

        public string? VifContactPerson { get; set; }

        public bool? VifPriority { get; set; }

        public bool? VifCallToday { get; set; }

        public string? VifAddressLevel1 { get; set; }

        public string? VifAddressLevel2 { get; set; }

        public string? VifCountry { get; set; }

        public string? VifZipCode { get; set; }

        public string? VifState { get; set; }

        public Guid? VifDossierId { get; set; }

        public bool? VifLocationUnknow { get; set; }

        public Guid? VifTimeSoltId { get; set; }

        public Guid? VifInvolvedPartyId { get; set; }

        public string? VifTypeOfContact { get; set; }

        public bool? VifIsActive { get; set; }

        public string? VifReason { get; set; }

        public Guid? VifEmployeeId { get; set; }

        public string? VifPhoneNumber { get; set; }

        public string? VifHouseNumberAddition { get; set; }

        public DateTime? VifCreatedDate { get; set; }

        public string? VifCreatedBy { get; set; }

        public DateTime? VifLastModifiedDate { get; set; }

        public string? VifLastModifiedBy { get; set; }
    }
}