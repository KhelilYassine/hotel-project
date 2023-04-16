using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gestion_Hotel
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Hotel hotel = new Hotel("Hôtel de Ville", "123 Rue de la Montagne, Montréal, QC H3G 1Z1, Canada");

            // Création de 10 clients
            Client client1 = new Client("Dupont", "Jean", "jean.dupont@email.com", "1234-5678-9012-3456", 101);
            Client client2 = new Client("Tremblay", "Marie", "marie.tremblay@email.com", "2345-6789-0123-4567", 102);
            Client client3 = new Client("Gagnon", "Luc", "luc.gagnon@email.com", "3456-7890-1234-5678", 103);
            Client client4 = new Client("Martin", "Sophie", "sophie.martin@email.com", "4567-8901-2345-6789", 104);
            // Ajout des clients à l'hôtel
            hotel.AjouterClient(client1);
            hotel.AjouterClient(client2);
            hotel.AjouterClient(client3);
            hotel.AjouterClient(client4);
            // Affichage des clients et de leur numéro de chambre en français
            Console.WriteLine("Liste des clients de " + hotel.Nom + ":\n");
            foreach (Client client in hotel.Clients)
            {
                Console.WriteLine(" - {0} {1} ({2}) Chambre : {3}", client.Prenom, client.Nom, client.Email,client.NumeroChambre);
            }


            // Attendez une saisie de l'utilisateur avant de fermer la fenêtre de console
            Console.WriteLine("Clicker sur une toucher pour quitter...");
            Console.ReadKey();
        }

    }
    }
