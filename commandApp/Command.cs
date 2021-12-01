using System;
using System.Collections.Generic;
using System.Text;

namespace commandApp
{
    public abstract class Command
    {
        public abstract void Execute();
        public abstract void UnExecute();
    }
}
