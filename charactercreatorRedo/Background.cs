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
    public class orkBGRacer : Background
    {
        public orkBGRacer()
        {
            Title = "Racer";
            Description = "Youz a speed freek you iz! You know betta dan anyun els dat red 'uns go fasta. No 'unz gonna tell ya how ta pilot YER mek, cuz youz da bestest o' da best! \nProficiency with 2 Vehicles of your choice.";
        }

    }
}
