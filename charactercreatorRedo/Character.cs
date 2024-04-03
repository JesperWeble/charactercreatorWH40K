using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace charactercreatorRedo
{
    class Character
    {
        public string? Title { get; set; }
        public string? Description { get; set; }
        public Race? Race { get; set; }
        public Subrace? Subrace { get; set; }
        public Class? Class { get; set; }
        public Background? Background { get; set; }
        public List<Trait> traits { get; set; } = new List<Trait>();
        public List<Power> powers { get; set; } = new List<Power>();
        public List<Spell> spells { get; set; } = new List<Spell>();
        public int Level { get; set; }
        public int Str { get; set; }
        public int Dex { get; set; }
        public int Con { get; set; }
        public int Int { get; set; }
        public int Wis { get; set; }
        public int Cha { get; set; }
    }
}
