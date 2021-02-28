using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryRobotPractice
{
    public class Robot
    {
        protected string name;
        protected int damage;
        protected int HP;
        protected bool Alive = true;
        

        #region Properties
        public string Name { get => name; set => name = value; }
        public int Damage { get => damage; set => damage = value; }
        #endregion

        #region Methods
        public void ReceiveDamage(int amountOfDamage)
        {
            HP -= amountOfDamage;

            if (HP <= 0)
            {
                Alive = false;
            }

            InformThatRobotWasAttacked(amountOfDamage);
        }

        public void Attack(Robot robotAtacado)
        {
            robotAtacado.ReceiveDamage(Damage);
        }

        public bool IsAlive()
        {
            return Alive;
        }

        public void ShowHP()
        {
            Console.WriteLine("HP: " + HP);
        }

        public void InformThatRobotWasAttacked(int amountOfDamageReceived) 
        {
            Console.WriteLine(Name + " fué atacado y recibió " + amountOfDamageReceived + " points of damage");
        }

        public void BeRepaired(int pointsOfRepair)
        {
            HP += pointsOfRepair;

            Console.WriteLine("El robot fué reparado por " + pointsOfRepair + " de puntos");
        }
        #endregion
    }
}
