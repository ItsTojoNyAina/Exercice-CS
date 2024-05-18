using System;
namespace Mini_jeux_de_combat
{
    class Program {
        static void Main(string[] args) {
            Guerrier g1 = new Guerrier("Tojo", 400,200,300,120);
            Guerrier g2 = new Guerrier("Botin", 200, 100, 400, 130);
            g2.LancerAttqAvcDef(g1);
            g1.LancerAttqAvcDef(g2);
            g2.ActiverSoin();
            g1.ActiverSoin();
        }
    }
}
