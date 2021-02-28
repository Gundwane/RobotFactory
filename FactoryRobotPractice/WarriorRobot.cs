using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryRobotPractice
{
    class WarriorRobot : Robot
    {
        public WarriorRobot()
        {
            HP = 100;
            Damage = 30;
            Tipo = "Guerrero";
            Console.WriteLine("Robot guerrero creado");
        }
    }
}
