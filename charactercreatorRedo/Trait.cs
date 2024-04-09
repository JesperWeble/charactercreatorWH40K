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
        public List<Trait> traits { get; set; } = new List<Trait>();
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
    public class commonTraitPowerfulBuild : Trait
    {
        public commonTraitPowerfulBuild()
        {
            Title = "Powerful Build";
            Description = "You count as one size larger when determining your carrying capacity and the weight you can push, drag, or lift.";
        }

    }

    public class commonTraitSmallFrame : Trait
    {
        public commonTraitSmallFrame()
        {
            Title = "Small Frame";
            Description = "Gain a +1 to your AC as long as your not wearing medium or heavy armor. Furthermore you can move through the space of any creature that is of a size larger than yours.";
        }

    }

    // ###---- RACIALS ----### \\
    // ##---- Ork ----## \\

    public class orkRacialPrimalIntuition : Trait
    {
        public orkRacialPrimalIntuition()
        {
            Title = "Primal Intuition";
            Description = "-- 1 Proficiency Gained of Your Choice --\nAnimal Handling\nInsight\nIntimidation\nMedicine\nNature\nPerception\nSurvival";
        }

    }

        public class orkBoyRacialEreWeGo : Trait
        {
            public orkBoyRacialEreWeGo()
            {
                Title = "Ere We Go";
                Description = "As a Bonus Action, you can move up to your speed toward an enemy of your choice that you can see or hear. You must end this move closer to the enemy than you started.";
            }

        }

        public class orkBoyRacialMobRule : Trait
        {
            public orkBoyRacialMobRule()
            {
                Title = "Mob Rule";
                Description = "Gain advantage on attack rolls against targets when at least 2 other Ork allies are within 5ft of the target and the allies are not incapacitated.";
            }

        }
        public class orkBoyRacialMightMakesRight : Trait
        {
            public orkBoyRacialMightMakesRight()
            {
                Title = "Might Makes Right";
                Description = "As you fight and kill more and more, you begin to change physically, making you bigger and stronger. Gain traits and ability score bonuses as you level up\n\nLevel 1-5:\t+2 Str   Trait: Powerful Build\n\nLevel 6-10:\t+2 Con   Trait: Larger Than Most\n\nLevel 11-15:\t+2 Cha & Str\n\nLevel 16-20:\t+2 Str, Con & Cha   Size: Large   Trait: Large Frame";
                traits.addTrait(new orkBoyRacialMightMakesRightT1());

            }

        }
        public class orkBoyRacialMightMakesRightT1 : Trait
        {
            public orkBoyRacialMightMakesRightT1()
            {
                Title = "Might Makes Right Tier 1";
                Description = "You are an ordinary Boy, average run o' the mill Ork with bulging muscles\n+2 Str\n--Traits Gained--\nPowerful Build";
                strBonus = 2;
                traits.addTrait(new commonTraitPowerfulBuild());

            }

        }

        public class orkGrotRacialSneakyEscape : Trait
        {
            public orkGrotRacialSneakyEscape()
            {
                Title = "Sneaky Escape";
                Description = "You can take the Disengage or Hide action as a Bonus Action on each of your turns.";

            }

        }
        public class orkGrotRacialGrotCunning : Trait
        {
            public orkGrotRacialGrotCunning()
            {
                Title = "Grot Cunning";
                Description = "When you damage a creature with a melee or ranged Attack and the creature’s size is larger than yours, you can cause the Attack or spell to deal extra d4 damage to the creature.";

            }

        }
}
