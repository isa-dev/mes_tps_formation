using Exercices.Exo3;
using System.Runtime.CompilerServices;

namespace Exercices.Test.Exo3;

[TestClass]
public class RechercheVilleTests
{
    [TestMethod]
    public void Search_WordLessThan2Characters_LeveNotFoundException()
    {
        RechercheVille recherche = new RechercheVille();
        Assert.ThrowsExactly<NotFoundException>(() => rechercheVille.Search("a"));
    }

    [TestMethod]
    public void Search_Va_ReturnValenceEtVancouver()
    {
        RechercheVille recherche = new RechercheVille();
        var result = recherche.Search("Va");
       // var result = _villes.Where(V => v.StartsWith(mot, StringComparison.OrdinalIgnoreCase)).ToList();
        CollectionAssert.AreEquivalent(new List<string> { "Valence", "Vancouver"}, result);
    }
    
    [TestMethod]
    public void Search_ape_ReturnBudapest()
    {
        RechercheVille recherche = new RechercheVille();
        var result = recherche.Search("ape");
        CollectionAssert.AreEqual(new List<string> { "Budapest"}, result);
    }

    [TestMethod]
    public void Search_Asterisque_ReturnToutesLesVilles()
    {
        RechercheVille recherche = new RechercheVille();

        var result = recherche.Search("*");

        Assert.AreEqual(16, result.Count);
        CollectionAssert.Contains(result, "Paris");
        CollectionAssert.Contains(result, "Istanbul");
    }
}
