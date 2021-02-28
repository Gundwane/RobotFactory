using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryRobotPractice
{
    public class TankRobot : Robot
    {
        public TankRobot()
        {
            HP = 130;
            Damage = 20;
            Console.WriteLine("Robot tanque creado");
        }
    }
}
