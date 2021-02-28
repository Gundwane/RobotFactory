using System;

namespace FactoryRobotPractice
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Robot Factory");
            WarriorRobot robotGuerrero = RobotFactory.CrearRobot<WarriorRobot>(1);
            TankRobot robotTanque = RobotFactory.CrearRobot<TankRobot>(2);
            MedicRobot robotMedico = RobotFactory.CrearRobot<MedicRobot>(3);

            robotGuerrero.Attack(robotTanque);
            robotTanque.Attack(robotGuerrero);
            robotGuerrero.Attack(robotTanque);
            robotMedico.Repair(robotTanque);
        }
    }
}
