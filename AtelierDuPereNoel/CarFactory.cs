using System;
using System.Collections.Generic;
using System.Text;

namespace AtelierDuPereNoel
{
    internal class CarFactory : ToyFactory
    {
        public override IToy CreateToy()
        {
            return new Car();     
        }
    }
}
