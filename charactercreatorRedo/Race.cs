using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace charactercreatorRedo
{
    public class Race
    {
        public string? Title { get; set; }
        public string? Description { get; set; }
        public List<Subrace> subraces { get; set; } = new List<Subrace>();
        public List<Trait> racials { get; set; } = new List<Trait>();
        public List<Background> backgrounds { get; set; } = new List<Background>();

    }

    public class Subrace
    {
        public string? Title { get; set; }
        public string? Description { get; set; }
        public List<Class> classes { get; set; } = new List<Class>();
        public List<Trait> racials { get; set; } = new List<Trait>();

    }

    public class RaceProgram
    {
        public static List<Race> races = new List<Race>();
        public static void Initialize()
        {
            //##### --- Humanity --- #####\\
            Race? raceHuman = new Race
            {
                Title = "Human"

            };
                Subrace? humanSubraceStandard = new Subrace
                {
                    Title = "Standard Human"

                };
                Subrace? humanSubraceOgryn = new Subrace
                {
                    Title = "Ogryn"

                };
                Subrace? humanSubraceRatling = new Subrace
                {
                    Title = "Ratling"

                };
                Subrace? humanSubraceSquat = new Subrace
                {
                    Title = "Squat"

                };
                Subrace? humanSubraceAstartes = new Subrace
                {
                    Title = "Astartes"

                };
                Subrace? humanSubraceMechanicus = new Subrace
                {
                    Title = "Mechanicus"

                };
                //raceHuman.subraces.Add(humanSubraceStandard); 
                //raceHuman.subraces.Add(humanSubraceOgryn); 
                //raceHuman.subraces.Add(humanSubraceRatling); 
                //raceHuman.subraces.Add(humanSubraceSquat);
                //raceHuman.subraces.Add(humanSubraceAstartes); 
                //raceHuman.subraces.Add(humanSubraceMechanicus);
            //races.Add(raceHuman);

            //##### --- Orkoids --- #####\\
            Race ? raceOrk = new Race
            {
                Title = "Ork"

            };
                Subrace? orkSubraceBoy = new Subrace
                {
                    Title = "Boy",
                    Description = "Orks are green-skinned and red-blooded, a side effect of their symbiotic physiological and genetic relationship with fungi. Orkoid physique itself is so robust that it can withstand tremendous punishment.\r\n\r\nOrks feel surprisingly little pain, even from the most grievous of wounds, enabling them to fight on whilst horrifically injured and even for a short while after being technically dead. It is most fortunate for the Orks that they can withstand such brutal physical punishment, since their Painboyz operate on a generally nineteenth-century (ca. 800-900.M2) level of surgical knowledge; unlike Humans, though, Orks are quite capable of being beheaded, having the head sewn onto a different body, and surviving the experience to fight again.\r\n\r\nIt is believed by some who study these brutes, albeit from afar, that this goes some way to explaining the greenskins' ultra-violent sense of humour. As pain and fear mean little to them, they are highly curious and amused by the reactions of their weaker foes as they hack them apart, the screams of terror contrasting with a deep throaty rumbling that, on occasion, could be mistaken for laughter from the Orks and their snickering brethren.\r\n\r\nThe greenskin regenerative process itself is so powerful that an Ork who has been hacked to bits can simply be stitched back together, bewildered but ready to fight once more. Nothing but the most grievous wounds will put an Ork down for long, and burning them to ash is reputed to be the only way to make absolutely sure that they are gone for good."

                };
                    orkSubraceBoy.racials.Add(new orkBoyRacialBase());
                    orkSubraceBoy.classes.Add(new orkClassShoota());
                    orkSubraceBoy.classes.Add(new orkClassWeirdboy());
                raceOrk.subraces.Add(orkSubraceBoy);

                Subrace? orkSubraceGretchin = new Subrace
                {
                    Title = "Gretchin",
                    Description = "Orkz! Test! 62496824096tu249062496024690246709246742098647906924970624907969709720690764904409970649444444444444444444444444444444444444444444444444444444444444444444444444444444444444444444444444444444444444444444444444444444444444444444444444444444444444444444444444444444442"
                };
                raceOrk.subraces.Add(orkSubraceGretchin);

                raceOrk.racials.Add(new orkRacialBase());
                raceOrk.racials.Add(new orkRacialPrimalIntuition());
                raceOrk.racials.Add(new commonTraitDarkvision());
                raceOrk.backgrounds.Add(new orkBGRacer());
            
            races.Add(raceOrk);


        }
    }
}
