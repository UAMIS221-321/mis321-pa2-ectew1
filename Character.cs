using System;
using mis321_pa2_ectew1.Interfaces;

namespace mis321_pa2_ectew1
{
    public class Character
    {
        public string CharacterName {get;set;}
        public int MaxPower {get;set;}
        public int Health {get;set;}
        public int AttackStrength {get;set;}
        public int DefensivePower {get;set;}
        public IAttack attackBehavior {get;set;}
        public IDefend defendBehavior {get;set;}

        public Character()
        {

        }

        public void SetAttackBehavior(IAttack attackBehavior)
        {
            this.attackBehavior = attackBehavior;
        }

        public void SetDefendBehavior(IDefend defendBehavior)
        {
            this.defendBehavior = defendBehavior;
        }

        public static int GetMaxPower()
        {
            Random randomNum = new Random();
            int randomMaxPower = randomNum.Next(1,101);
            return randomMaxPower;
        }

        public static int GetAttackStrength(int MaxPower)
        {
            Random randomNum = new Random();
            int randomAttackStrength = randomNum.Next(1, MaxPower);
            return randomAttackStrength;
        }

        public static int GetDefensivePower(int MaxPower)
        {
            Random randomNum = new Random();
            int randomDefensivePower = randomNum.Next(1, MaxPower);
            return randomDefensivePower;
        }

    }
}