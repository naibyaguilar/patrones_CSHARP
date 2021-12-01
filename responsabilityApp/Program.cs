using System;

namespace responsabilityApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Purchase purchase = new Purchase(2036, 26000, "Sillas Ejecutivas");

            Director bradley = new Director();
            VicePresident finn = new VicePresident();
            President rose = new President();

            bradley.SetSuccessor(finn).SetSuccessor(rose);

            bradley.ProcessRequest(purchase);

            Console.ReadKey();
        }
    }
}
