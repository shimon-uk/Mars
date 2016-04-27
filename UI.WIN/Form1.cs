using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI.WIN
{
    public partial class Form1 : Form
    {
        public Mars.Robots robots = new Mars.Robots();
        public Form1()
        {
            InitializeComponent();
        }

        private void AddRobot_Click(object sender, EventArgs e)
        {
            try
            {
                var direction = Direction.SelectedItem;
                var xcoord = int.Parse(XCoord.Text);
                var ycoord = int.Parse(YCoord.Text);
                var roamcoords = RoamCoords.Text;
                var plateau_x = int.Parse(Plateau_X.Text);
                var plateau_y = int.Parse(Plateau_Y.Text);

                var plateau = new Mars.Plateau(0, 0, plateau_x, plateau_y);
                var robot = new Mars.Robot(plateau);



                Mars.Compass compassVal = new Mars.Compass();
                compassVal = (Mars.Compass)Enum.Parse(typeof(Mars.Compass), direction.ToString());

                robot.ExceptCommand(xcoord, ycoord, compassVal, roamcoords);
                robots.Add(robot);


                populateAssignedRobots();
            }
            catch (Exception ex)
            {
                Error.Text = ex.Message;
            }


        }

        private void populateAssignedRobots()
        {
            RobotsAssigned.Items.Clear();

            IEnumerable<Mars.Robot> robotList = (IEnumerable<Mars.Robot>)robots.Get();
            foreach (Mars.Robot item in robotList)
            {
                RobotsAssigned.Items.Add(String.Format(" X:{0} Y:{1} Direction:{2} Roam:{3}",
                    item.X, item.Y, item.Direction, String.Concat<char>(item.RoamCoordinates)));
            }
        }

        private void StartExplore_Click(object sender, EventArgs e)
        {
            RobotResults.Items.Clear();

            IEnumerable<Mars.Robot> robotList = (IEnumerable<Mars.Robot>)robots.Get();
            foreach (Mars.Robot item in robotList)
            {
                item.ProcessCommand();
                Thread.Sleep(600);
                RobotResults.Items.Add(item.Status);

            }

        }

        private void Reset_Click(object sender, EventArgs e)
        {
            robots = new Mars.Robots();
            RobotsAssigned.Items.Clear();
            RobotResults.Items.Clear();
        }

   

      

     


    }
}
