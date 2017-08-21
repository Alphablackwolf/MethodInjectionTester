// Decompiled with JetBrains decompiler
// Type: StardewValley.Tools.Shears
// Assembly: Stardew Valley, Version=1.2.6400.27469, Culture=neutral, PublicKeyToken=null
// MVID: 77B7094A-F6F0-4ACC-91F4-E335E2733EDB
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Stardew Valley\Stardew Valley.exe

using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using MethodIjnectionTester;

namespace StardewValley.Tools
{
    public class Shears : Tool
    {

        //public Shears()
        //    : base("Shears", -1, 7, 7, false, 0)
        //{
        //}

        public override void DoFunction(GameLocation location, int x, int y, int power, Farmer who)
        {
            base.DoFunction(location, x, y, power, who);
           Logger.LogInformation("Shears DoFunction.");
        }

        public override int maximumStackSize()
        {
            throw new NotImplementedException();
        }


    }
}
