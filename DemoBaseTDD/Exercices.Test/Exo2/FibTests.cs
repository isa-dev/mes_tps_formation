using Exercices.Exo2;
using System.Security.Cryptography.X509Certificates;

namespace Exercices.Test.Exo2;

[TestClass]
public class FibTests
{
    private Fib _fib;
    [TestInitialize]
    private void Setup(int r)
    {
        _fib = new Fib(r);
    }


    //déclenchement fonction avec Range 1
    [TestMethod] // résultat n'est pas vide
    public void WhenGetFibSeries_Range1_ThenResultIsNotEmpty()
    {
        //Arrange
        Setup(1);
       // var fib = new Fib(1);

        //Act
        List<int> results = _fib.GetFibSeries();
       // var result = fib.GetFibSeries();

        //Assert - pls possibilités
        Assert.IsNotNull(results);
        Assert.IsNotEmpty(results);
        Assert.IsTrue(results.Count > 0);
        Assert.AreNotEqual(0, results.Count);
    }

    [TestMethod] // Correspond à une liste qui contient 0
    public void WhenGetFibSeries_Range1_ThenResultAqualsListContains0()
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
    public void WhenGetFibSeries_Range6_ThenResultHas6Elements()
    {
        //Arrange
        Setup(6);
        //var fib = new Fib(6);

        //Act
        List<int> results = _fib.GetFibSeries();

        //var result = fib.GetFibSeries();

        //Assert
        Assert.HasCount(6, results);
           
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
