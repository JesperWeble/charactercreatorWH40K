using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace charactercreatorRedo
{

//#####-*&/  ORKS  \*-#####\\

    public class Trait_Racial_Base_Ork : Trait
    {
        public Trait_Racial_Base_Ork()
        {
            Title = "Ork Traits";
            Description = "-- Stats --\nAbility: +2 CON\nSpeed: Your base walking speed is based on your Subrace.\nLanguages: Speak, not write Gothic.\n\n-- Traits Gained --\nPrimal Intuition\nDarkvision";
            conBonus = 2;
            traits.addTrait(new commonTraitDarkvision());
            traits.addTrait(new orkRacialPrimalIntuition());
            traits.addTrait(new Trait_Racial_Ork_GetStuckIn());
        }
    }

    public class Trait_Racial_Ork_GetStuckIn : Trait
    {
        public Trait_Racial_Ork_GetStuckIn()
        {
            Title = "Get Stuck In";
            Description = "When an attack made with a Melee Weapon hits with a natural 6, add one additional dice to the subsequent wound roll.";
        }

    }

    //#####-*\  ORKS  /*-#####\\


    //---/  Boy  \---\\

    public class Trait_Racial_Base_Ork_Boy : Trait
        {
            public Trait_Racial_Base_Ork_Boy()
            {
                Title = "Boy Traits";
                Description = "-- Stats --\nHit Points: +2\nSpeed: 30ft\nSize: Medium\n\n--Traits Gained--\nEre We Go\nMob Rule\nMight Makes Right";
                hp = 2;
                traits.addTrait(new orkBoyRacialEreWeGo());
                traits.addTrait(new orkBoyRacialMobRule());
                traits.addTrait(new orkBoyRacialMightMakesRight());
            }

        }

    //---/  Boy  \---\\


    //---/ Grot \---\\

        public class Trait_Racial_Base_Ork_Grot : Trait
        {
            public Trait_Racial_Base_Ork_Grot()
            {
                Title = "Grot Traits";
                Description = "-- Stats --\nAbility: +4 DEX & -2 CON\nSpeed: 35ft\nSize: Small\n\n--Traits Gained--\nSneaky Escape\nGrot Cunning\nSmall Frame";
                dexBonus = 4; 
                conBonus = -2;
                traits.addTrait(new commonTraitSmallFrame());
                traits.addTrait(new orkGrotRacialSneakyEscape());
                traits.addTrait(new orkGrotRacialGrotCunning());
            }
        }

    //---\ Grot /---\\

}
