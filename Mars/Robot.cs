
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Mars
{
    public class Robot : Mars.IRobot
    {


        public int X { get; set; }
        public int Y { get; set; }
        public Compass Direction { get; set; }
        public List<Char> RoamCoordinates { get; set; }
        public ILandingSurface Surface { get; set; }

        public string Status { get; set; }

        public Robot(ILandingSurface surface)
        {

            Surface = (ILandingSurface)surface;
        }

        private void MoveForward(Compass direction, int x, int y)
        {
            switch (direction)
            {
                case Compass.N:
                    y++;
                    break;
                case Compass.E:
                    x++;
                    break;
                case Compass.S:
                    y--;
                    break;
                case Compass.W:
                    x--;
                    break;
            }

            this.X = x;
            this.Y = y;
        }

        private Compass ChangeDirection(Compass direction, bool cloackwise)
        {
            switch (direction)
            {
                case Compass.N:
                    if (cloackwise)
                        direction = Compass.E;
                    else
                        direction = Compass.W;
                    break;
                case Compass.E:
                    if (cloackwise)
                        direction = Compass.S;
                    else
                        direction = Compass.N;
                    break;
                case Compass.S:
                    if (cloackwise)
                        direction = Compass.W;
                    else
                        direction = Compass.E;
                    break;
                case Compass.W:
                    if (cloackwise)
                        direction = Compass.N;
                    else
                        direction = Compass.S;
                    break;
            }
            return direction;
        }
        public Robot()
        {
            // TODO: Complete member initialization
        }





        public void ProcessCommand()
        {

            foreach (var item in RoamCoordinates)
            {

                switch (item)
                {
                    case 'L':
                        Direction = ChangeDirection(Direction, false);
                        break;
                    case 'R':
                        Direction = ChangeDirection(Direction, true);
                        break;
                    case 'M':
                        MoveForward(Direction, this.X, this.Y);
                        break;
                }


            }

            if (ValidatePosition(Surface, X, Y))
            {
                Status = String.Format(" X:{0} Y:{1} Direction:{2} Roam:{3}",
                       X, Y, Direction, String.Concat<char>(RoamCoordinates));
            }
            else
            {
                Status = "Failed: Robot is out of bounds";
            }



        }

        private bool ValidateFormat(string roamCoords)
        {
            var result = true;

            if (roamCoords.Except("LRM").Any())
                result = false;

            return result;
        }

        private bool ValidatePosition(ILandingSurface surface, int x, int y)
        {
            var result = true;

            if ((x > surface.X_Max) || (y > surface.Y_Max) || (x < surface.X_Min) || (y < surface.Y_Min))
                result = false;

            return result;
        }



        public bool ValidateData(ILandingSurface Surface, int x, int y, string roamCoords)
        {
            var result = true;

            if (!ValidateFormat(roamCoords))
                result = false;

            if (!ValidatePosition(Surface, x, y))
                result = false;


            return result;
        }


        public void ExceptCommand(int x, int y, Compass direction, string roamCoords)
        {
            try
            {
                if (ValidateData(Surface, x, y, roamCoords))
                {
                    this.X = x;
                    this.Y = y;
                    this.Direction = direction;
                    this.RoamCoordinates = roamCoords.ToCharArray().ToList();
                }
                else
                    throw new ArgumentOutOfRangeException("Robot cannot except Instructions");
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }

}
