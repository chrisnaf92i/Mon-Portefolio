using System;

namespace Banque
{
    public class Account
    {
        // identité
        public string nom;
        public string prenom;
        public string dateNaissance;
        public string adresse;

        // donnée bancaire
        public int AccountNumber;
        public int rib;
        public int currentAmount;
        
        public Account(string _nom, string _prenom, string _dateNaissance, string _adresse)
        {
            currentAmount = 0;

            nom = _nom;
            prenom = _prenom;
            dateNaissance = _dateNaissance;
            adresse = _adresse;


            // génération des information de bases
            AccountNumber = GenerateAccountNumber();
            rib = GenerateRib();

            Console.WriteLine("Création du compte de " + prenom + " " + nom + ".");
        }

        private int GenerateRib()
        {
            int newRib = 5;

            return newRib;
        }
        
        private int GenerateAccountNumber()
        {
            int newNumber = 5;

            return newNumber;
        }

        public void reception(int _amount)
        {
            currentAmount += _amount;

            Console.WriteLine("Vous venez de recevoir " + _amount + " e, vous avez maintenant " + currentAmount + " e");
        }

        public void pay(int _amount)
        {
            currentAmount -= _amount;

            Console.WriteLine("Vous venez de payer " + _amount + " e, il vous reste " + currentAmount + " e");
        }

        public void getReleverBancaire()
        {
            Console.WriteLine("titulaire : " + prenom + " " + nom);
            Console.WriteLine("\t - rib : " + rib);
            Console.WriteLine("\t - Current Amount : " + currentAmount + "e");
        }
    }
}