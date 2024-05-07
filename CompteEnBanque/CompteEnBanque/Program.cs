using System;

namespace CompteEnBanque
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Création d'un nouveau compte.");

            // Demander à l'utilisateur d'entrer les informations du compte
            Console.Write("Nom : ");
            string nom = Console.ReadLine();

            Console.Write("Prénom : ");
            string prenom = Console.ReadLine();

            Random rnd = new Random();
            int numeroCompte = rnd.Next(1000, 10000);

            Console.Write("Mot de passe : ");
            int motDePasse = int.Parse(Console.ReadLine());

            Compte monCompte = new Compte(nom, prenom, numeroCompte, motDePasse);

            // Demander à l'utilisateur d'effectuer une opération
            Console.WriteLine("\nQue souhaitez-vous faire ?");
            Console.WriteLine("1. Retrait");
            Console.WriteLine("2. Dépôt");
            int choix = int.Parse(Console.ReadLine());

            switch (choix)
            {
                case 1:
                    // Demander le montant du retrait
                    Console.Write("\nMontant du retrait : ");
                    int montantRetrait = int.Parse(Console.ReadLine());
                    Console.WriteLine("\nEntrer votre mot de passe:");
                    int mdp = int.Parse(Console.ReadLine());

                    // Effectuer le retrait
                    try
                    {
                        monCompte.Retrait(montantRetrait, mdp);
                        Console.WriteLine("Retrait effectué avec succès.");
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine("Erreur lors du retrait : " + ex.Message);
                    }
                    break;
                case 2:
                    // Demander le montant du dépôt
                    Console.Write("\nMontant du dépôt : ");
                    int montantDepot = int.Parse(Console.ReadLine());
                    Console.WriteLine("\nEntrer votre mot de passe:");
                    int mdp2 = int.Parse(Console.ReadLine());

                    // Effectuer le dépôt
                    try
                    {
                        monCompte.Depot(montantDepot, mdp2);
                        Console.WriteLine("Dépôt effectué avec succès.");
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine("Erreur lors du dépôt : " + ex.Message);
                    }
                    break;
                default:
                    Console.WriteLine("Choix invalide.");
                    break;
            }

            // Affichage des informations du compte après opération
            Console.WriteLine("\nInformations du compte après opération :");
            monCompte.Afficher();
        }
    }
}
