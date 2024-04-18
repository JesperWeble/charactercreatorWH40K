using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace charactercreatorRedo
{
    public class WeaponProgram
    {
        public static void Initialize()
        {
            Weapon? Wpn_Shoota = new Weapon
            {
                Title = "Shoota",
                Description = "Standard Issue Ork DAKKA, Rapid Fire(1): Roll 1 additional Attacks when fired from half range",
                Attacks = 2,
                AccuracyThreshold = 5,
                Damage = 1,
                Range = "30/60ft",
                Classification = "Dakka",
                Tags = "Rapid Fire(1)"

            };
        }
        
    }
}
