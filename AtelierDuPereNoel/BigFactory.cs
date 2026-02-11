using System;
using System.Collections.Generic;
using System.Text;

namespace AtelierDuPereNoel
{
   internal class BigFactory
    {
        public readonly Dictionary<string, ToyFactory> _factories = new Dictionary<string, ToyFactory>();

       public void AjouterFactory(string key, ToyFactory factory)
        {
            _factories[key] = factory;
        }

        public IToy ProductToy(string key)
        {
            if (!_factories.TryGetValue(key, out var factory))
                throw new InvalidOperationException($"Aucune factory pour la clé : {key}");
         return factory.CreateToy();
        }
    }
}
