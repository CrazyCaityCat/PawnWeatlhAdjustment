using RimWorld;
using Verse;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Reflection;

namespace PawnWealthAdjustment
{
    public class PriceUtility
    {
        static void Main(string[] args)

        {
            SimpleCurve newCurve = new SimpleCurve
        {
                 new CurvePoint(0f, 0.1f),
                 new CurvePoint(10f, 1f),
                 new CurvePoint(20f, 1.5f)
        };


            typeof(PriceUtility).GetField("AverageSkillCurve", BindingFlags.Static | BindingFlags.NonPublic).SetValue(null, newCurve);

        }

    }
}