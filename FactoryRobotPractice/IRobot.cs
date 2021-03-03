using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryRobotPractice
{
    interface IRobot
    {
        void ReceiveDamage(int amountOfDamage);

        void Attack(Robot robotAtacado);

        void BeRepaired(int pointsOfRepair);
    }
}
