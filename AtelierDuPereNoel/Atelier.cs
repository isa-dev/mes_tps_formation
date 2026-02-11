using System;
using System.Collections.Generic;
using System.Text;

namespace AtelierDuPereNoel
{
    internal class Atelier
    {
        public event Action<string>? OnProductionEvent;
        public void ProductToy(string toyName)
        {
            Notify($"Début de production : {toyName}");
            Notify($"Assemblage terminé : {toyName}");
            Notify($"Jouet prêt : {toyName}");
        }

        private void Notify(string message)
        {
            OnProductionEvent?.Invoke(message);
        }
    }
}
