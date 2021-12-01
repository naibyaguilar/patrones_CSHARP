using System;
using System.Collections.Generic;
using System.Text;

namespace MediatorApp
{
    internal class BottomNavigation : BaseComponent
    {
        public void HideBottomNavigation()
        {
            Console.WriteLine("Se ha ocultado el menu de navegación");
            this._mediator?.HandlerChange(this, "goToStore");
        }

        public void ShowBottomNavigation()
        {
            Console.WriteLine("Se ha mostrado el menu de navegador");
            this._mediator?.HandlerChange(this, "goToStore");

        }
    }
}
