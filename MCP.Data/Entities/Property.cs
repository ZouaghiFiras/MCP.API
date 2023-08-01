﻿namespace CED.Data.Entities
{
    public class Property
    {
        public Guid PrpId { get; set; }

        public byte[] PrpTimeStamp { get; set; } = null!;

        public string? PrpCondition { get; set; }

        public string? PrpBuildingUse { get; set; }

        public int? PrpConstructionYear { get; set; }

        public string? PrpDamageStreet { get; set; }

        public string? PrpDamageCity { get; set; }

        public string? PrpPolicyNumber { get; set; }

        public decimal? PrpDeductibleExcess { get; set; }

        public decimal? PrpInsuredAmount { get; set; }

        public string? PrpPolicyConditions { get; set; }

        public string? PrpDeedOfAssignment { get; set; }

        public bool? PrpGuaranteeAgainstUnderinsurance { get; set; }

        public bool? PrpInc { get; set; }

        public bool? PrpExVat { get; set; }

        public string? PrpPostalCode { get; set; }

        public string? PrpHouseNumber { get; set; }

        public string? PrpCountry { get; set; }

        public int? PrpNumberOfDamagedObjects { get; set; }

        public bool? PrpInsuredAmountHasToBeDetermined { get; set; }

        public decimal? PrpDamageAmount { get; set; }

        public string? PrpHouseNumberAddition { get; set; }

        public DateTime PrpCreatedDate { get; set; }

        public string? PrpCreatedBy { get; set; }

        public DateTime PrpLastModifiedDate { get; set; }

        public string? PrpLastModifiedBy { get; set; }

        public Guid? PrpExternalMaterialId { get; set; }

        public Guid? PrpRoofCoveringId { get; set; }

        public virtual InvolvedObject Prp { get; set; } = null!;

        public virtual ExternalMaterial? PrpExternalMaterial { get; set; }

        public virtual RoofCovering? PrpRoofCovering { get; set; }
    }
}