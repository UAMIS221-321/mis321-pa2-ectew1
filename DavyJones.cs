using mis321_pa2_ectew1.Interfaces;

namespace mis321_pa2_ectew1
{
    public class DavyJones : Character
    {
        public DavyJones()
        {
            attackBehavior = new CannonBehavior();
        }
    }
}