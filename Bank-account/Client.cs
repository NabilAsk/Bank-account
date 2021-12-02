using System;
using System.Collections.Generic;
using System.Text;

namespace Bank_account
{
    class Client
    {
        private string name;
        private Compte compte;
        private List<Operation> operation;

        public Client() { }

        public Client(string name, Compte compte)
        {
            this.name = name;
            operation = new List<Operation>();
        }

        public void Crediter(Compte compte, double montant) {
            Operation op = new Operation(DateTime.Now, "Dépot", montant, "Validé");
            compte.SetSolde(compte.Getsolde()+ montant);

            operation.Add(op);

        }
        public void Debiter (Compte compte, double montant) {
            string statut;
            if ((compte.Getsolde() - montant) < 0)
            {
                
                statut = "Echec, Votre solde est insiffusant";
            }
            else
            {
                compte.SetSolde( compte.Getsolde() - montant);
                statut = "Validé";
            }
            Operation op = new Operation(DateTime.Now, "Retrait", montant, statut);
            operation.Add(op);
        }

        public void afficher()
        {
          foreach(Operation op in operation){
                Console.WriteLine("Opération : "  +op.operation + ", montant: "  +op.montant+ 
                    ", Date d'opération :" + op.date.ToString() + ", Statut: "+op.statut);
            }
        }

    }

    
    
}
