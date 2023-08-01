namespace CED.Data.Entities
{
    public class DitzoPaymentsJournalLinesView
    {
        public string Ldrid { get; set; } = null!;

        public string Jrnlid { get; set; } = null!;

        public DateTime? Effdate { get; set; }

        public int Jrnlsnbr { get; set; }

        public long? Jrnllnbr { get; set; }

        public string Lientid { get; set; } = null!;

        public int Account { get; set; }

        public string Center { get; set; } = null!;

        public int? Project { get; set; }

        public string Product { get; set; } = null!;

        public string Flow { get; set; } = null!;

        public string Partner { get; set; } = null!;

        public decimal? Transamt { get; set; }

        public string Primcd { get; set; } = null!;

        public string Transcd { get; set; } = null!;

        public string Curtyp { get; set; } = null!;

        public string Curdat { get; set; } = null!;

        public string Jnlfld1 { get; set; } = null!;

        public string Jnlfld2 { get; set; } = null!;

        public string Jnlfld3 { get; set; } = null!;

        public string Descriptn { get; set; } = null!;

        public string Userid { get; set; } = null!;

        public string Primamt { get; set; } = null!;

        public string Srckey { get; set; } = null!;

        public string Adbvldat { get; set; } = null!;

        public string Channel { get; set; } = null!;

        public int? PaymentYear { get; set; }

        public int? PaymentMonth { get; set; }
    }
}