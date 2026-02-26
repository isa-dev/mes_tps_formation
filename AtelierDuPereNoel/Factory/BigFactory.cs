using System;
using System.Collections.Generic;
using System.Text;

namespace AtelierDuPereNoel.Factory
{
   internal class BigFactory
    {
        public readonly Dictionary<string, ToyFactory> _factoryMap = new Dictionary<string, ToyFactory>();

       public void AjouterFactory(string type, ToyFactory factory)
        {
            _factoryMap.Add(type, factory);
        }

        public IToy ProductToy(string type)
        {
            if (!_factoryMap.TryGetValue(type, out var factory))
                throw new InvalidOperationException($"Type de jouet inconnu " + type);

            var toy = factory.CreateToy();
            return toy;
        }
    }
}
