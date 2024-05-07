using System;
namespace CompteEnBanque
{
	public class Compte{
        public string Nom { get; private set; }
        public string Prenom { get; private set; }
        public int Solde { get; private set; }
        private int NumCompte { get; }
        private int Mdp { get; }

        public Compte(string nom, string prenom, int numCompte, int mdp)
        {
            Nom = nom;
            Prenom = prenom;
            Solde = 0;
            NumCompte = numCompte;
            Mdp = mdp;
        }

        public Compte(string nom, string prenom) : this(nom, prenom, 0, 0) { }

        private bool VerifierMotDePasse(int motDePasse)
        {
            return motDePasse == Mdp;
        }

        public void Retrait(int montant, int motDePasse)
        {
            if (!VerifierMotDePasse(motDePasse))
            {
                throw new InvalidOperationException("Mot de passe incorrect.");
            }

            if (montant <= 0)
            {
                throw new ArgumentException("Le montant du retrait doit être positif.");
            }

            if (montant > Solde)
            {
                throw new InvalidOperationException("Solde insuffisant.");
            }

            Solde -= montant;
        }

        public void Depot(int montant, int motDePasse)
        {
            if (!VerifierMotDePasse(motDePasse))
            {
                throw new InvalidOperationException("Mot de passe incorrect.");
            }

            if (montant <= 0)
            {
                throw new ArgumentException("Le montant du dépôt doit être positif.");
            }

            Solde += montant;
        }

        public void Afficher()
        {
            Console.WriteLine("Nom: " + Nom);
            Console.WriteLine("Prénom: " + Prenom);
            Console.WriteLine("Numéro de compte: 210-" + NumCompte);
            Console.WriteLine("Solde: " + Solde);
        }
    }
}
