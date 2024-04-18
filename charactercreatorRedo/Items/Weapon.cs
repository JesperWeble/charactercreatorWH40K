using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace charactercreatorRedo
{
    public class Weapon : Item
    {
        public int? Attacks { get; set; }
        public int? Damage { get; set; }
        public int? AccuracyThreshold { get; set; }
        public int? Pierce { get; set; }
        public string? Range { get; set; }
        public string? Classification { get; set; }
        public string? Tags { get; set; }
    }


    public class Wpn_Shoota : Weapon
    {
        public Wpn_Shoota()
        {
            Title = "Shoota";
            Description = "Standard Issue Ork DAKKA, Rapid Fire(1): Roll 1 additional Attacks when fired from half range";
            Attacks = 2;
            AccuracyThreshold = 5;
            Damage = 1;
            Range = "30/60ft";
            Classification = "Dakka";
            Tags = "Rapid Fire(1)";

        }
    }
}
