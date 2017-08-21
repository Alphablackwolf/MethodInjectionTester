using System;
using System.Windows.Forms;
using MethodIjnectionTester.Extensions;
using MethodIjnectionTester.Source;
using MethodIjnectionTester.Target;
using SkillPrestige.Bonuses.Replacements;
using StardewValley;
using StardewValley.Tools;

namespace MethodIjnectionTester
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                new StardewValley.Tools.Shears().DoFunction(new GameLocation(), 0, 0, 0, new Farmer());
            }
            else
            {
                new Target.Shears().Use();
            }


        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                new ShearsReplacement().DoFunction(new GameLocation(), 0, 0, 0, new Farmer());
            }
            else
            {
                new BetterShears().Use();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                typeof(StardewValley.Tools.Shears).HookToMethod("DoFunction").ReplaceUsing<ShearsReplacement>();
            }
            else
            {
                typeof(Target.Shears).HookToMethod("Use").ReplaceUsing<BetterShears>();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                typeof(StardewValley.Tool).GetMethod("DoFunction").CheckPointers();
                typeof(StardewValley.Tools.Shears).GetMethod("DoFunction").CheckPointers();
                typeof(ShearsReplacement).GetMethod("DoFunction").CheckPointers();
                typeof(StardewValley.Tools.WateringCan).GetMethod("DoFunction").CheckPointers();
            }
            else
            {
                typeof(Target.Tool).GetMethod("Use").CheckPointers();
                typeof(Target.Shears).GetMethod("Use").CheckPointers();
                typeof(BetterShears).GetMethod("Use").CheckPointers();
                typeof(Target.WateringCan).GetMethod("Use").CheckPointers();
            }
            
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                new StardewValley.Tools.WateringCan().DoFunction(new GameLocation(), 0, 0, 0, new Farmer());
            }
            else
            {
                new Target.WateringCan().Use();
            }
        }
    }
}
