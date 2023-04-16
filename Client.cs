using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gestion_Hotel
{
    internal class Client
    {
        public string Nom { get; set; }
        public string Prenom { get; set; }
        public string Email { get; set; }
        public string NumeroCarteCredit { get; set; }
        public int NumeroChambre { get; set; }

        public Client(string nom, string prenom, string email, string numeroCarteCredit, int numeroChambre)
        {
            Nom = nom;
            Prenom = prenom;
            Email = email;
            NumeroCarteCredit = numeroCarteCredit;
            NumeroChambre = numeroChambre;
        }
    }

}
