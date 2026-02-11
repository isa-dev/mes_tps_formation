using System;
using System.Collections.Generic;
using System.Text;

namespace AtelierDuPereNoel
{
    internal class DollFactory : ToyFactory
    {
        public override IToy CreateToy()
        {
            return new Doll();
        }
    }
}
