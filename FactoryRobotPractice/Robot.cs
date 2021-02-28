﻿using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryRobotPractice
{
    public class Robot
    {
        protected string name;
        private string tipo;
        protected int damage;
        protected int HP;
        protected bool Alive = true;
        

        #region Properties
        public string Name { get => name; set => name = value; }
        public int Damage { get => damage; set => damage = value; }
        protected string Tipo { get => tipo; set => tipo = value; }
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

        private void InformThatRobotWasAttacked(int amountOfDamageReceived) 
        {
            Console.WriteLine(Tipo + " fué atacado y recibió " + amountOfDamageReceived + " puntos de daño");
        }

        public void BeRepaired(int pointsOfRepair)
        {
            HP += pointsOfRepair;

            Console.WriteLine(Tipo + " fué reparado por " + pointsOfRepair + " de puntos");
        }
        #endregion
    }
}
