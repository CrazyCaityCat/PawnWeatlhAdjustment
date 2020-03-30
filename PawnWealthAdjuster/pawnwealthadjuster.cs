using RimWorld;
using System.Collections.Generic;
using System.Linq;
using Verse;
using HarmonyLib;
using UnityEngine;
using System.Reflection;

namespace PawnWealthAdjustement
{
    public class PawnWealthSettings : ModSettings
    {
        public float PawnSkillValue = 2f;

        public override void ExposeData()
        {
            base.ExposeData();
            Scribe_Values.Look(ref this.PawnSkillValue, "PawnSkillValue", 2f);
        }

        internal static PawnWealthSettings settings;
    }

    class PawnWealthAdjuster : Mod
    {
      private readonly  PawnWealthSettings settings;

        public PawnWealthAdjuster(ModContentPack content) : base(content)
        {
            this.settings = GetSettings<PawnWealthSettings>();
            PawnWealthSettings.settings = this.settings;
        }

        public override string SettingsCategory() => "Pawn Wealth";

        public override void DoSettingsWindowContents(Rect inRect)
        {
            this.settings.PawnSkillValue = Widgets.HorizontalSlider(inRect.TopHalf().TopHalf(), this.settings.PawnSkillValue, -10f, 10f, true, "Pawn Skill Value: " + this.settings.PawnSkillValue + "\nDetermines the value of a pawns skills", "5", "5");
        }

                public class PriceUtility
        {
            static void Main(string[] args)

            {
                SimpleCurve newCurve = new SimpleCurve
        {
                 new CurvePoint(0f, 0.1f),
                 new CurvePoint(10f, 0.75f),
                 new CurvePoint(20f, 1.5f)
        };


                typeof(PriceUtility).GetField("AverageSkillCurve", BindingFlags.Static | BindingFlags.NonPublic).SetValue(null, newCurve);

            }
        }
    }
}