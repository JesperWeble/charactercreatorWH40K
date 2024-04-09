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
            raceOrk.racials.addTrait(new orkRacialBase());
                Subrace? orkSubraceBoy = new Subrace
                {
                    Title = "Boy",
                    Description = "Orks are green-skinned and red-blooded, a side effect of their symbiotic physiological and genetic relationship with fungi. Orkoid physique itself is so robust that it can withstand tremendous punishment.\r\n\r\nOrks feel surprisingly little pain, even from the most grievous of wounds, enabling them to fight on whilst horrifically injured and even for a short while after being technically dead. It is most fortunate for the Orks that they can withstand such brutal physical punishment, since their Painboyz operate on a generally nineteenth-century (ca. 800-900.M2) level of surgical knowledge; unlike Humans, though, Orks are quite capable of being beheaded, having the head sewn onto a different body, and surviving the experience to fight again.\r\n\r\nIt is believed by some who study these brutes, albeit from afar, that this goes some way to explaining the greenskins' ultra-violent sense of humour. As pain and fear mean little to them, they are highly curious and amused by the reactions of their weaker foes as they hack them apart, the screams of terror contrasting with a deep throaty rumbling that, on occasion, could be mistaken for laughter from the Orks and their snickering brethren.\r\n\r\nThe greenskin regenerative process itself is so powerful that an Ork who has been hacked to bits can simply be stitched back together, bewildered but ready to fight once more. Nothing but the most grievous wounds will put an Ork down for long, and burning them to ash is reputed to be the only way to make absolutely sure that they are gone for good.",
                    
                };
                    orkSubraceBoy.racials.addTrait(new orkBoyRacialBase());
                    orkSubraceBoy.classes.Add(new orkClassShoota());
                    orkSubraceBoy.classes.Add(new orkClassMekboy());
                    orkSubraceBoy.classes.Add(new orkClassPainboy());
                    orkSubraceBoy.classes.Add(new orkClassKommando());
                    orkSubraceBoy.classes.Add(new orkClassBeastSnagga());
                    orkSubraceBoy.classes.Add(new orkClassWeirdboy());
                raceOrk.subraces.Add(orkSubraceBoy);

                Subrace? orkSubraceGretchin = new Subrace
                {
                    Title = "Gretchin",
                    Description = "Although they possess a similar physiology to the Orks, Gretchin are not as strong or as tough as their larger brethren.\r\n\r\nTo compensate for this, the Gretchin possess an abundance of low cunning. Commonly known as \"Grots\" to the Orks, Gretchin are even more numerous than Orks. They scurry around the larger greenskins on scrawny legs, and their grasping fingers snatch and steal from the unwary.\r\n\r\nGretchin have large, bulbous heads and wide tattered ears that flatten against their bald pates when they are afraid (which is most of the time). Sharp fangs fill their jaws, ever-ready to be sunk into the flesh of the weak or infirm, and malice gleams in their eyes whenever there is an opportunity for violence.\r\n\r\nThe Grots' large and protruberant noses give them an excellent sense of smell, their ears afford them a similarly advanced sense of hearing, and their eyesight is acute even in the dark.\r\n\r\nThese traits, combined with a heightened instinct for self-preservation, mean that Gretchin can not only survive but even thrive in a society dominated by vicious predators.\r\n\r\nSome Grots have their survival instinct honed to such a degree that they may possess a rudimentary sixth sense, or are naturally far more fortunate than they have any right to be.\r\n\r\nThe Grots improve their chances of survival further by exhibiting a fawning and obsequious nature to their Ork masters. Though braver Gretchin will pull faces and make rude gestures behind the backs of the bigger greenskins, few are stupid enough to risk doing so openly.\r\n\r\nGrots are fast learners and quick to spot an opportunity, meaning that many wind up as assistants or servants to more important Orks like Mekboyz or Nobz. Others will simply attempt to stay out of the Orks' way, whole groups of Grots fashioning hideouts amid scrap piles or warrens of tunnels too constricted for Orks to squeeze their bulk down."
                };
                    orkSubraceGretchin.racials.addTrait(new orkGrotRacialBase());
                

                    orkSubraceGretchin.classes.Add(new orkClassShoota());
                    orkSubraceGretchin.classes.Add(new orkClassMekboy());
                    orkSubraceGretchin.classes.Add(new orkClassPainboy());
                    orkSubraceGretchin.classes.Add(new orkClassKommando());
                    orkSubraceGretchin.classes.Add(new orkClassBeastSnagga());
                    orkSubraceGretchin.classes.Add(new orkClassWeirdboy());
                raceOrk.subraces.Add(orkSubraceGretchin);

                raceOrk.backgrounds.Add(new orkBGRacer());
            
            races.Add(raceOrk);


        }
    }
}
