using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace charactercreatorRedo
{
    public class Weapon : Item
    {
    }


    public class Wpn_Shoota : Weapon
    {
        public Wpn_Shoota()
        {
            Title = "Shoota";
            Description = "Standard Issue Ork DAKKA\n\nRange:\t30/60 ft\nAttacks:\t2\nAccuracy Threshold:\t5+\nDamage:\t1\n\n-- Tags --\nRapid Fire(1): Roll 1 additional Attacks when fired from half range";
        }
    }
}
