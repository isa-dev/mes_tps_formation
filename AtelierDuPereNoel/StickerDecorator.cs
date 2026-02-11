using System;
using System.Collections.Generic;
using System.Text;

namespace AtelierDuPereNoel
{
    internal class StickerDecorator : ToyDecorator
    {

        public StickerDecorator(IToy inner, string sticker) : base(inner)
        {
        }
        public override string Name => $"{Inner.Name} et avec  un joli ruban ";
    }
}
