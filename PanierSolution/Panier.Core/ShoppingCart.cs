using System;
using System.Collections.Generic;
using System.Text;

namespace Panier.Core
{
    public sealed class ShoppingCart
    {
        public int GetItemCount() => throw new NotImplementedException();
        public void AddItem(string name, decimal price, int quantity) //=> throw new NotImplementedException();
        {
            if (name is null)
                throw new ArgumentNullException(nameof(name));

            if (string.IsNullOrWhiteSpace(name))
                throw new ArgumentNullException("Name ne peut pas être vide.", nameof(name));

            if (price <= 0)
                throw new ArgumentOutOfRangeException(nameof(price), "Price doit être supèreur à 0.");

            if (quantity <= 0)
                throw new ArgumentOutOfRangeException(nameof(quantity), "Quantity doit être supèrieur à 0.");

        }
        public decimal GetTotal() => throw new NotImplementedException();
        public void ApplyDiscount(decimal percentage) => throw new NotImplementedException();
    }
}
