using mis321_pa2_ectew1.Interfaces;

namespace mis321_pa2_ectew1
{
    public class SwordBehavior : IAttack
    {
        public void Attack()
        {
            System.Console.WriteLine("\nArg! Will Turner attacked you with his sword!");
        }
    }
}