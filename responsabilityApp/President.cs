using System;
using System.Collections.Generic;
using System.Text;

namespace responsabilityApp
{
    internal class President : Approver
    {
        public override void ProcessRequest(Purchase purchase)
        {
            if (purchase._amount < 100000.0){
                Console.WriteLine("{0} ha aprobado la solicitud # {1}",
                  this.GetType().Name, purchase._number);
            }
            else if (_successor != null){
                Console.WriteLine(
                 "Solicitud # {0} ¡Requiere una junta ejecutiva!",
                 purchase._number);
            }
            else{
                Console.WriteLine("Solicitud # {1} Denegada para {0}",
                 this.GetType().Name, purchase._number);
            }
        }
    }
}
