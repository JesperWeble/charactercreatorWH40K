using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace charactercreatorRedo
{
    public class Class
    {
        public string? Title { get; set; }
        public string? Description { get; set; }
        public int? Level { get; set; }
        public List<Trait> traits { get; set; } = new List<Trait>();
        public Dictionary<string, Item> ItemPack { get; set; } = new Dictionary<string, Item>()
        {
        };
        public Dictionary<string, Weapon> Loadout { get; set; } = new Dictionary<string, Weapon>()
        {
        };

    }
    //##### --- Ork Classes --- #####\\
        public class orkClassShoota : Class
        {
            public orkClassShoota()
            {
                Title = "Shoota Boy";
                Description = "The standard soldier Ork, they excel at firing various weaponry or hitting things very hard. Highly Versatile. Brutal. Their primary ability is Strength, you don't need good aim, just more dakka.";
                traits.addTrait(new Trait_Class_Base_Ork_Shoota());
                Loadout.Add("Big Shoota", new Wpn_BigShoota());
                Loadout.Add("Choppa", new Wpn_Choppa());
                Loadout.Add("Kustom Slugga", new Wpn_KustomSlugga());

                ItemPack.Add("Bag Squig", new Item_BagSquig());
                ItemPack.Add("Scrap Jet", new Item_ScrapJet());
                ItemPack.Add("Teef", new Item_Teef() { Count = 100});
                ItemPack.Add("Stikkbomb", new Item_Stikkbomb() { Count = 3 });
                
                
            }
        
        }

        public class orkClassMekboy : Class
        {
            public orkClassMekboy()
            {
                Title = "Mekboy";
                Description = "The mechanic Ork, they excel at crafting, repairing, manipulating and piloting vehicles and mechs. Very good with explosives. Primary ability is Intelligence.";
                traits.addTrait(new Trait_Class_Base_Ork_Mekboy());
                Loadout.Add("Wrench", new Wpn_Wrench());
                Loadout.Add("Killsaw", new Wpn_Killsaw());
                Loadout.Add("Deffgun", new Wpn_Deffgun());
                Loadout.Add("Slugga", new Wpn_Slugga());

                ItemPack.Add("Bag Squig", new Item_BagSquig());
                ItemPack.Add("Tool Kit", new Item_ToolKit());
                ItemPack.Add("Grappling Gun", new Item_GrapplingGun());
                ItemPack.Add("Scrap Turret", new Item_Machine_ScrapTurret());
                ItemPack.Add("Molotov Cocktail", new Item_Molotov() { Count = 3 });
                ItemPack.Add("Teef", new Item_Teef() { Count = 100});
            }

        }
        public class orkClassPainboy : Class
        {
            public orkClassPainboy()
            {
                Title = "Painboy";
                Description = "The doctor Ork, they excel at support with resuscitation, healing, buffing and similar. Though accidents may occur and hilarity ensues. Primary ability is Intelligence, you don't need to know how to do it, as long as you know what to do.";
                traits.addTrait(new Trait_Class_Base_Ork_Painboy());
                Loadout.Add("Choppa", new Wpn_Choppa());
                Loadout.Add("Kill Saw", new Wpn_Killsaw());
                Loadout.Add("Shoota", new Wpn_Shoota());
                Loadout.Add("Slugga", new Wpn_Slugga());

                ItemPack.Add("Bag Squig", new Item_BagSquig());
                ItemPack.Add("Medkit", new Item_MedKit());
                ItemPack.Add("Gas Bulb", new Item_Bulb_Gas() { Count = 3 });
                ItemPack.Add("Stimpack", new Item_Stimpack() { Count = 3 });
                ItemPack.Add("Combat Stim", new Item_Stim_Combat() { Count = 3 });
                ItemPack.Add("Phys Stim", new Item_Stim_Phys() { Count = 3 });
                ItemPack.Add("Morphine", new Item_Stim_Morphine() { Count = 3 });
                ItemPack.Add("Teef", new Item_Teef() { Count = 100});
            }

        }
        public class orkClassKommando : Class
        {
            public orkClassKommando()
            {
                Title = "Kommando";
                Description = "The assassin Ork, they excel at stealth and killing. Kunnin'. Primary ability is Dexterity, sometimes less dakka is okay so long as you can aim.";
                traits.addTrait(new Trait_Class_Base_Ork_Kommando());
                Loadout.Add("Choppa", new Wpn_Choppa());
                Loadout.Add("Shoota", new Wpn_Shoota());
                Loadout.Add("Slugga", new Wpn_Slugga());

                ItemPack.Add("Bag Squig", new Item_BagSquig());
                ItemPack.Add("Gas Bulb", new Item_Bulb_Gas() { Count = 3 });
                ItemPack.Add("Vial of Acid", new Item_Vial_Acid() { Count = 3 });
                ItemPack.Add("Molotov Cocktail", new Item_Molotov() { Count = 3 });
                ItemPack.Add("Teef", new Item_Teef() { Count = 100});
            }

        }
        public class orkClassBeastSnagga : Class
        {
            public orkClassBeastSnagga()
            {
                Title = "Beast Snagga";
                Description = "The hunter-killer Ork, they excel at tracking, hunting and trapping, they also excel at handling, fighting and riding beasts. Often carry around a squig for any occasion. Primary ability is Wisdom";
                traits.addTrait(new Trait_Class_Base_Ork_BeastSnagga());
                Loadout.Add("Choppa", new Wpn_Choppa());
                Loadout.Add("Shoota", new Wpn_Shoota());
                Loadout.Add("Slugga", new Wpn_Slugga());

                ItemPack.Add("Bag Squig", new Item_BagSquig());
                ItemPack.Add("Teef", new Item_Teef() { Count = 100});
            }

        }
        
        public class orkClassWeirdboy : Class
        {
            public orkClassWeirdboy()
            {
                Title = "Weirdboy";
                Description = "Psyker caster Ork, they excel at crowd control, utility and are like walking time bombs. Primary ability is Wisdom";
                traits.addTrait(new Trait_Class_Base_Ork_Weirdboy());
                Loadout.Add("Choppa", new Wpn_Choppa());
                Loadout.Add("Shoota", new Wpn_Shoota());
                Loadout.Add("Slugga", new Wpn_Slugga());

                ItemPack.Add("Bag Squig", new Item_BagSquig());
                ItemPack.Add("Teef", new Item_Teef() { Count = 100});
            }

        }
}
