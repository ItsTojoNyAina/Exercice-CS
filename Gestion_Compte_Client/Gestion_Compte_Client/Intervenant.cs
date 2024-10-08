﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gestion_Compte_Client
{
    internal class Intervenant
    {
            public string Nom { get; set; }
            public string QualificationBase { get; set; }
            public double QualificationIntervention { get; set; }
            public double TarifJournalier { get; set; }
            public int JoursHommes { get; set; }

            public Intervenant(string nom, string qualificationBase, double qualificationIntervention, double tarifJournalier, int joursHommes)
            {
                Nom = nom;
                QualificationBase = qualificationBase;
                QualificationIntervention = qualificationIntervention;
                TarifJournalier = tarifJournalier;
                JoursHommes = joursHommes;
            }

            public double CalculerCout()
            {
                return TarifJournalier * JoursHommes;
            }

            public void AjusterQualification(double deltaQualification)
            {
                QualificationIntervention += deltaQualification * F(QualificationIntervention);
            }

            private double F(double qualification)
            {
                return 1.0;  
            }
        }

    }
