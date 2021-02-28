using System;

namespace FactoryRobotPractice
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Robot Factory");

            RobotFactory factory = new RobotFactory();
            Robot robotGuerrero = factory.CrearRobot(1);
            Robot robotTanque = factory.CrearRobot(2);
            Robot robotMedico = factory.CrearRobot(3);

            robotGuerrero.Attack(robotTanque);
        }
    }
}
