using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace charactercreatorRedo
{
    public class trait_CF_Ork_Boy_Shoota_Base : Trait
    {
        public trait_CF_Ork_Boy_Shoota_Base()
        {
            Title = "Class Base";
            Description = "-- Hit Points --\nHit Dice: 1d12 per Shoota Level\nHit Points at 1st Level: 12 + Con Modifier\nHit Points at Higher Levels: 1d12 + CON modifier per Shoota level after 1st.\n\n-- Proficiencies --\nSaving Throws: Strength & Constitution\nSkills: Choose two from Animal Handling, Athletics, Intimidation, Perception or Survival";
        }
    }

    public class trait_CF_Ork_Boy_Shoota_InnateSpecialism : Trait
    {
        public trait_CF_Ork_Boy_Shoota_InnateSpecialism()
        {
            Title = "Innate Specialism";
            Description = "You roll an additional attack dice with Dakkas and deal 2 additional damage with Choppas.";
        }
    }

    public class trait_CF_Ork_Boy_Shoota_WAAAGH : Trait
    {
        public trait_CF_Ork_Boy_Shoota_WAAAGH()
        {
            Title = "WAAAGH!";
            Description = "You may declare WAAAGH during your turn, only once per battle. Until your next turn you may Sprint as a bonus action, your AC is increased by 1 and you roll an additional dice for any attack.";
        }
    }
}
