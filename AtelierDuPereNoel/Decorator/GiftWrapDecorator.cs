using AtelierDuPereNoel.Factory;
using System;
using System.Collections.Generic;
using System.Text;

namespace AtelierDuPereNoel.Decorator
{
    internal class GiftWrapDecorator : ToyDecorator
    {
        public GiftWrapDecorator(IToy inner) : base(inner)
        {
        }

        public override string Name => $"{Inner.Name} + emballage cadeau";


    }
}
