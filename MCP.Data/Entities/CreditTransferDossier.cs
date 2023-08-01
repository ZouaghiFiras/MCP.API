namespace CED.Data.Entities
{
    public class CreditTransferDossier
    {
        public Guid CtdId { get; set; }

        public byte[] CtdTimeStamp { get; set; } = null!;

        public Guid CtdCreditTransferId { get; set; }

        public string CtdDossierNumber { get; set; } = null!;

        public string? CtdDossierStatus { get; set; }

        public string? CtdInsurancePolicyNumber { get; set; }

        public string? CtdIncidentNumber { get; set; }

        public DateTime? CtdIncidentDate { get; set; }

        public string? CtdIncidentDescription { get; set; }

        public string? CtdInsuredPartyName { get; set; }

        public string? CtdInsuredPartyLicensePlate { get; set; }

        public string? CtdCounterPartyName { get; set; }

        public string? CtdInsuredDriverName { get; set; }

        public int? CtdInsuredDriverAge { get; set; }

        public bool? CtdIsInsuredLiable { get; set; }

        public bool? CtdIsClientCheckingAccount { get; set; }

        public string? CtdInsuranceCoverageCode { get; set; }

        public string? CtdInternalTextLine1 { get; set; }

        public string? CtdInternalTextLine2 { get; set; }

        public string? CtdInvolvedPartyRoleCode { get; set; }

        public string? CtdInvolvedPartyName { get; set; }

        public string? CtdInvolvedPartyStreetName { get; set; }

        public string? CtdInvolvedPartyPostalCode { get; set; }

        public string? CtdInvolvedPartyCity { get; set; }

        public string? CtdInvolvedPartyNotes { get; set; }

        public string? CtdPaymentToInvolvedPartyRoleCode { get; set; }

        public string? CtdAuditNotes { get; set; }

        public string? CtdClientProductCode { get; set; }

        public DateTime CtdCreatedDate { get; set; }

        public string? CtdCreatedBy { get; set; }

        public DateTime CtdLastModifiedDate { get; set; }

        public string? CtdLastModifiedBy { get; set; }

        public virtual CreditTransfer CtdCreditTransfer { get; set; } = null!;
    }
}