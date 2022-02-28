using System;
using mis321_pa2_ectew1.Interfaces;

namespace mis321_pa2_ectew1
{
    public class Character
    {
        public string PlayerName {get;set;}
        public string CharacterName {get;set;}
        public int MaxPower {get;set;}
        public double Health {get;set;}
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
            int randomMP = randomNum.Next(1,101);
            return randomMP;
        }

        public static int GetAttackStrength(int MaxPower)
        {
            Random randomNum = new Random();
            int randomAS = randomNum.Next(1, MaxPower);
            return randomAS;
        }

        public static int GetDefensivePower(int MaxPower)
        {
            Random randomNum = new Random();
            int randomDP = randomNum.Next(1, MaxPower);
            return randomDP;
        }

    }
}