using System;
using NUnit.Framework;
using Mars;
using System.Collections.Generic;

namespace MarsTests
{
    [TestFixture]
    public class RobotsCollectionTests
    {

        IRobots robotsCollection;

        [OneTimeSetUp]
        public void FixtureSetup()
        {
            robotsCollection = new Robots();

        }


        [Test]
        [TestCaseSource("RobotsCollectionData")]
        public void AddRobot(Robot input)
        {
            var expected = robotsCollection.Get().Count;


            robotsCollection.Add(input);
            var actual = robotsCollection.Get();

            Assert.AreEqual(expected + 1, actual.Count);
        }


        [Test]
        public void GetRobotCollectTypeIsEqualtoListOfRobot()
        {

            var actual = robotsCollection.Get();

            Assert.IsInstanceOf<List<Mars.Robot>>(actual);
        }

        [Test]
        [TestCaseSource("RobotsCollectionData")]
        public void RemoveRobot(Robot input)
        {
            robotsCollection.Add(input);
            var expected = robotsCollection.Get().Count - 1;


            robotsCollection.Remove(input);
            var actual = robotsCollection.Get();

            Assert.AreEqual(expected, actual.Count);
        }

        [OneTimeTearDown]
        public void FixtureTearDown()
        {
            robotsCollection = null;
        }

        //Data

        static object[] RobotInstructionInputs =
        {
            new object[] {new Robot(){X=1,Y=3,Direction=Compass.N}},
            new object[] {new Robot(){X=5,Y=1,Direction=Compass.E}}
        };

        static object[] RobotsCollectionData =
        {
            new object[] {new Robot(){X=1,Y=3,Direction=Compass.N}}
        };
    }

}