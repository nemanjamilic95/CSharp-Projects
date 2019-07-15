using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NemanjaRoboti.BiznisSloj
{
    public class PomeriRobotaLevo:Operacija
    {
        public Robot robot = new Robot();
        public double pomeraj;

        public override void izvrsi(Robot robot,double pomeraj)
        {
            this.robot.pozicija.X = (-pomeraj);
        }
    }
}
