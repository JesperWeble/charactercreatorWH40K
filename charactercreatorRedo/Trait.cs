using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace charactercreatorRedo
{
    public class Trait
    {
        public string? Title { get; set; }
        public string? Description { get; set; }
        public List<Power> powers { get; set; } = new List<Power>();
        public List<Spell> spells { get; set; } = new List<Spell>();
        public int? speedGround { get; set; }
        public int? speedAir { get; set;}
        public int? size { get; set;}
        public int? hitDieSize { get; set;}
        public int? hitDieCount { get; set;}
        public int? hpBonus { get; set; }
        public int? acBonus { get; set; }
        public int? strBonus { get; set; }
        public int? dexBonus { get; set; }
        public int? conBonus { get; set; }
        public int? intBonus { get; set; }
        public int? wisBonus { get; set; }
        public int? chaBonus { get; set; }
    }

    // ---- Common Traits ---- \\
    public class commonTraitDarkvision : Trait
    {
        public commonTraitDarkvision()
        {
            Title = "Darkvision";
            Description = "You can see in dim light within 60 feet of you as if it were bright light, and in darkness as if it were dim light. You can’t discern color in darkness, only shades of gray.";
        }

    }

// ###---- RACIALS ----### \\
    // ##---- Ork ----## \\
    public class orkRacialBase : Trait
    {
        public orkRacialBase()
        {
            Title = "Ork Traits";
            Description = "Your base traits and stats\n+2 CON\n\nAge. Orks reach adulthood in a week or so after they emerge from the fungal pod. Mercifully most are short-lived, soon destroying themselves in a maelstrom of violence and internecine conflict. The true length is unknown By the Imperium.\n\nAlignment: Orks are generally a chaotic race usually in the chaotic neutral realm.\n\nSize: Your hight is dependent on Subrace.\nSpeed: Your base walking speed is based on your Subrace.\nLanguages: You can speak but not read, and write gothic.\n\n--Traits Gained--\nPrimal Intuition\nDarkvision";
            conBonus = 2;
        }

    }
    public class orkRacialPrimalIntuition : Trait
    {
        public orkRacialPrimalIntuition()
        {
            Title = "Primal Intuition";
            Description = "-- 1 Proficiency Gained of Your Choice --\nAnimal Handling\nInsight\nIntimidation\nMedicine\nNature\nPerception\nSurvival";
        }

    }


    // #---- Subracials ----# \\
    public class orkBoyRacialBase : Trait
    {
        public orkBoyRacialBase()
        {
            Title = "Boy Traits";
            Description = "Speed: 30ft\n\nSize: Boys vary widely in height and build, from the boy that are 6 to 8 ft tall to a Nob Being around 10 to 12ft tall. Regardless of your position in that range, your size is Medium, Though a Boy with the right might may grow as tall as 15ft in that case they are Large.\n\n--Traits Gained--\nEre We Go\nMob Rule\nMight Makes Right";
        }

    }
}
