using System;
using NUnit.Framework;
using Mars;

namespace MarsTests
{
    [TestFixture]
    public class PlateauTests
    {

        int xmax;
        int ymax;
        int xmin;
        int ymin;

        [OneTimeSetUp]
        public void FixtureSetup()
        {
            xmax = 5;
            ymax = 5;
            xmin = 0;
            ymin = 1;
        }

        [Test]
        public void PlataeuConstructorPassesX_MINValueToProperties()
        {
            var actual = new Plateau(xmin, ymin, xmax, ymax);

            Assert.AreEqual(actual.X_Min, xmin);
        }
        [Test]
        public void PlataeuConstructorPassesY_MINValueToProperties()
        {
            var actual = new Plateau(xmin, ymin, xmax, ymax);

            Assert.AreEqual(actual.Y_Min, ymin);
        }
        [Test]
        public void PlataeuConstructorPassesX_MaxValueToProperties()
        {
            var actual = new Plateau(xmin, ymin, xmax, ymax);

            Assert.AreEqual(actual.X_Max, xmax);
        }
        [Test]
        public void PlataeuConstructorPassesY_MAXValueToProperties()
        {
            var actual = new Plateau(xmin, ymin, xmax, ymax);

            Assert.AreEqual(actual.Y_Max, ymax);
        }
        [Test]
        public void PlataeuConstructorErrorsWhenValueX_MINisNegative()
        {
            int testVal = -1;

            Assert.That(() => (new Plateau(testVal, ymin, xmax, ymax)), Throws.TypeOf<ArgumentOutOfRangeException>());

        }
        [Test]
        public void PlataeuConstructorErrorsWhenValueY_MINisNegative()
        {
            int testVal = -1;

            Assert.That(() => (new Plateau(xmin, testVal, xmax, ymax)), Throws.TypeOf<ArgumentOutOfRangeException>());

        }
        [Test]
        public void PlataeuConstructorErrorsWhenValueY_MAXisNegative()
        {
            int testVal = -1;

            Assert.That(() => (new Plateau(xmin, ymin, xmax, testVal)), Throws.TypeOf<ArgumentOutOfRangeException>());

        }
        [Test]
        public void PlataeuConstructorErrorsWhenValueX_MAXisNegative()
        {
            int testVal = -1;

            Assert.That(() => (new Plateau(xmin, ymin, testVal, ymax)), Throws.TypeOf<ArgumentOutOfRangeException>());
        }

        [Test]
        public void PropertyX_MINStoresCorrectly()
        {
            var plateau = new Plateau(xmin, ymin, xmax, ymax);
            var newVal = 10;

            plateau.X_Min = newVal;

            Assert.AreEqual(newVal, plateau.X_Min);
        }
        [Test]
        public void PropertyX_MAXStoresCorrectly()
        {
            var plateau = new Plateau(xmin, ymin, xmax, ymax);
            var newVal = 10;

            plateau.X_Max = newVal;

            Assert.AreEqual(newVal, plateau.X_Max);
        }
        [Test]
        public void PropertyY_MINStoresCorrectly()
        {
            var plateau = new Plateau(xmin, ymin, xmax, ymax);
            var newVal = 10;

            plateau.Y_Min = newVal;

            Assert.AreEqual(newVal, plateau.Y_Min);
        }
        [Test]
        public void PropertyY_MAXStoresCorrectly()
        {
            var plateau = new Plateau(xmin, ymin, xmax, ymax);
            var newVal = 10;

            plateau.Y_Max = newVal;

            Assert.AreEqual(newVal, plateau.Y_Max);
        }

        [OneTimeTearDown]
        public void FixtureTearDown()
        {

        }

    }
}
