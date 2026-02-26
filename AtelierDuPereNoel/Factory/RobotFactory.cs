using System;
using System.Collections.Generic;
using System.Text;

namespace AtelierDuPereNoel.Factory
{
    internal class RobotFactory : ToyFactory
    {
        public override IToy CreateToy()
        {
            return new Robot();        }
    }
}
