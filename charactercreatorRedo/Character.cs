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
        public Dictionary<string, bool> savingThrows { get; set; } = new Dictionary<string, bool>()
        {
            { "STRSave", false },
            { "DEXSave", false },
            { "CONSave", false },
            { "INTSave", false },
            { "WISSave", false },
            { "CHASave", false }
        };
        public int Level { get; set; }
        public int Str { get; set; }
        public int Dex { get; set; }
        public int Con { get; set; }
        public int Int { get; set; }
        public int Wis { get; set; }
        public int Cha { get; set; }
    }
}
