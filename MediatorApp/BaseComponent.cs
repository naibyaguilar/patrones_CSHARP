using System;
using System.Collections.Generic;
using System.Text;

namespace MediatorApp
{
    internal class BaseComponent
    {
        protected IMediator? _mediator;
        public BaseComponent(IMediator? mediator = null)
        {
            this._mediator = mediator;
        }

        public void SetMediator(IMediator mediator)
        {
            this._mediator = mediator;
        }
    }
}
