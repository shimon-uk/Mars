using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mars
{
    public class Plateau : Mars.ILandingSurface
    {

        private int x_Max;
        private int y_Max;
        private int x_Min;
        private int y_Min;


        public int X_Min
        {
            get { return x_Min; }
            set { x_Min = value; }
        }


        public int Y_Min
        {
            get { return y_Min; }
            set { y_Min = value; }
        }

        public int X_Max
        {
            get { return x_Max; }
            set { x_Max = value; }
        }



        public int Y_Max
        {
            get { return y_Max; }
            set { y_Max = value; }
        }



        public Plateau(int x, int y, int x_max, int y_max)
        {
            try
            {
                // TODO: Complete member initialization
                if (x > -1 && y > -1 && x_max > -1 && y_max > -1)
                {
                    this.x_Min = x;
                    this.y_Min = y;
                    this.x_Max = x_max;
                    this.y_Max = y_max;
                }
                else
                {
                    throw new ArgumentOutOfRangeException("Value cannot be negative");
                }
            }
            catch (Exception ex)
            {
                throw ex;

            }
        }


    }
}
