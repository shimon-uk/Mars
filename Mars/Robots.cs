using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mars
{
    public class Robots : Mars.IRobots
    {
        private List<Robot> robots = new List<Robot>();

        public List<Robot> Get()
        {
            return robots;
        }

        public void Add(Robot input)
        {
            robots.Add(input);
        }

        public void Remove(Robot input)
        {
            robots.Remove(input);
        }
    }
}
