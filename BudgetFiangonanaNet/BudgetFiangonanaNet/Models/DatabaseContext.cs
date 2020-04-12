using System.Data.Entity;

namespace BudgetFiangonanaNet.Models
{
    public class DatabaseContext:DbContext
    {
        public DatabaseContext():base("budgetfiangonananet")
        {
        }

        public DbSet<CompteUtilisateur> CompteUtilisateur { get; set; }
		public DbSet<Mouvement> CompteUtilisateur { get; set; }

	}
}
