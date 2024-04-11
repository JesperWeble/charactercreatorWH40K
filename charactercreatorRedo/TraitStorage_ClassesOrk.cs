using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace charactercreatorRedo
{
    public class Trait_Class_Base_Ork_Shoota : Trait
    {
        public Trait_Class_Base_Ork_Shoota()
        {
            Title = "Class Base";
            Description = "-- Stats --\nHit Points: 6 + CON Modifier to a minimum of 6\n\n-- Class Features --\nNot Enuff Dakka\nHeavy Hittin'\nWAAAGH!";
            hp = 6;
            hpMin = 6;
            traits.addTrait(new Trait_Class_Ork_Shoota_NotEnuffDakka());
            traits.addTrait(new Trait_Class_Ork_Shoota_HeavyHittin());
            traits.addTrait(new Trait_Class_Ork_Shoota_WAAAGH());


        }
    }

    public class Trait_Class_Ork_Shoota_NotEnuffDakka : Trait
    {
        public Trait_Class_Ork_Shoota_NotEnuffDakka()
        {
            Title = "Not Enuff Dakka";
            Description = "You roll an additional attack dice with DAKKA";
        }
    }

    public class Trait_Class_Ork_Shoota_HeavyHittin : Trait
    {
        public Trait_Class_Ork_Shoota_HeavyHittin()
        {
            Title = "Heavy Hittin'";
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





    public class Trait_Class_Base_Ork_Mekboy : Trait
    {
        public Trait_Class_Base_Ork_Mekboy()
        {
            Title = "Class Base";
            Description = "-- Stats --\nHit Points: 6 + CON Modifier to a minimum of 6\n\n-- Class Features --\n";
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
            Description = "May be used per battle a number of times equal to your Intelligence Modifier and only once per turn.\n\nReroll all natural 1 Wound rolls of an ally Dakka weapon within 5ft of you. You may do this after seeing the rolls.";
        }
    }
}
