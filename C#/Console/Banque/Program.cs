using System;

namespace Banque
{
    class Program
    {
        static void Main(string[] args)
        {
            Account newAccount = new Account("Nafrere", "Christopher", "26/07/2000", "11 rue de nezel");
            newAccount.reception(1500);

            Console.WriteLine("\n");

            newAccount.getReleverBancaire();

        }
    }
}
