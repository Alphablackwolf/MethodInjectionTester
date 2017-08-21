// Decompiled with JetBrains decompiler
// Type: StardewValley.Tools.WateringCan
// Assembly: Stardew Valley, Version=1.2.6400.27469, Culture=neutral, PublicKeyToken=null
// MVID: 77B7094A-F6F0-4ACC-91F4-E335E2733EDB
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Stardew Valley\Stardew Valley.exe

using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using MethodIjnectionTester;

namespace StardewValley.Tools
{
    public class WateringCan : Tool
    {
        private int waterLeft = 40;
        
        //public WateringCan()
        //    : base("Watering Can", 0, 273, 296, false, 0)
        //{
        //    this.upgradeLevel = 0;
        //}


        public override void DoFunction(GameLocation location, int x, int y, int power, Farmer who)
        {
            base.DoFunction(location, x, y, power, who);
            Logger.LogInformation("Watering Can DoFunction.");

        }

        public override int maximumStackSize()
        {
            throw new System.NotImplementedException();
        }


    }
}
