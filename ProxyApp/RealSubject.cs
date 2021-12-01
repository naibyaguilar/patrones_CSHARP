using System;
using System.Collections.Generic;
using System.Text;

namespace ProxyApp
{
    class RealSubject : ISubject
    {
        public void Request()
        {
            Console.WriteLine("RealSubject: Handling Request.");
        }
    }
}
