using mis321_pa2_ectew1.Interfaces;

namespace mis321_pa2_ectew1
{
    public class Character
    {
        public string Name {get;set;}
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

    }
}