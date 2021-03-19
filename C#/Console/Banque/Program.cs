using System;

namespace Banque
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("---------------------------- Neuro Game Banque ----------------------------\n \n");

            Account newAccount = new Account("Christopher", "Nafrere", "26/07/2000", "11 rue de Nezel, Aubergenville");

            newAccount.getReleverBancaire();
        }
    }
}
