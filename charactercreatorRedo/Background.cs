using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace charactercreatorRedo
{
    public class Background
    {
        public string? Title { get; set; }
        public string? Description { get; set; }
        public List<Trait> racials { get; set; } = new List<Trait>();
    }

    //##### --- Ork Backgrounds --- #####\\
    public class orkBGSpeedFreek : Class
    {
        public orkBGSpeedFreek()
        {
            Title = "Speed Freek";
        }

    }
}
