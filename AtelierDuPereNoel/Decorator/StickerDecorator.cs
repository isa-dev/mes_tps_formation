using AtelierDuPereNoel.Factory;
using System;
using System.Collections.Generic;
using System.Text;

namespace AtelierDuPereNoel.Decorator
{
    internal class StickerDecorator : ToyDecorator
    {

        public StickerDecorator(IToy inner) : base(inner)
        {
        }
        public override string Name => $"{Inner.Name}  avec  un joli ruban ";
    }
}
