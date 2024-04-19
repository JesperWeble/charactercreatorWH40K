using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace charactercreatorRedo
{
    public class Character
    {
        public string? Title { get; set; }
        public string? Description { get; set; }
        public string? Backstory { get; set; }
        public Race? Race { get; set; }
        public Subrace? Subrace { get; set; }
        public Class? Class { get; set; }
        public Background? Background { get; set; }
        public List<Trait> traits { get; set; } = new List<Trait>();
        public List<Power> powers { get; set; } = new List<Power>();
        public Dictionary<string, bool> proficiencies { get; set; } = new Dictionary<string, bool>()
        {
            { "Athletics", false },
            { "Acrobatics", false },
            { "SleightOfHand", false },
            { "Stealth", false },
            { "Arcana", false },
            { "History", false },
            { "Investigation", false },
            { "Nature", false },
            { "Religion", false },
            { "AnimalHandling", false },
            { "Insight", false },
            { "Medicine", false },
            { "Perception", false },
            { "Survival", false },
            { "Deception", false },
            { "Intimidation", false },
            { "Performance", false },
            { "Persuasion", false },
            { "Technology", false },
            { "Crafting", false },
        };
        public Dictionary<string, int> abilityScores { get; set; } = new Dictionary<string, int>()
        {
            { "STR", 0},
            { "DEX", 0},
            { "CON", 0},
            { "INT", 0},
            { "WIS", 0},
            { "CHA", 0}
        };
        public Dictionary<string, int> abilityModifiers { get; set; } = new Dictionary<string, int>()
        {
            { "STR_Mod", 0},
            { "DEX_Mod", 0},
            { "CON_Mod", 0},
            { "INT_Mod", 0},
            { "WIS_Mod", 0},
            { "CHA_Mod", 0}
        };
        public Dictionary<string, bool> savingThrows { get; set; } = new Dictionary<string, bool>()
        {
            { "STR_Save", false },
            { "DEX_Save", false },
            { "CON_Save", false },
            { "INT_Save", false },
            { "WIS_Save", false },
            { "CHA_Save", false }
        };
        public Dictionary<string, Weapon> weapons { get; set; } = new Dictionary<string, Weapon>()
        {
        };
        public Dictionary<string, Item> Inventory { get; set; } = new Dictionary<string, Item>()
        {
        };
        public int? Level { get; set; }
        public int? maxHP { get; set; } = 0;
        public int? hp { get; set; } = 0;
        public int? hpMin { get; set; } = 0;
        public int? ac { get; set; } = 0;
    }
}
