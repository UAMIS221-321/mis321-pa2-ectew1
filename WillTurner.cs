using mis321_pa2_ectew1.Interfaces;

namespace mis321_pa2_ectew1
{
    public class WillTurner : Character
    {
        public WillTurner()
        {
            attackBehavior = new SwordBehavior();
        }
    }
}