using mis321_pa2_ectew1.Interfaces;

namespace mis321_pa2_ectew1
{
    public class DistractBehavior : IAttack
    {
        public void Attack()
        {
            System.Console.WriteLine("\nHaha, Jack Sparrow distracted you!");
        }
    }
}