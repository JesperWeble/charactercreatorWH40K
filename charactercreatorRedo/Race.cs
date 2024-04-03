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
                    Title = "Boy"

                };
                    orkSubraceBoy.classes.Add(new orkClassShoota());
                    orkSubraceBoy.classes.Add(new orkClassWeirdboy());
                raceOrk.subraces.Add(orkSubraceBoy);

                Subrace? orkSubraceGretchin = new Subrace
                {
                    Title = "Gretchin"

                };
                raceOrk.subraces.Add(orkSubraceGretchin);

            races.Add(raceOrk);


        }
    }
}
