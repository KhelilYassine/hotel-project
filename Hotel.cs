using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gestion_Hotel
{
    internal class Hotel
    {
        public string Nom { get; set; }
        public string Adresse { get; set; }
        public List<Client> Clients { get; set; }

        public Hotel(string nom, string adresse)
        {
            Nom = nom;
            Adresse = adresse;
            Clients = new List<Client>();
        }

        public void AjouterClient(Client client)
        {
            Clients.Add(client);
        }
    }


}
