using AtelierDuPereNoel.Factory;
using System;
using System.Collections.Generic;
using System.Text;

namespace AtelierDuPereNoel.Decorator
{
    internal abstract class ToyDecorator : IToy
    {
        protected readonly IToy Inner;
        protected ToyDecorator(IToy inner)
        {  
            Inner = inner; 
        }

        public virtual string Name => Inner.Name;
        
    }
}
