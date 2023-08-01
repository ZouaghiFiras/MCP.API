namespace CED.Data.Entities
{
    public class VolumeSalesAgreement
    {
        public Guid VsaId { get; set; }

        public byte[] VsaTimeStamp { get; set; } = null!;

        public double VsaVolumeMin { get; set; }

        public double? VsaVolumeMax { get; set; }

        public decimal? VsaAmount { get; set; }

        public DateTime VsaCreatedDate { get; set; }

        public string? VsaCreatedBy { get; set; }

        public DateTime VsaLastModifiedDate { get; set; }

        public string? VsaLastModifiedBy { get; set; }

        public Guid VsaSalesAgreementId { get; set; }

        public string? VsaUnitOfMeasureId { get; set; }

        public virtual SalesAgreement VsaSalesAgreement { get; set; } = null!;

        public virtual UnitOfMeasure? VsaUnitOfMeasure { get; set; }
    }
}