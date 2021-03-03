using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryRobotPractice
{
    public class TankRobot : Robot, IRobot
    {
        public TankRobot()
        {
            Hp = 130;
            Damage = 20;
            Tipo = "Tanque";
            Console.WriteLine("Robot tanque creado");
        }
    }
}
