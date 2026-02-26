using Panier.Core;

namespace Panier.Tests;

    [TestClass]
    public class ShoppingCartTests
    {
    [TestMethod] //'name` ne peut pas être null, vide ou uniquement des espaces.


    public void AddItem_NameIsNull_ThrowArgumentNullException()
        {
            ShoppingCart cart = new ShoppingCart();
            Assert.ThrowsExactly<ArgumentNullException>(() => cart.AddItem(null, 10m, 1));
        }
    
    [TestMethod] //`name` ne peut pas vide 

    public void AddItem_NameIsEmpty_ThrowsArgumentException()
    {
        ShoppingCart cart = new ShoppingCart();
        Assert.ThrowsExactly<ArgumentException>(() => cart.AddItem("", 10m, 1)
        );
    }

    [TestMethod] // `name` ne peut pas être uniquement des espaces.

    public void AddItem_NameIsWhitespace_ThrowsArgumentException()
    {
        ShoppingCart cart = new ShoppingCart();
        Assert.ThrowsExactly<ArgumentException>(() => cart.AddItem("  ", 10m, 1)
        );
    }

    [TestMethod] // `price` doit être strictement > 0.
    public void AddItem_PriceIsZero_ThrowsArgumentOutOfRangeException()
    {
        ShoppingCart cart = new ShoppingCart();
        Assert.ThrowsExactly<ArgumentOutOfRangeException>(() => cart.AddItem("Pomme", 0m, 1)
        );
    }

    [TestMethod] 
    public void AddItem_PriceIsNegative_ThrowsArgumentOutOfRangeException()
    {
        ShoppingCart cart = new ShoppingCart();
        Assert.ThrowsExactly<ArgumentOutOfRangeException>(() => cart.AddItem("Pomme", -1m, 1)
        );
    }

    [TestMethod] // `quantity` doit être strictement > 0.

    public void AddItem_QuantityIsNegative_ThrowsArgumentOutOfRangeException()
    {
        ShoppingCart cart = new ShoppingCart();
        Assert.ThrowsExactly<ArgumentOutOfRangeException>(() => cart.AddItem("Pomme", 1m, -2)

        );
    }

    }
