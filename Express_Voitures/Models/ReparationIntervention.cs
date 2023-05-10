namespace Express_Voitures.Models
{
    public class ReparationIntervention

    {
        public int Id { get; set; }
        public int ReparationId { get; set; }
        public Reparation Reparation { get; set; }

        public int InterventionId { get; set; }
        public Intervention Intervention { get; set; }

    }
}

