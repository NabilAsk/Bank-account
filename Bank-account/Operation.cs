using System;

namespace Bank_account
{
    public class Operation
    {


        public DateTime date;

        public string operation;

        public double montant;

        public string statut;


        public Operation(DateTime date, string operation, double montant, string statut)
        {
            this.date = date;
            this.operation = operation;
            this.montant = montant;
            this.statut = statut;
        }
    }
}