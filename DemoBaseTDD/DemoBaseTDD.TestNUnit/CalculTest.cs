namespace DemoBaseTDD.TestsNUnit;

public class CalculTest
{
    [SetUp] // s'executera AVANT chaque test
    public void Setup()
    {
    }

    [TearDown] // s'executera APRES chaque test
    public void Teardown()
    {

    }

    [OneTimeSetUp] // s'executera 1 SEULE FOIS AVANT tous les tests
    public void OneTimeSetUp() { }

    [OneTimeTearDown] // s'executera 1 SEULE FOIS APRES tous les tests
    public void OneTimeTearDown() { }

    [Test]
    public void WhenAddition_10_30_Then_40() // tjt test en public et aucun retour 
    {
        // Assert.Pass(); Fais passer le test

        //Arrange
        var calcul = new Calcul();

        //Act
        var result = calcul.Addition(10, 30);

        //Assert
        Assert.That(result, Is.EqualTo(40));

    }
}
