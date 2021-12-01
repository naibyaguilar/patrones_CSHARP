using System;
using System.Collections.Generic;
using System.Text;

namespace MediatorApp
{
    internal class UI : IMediator
    {
        private BottomNavigation? _bottomNavigation;
        private Logo? _logo;

        public UI(BottomNavigation bottomNavigation, Logo logo)
        {
            this._bottomNavigation = bottomNavigation;
            this._bottomNavigation.SetMediator(this);
            this._logo = logo;
            this._logo.SetMediator(this);
        }

        public void HandlerChange(object sender, string e)
        {
            if (e == "goToStore")
            {
                Console.WriteLine("La reacción de la interfaz de usuario del mediador con goToStoreActions");
                this._logo?.ChangeIcon();
            }
            if (e == "HIDE")
            {
                Console.WriteLine("La reacción de la interfaz de usuario del mediador con goToHomeActions");
                this._bottomNavigation?.HideBottomNavigation();
            }
        }
    }
}
