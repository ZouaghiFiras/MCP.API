﻿namespace CED.Data.Entities
{
    public class InvolvedPartiesHistory
    {
        public Guid HistoryId { get; set; }

        public string? HistoryTriggeredBy { get; set; }

        public string? HistoryTriggerType { get; set; }

        public DateTime? HistoryTriggerDateTime { get; set; }

        public Guid? IpaId { get; set; }

        public string? IpaPartyNumber { get; set; }

        public string? IpaInitials { get; set; }

        public string? IpaFirstName { get; set; }

        public string? IpaPrefixLastName { get; set; }

        public string? IpaLastName { get; set; }

        public string? IpaFullName { get; set; }

        public string? IpaIban { get; set; }

        public string? IpaBic { get; set; }

        public long? IpaBankAccountNumber { get; set; }

        public string? IpaStreetName { get; set; }

        public string? IpaHouseNumber { get; set; }

        public string? IpaHouseNumberAddition { get; set; }

        public string? IpaPostalCode { get; set; }

        public string? IpaCity { get; set; }

        public string? IpaProvince { get; set; }

        public string? IpaCountryCode { get; set; }

        public string? IpaFullAddress { get; set; }

        public string? IpaPhoneNumber { get; set; }

        public string? IpaEmail { get; set; }

        public DateTime? IpaDateOfBirth { get; set; }

        public string? IpaPartyGender { get; set; }

        public bool? IpaIsTaxExempted { get; set; }

        public string? IpaExemptNumber { get; set; }

        public DateTime? IpaCreatedDate { get; set; }

        public string? IpaCreatedBy { get; set; }

        public DateTime? IpaLastModifiedDate { get; set; }

        public string? IpaLastModifiedBy { get; set; }

        public string? IpaPhoneNumber2 { get; set; }

        public string? IpaMiddleName { get; set; }

        public string? IpaCocNumber { get; set; }

        public Guid? IpaSalutationId { get; set; }

        public bool? IpaIsHomeOwnerAssociation { get; set; }

        public string? IpaPhoneNumber3 { get; set; }

        public string? IpaReference { get; set; }
    }
}