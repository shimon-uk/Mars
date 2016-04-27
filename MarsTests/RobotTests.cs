using System;
using NUnit.Framework;
using Mars;

namespace MarsTests
{
    [TestFixture]
    public class RobotTests
    {
        IRobot robot;
        ILandingSurface plateau;

        [OneTimeSetUp]
        public void FixtureSetup()
        {
            plateau = new Plateau(0, 0, 5, 5);
            robot = new Mars.Robot(plateau);
        }


        [Test]
        public void RobotIsInstanceOfRobot()
        {
            Assert.IsInstanceOf<Robot>(robot);
        }
        [Test]
        public void PlateauPassesX_MINpropertytoRobot()
        {
            var actual = robot.Surface;

            Assert.AreEqual(plateau.X_Min, actual.X_Min);
        }
        [Test]
        public void PlateauPassesY_MINpropertytoRobot()
        {
            var actual = robot.Surface;

            Assert.AreEqual(plateau.Y_Min, actual.Y_Min);
        }
        [Test]
        public void PlateauPassesX_MAXpropertytoRobot()
        {
            var actual = robot.Surface;

            Assert.AreEqual(plateau.X_Max, actual.X_Max);
        }
        [Test]
        public void PlateauPassesY_MAXpropertytoRobot()
        {
            var actual = robot.Surface;

            Assert.AreEqual(plateau.Y_Max, actual.Y_Max);
        }

        [Test]
        [TestCaseSource("RobotInstructionInputs")]
        public void RobotProcessesInstructionforDirectionProp(int x, int y, Compass direction, string roamCoords, Robot expected)
        {
            robot.ExceptCommand(x, y, direction, roamCoords);

            robot.ProcessCommand();

            Assert.AreEqual(expected.Direction, robot.Direction);
        }
        [Test]
        [TestCaseSource("RobotInstructionInputs")]
        public void RobotProcessesInstructionforXProp(int x, int y, Compass direction, string roamCoords, Robot expected)
        {
            robot.ExceptCommand(x, y, direction, roamCoords);

            robot.ProcessCommand();

            Assert.AreEqual(expected.X, robot.X);
        }
        [Test]
        [TestCaseSource("RobotInstructionInputs")]
        public void RobotProcessesInstructionforYProp(int x, int y, Compass direction, string roamCoords, Robot expected)
        {
            robot.ExceptCommand(x, y, direction, roamCoords);

            robot.ProcessCommand();

            Assert.AreEqual(expected.Y, robot.Y);
        }
        [Test]
        [TestCaseSource("RobotInstructionInputs")]
        public void ExceptionThrownIfCommandValueXNotExcepted(int x, int y, Compass direction, string roamCoords, Robot expected)
        {
            x = -x;

            Assert.That(() => robot.ExceptCommand(x, y, direction, roamCoords), Throws.TypeOf<ArgumentOutOfRangeException>());
        }

        [Test]
        [TestCaseSource("RobotInstructionInputs")]
        public void ExceptionThrownIfCommandValueYNotExcepted(int x, int y, Compass direction, string roamCoords, Robot expected)
        {
            y = -y;

            Assert.That(() => robot.ExceptCommand(x, y, direction, roamCoords), Throws.TypeOf<ArgumentOutOfRangeException>());
        }
        [Test]
        [TestCaseSource("RobotInstructionInputs")]
        public void ExceptionThrownIfCommandValueRoamCoordsNotExcepted(int x, int y, Compass direction, string roamCoords, Robot expected)
        {
            roamCoords = String.Concat(roamCoords + "k");

            Assert.That(() => robot.ExceptCommand(x, y, direction, roamCoords), Throws.TypeOf<ArgumentOutOfRangeException>());
        }

        [Test]
        [TestCaseSource("RobotInstructionInputs")]
        public void StatusErrorIfRobotisOutofBounds(int x, int y, Compass direction, string roamCoords, Robot expected)
        {
            robot.ExceptCommand(robot.Surface.X_Max, robot.Surface.Y_Max, direction, roamCoords + "MMMMMMMMMMMMMMM");

            robot.ProcessCommand();

            Assert.IsTrue(robot.Status.Contains("Failed"));
        }


        [OneTimeTearDown]
        public void TestFixtureTearDown()
        {
            plateau = null;
            robot = null;
        }



        //Data
        static object[] RobotInstructionInputs =
        {
            new object[] {1,2,Compass.N,"LMLMLMLMM", new Robot(new Plateau(0,0,5,5)){X=1,Y=3,Direction=Compass.N}},
            new object[] {3,3,Compass.E,"MMRMMRMRRM", new Robot(new Plateau(0,0,5,5)){X=5,Y=1,Direction=Compass.E}}
        };
    }
}
