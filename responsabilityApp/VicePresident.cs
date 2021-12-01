using System;
using System.Collections.Generic;
using System.Text;

namespace responsabilityApp
{
    internal class VicePresident : Approver
    {
        public override void ProcessRequest(Purchase purchase)
        {
            if (purchase._amount < 25000.0){
                Console.WriteLine("{0} ha aprobado la solicitud # {1}",
                  this.GetType().Name, purchase._number);
            }
            else{
                Console.WriteLine("Solicitud # {1} Denegada para {0}, enviando a superior",
                 this.GetType().Name, purchase._number);
                _successor.ProcessRequest(purchase);
            }
        }
    }
}
