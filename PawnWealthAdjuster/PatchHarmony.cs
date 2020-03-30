using HarmonyLib;
using System.Reflection;
using Verse;

namespace PawnWealthAdjuster
{
    [StaticConstructorOnStartup]
    public class PawnWealthAdjuster
    {
        static PawnWealthAdjuster()
        {
            var harmony = new Harmony("Crazycaitycat.PawnWealthAdjuster");
            harmony.PatchAll(Assembly.GetExecutingAssembly());
        }
    }
}