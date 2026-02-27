using Demo03Mock.Core;
using Moq;

namespace Demo03Mock.Tests;

[TestClass]
public class JeuTest
{
    [TestMethod]
    public void Jouer_Win()
    {
        // Arrange
        IDe dewin = Mock.Of<IDe>(); // creation du "faux" de
        Mock.Get(dewin)
            .Setup(d => d.Lancer())
            .Returns(20); // reglage de la methode lancer du "faux" de

        Jeu jeu = new Jeu(dewin);

        // Act
        bool result = jeu.Jouer();

        // Assert
        Assert.IsTrue(result);

    }


    [TestMethod]
    public void Jouer_Loose()
    {
        // Arrange
        IDe dewin = Mock.Of<IDe>(); // creation du "faux" de
        Mock.Get(dewin).Setup(d => d.Lancer()).Returns(15); // reglage de la methode lancer du "faux" de

        Jeu jeu = new Jeu(dewin);

        // Act
        bool result = jeu.Jouer();

        // Assert
        Assert.IsFalse(result);
    }
}
