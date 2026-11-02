using UnityEngine;
using Verse;

namespace BigSmallUniqueWeapons
{
    // ThingWithComps.DrawColor takes the first comp's ForceColor, so listing this before
    // CompProperties_UniqueWeapon keeps the base weapon's colours instead of a random tint.
    // A subclass of CompUniqueWeapon won't do: ThingDef.HasComp(Type) needs the exact class.
    public class CompKeepBaseColor : ThingComp
    {
        public override Color? ForceColor()
        {
            if (parent.Stuff != null)
            {
                return parent.def.GetColorForStuff(parent.Stuff);
            }
            return parent.def.graphicData?.color ?? Color.white;
        }
    }
}
