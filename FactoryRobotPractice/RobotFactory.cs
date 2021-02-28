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

        public static T CrearRobot<T>(int tipoDeRobot, string nombre = "")
        {
            switch (tipoDeRobot)
            {
                case Warrior:
                    WarriorRobot warrior = new WarriorRobot();
                    return (T)Convert.ChangeType(warrior, typeof(T)); ;

                case Tank:
                    TankRobot tank = new TankRobot();
                    return (T)Convert.ChangeType(tank, typeof(T)); ;

                case Medic:
                    MedicRobot medic = new MedicRobot();
                    return (T)Convert.ChangeType(medic, typeof(T));

                default: return (T)Convert.ChangeType(null, typeof(T));
            }
        }
    }
}
