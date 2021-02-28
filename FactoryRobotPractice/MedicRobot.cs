using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryRobotPractice
{
    public class MedicRobot : Robot
    {
        private int RepairPoints = 10;
        public MedicRobot()
        {
            HP = 70;
            Damage = 10;
            Tipo = "Médico";
            Console.WriteLine("Robot médico creado");
        }

        public void Repair(Robot robotToRepair)
        {
            robotToRepair.BeRepaired(RepairPoints);
        }
    }
}
