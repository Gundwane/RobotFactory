using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryRobotPractice
{
    public class MedicRobot : Robot
    {
        public MedicRobot()
        {
            HP = 70;
            Damage = 10;
            Console.WriteLine("Robot médico creado");
        }
    }
}
