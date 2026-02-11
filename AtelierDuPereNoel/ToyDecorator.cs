using System;
using System.Collections.Generic;
using System.Text;

namespace AtelierDuPereNoel
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
