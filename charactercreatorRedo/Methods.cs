using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using charactercreatorRedo;

namespace charactercreatorRedo
{
    public static class TraitMethods
    {
        public static void addTrait(this List<Trait> targetList, Trait trait)
        {
            targetList.Add(trait);
            foreach (var subTrait in trait.traits)
            {
                targetList.Add(subTrait);
            }
            
        }
    }
}