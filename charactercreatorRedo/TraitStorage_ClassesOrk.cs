using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace charactercreatorRedo
{
    //
    //          Shoota
    //
    public class Trait_Class_Base_Ork_Shoota : Trait
    {
        public Trait_Class_Base_Ork_Shoota()
        {
            Title = "Class Base";
            Description = "-- Stats --\nHit Points: 8 + CON Modifier to a minimum of 8\n\n-- Class Features --\nNot Enuff Dakka\nHeavy Hittin'\nWAAAGH!";
            hp = 8;
            hpMin = 8;
            traits.addTrait(new Trait_Class_Ork_Shoota_NotEnuffDakka());
            traits.addTrait(new Trait_Class_Ork_Shoota_BrutallyKunnin());
            traits.addTrait(new Trait_Class_Ork_Shoota_WAAAGH());


        }
    }

    public class Trait_Class_Ork_Shoota_NotEnuffDakka : Trait
    {
        public Trait_Class_Ork_Shoota_NotEnuffDakka()
        {
            Title = "Not Enuff Dakka";
            Description = "You add one additional dice to attacks done with DAKKA\n\nAs a bonus action you may attack again with another weapon";
        }
    }

    public class Trait_Class_Ork_Shoota_BrutallyKunnin : Trait
    {
        public Trait_Class_Ork_Shoota_BrutallyKunnin()
        {
            Title = "Brutally Kunnin'";
            Description = "May be used per battle a number of times equal to your Strength Modifier\n\nReroll a single of your Wound rolls.";
        }
    }

    public class Trait_Class_Ork_Shoota_WAAAGH : Trait
    {
        public Trait_Class_Ork_Shoota_WAAAGH()
        {
            Title = "WAAAGH!";
            Description = "You may declare WAAAGH during your turn, only once per battle.\n\n*Until the start of your next turn*\nYou and nearby allied Orks\n\tMay Sprint as a free action\n\tHave your AC increased by 1\n\tRoll one additional attack dice on any attack.";
        }
    }




    //
    //          Mekboy
    //
    public class Trait_Class_Base_Ork_Mekboy : Trait
    {
        public Trait_Class_Base_Ork_Mekboy()
        {
            Title = "Class Base";
            Description = "-- Stats --\nHit Points: 6 + CON Modifier to a minimum of 6\n\n-- Class Features --\nMekky Talent\nMekaniak\nDakkaboosta";
            hp = 6;
            hpMin = 6;
            traits.addTrait(new Trait_Class_Ork_Mekboy_MekkyTalent());
            traits.addTrait(new Trait_Class_Ork_Mekboy_Mekaniak());
            traits.addTrait(new Trait_Class_Ork_Mekboy_Dakkaboosta());



        }
    }
    public class Trait_Class_Ork_Mekboy_MekkyTalent : Trait
    {
        public Trait_Class_Ork_Mekboy_MekkyTalent()
        {
            Title = "Mekky Talent";
            Description = "You have advantage when crafting and repairing weaponry, augments, vehicles and machinery.\nAdd +1 to all Hit AND Wound rolls made against Vehicles or Machines";
        }
    }
    public class Trait_Class_Ork_Mekboy_Mekaniak : Trait
    {
        public Trait_Class_Ork_Mekboy_Mekaniak()
        {
            Title = "Mekaniak";
            Description = "You may spend an action to restore 1d3 hit points to a Vehicle or Machine.\nUntil the start of your next turn that Vehicle or Machine has 1 reduced Accuracy Threshold on all its attacks";
        }
    }
    public class Trait_Class_Ork_Mekboy_Dakkaboosta : Trait
    {
        public Trait_Class_Ork_Mekboy_Dakkaboosta()
        {
            Title = "Dakkaboosta";
            Description = "May be used per battle a number of times equal to your Intelligence Modifier and only once per turn.\n\nReroll all natural 1 Hit rolls of a Dakka weapon within 5ft of you. You may do this after seeing the rolls.";
        }
    }

    //
    //          Painboy
    //
    public class Trait_Class_Base_Ork_Painboy : Trait
    {
        public Trait_Class_Base_Ork_Painboy()
        {
            Title = "Class Base";
            Description = "-- Stats --\nHit Points: 6 + CON Modifier to a minimum of 6\n\n-- Class Features --\n";
            hp = 6;
            hpMin = 6;
            traits.addTrait(new Trait_Class_Ork_Painboy_DoksLicense());
            traits.addTrait(new Trait_Class_Ork_Painboy_GetBackInDere());
            traits.addTrait(new Trait_Class_Ork_Painboy_WalkItOff());


        }
    }

    public class Trait_Class_Ork_Painboy_GetBackInDere : Trait
    {
        public Trait_Class_Ork_Painboy_GetBackInDere()
        {
            Title = "Get Back In Dere!";
            Description = "Once per battle as a bonus action: Restore 1d4 hit points of a creature within 5ft. Until the start of your next turn that creature has Feel No Pain(4+)\n\nFeel No Pain(x): Before sustaining any damage, roll 1d6 for each damaging effect. If you roll equal to or above X, you take no damage from that effect.";
        }
    }
    public class Trait_Class_Ork_Painboy_WalkItOff : Trait
    {
        public Trait_Class_Ork_Painboy_WalkItOff()
        {
            Title = "Walk It Off!";
            Description = "As an action: You may instantly stabilize a creature within 5ft that has 0 hit points, until the start of your next turn that creature has Feel No Pain(4+)\n\nFeel No Pain(x): Before sustaining any damage, roll 1d6 for each damaging effect. If you roll equal to or above X, you take no damage from that effect.";
        }
    }
    public class Trait_Class_Ork_Painboy_DoksLicense : Trait
    {
        public Trait_Class_Ork_Painboy_DoksLicense()
        {
            Title = "Doks License";
            Description = "You have advantage when performing surgeries or identifying medicine.\n\nWhile within 5ft of you, allies have Feel No Pain(5+).\n\nFeel No Pain(x): Before sustaining any damage, roll 1d6 for each damaging effect. If you roll equal to or above X, you take no damage from that effect.";
        }
    }


    //
    //          Kommando
    //
    public class Trait_Class_Base_Ork_Kommando : Trait
    {
        public Trait_Class_Base_Ork_Kommando()
        {
            Title = "Class Base";
            Description = "-- Stats --\nHit Points: 6 + CON Modifier to a minimum of 6\n\n-- Class Features --\nSneaky Surprise\nKunnin'ly Brutral\nKritikal Krumpin'";
            hp = 6;
            hpMin = 6;
            traits.addTrait(new Trait_Class_Ork_Kommando_SneakySurprise());
            traits.addTrait(new Trait_Class_Ork_Kommando_KunninlyBrutal());
            traits.addTrait(new Trait_Class_Ork_Kommando_KritikalKrumpin());

        }
    }
    public class Trait_Class_Ork_Kommando_SneakySurprise : Trait
    {
        public Trait_Class_Ork_Kommando_SneakySurprise()
        {
            Title = "Sneaky Surprise";
            Description = "You can take the Disengage or Hide action as a Bonus Action on each of your turns.\n\nWhen attacking a target that is has not spotted you, add one additional die to the wound roll.";
        }
    }

    public class Trait_Class_Ork_Kommando_KritikalKrumpin : Trait
    {
        public Trait_Class_Ork_Kommando_KritikalKrumpin()
        {
            Title = "Kritikal Krumpin'";
            Description = "When an attack made with a Melee Weapon hits with a natural 6, add one additional dice to the subsequent wound roll.";
        }
    }

    public class Trait_Class_Ork_Kommando_KunninlyBrutal : Trait
    {
        public Trait_Class_Ork_Kommando_KunninlyBrutal()
        {
            Title = "Kunnin'ly Brutal";
            Description = "May be used per battle a number of times equal to your Dexterity Modifier\n\nReroll a single of your Hit rolls.";
        }
    }

    //
    //          Beast Snagga
    //
    public class Trait_Class_Base_Ork_BeastSnagga : Trait
    {
        public Trait_Class_Base_Ork_BeastSnagga()
        {
            Title = "Class Base";
            Description = "-- Stats --\nHit Points: 6 + CON Modifier to a minimum of 6\n\n-- Class Features --\n";
            hp = 6;
            hpMin = 6;
            traits.addTrait(new Trait_Class_Ork_BeastSnagga_MonsterHunter());
            traits.addTrait(new Trait_Class_Ork_BeastSnagga_WildRide());
            traits.addTrait(new Trait_Class_Ork_BeastSnagga_SquigMasta());


        }
    }
    public class Trait_Class_Ork_BeastSnagga_MonsterHunter: Trait
    {
        public Trait_Class_Ork_BeastSnagga_MonsterHunter()
        {
            Title = "Monster Hunter";
            Description = "Once per turn: When attacking a Monster or Vehicle, you may reroll any amount of the hit dice.\n\nYou have advantage when tracking any creature or vehicle and when identifying, wrestling and handling Animals, Beasts and Monsters.";
        }
    }

    public class Trait_Class_Ork_BeastSnagga_WildRide : Trait
    {
        public Trait_Class_Ork_BeastSnagga_WildRide()
        {
            Title = "Wild Ride";
            Description = "You automatically succeed riding checks.\n\nWhile riding on a creature, you and the creature have Feel No Pain(6+)\n\nFeel No Pain(x): Before sustaining any damage, roll 1d6 for each damaging effect. If you roll equal to or above X, you take no damage from that effect.";
        }
    }
    public class Trait_Class_Ork_BeastSnagga_SquigMasta : Trait
    {
        public Trait_Class_Ork_BeastSnagga_SquigMasta()
        {
            Title = "Squig Masta";
            Description = "You can order two squigs per turn instead of one.\nYour Squigs have +1 attacks and +1 AC.";
        }
    }

    //
    //          Weirdboy
    //
    public class Trait_Class_Base_Ork_Weirdboy : Trait
    {
        public Trait_Class_Base_Ork_Weirdboy()
        {
            Title = "Class Base";
            Description = "-- Stats --\nHit Points: 6 + CON Modifier to a minimum of 6\n\n-- Class Features --\n";
            hp = 6;
            hpMin = 6;
            traits.addTrait(new Trait_Class_Ork_Painboy_DoksLicense());
            traits.addTrait(new Trait_Class_Ork_Painboy_GetBackInDere());
            traits.addTrait(new Trait_Class_Ork_Painboy_WalkItOff());


        }
    }
    public class Trait_Class_Ork_Weirdboy_WeirdPower : Trait
    {
        public Trait_Class_Ork_Weirdboy_WeirdPower()
        {
            Title = "Weird Power";
            Description = "You are considered a Psyker, a caster of spells: To manifest a spell you must roll 2d6s + your WIS modifier. Each spell has a Warp Charge, to manifest the spell you must roll equal to or above the Warp Charge.\nEvery time you attempt to manifest a spell regardless of if it succeeds or fails the Warp Charge of that spell is increased by 1 until your next long rest.\nIf you roll double ones or double sixes you suffer the perils of the Warp taking 1d3 damage. If you reach 0 health from this everyone within 15ft of you also suffer 1d3 damage.\n-- Spells Gained --\nSmite";
        }
    }
}
