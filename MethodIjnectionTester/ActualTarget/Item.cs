// Decompiled with JetBrains decompiler
// Type: StardewValley.Item
// Assembly: Stardew Valley, Version=1.2.6400.27469, Culture=neutral, PublicKeyToken=null
// MVID: 77B7094A-F6F0-4ACC-91F4-E335E2733EDB
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Stardew Valley\Stardew Valley.exe

using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Xml.Serialization;

namespace StardewValley
{
    [XmlInclude(typeof(Object))]
    [XmlInclude(typeof(Tool))]
    public abstract class Item : IComparable
    {
        public int specialVariable;
        public int category;


        protected virtual string DisplayName { get; set; }

        protected virtual string Name { get; }

        protected virtual int Stack { get; set; }

        public abstract int maximumStackSize();

        public virtual bool canBeTrashed()
        {
            return true;
        }

        public int CompareTo(object obj)
        {
            throw new NotImplementedException();
        }
    }
}
