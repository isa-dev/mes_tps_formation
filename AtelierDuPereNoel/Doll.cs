using System;
using System.Collections.Generic;
using System.Text;

namespace AtelierDuPereNoel
{
    internal class Doll : IToy
    {
        public string Name => "Poupée";

        public string Description => "Poupée qui parle";

        public decimal Price => 49m;
    }
}
