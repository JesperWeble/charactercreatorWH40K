using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace charactercreatorRedo
{

//#####-*&/  ORKS  \*-#####\\

    public class orkRacialBase : Trait
    {
        public orkRacialBase()
        {
            Title = "Ork Traits";
            Description = "Your base traits and stats\n+2 CON\n\nAge. Orks reach adulthood in a week or so after they emerge from the fungal pod. Mercifully most are short-lived, soon destroying themselves in a maelstrom of violence and internecine conflict. The true length is unknown By the Imperium.\n\nAlignment: Orks are generally a chaotic race usually in the chaotic neutral realm.\n\nSize: Your hight is dependent on Subrace.\nSpeed: Your base walking speed is based on your Subrace.\nLanguages: You can speak but not read, and write gothic.\n\n--Traits Gained--\nPrimal Intuition\nDarkvision";
            traits.addTrait(new commonTraitDarkvision());
            traits.addTrait(new orkRacialPrimalIntuition());
            conBonus = 2;
        }
    }

//#####-*\  ORKS  /*-#####\\


    //---/  Boy  \---\\

        public class orkBoyRacialBase : Trait
        {
            public orkBoyRacialBase()
            {
                Title = "Boy Traits";
                Description = "Speed: 30ft\n\nSize: Boys vary widely in height and build, from the boy that are 6 to 8 ft tall to a Nob Being around 10 to 12ft tall. Regardless of your position in that range, your size is Medium, Though a Boy with the right might may grow as tall as 15ft in that case they are Large.\n\n--Traits Gained--\nEre We Go\nMob Rule\nMight Makes Right";
                speedGround = 30;
                size = 3; // Medium
                traits.addTrait(new orkBoyRacialEreWeGo());
                traits.addTrait(new orkBoyRacialMobRule());
                traits.addTrait(new orkBoyRacialMightMakesRight());
            }

        }

    //---/  Boy  \---\\


    //---/ Grot \---\\

        public class orkGrotRacialBase : Trait
        {
            public orkGrotRacialBase()
            {
                Title = "Grot Traits";
                Description = "+4 Dex, -2 Con\n\nSpeed: 35ft\n\nSize: Small\n\n--Traits Gained--\nSneaky Escape\nGrot Cunning\nSmall Frame";
                dexBonus = 4; conBonus = -2;
                speedGround = 35;
                size = 2; // Small
                traits.addTrait(new commonTraitSmallFrame());
                traits.addTrait(new orkGrotRacialSneakyEscape());
                traits.addTrait(new orkGrotRacialGrotCunning());
            }
        }

    //---\ Grot /---\\

}
