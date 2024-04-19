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
        public List<Trait> traits { get; set; } = new List<Trait>();
        public int? hp { get; set; }
        public int? hpMin { get; set; }
        public int? ac { get; set; }
        public Dictionary<string, int> abilityBonus { get; set; } = new Dictionary<string, int>()
        {
            { "STR_Bonus", 0},
            { "DEX_Bonus", 0},
            { "CON_Bonus", 0},
            { "INT_Bonus", 0},
            { "WIS_Bonus", 0},
            { "CHA_Bonus", 0}
        };
        public string? Classification { get; set; }
    }

    public class commonTraitDarkvision : Trait
    {
        public commonTraitDarkvision()
        {
            Title = "Darkvision";
            Classification = "Racial";
            Description = "You can see in dim light within 60 feet of you as if it were bright light, and in darkness as if it were dim light. You can’t discern color in darkness, only shades of gray.";
        }

    }
    public class commonTraitPowerfulBuild : Trait
    {
        public commonTraitPowerfulBuild()
        {
            Title = "Powerful Build";
            Classification = "Racial";
            Description = "You count as one size larger when determining your carrying capacity and the weight you can push, drag, or lift.";
        }

    }

    public class commonTraitSmallFrame : Trait
    {
        public commonTraitSmallFrame()
        {
            Title = "Small Frame";
            Classification = "Racial";
            Description = "Gain a +1 to your AC as long as your not wearing medium or heavy armor. Furthermore you can move through the space of any creature that is of a size larger than yours.";
        }

    }

    public class orkRacialPrimalIntuition : Trait
    {
        public orkRacialPrimalIntuition()
        {
            Title = "Primal Intuition";
            Classification = "Racial";
            Description = "-- Choose Two Proficiencies --\nAnimal Handling\nInsight\nIntimidation\nMedicine\nNature\nPerception\nSurvival";
        }

    }

        public class orkBoyRacialEreWeGo : Trait
        {
            public orkBoyRacialEreWeGo()
            {
                Title = "Ere We Go";
                Classification = "Racial";
                Description = "As a Bonus Action, you can move up to your speed toward an enemy of your choice that you can see or hear. You must end this move closer to the enemy than you started.";
            }

        }

        public class orkBoyRacialMobRule : Trait
        {
            public orkBoyRacialMobRule()
            {
                Title = "Mob Rule";
                Classification = "Racial";
                Description = "Decrease Melee accuracy threshold by 1 while target is within 5ft of atleast one other allied Ork that is not incapacitated. If atleast two other allied Orks are within 5ft, also decrease Ranged accuracy threshold by 1.";
            }

        }
        public class orkBoyRacialMightMakesRight : Trait
        {
            public orkBoyRacialMightMakesRight()
            {
                Title = "Might Makes Right";
                Classification = "Racial";
                Description = "As you kill and fight more and more you slowly grow bigger and stronger.";
                traits.addTrait(new orkBoyRacialMightMakesRightT1());

            }

        }
        public class orkBoyRacialMightMakesRightT1 : Trait
        {
            public orkBoyRacialMightMakesRightT1()
            {
                Title = "Might Makes Right Tier 1";
                Classification = "Racial";
                Description = "You are an ordinary Boy, average run o' the mill Ork with bulging muscles\n\n-- Stats --\n+2 CON\n\n--Traits Gained--\nPowerful Build";
                abilityBonus["CON_Bonus"] = 2;
                traits.addTrait(new commonTraitPowerfulBuild());

            }

        }

        public class orkBoyRacialMightMakesRightT2 : Trait
        {
            public orkBoyRacialMightMakesRightT2()
            {
                Title = "Might Makes Right Tier 2";
                Classification = "Racial";
                Description = "You are a Nobb, a real massive zoggin' Boy.\n\n-- Stats --\n+2 STR & +2 CON\n\n--Traits Gained--\nPowerful Build\nLarger Than Most";
                abilityBonus["STR_Bonus"] = 2;

            }

        }

        public class orkGrotRacialSneakyEscape : Trait
        {
            public orkGrotRacialSneakyEscape()
            {
                Title = "Sneaky Escape";
                Classification = "Racial";
                Description = "You can take the Disengage or Hide action as a Bonus Action on each of your turns.";

            }

        }
        public class orkGrotRacialGrotCunning : Trait
        {
            public orkGrotRacialGrotCunning()
            {
                Title = "Grot Cunning";
                Classification = "Racial";
                Description = "When you damage a creature with a melee or ranged Attack and the creature’s size is larger than yours, you can cause the Attack or spell to deal extra d4 damage to the creature.";

            }

        }
}
