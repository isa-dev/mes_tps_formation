using System;
using System.Collections.Generic;
using System.Text;

namespace AtelierDuPereNoel
{
    internal class Car : IToy
    {
        public string Name => "Voiture";

        public string Description => "Voiture télécommandée";

        public decimal Price => 29m;
    }
}
