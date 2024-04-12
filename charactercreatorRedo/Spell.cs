using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace charactercreatorRedo
{
    public class Spell : Trait
    {

    }

    public class spell_Standard_Smite : Spell
    {
        public spell_Standard_Smite()
        {
            Title = "Smite";
            Description = "Warp Charge: 5\nPoint at a target within 120ft and manifest a bolt of crackling psychic lightning that deals 1d3 damage and push them up to 10 feet away. If you roll 11 or above, deal 1d6 instead.";
        }
    }
    public class spell_Weirdboy_DaJump : Spell
    {
        public spell_Weirdboy_DaJump()
        {
            Title = "Da Jump";
            Description = "Warp Charge: 0\nTeleport to any location within 120ft and increase this spell's Warp Charge by an additional +3.";
        }
    }
    public class spell_Weirdboy_RoarOfMork : Spell
    {
        public spell_Weirdboy_RoarOfMork()
        {
            Title = "Roar of Mork";
            Description = "Warp Charge: 8\nRoar with the might of great Mork! Until the start of your next turn: All allies within 60ft gain Feel No Pain(2+) and gain +1 to all combat rolls and +4 to all skill checks, ability checks and saving throws. Increase this spell's Warp Charge by an addition +1.";
        }
    }
    public class spell_Weirdboy_Headbanger : Spell
    {
        public spell_Weirdboy_Headbanger()
        {
            Title = "Headbanger";
            Description = "Warp Charge: 5\nFire a bolt of raw power from your forehad that attempts to make a target within 30ft's head explode dealing 1d6 damage.";
        }
    }
}
