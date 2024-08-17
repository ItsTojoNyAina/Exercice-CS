using System;
using System.Collections.Generic;

namespace Gestion_Compte_Client
{ 
    class Program
    {
        static void Main()
        {
            // Exemples d'intervenants
            var intervenant1 = new Intervenant("Alice", "Qualification 1", 5.0, 300.0, 10);
            var intervenant2 = new Intervenant("Bob", "Qualification 2", 4.0, 400.0, 8);
            var intervenant3 = new Intervenant("Charlie", "Qualification 3", 6.0, 500.0, 12);

            // Liste d'intervenants pour l'intervention
            var intervenants = new List<Intervenant> { intervenant1, intervenant2, intervenant3 };

            // Création de l'intervention
            var intervention = new Intervention(intervenants);

            // Ajustement des qualifications avec l'algorithme d'Euler
            double coutTotalFinal = intervention.AjustementQualificationEuler(nombreIterations: 100, pas: 0.01, seuil: 0.001);

            // Affichage du coût total final
            Console.WriteLine("Le coût total final de l'intervention est : " + coutTotalFinal);
        }
    }
}
