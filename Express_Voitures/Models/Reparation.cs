namespace Express_Voitures.Models
{
    public class Reparation
    {
        public int Id { get; set; }
        public DateTime DatePEC { get; set; }
        public string Description { get; set; }
        // public decimal Cout { get; set; }
        public DateTime? DateDisponibilite { get; set; }

        public int VoitureId { get; set; }
        public Voiture Voiture { get; set; }
    }
}
