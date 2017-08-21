using System;
using MethodIjnectionTester;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using StardewValley;

namespace SkillPrestige.Bonuses.Replacements
{
    /// <summary>
    /// A holder to contain replacement routines for the Stardew Valley Shears class.
    /// </summary>
    // ReSharper disable once ClassNeverInstantiated.Global - is used through reflection.
    public class ShearsReplacement : StardewValley.Tool
    {

        /// <summary>
        /// For some reason without this constructor the DoFunction code will cause execution exceptions at runtime.
        /// </summary>
        //public ShearsReplacement()
        //    : base("Shears", -1, 7, 7, false)
        //{
        //}

        /// <summary>
        /// Replaces the existing DoFunction in Shears, adding a quantity increase.
        /// </summary>
        /// <param name="location"></param>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <param name="power"></param>
        /// <param name="who"></param>
        public new void DoFunction(GameLocation location, int x, int y, int power, StardewValley.Farmer who)
        {
            Logger.LogInformation("using replacement shears DoFunction...");
            base.DoFunction(location, x, y, power, who);
            Logger.LogInformation("<The rest of the replacement shears DoFunction.>");
        }

        public override int maximumStackSize()
        {
            throw new NotImplementedException();
        }


    }
}
