using System.Security.Cryptography.X509Certificates;

namespace Exercices.Test;

[TestClass]
public class FibTests
{
    //déclenchement fonction avec Range 1
    [TestMethod] // résultat n'est pas vide
    public void GetFibSeries_Range1_ResultIsNotEmpty()
    {
        //Arrange
        var fib = new Fib(1);

        //Act
        var result = fib.GetFibSeries();

        //Assert
        Assert.IsNotNull(result);
        Assert.IsNotEmpty(result);
    }

    [TestMethod] // Correspond à une liste qui contient 0
    public void GetFibSeries_Range1_ResultAqualsListContains0()
    {
        //Arrange
        var fib = new Fib(1);

        //Act
        var result = fib.GetFibSeries();

        //Assert
        CollectionAssert.AreEqual(new List<int> { 0 }, result);
    }
    // Déclenchement fonction avec Range 6
    [TestMethod] // resultat contient 3
    public void GetFibSeries_Range6_ResultContains3()
    {
        //Arrange
        var fib = new Fib(6);

        //Act
        var result = fib.GetFibSeries();

        //Assert
        CollectionAssert.Contains(result, 3);
    }

    [TestMethod] // resultat contient 6 éléments
    public void GetFibSeries_Range6_ResultHas6Elements()
    {
        //Arrange
        var fib = new Fib(6);

        //Act
        var result = fib.GetFibSeries();

        //Assert
        Assert.HasCount(6, result.Count);
           
    }

    [TestMethod] // resultat n'a pas le chiffre 4 en son sein
    public void GetFibSeries_Range6_ResultDoesNotContain4()
    {
        //Arrange
        var fib = new Fib(6);

        //Act
        var result = fib.GetFibSeries();

        //Assert
        CollectionAssert.DoesNotContain(result, 4);

    }

}
