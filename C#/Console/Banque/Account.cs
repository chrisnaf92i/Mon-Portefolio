using System;

namespace Banque
{
    public class Account
    {
        // Intégration de l'objet random
        public Random random = new Random();

        // identité
        public string name;
        public string firstName;
        public string birthDate;
        public string adresse;

        // donnée bancaire
        public int AccountNumber;
        public int rib;
        public int currentAmount;
        
        public Account(string _name, string _firstName, string _birthDate, string _adresse)
        {
            currentAmount = 0;

            name = _name;
            firstName = _firstName;
            birthDate = _birthDate;
            adresse = _adresse;


            // génération des information de bases
            AccountNumber = GenerateAccountNumber();
            rib = GenerateRib();

            Console.WriteLine("Création du compte de " + firstName + " " + name + ".");
        }

        private int GenerateRib()
        {
            int newRib = random.Next(100000, 999999);
            
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

            Console.WriteLine("Vous venez de recevoir " + _amount + " EUR, vous avez maintenant " + currentAmount + " EUR");
        }

        public void pay(int _amount)
        {
            currentAmount -= _amount;

            Console.WriteLine("Vous venez de payer " + _amount + " EUR, il vous reste " + currentAmount + " EUR");
        }

        public void getReleverBancaire()
        {
            Console.WriteLine("titulaire : " + firstName + " " + name);
            Console.WriteLine("\t - rib : " + rib);
            Console.WriteLine("\t - Montant Actuel : " + currentAmount + " EUR");
        }
    }
}