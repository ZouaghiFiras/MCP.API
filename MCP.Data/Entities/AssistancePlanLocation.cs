namespace CED.Data.Entities
{
    public class AssistancePlanLocation
    {
        public Guid AloId { get; set; }

        public byte[] AloTimeStamp { get; set; } = null!;

        public Guid? AloAddressId { get; set; }

        public string? AloRoadName { get; set; }

        public double? AloHectometerPost { get; set; }

        public string? AloHectometerPostAddition { get; set; }

        public string? AloDirection { get; set; }

        public string? AloNotes { get; set; }

        public string? AloRoadSectionId { get; set; }

        public string? AloRoadTypeId { get; set; }

        public string? AloRoadNumber { get; set; }

        public string? AloRoadLane { get; set; }

        public bool AloIsMainRoad { get; set; }

        public Guid? AloRoadLocationId { get; set; }

        public Guid? AloLocationTypeId { get; set; }

        public DateTime AloCreatedDate { get; set; }

        public string? AloCreatedBy { get; set; }

        public DateTime AloLastModifiedDate { get; set; }

        public string? AloLastModifiedBy { get; set; }

        public virtual Address? AloAddress { get; set; }

        public virtual LocationType? AloLocationType { get; set; }

        public virtual RoadLocation1? AloRoadLocation { get; set; }

        public virtual RoadSection1? AloRoadSection { get; set; }

        public virtual RoadType? AloRoadType { get; set; }

        public virtual ICollection<AssistanceDossier> AssistanceDossiers { get; } = new List<AssistanceDossier>();

        public virtual ICollection<AssistancePlan> AssistancePlanAspDropoffLocations { get; } =
            new List<AssistancePlan>();

        public virtual ICollection<AssistancePlan> AssistancePlanAspPickupLocations { get; } =
            new List<AssistancePlan>();

        public virtual ICollection<MedicalDossier> MedicalDossiers { get; } = new List<MedicalDossier>();
    }
}