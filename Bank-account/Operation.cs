using System;

namespace Bank_account
{
    public class Operation
    {


        public DateTime date { get; set; }

        public string operation { get; set; }

        public double montant { get; set; }

        public string statut { get; set; }


        public Operation(DateTime date, string operation, double montant, string statut)
        {
            this.date = date;
            this.operation = operation;
            this.montant = montant;
            this.statut = statut;
        }
    }
}