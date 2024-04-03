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
    }
}
