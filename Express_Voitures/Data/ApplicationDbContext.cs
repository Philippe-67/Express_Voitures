using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Express_Voitures.Models;

namespace Express_Voitures.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<Express_Voitures.Models.Voiture> Voiture { get; set; } = default!;
        public DbSet<Express_Voitures.Models.Reparation> Reparation { get; set; } = default!;
        public DbSet<Express_Voitures.Models.Intervention> Intervention { get; set; } = default!;
        public DbSet<Express_Voitures.Models.ReparationIntervention> ReparationIntervention { get; set; } = default!;
    }
}