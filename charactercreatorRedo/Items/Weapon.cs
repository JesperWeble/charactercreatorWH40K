using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace charactercreatorRedo
{
    public class Weapon : Item
    {
        public string? Attacks { get; set; }
        public string? Damage { get; set; }
        public string? Pierce { get; set; }
        public string? AccuracyThreshold { get; set; }
        public string? Range { get; set; }
        public string? Classification { get; set; }
        public string? Tags { get; set; }
    }




    public class Wpn_CloseCombatWeapon : Weapon
    {
        public Wpn_CloseCombatWeapon()
        {
            Title = "Close Combat Weapon";
            Description = "A makeshift weapon that you found or made, its feels nice in your hand.";
            Attacks = "2";
            Pierce = "0";
            Damage = "1";
            AccuracyThreshold = "3+";
            Range = "5ft";
            Classification = "Melee, 1H";
            Tags = "--";

        }
    }
    public class Wpn_Wrench : Weapon
    {
        public Wpn_Wrench()
        {
            Title = "Wrench";
            Description = "A makeshift weapon that you found or made, its feels nice in your hand.";
            Attacks = "3";
            Pierce = "0";
            Damage = "1";
            AccuracyThreshold = "3+";
            Range = "5ft";
            Classification = "Melee, 1H";
            Tags = "--";

        }
    }

    public class Wpn_Killsaw : Weapon
    {
        public Wpn_Killsaw()
        {
            Title = "Killsaw";
            Description = "A makeshift weapon that you found or made, its feels nice in your hand.";
            Attacks = "1";
            Pierce = "3";
            Damage = "2";
            AccuracyThreshold = "4+";
            Range = "5ft";
            Classification = "Melee, 2H";
            Tags = "--";

        }
    }

    public class Wpn_Choppa : Weapon
    {
        public Wpn_Choppa()
        {
            Title = "Choppa";
            Description = "Now 'is 'ere is a roight proppa Choppa! Perfekt fer bashin' sum 'umie skullz!";
            Attacks = "3";
            Damage = "1";
            Pierce = "1";
            AccuracyThreshold = "3+";
            Range = "5ft";
            Classification = "Melee, 1H";
            Tags = "--";
        }
    }

    public class Wpn_BigChoppa : Weapon
    {
        public Wpn_BigChoppa()
        {
            Title = "Big Choppa";
            Description = "A beautiful Choppa, bigger dan most, ye'd need 2 hands ta wield dis one.";
            Attacks = "3";
            Damage = "2";
            Pierce = "1";
            AccuracyThreshold = "3+";
            Range = "5ft";
            Classification = "Melee, 2H";
            Tags = "--";
        }
    }

    public class Wpn_Slugga : Weapon
    {
        public Wpn_Slugga()
        {
            Title = "Slugga";
            Description = "An ordinary puny slugga, 's alroight I s'pose.";
            Attacks = "1";
            Damage = "2";
            Pierce = "0";
            AccuracyThreshold = "5+";
            Range = "15ft";
            Classification = "Ranged, 1H";
            Tags = "Pistol";

        }
    }
    public class Wpn_KustomSlugga : Weapon
    {
        public Wpn_KustomSlugga()
        {
            Title = "Kustom Slugga";
            Description = "A betta slugga";
            Attacks = "2";
            Damage = "2";
            Pierce = "0";
            AccuracyThreshold = "5+";
            Range = "15/30ft";
            Classification = "Ranged, 1H";
            Tags = "Pistol";

        }
    }
    public class Wpn_Shoota : Weapon
    {
        public Wpn_Shoota()
        {
            Title = "Shoota";
            Description = "Standard Issue Ork DAKKA";
            Attacks = "2";
            Damage = "1";
            Pierce = "0";
            AccuracyThreshold = "5+";
            Range = "30/60ft";
            Classification = "Ranged, Dakka, 2H";
            Tags = "Rapid Fire(1)";

        }
    }

    public class Wpn_BigShoota : Weapon
    {
        public Wpn_BigShoota()
        {
            Title = "Big Shoota";
            Description = "Bigger Ork DAKKA";
            Attacks = "3";
            Damage = "1";
            Pierce = "0";
            AccuracyThreshold = "5+";
            Range = "30/60ft";
            Classification = "Ranged, Dakka";
            Tags = "Rapid Fire(2), 2H";

        }
    }

    public class Wpn_Snazzgun : Weapon
    {
        public Wpn_Snazzgun()
        {
            Title = "Snazzgun";
            Description = "";
            Attacks = "3";
            Damage = "2";
            Pierce = "1";
            AccuracyThreshold = "5+";
            Range = "30/60ft";
            Classification = "Ranged, Dakka, 2H";
            Tags = "Heavy, Critical(1)";

        }
    }

    public class Wpn_Deffgun : Weapon
    {
        public Wpn_Deffgun()
        {
            Title = "Deffgun";
            Description = "";
            Attacks = "2";
            Damage = "2";
            Pierce = "2";
            AccuracyThreshold = "6+";
            Range = "60/120ft";
            Classification = "Ranged, Dakka";
            Tags = "Heavy, Rapid Fire(1)";

        }
    }

    public class Wpn_RokkitLauncha : Weapon
    {
        public Wpn_RokkitLauncha()
        {
            Title = "Rokkit Launcha";
            Description = "";
            Attacks = "1D3";
            Damage = "3";
            Pierce = "2";
            AccuracyThreshold = "5+";
            Range = "90ft, 5ft Radius";
            Classification = "Ranged";
            Tags = "Blast";

        }
    }

    public class Wpn_Burna : Weapon
    {
        public Wpn_Burna()
        {
            Title = "Burna";
            Description = "";
            Attacks = "1D6";
            Damage = "1";
            Pierce = "0";
            AccuracyThreshold = "--";
            Range = "15ft";
            Classification = "Ranged, Flamer";
            Tags = "Torrent";

        }
    }

    public class Wpn_Megablasta : Weapon
    {
        public Wpn_Megablasta()
        {
            Title = "Mega-blasta";
            Description = "";
            Attacks = "3";
            Damage = "2 (+2 vs Vehicles, Fortifications & Monstrous Creatures";
            Pierce = "2";
            AccuracyThreshold = "5+";
            Range = "30/60ft";
            Classification = "Ranged";
            Tags = "--";

        }
    }
}
