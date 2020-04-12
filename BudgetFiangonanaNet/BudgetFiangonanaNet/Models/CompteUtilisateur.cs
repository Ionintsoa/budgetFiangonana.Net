using System;
using System.ComponentModel;

namespace BudgetFiangonanaNet.Models
{
    public class CompteUtilisateur
    {
        public String FirstName { get; set; }
        public String LastName { get; set; }
        [DisplayName("Identifiant")]
        public String EmailAddress { get; set; }
        [DisplayName("Mot de passe")]
        public String Password { get; set; }


    }
}
