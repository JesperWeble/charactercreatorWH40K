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
    }
    //##### --- Ork Classes --- #####\\
        public class orkClassShoota : Class
        {
            public orkClassShoota()
            {
                Title = "Shoota Boy";
                Description = "The standard soldier Ork, they excel at firing various weaponry or hitting things very hard. Highly Versatile. Brutal. Their primary ability is Strength, you don't need good aim, just more dakka.";
                traits.addTrait(new trait_CF_Ork_Boy_Shoota_Base());
            }
        
        }
        public class orkClassWeirdboy : Class
        {
            public orkClassWeirdboy()
            {
                Title = "Weirdboy";
                Description = "Psyker caster Ork, they excel at crowd control, utility and are like walking time bombs. Primary ability is Wisdom";
            }

        }
        public class orkClassMekboy : Class
        {
            public orkClassMekboy()
            {
                Title = "Mekboy";
                Description = "The mechanic Ork, they excel at crafting, repairing, manipulating and piloting vehicles and mechs. Very good with explosives. Primary ability is Intelligence.";
            }

        }
        public class orkClassPainboy : Class
        {
            public orkClassPainboy()
            {
                Title = "Painboy";
                Description = "The doctor Ork, they excel at support with resuscitation, healing, buffing and similar. Though accidents may occur and hilarity ensues. Primary ability is Intelligence, you don't need to know how to do it, as long as you know what to do.";
            }

        }
        public class orkClassBeastSnagga : Class
        {
            public orkClassBeastSnagga()
            {
                Title = "Beast Snagga";
                Description = "The hunter-killer Ork, they excel at tracking, hunting and trapping, they also excel at handling, fighting and riding beasts. Often carry around a squig for any occasion. Primary ability is Wisdom";
            }

        }
        public class orkClassKommando : Class
        {
            public orkClassKommando()
            {
                Title = "Kommando";
                Description = "The assassin Ork, they excel at stealth and killing. Kunnin'. Primary ability is Dexterity, sometimes less dakka is okay so long as you can aim.";
            }

        }

}
