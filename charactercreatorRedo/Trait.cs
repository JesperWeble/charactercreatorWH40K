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
        public int? hp { get; set; }
        public int? hpMin { get; set; }
        public int? ac { get; set; }
        public int? strBonus { get; set; }
        public int? dexBonus { get; set; }
        public int? conBonus { get; set; }
        public int? intBonus { get; set; }
        public int? wisBonus { get; set; }
        public int? chaBonus { get; set; }
    }

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

    public class orkRacialPrimalIntuition : Trait
    {
        public orkRacialPrimalIntuition()
        {
            Title = "Primal Intuition";
            Description = "-- Gain Proficiency in 1 --\nAnimal Handling\nInsight\nIntimidation\nMedicine\nNature\nPerception\nSurvival";
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
                Description = "Decrease Melee accuracy threshold by 1 while target is within 5ft of atleast one other allied Ork that is not incapacitated. If atleast two other allied Orks are within 5ft, also decrease Ranged accuracy threshold by 1.";
            }

        }
        public class orkBoyRacialMightMakesRight : Trait
        {
            public orkBoyRacialMightMakesRight()
            {
                Title = "Might Makes Right";
                Description = "As you kill and fight more and more you slowly grow bigger and stronger.";
                traits.addTrait(new orkBoyRacialMightMakesRightT1());

            }

        }
        public class orkBoyRacialMightMakesRightT1 : Trait
        {
            public orkBoyRacialMightMakesRightT1()
            {
                Title = "Might Makes Right Tier 1";
                Description = "You are an ordinary Boy, average run o' the mill Ork with bulging muscles\n\n-- Stats --\n+2 CON\n\n--Traits Gained--\nPowerful Build";
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
