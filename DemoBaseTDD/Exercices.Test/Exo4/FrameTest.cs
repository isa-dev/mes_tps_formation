using Exercices.Exo4;
using Moq;

namespace Exercices.Test;

[TestClass]
public class FrameTest
{
    [TestMethod]
    public void Roll_SimpleFrame_FirstRoll_CheckScore()
    {
        IGenerateur generateur = Mock.Of<IGenerateur>();
        Mock.Get(generateur)
            .Setup(g => g.RandomPin(It.IsAny<int>()))
            .Returns(5);

        Frame frame = new Frame(generateur);

        frame.MakeRoll();

        Assert.IsTrue(frame.MakeRoll()); 
        Assert.AreEqual(5, frame.Score);
    }

    [TestMethod]
    public void Roll_SimpleFrame_SecondRoll_CheckScore()
    {
        IGenerateur generateur = Mock.Of<IGenerateur>();
        Mock.Get(generateur)
            .SetupSequence(g => g.RandomPin(It.IsAny<int>()))
            .Returns(3)
            .Returns(4);


        Frame frame = new Frame(generateur, lastFrame: false);

     

        Assert.IsTrue(frame.MakeRoll());
        Assert.IsTrue(frame.MakeRoll());

        Assert.AreEqual(7, frame.Score);

    }

    [TestMethod]
    public void Roll_SimpleFrame_SecondRoll_FirstRollStrick_ReturnFalse()
    {
        IGenerateur generateur = Mock.Of<IGenerateur>();
        Mock.Get(generateur)
            .SetupSequence(g => g.RandomPin(It.IsAny<int>()))
            .Returns(10);

        Frame frame = new Frame(generateur, lastFrame: false);

        Assert.IsTrue(frame.MakeRoll()); // strike
        var okSecond = frame.MakeRoll(); // interdit

        Assert.IsFalse(okSecond);
        Assert.AreEqual(10, frame.Score);

    }

    [TestMethod]    
    public void Roll_SimpleFrame_MoreRolls_ReturnFalse()
    {
        IGenerateur generateur = Mock.Of<IGenerateur>();
        Mock.Get(generateur)
            .SetupSequence(g => g.RandomPin(It.IsAny<int>()))
            .Returns(3)
            .Returns(4);

        Frame frame = new Frame(generateur, lastFrame: false);

        Assert.IsTrue(frame.MakeRoll());
        Assert.IsTrue(frame.MakeRoll());
        var okThird = frame.MakeRoll(); // 3e interdit

        Assert.IsFalse(okThird);
        Assert.AreEqual(7, frame.Score);

    }

    [TestMethod]
    public void Roll_LastFrame_SecondRoll_FirstRollStrick_ReturnTrue()
    {
        IGenerateur generateur = Mock.Of<IGenerateur>();
        Mock.Get(generateur)
            .SetupSequence(g => g.RandomPin(It.IsAny<int>()))
            .Returns(10)
            .Returns(3);

        Frame frame = new Frame(generateur, lastFrame: true);

        Assert.IsTrue(frame.MakeRoll()); // strike
        var okSecond = frame.MakeRoll(); // autorisé

        Assert.IsTrue(okSecond);

    }

    [TestMethod]
    public void Roll_LastFrame_SecondRoll_FirstRollStrick_CheckScore()
    {
        IGenerateur generateur = Mock.Of<IGenerateur>();
        Mock.Get(generateur)
            .SetupSequence(g => g.RandomPin(It.IsAny<int>()))
            .Returns(10)
            .Returns(3);

        Frame frame = new Frame(generateur, lastFrame: true);

        frame.MakeRoll(); // 1er lancer strike
        frame.MakeRoll(); // 2eme lancer

            Assert.AreEqual(13, frame.Score);

    }

    [TestMethod]
    public void Roll_LastFrame_ThirdRoll_FirstRollStrick_ReturnTrue()


    {
        IGenerateur generateur = Mock.Of<IGenerateur>();
        Mock.Get(generateur)
            .SetupSequence(g => g.RandomPin(It.IsAny<int>()))
            .Returns(10)
            .Returns(3)
            .Returns(4);

        Frame frame = new Frame(generateur, lastFrame: true);

        frame.MakeRoll(); // strike
        frame.MakeRoll(); // ok
        var okThird = frame.MakeRoll();// ok car 1er : strike

        Assert.IsTrue(okThird);

    }

    [TestMethod]
    public void RoRoll_LastFrame_ThirdRoll_FirstRollStrick_CheckScore()

    {
        IGenerateur generateur = Mock.Of<IGenerateur>();
        Mock.Get(generateur)
            .SetupSequence(g => g.RandomPin(It.IsAny<int>()))
            .Returns(10)
            .Returns(3)
            .Returns(4);

        Frame frame = new Frame(generateur, lastFrame: true);

        frame.MakeRoll(); // 1er mancer
        frame.MakeRoll();// spare
        frame.MakeRoll();// 3ème autorisé

        Assert.AreEqual(17, frame.Score);

    }

    [TestMethod]
    public void Roll_LastFrame_ThirdRoll_Spare_ReturnTrue()
    {
        IGenerateur generateur = Mock.Of<IGenerateur>();
        Mock.Get(generateur)
            .SetupSequence(g => g.RandomPin(It.IsAny<int>()))
            .Returns(6)
            .Returns(4)
            .Returns(5);

        Frame frame = new Frame(generateur, lastFrame: true);

        frame.MakeRoll();
        frame.MakeRoll();
        var okThird = frame.MakeRoll(); // ok car spare

        Assert.IsTrue(okThird);
    }

    [TestMethod]
    public void Roll_LastFrame_ThirdRoll_Spare_CheckScore()
    {
        IGenerateur generateur = Mock.Of<IGenerateur>();
        Mock.Get(generateur)
            .SetupSequence(g => g.RandomPin(It.IsAny<int>()))
            .Returns(6)
            .Returns(4)
            .Returns(5);

        Frame frame = new Frame(generateur, lastFrame: true);

        frame.MakeRoll();
        frame.MakeRoll();
        frame.MakeRoll();

        Assert.AreEqual(15, frame.Score);


    }

    [TestMethod]
    public void Roll_LastFrame_FourthRoll_ReturnFalse()
    {
        IGenerateur generateur = Mock.Of<IGenerateur>();
        Mock.Get(generateur)
            .SetupSequence(g => g.RandomPin(It.IsAny<int>()))
            .Returns(10)
            .Returns(3)
            .Returns(4);

        Frame frame = new Frame(generateur, lastFrame: true);

        Assert.IsTrue(frame.MakeRoll()); // 1er --> 10
        Assert.IsTrue(frame.MakeRoll()); // 2eme --> 3 score = 13
        Assert.IsTrue(frame.MakeRoll()); // 3eme --> 4 score 17


        var okFourth = frame.MakeRoll(); // interdit

        Assert.IsFalse(okFourth);
        
    }











}
