using System;
using System.Collections.Generic;
using System.Text;

namespace responsabilityApp
{
    internal abstract class Approver
    {
        protected Approver? _successor;

        public Approver SetSuccessor(Approver successor)
        {
            this._successor = successor;
            return this._successor;
        }

        public abstract void ProcessRequest(Purchase purchase);

    }
}
