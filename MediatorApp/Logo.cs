using System;
using System.Collections.Generic;
using System.Text;

namespace MediatorApp
{
    internal class Logo : BaseComponent
    {
        public void ChangeIcon()
        {
            Console.WriteLine("Se ha cambiado el icono del logotipo");
            this._mediator?.HandlerChange(this, "goToMain");
        }

        public void HideLogo()
        {
            Console.WriteLine("el logotipo ha desaparecido");
            this._mediator?.HandlerChange(this, "goToProfile");
        }
    }
}
