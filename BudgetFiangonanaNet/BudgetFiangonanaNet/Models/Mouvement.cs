using System;
namespace BudgetFiangonanaNet.Models
{
    public class Mouvement
    {
        public int TypeMouvement { get; set; }
        public double Montant { get; set; }
        public string Motif { get; set; }
        public DateTime Date { get; set; }
        public DateTime DateCreation { get; set; }
    }
}
