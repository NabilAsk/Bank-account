namespace Bank_account
{
    public class Compte
    {
        private double solde;
        
        public Compte(double solde)
        {
            this.solde = solde;
        }

        public double Getsolde()
        {
            return solde;
        }

        public void SetSolde(double solde)
        {
            this.solde = solde;
        }

    }
}