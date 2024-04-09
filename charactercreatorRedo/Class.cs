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
        public List<Trait> traits { get; set; } = new List<Trait>();
    }
    //##### --- Ork Classes --- #####\\
        public class orkClassShoota : Class
        {
            public orkClassShoota()
            {
                Title = "Shoota Boy";
            }
        
        }
        public class orkClassWeirdboy : Class
        {
            public orkClassWeirdboy()
            {
                Title = "Weirdboy";
            }

        }
        public class orkClassMekboy : Class
        {
            public orkClassMekboy()
            {
                Title = "Mekboy";
            }

        }
        public class orkClassPainboy : Class
        {
            public orkClassPainboy()
            {
                Title = "Painboy";
            }

        }
        public class orkClassBeastSnagga : Class
        {
            public orkClassBeastSnagga()
            {
                Title = "Beast Snagga";
            }

        }
        public class orkClassKommando : Class
        {
            public orkClassKommando()
            {
                Title = "Kommando";
            }

        }

}
