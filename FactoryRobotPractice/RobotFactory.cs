using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryRobotPractice
{
    public class RobotFactory
    {
        public const int Warrior = 1;
        public const int Tank = 2;
        public const int Medic = 3;

        public static Robot CrearRobot(int tipoDeRobot, string nombre = "")
        {
            switch (tipoDeRobot)
            {
                case Warrior:
                    Robot warrior = new WarriorRobot();
                    return warrior;

                case Tank:
                    Robot tank = new TankRobot();
                    return tank;

                case Medic:
                    Robot medic = new MedicRobot();
                    return medic;

                default: return null;
            }
        }
    }
}
