using mis321_pa2_ectew1.Interfaces;

namespace mis321_pa2_ectew1
{
    public class CannonBehavior : IAttack
    {
        public void Attack()
        {
            System.Console.WriteLine("\nHere comes Davy Jones' Cannon Fire!");
        }
    }
}