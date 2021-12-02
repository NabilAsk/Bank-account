using System;

namespace Bank_account
{
    class Program
    {
        static void Main(string[] args)
        {
            Compte compte = new Compte(1000);
            Client client = new Client("Laurent", compte);

            client.Debiter(compte, 500);
            client.Debiter(compte, 600);
            client.Crediter(compte, 500);

            client.afficher();

        }
    }
}
