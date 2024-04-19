using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace charactercreatorRedo
{
    public class Item
    {
        public string? Title { get; set; }
        public string? Description { get; set; }
        public string? Classification { get; set; }
        public int? Count { get; set; } = 1;

    }

    public class Item_Stikkbomb : Item
    {
        public Item_Stikkbomb()
        {
            Title = "Stikkbomb";
            Classification = "Explosive";
            Description = "Throwable stick that explodes for 1d3 damage in a 10ft radius.";

        }
    }
    public class Item_Stimpack : Item
    {
        public Item_Stimpack()
        {
            Title = "Stimpack";
            Classification = "Drug";
            Description = "Restore 3 hit points.";

        }
    }
    public class Item_Stim_Combat : Item
    {
        public Item_Stim_Combat()
        {
            Title = "Combat Stim";
            Classification = "Drug";
            Description = "+1 AC and +1 to hit AND wound rolls for 1 minute.";

        }
    }

    public class Item_Stim_Phys : Item
    {
        public Item_Stim_Phys()
        {
            Title = "Phys Stim";
            Classification = "Drug";
            Description = "Gain +2 to all your ability modifiers for 5 minutes.";

        }
    }

    public class Item_BagSquig : Item
    {
        public Item_BagSquig()
        {
            Title = "Bag Squig";
            Classification = "Pack";
            Description = "A squig dat funktions like a bag ta hold yer stuff an' all dat. Its stuffed with doodads, trinkets an' wotzit";

        }
    }
    public class Item_MedKit : Item
    {
        public Item_MedKit()
        {
            Title = "Medkit";
            Classification = "Kit";
            Description = "A pack full of all the things you'd need to tend to wounds and disease";

        }
    }

    public class Item_ToolKit : Item
    {
        public Item_ToolKit()
        {
            Title = "Tool Kit";
            Classification = "Kit";
            Description = "A pack full of all the things you'd need to tend to repair, craft, tinker, build etc.";

        }
    }

    public class Item_VoxComm : Item
    {
        public Item_VoxComm()
        {
            Title = "Vox Communicator";
            Classification = "Gadget";
            Description = "A communication device capable of connecting to other similar divices across the planet or even from orbit.";

        }
    }
    public class Item_Teef : Item
    {
        public Item_Teef()
        {
            Title = "Teef";
            Classification = "Currency";
            Description = "Ork teeth, used by the greenskins as currency.";

        }
    }
    public class Item_Molotov : Item
    {
        public Item_Molotov()
        {
            Title = "Molotov Cocktail";
            Classification = "Explosive";
            Description = "Throwable bottle that explodes into flames, upon impact deals 1 damage to target and coats a 5ft radius in flames. Standing in fire deals 1 damage at the start of your turn.";

        }
    }

    public class Item_Bulb_Gas : Item
    {
        public Item_Bulb_Gas()
        {
            Title = "Gas Bulb";
            Classification = "Explosive";
            Description = "Throwable bulb that when shattered coats a 5ft radius in deadly gas. Standing in the gas deals 1 damage at the start of your turn.";

        }
    }
    public class Item_Vial_Acid : Item
    {
        public Item_Vial_Acid()
        {
            Title = "Vial of Acid";
            Classification = "Vial";
            Description = "Creatures coated in acid have -1 AC.";

        }
    }

    public class Item_Stim_Morphine : Item
    {
        public Item_Stim_Morphine()
        {
            Title = "Morphine";
            Classification = "Drug";
            Description = "Grants 'Feel No Pain(4)' for 1 minute.";

        }
    }
    public class Item_GrapplingGun : Item
    {
        public Item_GrapplingGun()
        {
            Title = "Grappling Gun";
            Classification = "Gadget";
            Description = "A gun that fires a hook and wire that can retract forcefully.";

        }
    }
    public class Item_Machine_ScrapTurret : Item
    {
        public Item_Machine_ScrapTurret()
        {
            Title = "Scrap Turret";
            Classification = "Machine";
            Description = "An remote controlled gun turret. ATKS: 2,   AT: 4+,   DMG: 1";

        }
    }
    public class Item_ScrapJet : Item
    {
        public Item_ScrapJet()
        {
            Title = "Scrap Jet";
            Classification = "Gadget";
            Description = "A volatile jetpack. Jumps up to 60ft, roll 1d6, on a 1 it explodes violently.";

        }
    }

}
