using System;

namespace MediatorApp
{
    class Program
    {
        static void Main(string[] args)
        {
            BottomNavigation bottomNavigation = new BottomNavigation();
            Logo logo = new Logo();

            new UI(bottomNavigation, logo);

            Console.WriteLine("Reacción de la interfaz de usuario del cliente de HomeAction");
            bottomNavigation.HideBottomNavigation();

            Console.ReadKey();
        }
    }
}
