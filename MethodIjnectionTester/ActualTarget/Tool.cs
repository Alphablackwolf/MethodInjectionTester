// Decompiled with JetBrains decompiler
// Type: StardewValley.Tool
// Assembly: Stardew Valley, Version=1.2.6400.27469, Culture=neutral, PublicKeyToken=null
// MVID: 77B7094A-F6F0-4ACC-91F4-E335E2733EDB
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Stardew Valley\Stardew Valley.exe

using Microsoft.Xna.Framework;
using System;
using System.Xml.Serialization;
using MethodIjnectionTester;

namespace StardewValley
{
    public abstract class Tool : Item
    {
        public string name;
        [XmlIgnore]
        private string _description;
        public bool stackable;
        public int upgradeLevel;
        protected Farmer lastUser;
        [XmlIgnore]
        protected string displayName;

        protected override int Stack
        {
            get { return Stack; }
            set
            {
                if (!this.stackable)
                    return;
                this.Stack = Math.Min(Math.Max(0, value), this.maximumStackSize());
            }
        }

        public Tool()
        {
            this.category = -99;
        }

        public Farmer getLastFarmerToUse()
        {
            return this.lastUser;
        }

        public virtual void DoFunction(GameLocation location, int x, int y, int power, Farmer who)
        {
            Logger.LogInformation("base tool DoFunction thing.");
        }
    }
}
