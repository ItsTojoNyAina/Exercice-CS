using System;
namespace Mini_jeux_de_combat
{
	public class Guerrier
	{
		private string Nom { get; set; }
		private int Attaque { get; set; }
		private int Defense { get; set; }
		private int Sante { get; set; }
		private int Mana { get; set; }
		public Guerrier(string nom,int attaque, int defense, int sante,int mana)
		{
			this.Nom = nom;
			this.Attaque = attaque;
			this.Defense = defense;
			this.Sante = sante;
			this.Mana = 100;
		}
		public Guerrier() { }
		public void AfficherInformation() {
			Console.WriteLine("Nom:" + this.Nom);
            Console.Write("Attaque:" + this.Attaque);
            Console.Write("Défense:" + this.Defense);
            Console.Write("Santé:" + this.Sante);
        }
		public void LancerAttaqueSur(Guerrier cible) {
			cible.Sante -= Attaque;
			AfficherInformation();
			cible.AfficherInformation();
		}
		public void LancerAttqAvcDef (Guerrier cible){
			Console.WriteLine($"{Nom} essaie d'attaquer"+cible.Nom);
			if (Attaque > cible.Defense) {
				LancerAttaqueSur(cible);
			}
			else {
				Console.WriteLine("Vous êtes trop faible pour attaquer le Goat en face de vous......Maintenant Fuck You");
				Sante -= (cible.Defense - Attaque); 
			}
            AfficherInformation();
            cible.AfficherInformation();
        }
		public void ActiverSoin() {
			if (Mana >= 10) {
				Console.WriteLine($"{Nom} essaie de se soigner!");
				Mana -= 10;
				Sante += 10;
				Console.WriteLine($"Soin réussi nouvelle stat de Santé: {Sante}");
            }
			else {
				Console.WriteLine("Pas assez de mana pour se soigner");
			}
		}
		
	}
}

