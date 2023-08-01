﻿namespace CED.Data.Entities
{
    public class AdviceDossier
    {
        public Guid AvdId { get; set; }

        public byte[] AvdTimeStamp { get; set; } = null!;

        public Guid? AvdInsurancePolicyId { get; set; }

        public string? AvdCaseNumber { get; set; }

        public DateTime? AvdDamageDate { get; set; }

        public string? AvdDamageStreet { get; set; }

        public string? AvdDamageCity { get; set; }

        public string? AvdCoverage { get; set; }

        public string? AvdDamageType { get; set; }

        public string? AvdCause { get; set; }

        public string? AvdObjectCondition { get; set; }

        public string? AvdObjectBuildingInUse { get; set; }

        public int? AvdObjectContructionYear { get; set; }

        public string? AvdObjectExternalMaterials { get; set; }

        public string? AvdObjectRoofCoverging { get; set; }

        public bool? AvdRecoveryPossible { get; set; }

        public string? AvdAdditionalExplanation { get; set; }

        public decimal? AvdDamageAmountEstimate { get; set; }

        public bool AvdDamageDateKnown { get; set; }

        public bool AvdIsDamageDateEstimated { get; set; }

        public Guid? AvdMainReason { get; set; }

        public Guid? AvdReason { get; set; }

        public Guid? AvdSubReason { get; set; }

        public DateTime? AvdIntakeDate { get; set; }

        public DateTime AvdCreatedDate { get; set; }

        public string? AvdCreatedBy { get; set; }

        public DateTime AvdLastModifiedDate { get; set; }

        public string? AvdLastModifiedBy { get; set; }

        public bool? AvdIsNotUrgent { get; set; }

        public virtual Dossier Avd { get; set; } = null!;

        public virtual InsurancePolicy? AvdInsurancePolicy { get; set; }
    }
}