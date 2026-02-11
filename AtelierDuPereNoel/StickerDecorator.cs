using System;
using System.Collections.Generic;
using System.Text;

namespace AtelierDuPereNoel
{
    internal class StickerDecorator : ToyDecorator
    {

        public StickerDecorator(IToy inner) : base(inner)
        {
        }
        public override string Name => $"{Inner.Name}  avec  un joli ruban ";
    }
}
