using mis321_pa2_ectew1.Interfaces;

namespace mis321_pa2_ectew1
{
    public class JackSparrow : Character
    {
        public JackSparrow()
        {
            attackBehavior = new DistractBehavior();
        }
    }
}