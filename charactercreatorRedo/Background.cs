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


    //##### --- Common Backgrounds --- #####\\
    public class bgVisionairy : Background
    {
        public bgVisionairy()
        {
            Title = "Visionairy";
            Description = "You've received a vision or prophetic dream.";
        }

    }
    public class bgPilot : Background
    {
        public bgPilot()
        {
            Title = "Pilot";
            Description = "You feel at home in the sky, you're a skilled pilot capable of soaring through the sky in an aircraft.";
        }

    }

    //##### --- Ork Backgrounds --- #####\\
    public class orkBGSpeedFreek : Background
    {
        public orkBGSpeedFreek()
        {
            Title = "Speed Freek";
            Description = "Youz a speed freek you iz! You know betta dan anyun els dat red 'uns go fasta. No 'unz gonna tell ya how ta pilot YER mek, cuz youz da bestest o' da best! \nProficiency with 2 Vehicles of your choice.";
        }

    }

    public class orkBGGladiator : Background
    {
        public orkBGGladiator()
        {
            Title = "Speed Freek";
            Description = "Youz a speed freek you iz! You know betta dan anyun els dat red 'uns go fasta. No 'unz gonna tell ya how ta pilot YER mek, cuz youz da bestest o' da best! \nProficiency with 2 Vehicles of your choice.";
        }

    }

}
