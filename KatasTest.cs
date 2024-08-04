namespace LinqKatas;

[TestClass]
public class KatasTest
{

    private IEnumerable<Animal> animals;

    [TestInitialize]
    public void Initialize()
    {
        animals = Data.Get();
    }

    [TestMethod]
    public void GetAllMammals_Test()
    {
        var result = Katas.GetAllMammals(animals);

        Assert.AreEqual(5, result.Count());
        Assert.IsTrue(result.All(animal => animal.Type == "Mammal"));
    }

    [TestMethod]
    public void GetFirstBirdNameOrderByName_Test()
    {
        var result = Katas.GetFirstBirdNameOrderByName(animals);
        Assert.AreEqual("Eagle", result);
    }


    [TestMethod]
    public void GetHeaviestAnimalName_Test()
    {
        var result = Katas.GetHeaviestAnimalName(animals);
        Assert.AreEqual("Elephant", result);
    }

    [TestMethod]
    public void GetTheSmallestAnimalName_Test()
    {
        var result = Katas.GetTheSmallestAnimalName(animals);
        Assert.AreEqual("Penguin", result);
    }

    [TestMethod]
    public void GetAverageWeightOfReptiles_Test()
    {
        var result = Katas.GetAverageWeightOfReptiles(animals);
        Assert.AreEqual(80, result);
    }

    [TestMethod]
    public void GetTotalWeightOfAllReptiles_Test()
    {
        var result = Katas.GetTotalWeightOfAllReptiles(animals);

        Assert.AreEqual(160.0, result);
    }


    [TestMethod]
    public void GetAllReptileNames_Test()
    {
        var result = Katas.GetAllReptileNames(animals).ToList();
        CollectionAssert.Contains(result, "Snake");
        CollectionAssert.Contains(result, "Crocodile");
    }

    [TestMethod]
    public void GetTallestAnimalName_Test()
    {
        var result = Katas.GetTallestAnimalName(animals);
        Assert.AreEqual("Elephant", result);
    }

    [TestMethod]
    public void GetNamesOfAnimalsHeavierThan_Test()
    {
        var result = Katas.GetNamesOfAnimalsHeavierThan(animals, 300).ToList();
        var expected = new List<string> { "Elephant", "Giraffe" };
        CollectionAssert.AreEqual(expected, result);
    }

    [TestMethod]
    public void GetCountOfEachAnimalType_Test()
    {
        var result = Katas.GetCountOfEachAnimalType(animals);
        Assert.AreEqual(4, result["Bird"]);
        Assert.AreEqual(5, result["Mammal"]);
        Assert.AreEqual(2, result["Reptile"]);
    }

    [TestMethod]
    public void GetAllAnimalNamesWhichNameLenghtIsFive_Test()
    {
        var result = Katas.GetAllAnimalNamesWhichNameLenghtIsFive(animals);
        var expected = new List<string> { "Eagle", "Snake", "Tiger" };

        CollectionAssert.AreEqual(expected, result.ToList());
    }

    [TestMethod]
    public void GetTop3NamesOfAnimalsOrderedByWeightDescending_Test()
    {
        var result = Katas.GetTop3NamesOfAnimalsOrderedByWeightDescending(animals);

        var expected = new[] { "Elephant", "Giraffe", "Dolphin" };
        CollectionAssert.AreEqual(expected, result.ToList());
    }

    [TestMethod]
    public void GetBirdsNamesInDescendingOrder_Test()
    {
        var result = Katas.GetBirdsNamesInDescendingOrder(animals);

        var expected = "Penguin, Hawk, Hawk, Eagle";
        Assert.AreEqual(expected, result);
    }

    [TestMethod]
    public void CountAllAnimals_Test()
    {
        var result = Katas.CountAllAnimals(animals);

        Assert.AreEqual(11, result);
    }

    [TestMethod]
    public void GetDuplicatedAnimalsByName_Test()
    {
        var result = Katas.GetDuplicatedAnimalName(animals);

        Assert.AreEqual(result, "Hawk");
    }



}