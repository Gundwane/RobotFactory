using System;

namespace FactoryRobotPractice
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Robot Factory");
            Robot robotGuerrero = RobotFactory.CrearRobot(1);
            Robot robotTanque = RobotFactory.CrearRobot(2);
            Robot robotMedico = RobotFactory.CrearRobot(3);

            robotGuerrero.Attack(robotTanque);
        }
    }
}
