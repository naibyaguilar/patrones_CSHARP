using System;
using System.Collections.Generic;
using System.Text;

namespace MediatorApp
{
    internal interface IMediator
    {
        void HandlerChange(object sender, string e);

    }
}
