using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace charactercreatorRedo
{
    public class spell_Standard_Smite : Trait
    {
        public spell_Standard_Smite()
        {
            Title = "Smite";
            Description = "Warp Charge: 4\nAction\nPoint at a target within 120ft and manifest a bolt of crackling psychic lightning that deals 1d3 damage and push them up to 10 feet away. If you roll 11 or above, deal 1d6 instead.";
        }
    }
    public class spell_Weirdboy_DaJump : Trait
    {
        public spell_Weirdboy_DaJump()
        {
            Title = "Da Jump";
            Description = "Warp Charge: 0\nBonus Action\nTeleport to any location within 120ft and increase this spell's Warp Charge by an additional +3.";
        }
    }
    public class spell_Weirdboy_Warpath : Trait
    {
        public spell_Weirdboy_Warpath()
        {
            Title = "Warpath";
            Description = "Warp Charge: 4\nBonus Action\nAdd 1 additional hit to the next melee attack of the target.";
        }
    }
    public class spell_Weirdboy_Prestidigitation : Trait
    {
        public spell_Weirdboy_Prestidigitation()
        {
            Title = "Prestidigitation";
            Description = "Warp Charge: 2\nBonus Action\nYou create one of the following magical effects within range:\r\nYou create an instantaneous, harmless sensory effect, such as a shower of sparks, a puff of wind, faint musical notes, or an odd odor.\r\nYou instantaneously light or snuff out a candle, a torch, or a small campfire.\r\nYou instantaneously clean or soil an object no larger than 1 cubic foot.\r\nYou chill, warm, or flavor up to 1 cubic foot of nonliving material for 1 hour.\r\nYou make a color, a small mark, or a symbol appear on an object or a surface for 1 hour.\r\nYou create a nonmagical trinket or an illusory image that can fit in your hand and that lasts until the end of your next turn.\r\nIf you cast this spell multiple times, you can have up to three of its non-instantaneous effects active at a time, and you can dismiss such an effect as an action.";
        }
    }
}
