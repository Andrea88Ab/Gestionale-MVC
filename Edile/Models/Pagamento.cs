namespace Edile.Models
{
    public class Pagamento
    {
        public int Id { get; set; }
        public int DipendenteId { get; set; }
        public string Periodo { get; set; }
        public decimal Ammontare { get; set; }
        public string Tipo { get; set; } // Stipendio o Acconto
    }
}
