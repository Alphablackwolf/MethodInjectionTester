// Decompiled with JetBrains decompiler
// Type: StardewValley.Farmer
// Assembly: Stardew Valley, Version=1.2.6400.27469, Culture=neutral, PublicKeyToken=null
// MVID: 77B7094A-F6F0-4ACC-91F4-E335E2733EDB
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Stardew Valley\Stardew Valley.exe

using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace StardewValley
{
    public class Farmer : IComparable
    {

        public List<int> professions = new List<int>();
        public List<Point> newLevels = new List<Point>();
        private Queue<int> newLevelSparklingTexts = new Queue<int>();
        public int[] experiencePoints = new int[6];
        public List<int> dialogueQuestionsAnswered = new List<int>();
        public List<string> furnitureOwned = new List<string>();
        public List<int> eventsSeen = new List<int>();
        public List<string> songsHeard = new List<string>();
        public List<int> achievements = new List<int>();
        public List<int> specialItems = new List<int>();
        public List<int> specialBigCraftables = new List<int>();
        public List<string> mailReceived = new List<string>();
        public List<string> mailForTomorrow = new List<string>();
        public List<string> blueprints = new List<string>();

        public Tool[] toolBox = new Tool[30];
        public Object[] cupboard = new Object[30];
        [XmlIgnore]
        public List<int> movementDirections = new List<int>();
        public string farmName = "";
        public string favoriteThing = "";
        public List<object[]> multiplayerMessage = new List<object[]>();

        public long uniqueMultiplayerID = -6666666;
        [XmlIgnore]
        public string _tmpLocationName = "FarmHouse";
        [XmlIgnore]
        public string previousLocationName = "";
        public bool catPerson = true;
        public int accessory = -1;
        public int facialHair = -1;
        public int maxStamina = 270;
        public int maxItems = 12;
        public float stamina = 270f;
        public int money = 500;
        public int daysUntilHouseUpgrade = -1;
        public bool showChestColorPicker = true;

        private int craftingTime = 1000;
        private int raftPuddleCounter = 250;
        private int raftBobCounter = 1000;
        public int health = 100;
        public int maxHealth = 100;
        [XmlIgnore]
        public Vector2 jitter = Vector2.Zero;
        [XmlIgnore]
        public Vector2 lastGrabTile = Vector2.Zero;
        public bool isMale = true;
        [XmlIgnore]
        public bool canMove = true;
        [XmlIgnore]
        public Microsoft.Xna.Framework.Rectangle temporaryImpassableTile = Microsoft.Xna.Framework.Rectangle.Empty;
        public string bobber = "";
        public float movementMultiplier = 0.01f;
        public const int millisecondsPerSpeedUnit = 64;
        public const byte halt = 64;
        public const byte up = 1;
        public const byte right = 2;
        public const byte down = 4;
        public const byte left = 8;
        public const byte run = 16;
        public const byte release = 32;
        public const int FESTIVAL_WINNER = -9999;
        public const int farmingSkill = 0;
        public const int miningSkill = 3;
        public const int fishingSkill = 1;
        public const int foragingSkill = 2;
        public const int combatSkill = 4;
        public const int luckSkill = 5;
        public const float interpolationConstant = 0.5f;
        public const int runningSpeed = 5;
        public const int walkingSpeed = 2;
        public const int caveNothing = 0;
        public const int caveBats = 1;
        public const int caveMushrooms = 2;
        public const int millisecondsInvincibleAfterDamage = 1200;
        public const int millisecondsPerFlickerWhenInvincible = 50;
        public const int startingStamina = 270;
        public const int totalLevels = 35;
        public const int maxInventorySpace = 36;
        public const int hotbarSize = 12;
        public const int eyesOpen = 0;
        public const int eyesHalfShut = 4;
        public const int eyesClosed = 1;
        public const int eyesRight = 2;
        public const int eyesLeft = 3;
        public const int eyesWide = 5;
        public const int rancher = 0;
        public const int tiller = 1;
        public const int butcher = 2;
        public const int shepherd = 3;
        public const int artisan = 4;
        public const int agriculturist = 5;
        public const int fisher = 6;
        public const int trapper = 7;
        public const int angler = 8;
        public const int pirate = 9;
        public const int baitmaster = 10;
        public const int mariner = 11;
        public const int forester = 12;
        public const int gatherer = 13;
        public const int lumberjack = 14;
        public const int tapper = 15;
        public const int botanist = 16;
        public const int tracker = 17;
        public const int miner = 18;
        public const int geologist = 19;
        public const int blacksmith = 20;
        public const int burrower = 21;
        public const int excavator = 22;
        public const int gemologist = 23;
        public const int fighter = 24;
        public const int scout = 25;
        public const int brute = 26;
        public const int defender = 27;
        public const int acrobat = 28;
        public const int desperado = 29;

        //[XmlIgnore]
        //private Item activeObject;
        //public List<Item> items;
        //[XmlIgnore]
        //public Item mostRecentlyGrabbedItem;
        //[XmlIgnore]
        //public Item itemToEat;

        [XmlIgnore]
        public int toolPower;
        [XmlIgnore]
        public int toolHold;
        public Vector2 mostRecentBed;
        public int shirt;
        public int hair;
        public int skin;
        [XmlIgnore]
        public int currentEyes;
        [XmlIgnore]
        public int blinkTimer;
        [XmlIgnore]
        public int festivalScore;
        [XmlIgnore]
        public float temporarySpeedBuff;
        public Color hairstyleColor;
        public Color pantsColor;
        public Color newEyeColor;

        [XmlIgnore]
        public bool ridingMineElevator;
        [XmlIgnore]
        public bool mineMovementDirectionWasUp;
        [XmlIgnore]
        public bool cameFromDungeon;
        [XmlIgnore]
        public bool readyConfirmation;
        [XmlIgnore]
        public bool exhausted;
        [XmlIgnore]
        public bool divorceTonight;
        [XmlIgnore]

        public int deepestMineLevel;
        private int currentToolIndex;
        public int woodPieces;
        public int stonePieces;
        public int copperPieces;
        public int ironPieces;
        public int coalPieces;
        public int goldPieces;
        public int iridiumPieces;
        public int quartzPieces;
        public int caveChoice;
        public int feed;
        public int farmingLevel;
        public int miningLevel;
        public int combatLevel;
        public int foragingLevel;
        public int fishingLevel;
        public int luckLevel;
        public int newSkillPointsToSpend;
        public int addedFarmingLevel;
        public int addedMiningLevel;
        public int addedCombatLevel;
        public int addedForagingLevel;
        public int addedFishingLevel;
        public int addedLuckLevel;
        public int resilience;
        public int attack;
        public int immunity;
        public float attackIncreaseModifier;
        public float knockbackModifier;
        public float weaponSpeedModifier;
        public float critChanceModifier;
        public float critPowerModifier;
        public float weaponPrecisionModifier;
        public int clubCoins;
        public uint totalMoneyEarned;
        public uint millisecondsPlayed;
        public Tool toolBeingUpgraded;
        public int daysLeftForToolUpgrade;
        private float timeOfLastPositionPacket;
        private int numUpdatesSinceLastDraw;
        public int houseUpgradeLevel;
        public int coopUpgradeLevel;
        public int barnUpgradeLevel;
        public bool hasGreenhouse;
        public bool hasRustyKey;
        public bool hasSkullKey;
        public bool hasUnlockedSkullDoor;
        public bool hasDarkTalisman;
        public bool hasMagicInk;
        public int temporaryInvincibilityTimer;
        [XmlIgnore]
        public float rotation;
        public int timesReachedMineBottom;
        [XmlIgnore]
        public Vector2 lastPosition;
        [XmlIgnore]
        public float jitterStrength;
        [XmlIgnore]
        public float xOffset;
        [XmlIgnore]
        public bool running;
        [XmlIgnore]
        public bool usingTool;
        [XmlIgnore]
        public bool forceTimePass;
        [XmlIgnore]
        public bool isRafting;
        [XmlIgnore]
        public bool usingSlingshot;
        [XmlIgnore]
        public bool bathingClothes;
        [XmlIgnore]
        public bool canOnlyWalk;
        [XmlIgnore]
        public bool temporarilyInvincible;
        public bool hasBusTicket;
        public bool stardewHero;
        public bool hasClubCard;
        public bool hasSpecialCharm;
        [XmlIgnore]
        public bool canReleaseTool;
        [XmlIgnore]
        public bool isCrafting;
        public bool canUnderstandDwarves;

        [XmlIgnore]
        public Vector2 positionBeforeEvent;
        [XmlIgnore]
        public Vector2 remotePosition;
        [XmlIgnore]
        public int orientationBeforeEvent;
        [XmlIgnore]
        public int swimTimer;
        [XmlIgnore]
        public int timerSinceLastMovement;
        [XmlIgnore]
        public int noMovementPause;
        [XmlIgnore]
        public int freezePause;
        [XmlIgnore]
        public float yOffset;

        public string spouse;
        public string dateStringForSaveGame;
        public int? dayOfMonthForSaveGame;
        public int? seasonForSaveGame;
        public int? yearForSaveGame;
        public int overallsColor;
        public int shirtColor;
        public int skinColor;
        public int hairColor;
        public int eyeColor;
        [XmlIgnore]
        public Vector2 armOffset;

        public int saveTime;
        public int daysMarried;
        private int toolPitchAccumulator;
        private int charactercollisionTimer;


        [XmlIgnore]
        public int MaxItems
        {
            get
            {
                return this.maxItems;
            }
            set
            {
                this.maxItems = value;
            }
        }

        [XmlIgnore]
        public int Level
        {
            get
            {
                return (this.farmingLevel + this.fishingLevel + this.foragingLevel + this.combatLevel + this.miningLevel + this.luckLevel) / 2;
            }
        }

        [XmlIgnore]
        public int CraftingTime
        {
            get
            {
                return this.craftingTime;
            }
            set
            {
                this.craftingTime = value;
            }
        }

        [XmlIgnore]
        public int NewSkillPointsToSpend
        {
            get
            {
                return this.newSkillPointsToSpend;
            }
            set
            {
                this.newSkillPointsToSpend = value;
            }
        }

        [XmlIgnore]
        public int FarmingLevel
        {
            get
            {
                return this.farmingLevel + this.addedFarmingLevel;
            }
            set
            {
                this.farmingLevel = value;
            }
        }

        [XmlIgnore]
        public int MiningLevel
        {
            get
            {
                return this.miningLevel + this.addedMiningLevel;
            }
            set
            {
                this.miningLevel = value;
            }
        }

        [XmlIgnore]
        public int CombatLevel
        {
            get
            {
                return this.combatLevel + this.addedCombatLevel;
            }
            set
            {
                this.combatLevel = value;
            }
        }

        [XmlIgnore]
        public int ForagingLevel
        {
            get
            {
                return this.foragingLevel + this.addedForagingLevel;
            }
            set
            {
                this.foragingLevel = value;
            }
        }

        [XmlIgnore]
        public int FishingLevel
        {
            get
            {
                return this.fishingLevel + this.addedFishingLevel;
            }
            set
            {
                this.fishingLevel = value;
            }
        }

        [XmlIgnore]
        public int LuckLevel
        {
            get
            {
                return this.luckLevel + this.addedLuckLevel;
            }
            set
            {
                this.luckLevel = value;
            }
        }

        [XmlIgnore]
        public int HouseUpgradeLevel
        {
            get
            {
                return this.houseUpgradeLevel;
            }
            set
            {
                this.houseUpgradeLevel = value;
            }
        }

        [XmlIgnore]
        public int CoopUpgradeLevel
        {
            get
            {
                return this.coopUpgradeLevel;
            }
            set
            {
                this.coopUpgradeLevel = value;
            }
        }

        [XmlIgnore]
        public int BarnUpgradeLevel
        {
            get
            {
                return this.barnUpgradeLevel;
            }
            set
            {
                this.barnUpgradeLevel = value;
            }
        }

        [XmlIgnore]
        public Microsoft.Xna.Framework.Rectangle TemporaryImpassableTile
        {
            get
            {
                return this.temporaryImpassableTile;
            }
            set
            {
                this.temporaryImpassableTile = value;
            }
        }

        //[XmlIgnore]
        //public List<Item> Items
        //{
        //    get
        //    {
        //        return this.items;
        //    }
        //    set
        //    {
        //        this.items = value;
        //    }
        //}


        //[XmlIgnore]
        //public Object ActiveObject
        //{
        //    get
        //    {
        //        if (this.currentToolIndex < this.items.Count && this.items[this.currentToolIndex] != null && this.items[this.currentToolIndex] is Object)
        //            return (Object)this.items[this.currentToolIndex];
        //        return (Object)null;
        //    }
        //    set
        //    {
        //        if (value == null)
        //            this.removeItemFromInventory((Item)this.ActiveObject);
        //        else
        //            this.addItemToInventory((Item)value, this.CurrentToolIndex);
        //    }
        //}

        [XmlIgnore]
        public string Name
        {
            get
            {
                return string.Empty;
            }
            set
            {
                
            }
        }

        [XmlIgnore]
        public bool IsMale
        {
            get
            {
                return this.isMale;
            }
            set
            {
                this.isMale = value;
            }
        }

        [XmlIgnore]
        public List<int> DialogueQuestionsAnswered
        {
            get
            {
                return this.dialogueQuestionsAnswered;
            }
            set
            {
                this.dialogueQuestionsAnswered = value;
            }
        }

        [XmlIgnore]
        public int WoodPieces
        {
            get
            {
                return this.woodPieces;
            }
            set
            {
                this.woodPieces = value;
            }
        }

        [XmlIgnore]
        public int StonePieces
        {
            get
            {
                return this.stonePieces;
            }
            set
            {
                this.stonePieces = value;
            }
        }

        [XmlIgnore]
        public int CopperPieces
        {
            get
            {
                return this.copperPieces;
            }
            set
            {
                this.copperPieces = value;
            }
        }

        [XmlIgnore]
        public int IronPieces
        {
            get
            {
                return this.ironPieces;
            }
            set
            {
                this.ironPieces = value;
            }
        }

        [XmlIgnore]
        public int CoalPieces
        {
            get
            {
                return this.coalPieces;
            }
            set
            {
                this.coalPieces = value;
            }
        }

        [XmlIgnore]
        public int GoldPieces
        {
            get
            {
                return this.goldPieces;
            }
            set
            {
                this.goldPieces = value;
            }
        }

        [XmlIgnore]
        public int IridiumPieces
        {
            get
            {
                return this.iridiumPieces;
            }
            set
            {
                this.iridiumPieces = value;
            }
        }

        [XmlIgnore]
        public int QuartzPieces
        {
            get
            {
                return this.quartzPieces;
            }
            set
            {
                this.quartzPieces = value;
            }
        }

        [XmlIgnore]
        public int Feed
        {
            get
            {
                return this.feed;
            }
            set
            {
                this.feed = value;
            }
        }

        [XmlIgnore]
        public bool CanMove
        {
            get
            {
                return this.canMove;
            }
            set
            {
                this.canMove = value;
            }
        }

        [XmlIgnore]
        public bool UsingTool
        {
            get
            {
                return this.usingTool;
            }
            set
            {
                this.usingTool = value;
            }
        }

        //[XmlIgnore]
        //public Tool CurrentTool
        //{
        //    get
        //    {
        //        if (this.CurrentItem != null && this.CurrentItem is Tool)
        //            return (Tool)this.CurrentItem;
        //        return (Tool)null;
        //    }
        //    set
        //    {
        //        this.items[this.CurrentToolIndex] = (Item)value;
        //    }
        //}

        //[XmlIgnore]
        //public Item CurrentItem
        //{
        //    get
        //    {
        //        if (this.currentToolIndex >= this.items.Count)
        //            return (Item)null;
        //        return this.items[this.currentToolIndex];
        //    }
        //}

        //[XmlIgnore]
        //public int CurrentToolIndex
        //{
        //    get
        //    {
        //        return this.currentToolIndex;
        //    }
        //    set
        //    {
        //        if (this.currentToolIndex >= 0 && this.CurrentItem != null && value != this.currentToolIndex)
        //            this.CurrentItem.actionWhenStopBeingHeld(this);
        //        this.currentToolIndex = value;
        //    }
        //}

        [XmlIgnore]
        public float Stamina
        {
            get
            {
                return this.stamina;
            }
            set
            {
                this.stamina = Math.Min((float)this.maxStamina, Math.Max(value, -16f));
            }
        }

        [XmlIgnore]
        public int MaxStamina
        {
            get
            {
                return this.maxStamina;
            }
            set
            {
                this.maxStamina = value;
            }
        }

        [XmlIgnore]
        public bool IsMainPlayer
        {
            get
            {
                return true;
            }
        }




        [XmlIgnore]
        public int Money
        {
            get
            {
                return this.money;
            }
            set
            {
                if (value > this.money)
                {
                    this.totalMoneyEarned = this.totalMoneyEarned + (uint)(value - this.money);
                }
                else
                {
                    int money = this.money;
                }
                this.money = value;
            }
        }

        public Farmer()
        {

        }



        public  void SetMovingDown(bool b)
        {
            this.setMoving((byte)(4 + (b ? 0 : 32)));
        }

        public  void SetMovingRight(bool b)
        {
            this.setMoving((byte)(2 + (b ? 0 : 32)));
        }

        public  void SetMovingUp(bool b)
        {
            this.setMoving((byte)(1 + (b ? 0 : 32)));
        }

        public  void SetMovingLeft(bool b)
        {
            this.setMoving((byte)(8 + (b ? 0 : 32)));
        }
        


        

        public void gainExperience(int which, int howMuch)
        {
            if (which == 5 || howMuch <= 0)
                return;
            int num1 = Farmer.checkForLevelGain(this.experiencePoints[which], this.experiencePoints[which] + howMuch);
            this.experiencePoints[which] += howMuch;
            int num2 = -1;
            if (num1 != -1)
            {
                switch (which)
                {
                    case 0:
                        num2 = this.farmingLevel;
                        this.farmingLevel = num1;
                        break;
                    case 1:
                        num2 = this.fishingLevel;
                        this.fishingLevel = num1;
                        break;
                    case 2:
                        num2 = this.foragingLevel;
                        this.foragingLevel = num1;
                        break;
                    case 3:
                        num2 = this.miningLevel;
                        this.miningLevel = num1;
                        break;
                    case 4:
                        num2 = this.combatLevel;
                        this.combatLevel = num1;
                        break;
                    case 5:
                        num2 = this.luckLevel;
                        this.luckLevel = num1;
                        break;
                }
            }
            if (num1 <= num2)
                return;
            for (int y = num2 + 1; y <= num1; ++y)
            {
                this.newLevels.Add(new Point(which, y));
                int count = this.newLevels.Count;
            }
        }

        public int getEffectiveSkillLevel(int whichSkill)
        {
            if (whichSkill < 0 || whichSkill > 5)
                return -1;
            int[] numArray = new int[6] { this.farmingLevel, this.fishingLevel, this.foragingLevel, this.miningLevel, this.combatLevel, this.luckLevel };
            for (int index = 0; index < this.newLevels.Count; ++index)
                numArray[this.newLevels[index].X] -= this.newLevels[index].Y;
            return numArray[whichSkill];
        }

        public static int checkForLevelGain(int oldXP, int newXP)
        {
            int num = -1;
            if (oldXP < 100 && newXP >= 100)
                num = 1;
            if (oldXP < 380 && newXP >= 380)
                num = 2;
            if (oldXP < 770 && newXP >= 770)
                num = 3;
            if (oldXP < 1300 && newXP >= 1300)
                num = 4;
            if (oldXP < 2150 && newXP >= 2150)
                num = 5;
            if (oldXP < 3300 && newXP >= 3300)
                num = 6;
            if (oldXP < 4800 && newXP >= 4800)
                num = 7;
            if (oldXP < 6900 && newXP >= 6900)
                num = 8;
            if (oldXP < 10000 && newXP >= 10000)
                num = 9;
            if (oldXP < 15000 && newXP >= 15000)
                num = 10;
            return num;
        }
        

        public bool tryToCraftItem(List<int[]> ingredients, double successRate, int itemToCraft, bool bigCraftable, string craftingOrCooking)
        {
            List<int[]> locationOfIngredients = new List<int[]>();
            foreach (int[] ingredient in ingredients)
            {
                if (ingredient[0] <= -100)
                {
                    int num = 0;
                    switch (ingredient[0])
                    {
                        case -106:
                            num = this.IridiumPieces;
                            break;
                        case -105:
                            num = this.GoldPieces;
                            break;
                        case -104:
                            num = this.CoalPieces;
                            break;
                        case -103:
                            num = this.IronPieces;
                            break;
                        case -102:
                            num = this.CopperPieces;
                            break;
                        case -101:
                            num = this.stonePieces;
                            break;
                        case -100:
                            num = this.WoodPieces;
                            break;
                    }
                    if (num < ingredient[1])
                        return false;
                    locationOfIngredients.Add(ingredient);
                }
            }
            
            return true;
        }

        private static bool containsIndex(List<int[]> locationOfIngredients, int index)
        {
            for (int index1 = 0; index1 < locationOfIngredients.Count; ++index1)
            {
                if (locationOfIngredients[index1][0] == index)
                    return true;
            }
            return false;
        }


        public void changeIntoSwimsuit()
        {
            this.bathingClothes = true;
            this.Halt();
            this.setRunning(false, false);
            this.canOnlyWalk = true;
        }


        public bool ownsFurniture(string name)
        {
            foreach (string str in this.furnitureOwned)
            {
                if (str.Equals(name))
                    return true;
            }
            return false;
        }
        
        public bool couldInventoryAcceptThisObject(int index, int stack, int quality = 0)
        {
            for (int index1 = 0; index1 < this.maxItems; ++index1)
            {

                    return true;
            }

            return false;
        }

        public bool hasItemOfType(string type)
        {
            for (int index = 0; index < this.maxItems; ++index)
            {
                    return true;
            }
            return false;
        }
        
        
        

        public void setMoving(byte command)
        {
            bool flag = false;
            if (this.movementDirections.Count < 2)
            {
                if ((int)command == 1 && !this.movementDirections.Contains(0) && !this.movementDirections.Contains(2))
                {
                    this.movementDirections.Insert(0, 0);
                    flag = true;
                }
                if ((int)command == 2 && !this.movementDirections.Contains(1) && !this.movementDirections.Contains(3))
                {
                    this.movementDirections.Insert(0, 1);
                    flag = true;
                }
                if ((int)command == 4 && !this.movementDirections.Contains(2) && !this.movementDirections.Contains(0))
                {
                    this.movementDirections.Insert(0, 2);
                    flag = true;
                }
                if ((int)command == 8 && !this.movementDirections.Contains(3) && !this.movementDirections.Contains(1))
                {
                    this.movementDirections.Insert(0, 3);
                    flag = true;
                }
            }
            if ((int)command == 33)
            {
                this.movementDirections.Remove(0);
                flag = true;
            }
            if ((int)command == 34)
            {
                this.movementDirections.Remove(1);
                flag = true;
            }
            if ((int)command == 36)
            {
                this.movementDirections.Remove(2);
                flag = true;
            }
            if ((int)command == 40)
            {
                this.movementDirections.Remove(3);
                flag = true;
            }
            if ((int)command == 16)
            {
                this.setRunning(true, false);
                flag = true;
            }
            else if ((int)command == 48)
            {
                this.setRunning(false, false);
                flag = true;
            }
            if (((int)command & 64) == 64)
            {
                this.Halt();
                this.running = false;
                flag = true;
            }

        }


        public void lerpPosition(Vector2 target)
        {

        }



        public static string getSkillDisplayNameFromIndex(int index)
        {
                    return "";
        }

        public bool isMoving()
        {
            return this.movementDirections.Count > 0;
        }

        public bool hasCompletedCommunityCenter()
        {
            if (this.mailReceived.Contains("ccBoilerRoom") && this.mailReceived.Contains("ccCraftsRoom") && (this.mailReceived.Contains("ccPantry") && this.mailReceived.Contains("ccFishTank")) && this.mailReceived.Contains("ccVault"))
                return this.mailReceived.Contains("ccBulletin");
            return false;
        }

      
        public float getMovementSpeed()
        {

            return 1;
        }

        public void Halt()
        {

        }

        public void stopJittering()
        {
            this.jitterStrength = 0.0f;
            this.jitter = Vector2.Zero;
        }

        public Microsoft.Xna.Framework.Rectangle nextPosition(int direction)
        {
            Microsoft.Xna.Framework.Rectangle boundingBox = new Rectangle();
            switch (direction)
            {
                case 0:
                    boundingBox.Y -= (int)Math.Ceiling((double)this.getMovementSpeed());
                    break;
                case 1:
                    boundingBox.X += (int)Math.Ceiling((double)this.getMovementSpeed());
                    break;
                case 2:
                    boundingBox.Y += (int)Math.Ceiling((double)this.getMovementSpeed());
                    break;
                case 3:
                    boundingBox.X -= (int)Math.Ceiling((double)this.getMovementSpeed());
                    break;
            }
            return boundingBox;
        }

        public Microsoft.Xna.Framework.Rectangle nextPositionHalf(int direction)
        {
            Microsoft.Xna.Framework.Rectangle boundingBox = new Rectangle();
            switch (direction)
            {
                case 0:
                    boundingBox.Y -= (int)Math.Ceiling((double)this.getMovementSpeed() / 2.0);
                    break;
                case 1:
                    boundingBox.X += (int)Math.Ceiling((double)this.getMovementSpeed() / 2.0);
                    break;
                case 2:
                    boundingBox.Y += (int)Math.Ceiling((double)this.getMovementSpeed() / 2.0);
                    break;
                case 3:
                    boundingBox.X -= (int)Math.Ceiling((double)this.getMovementSpeed() / 2.0);
                    break;
            }
            return boundingBox;
        }

        public int getProfessionForSkill(int skillType, int skillLevel)
        {
            if (skillLevel == 5)
            {
                switch (skillType)
                {
                    case 0:
                        if (this.professions.Contains(0))
                            return 0;
                        if (this.professions.Contains(1))
                            return 1;
                        break;
                    case 1:
                        if (this.professions.Contains(6))
                            return 6;
                        if (this.professions.Contains(7))
                            return 7;
                        break;
                    case 2:
                        if (this.professions.Contains(12))
                            return 12;
                        if (this.professions.Contains(13))
                            return 13;
                        break;
                    case 3:
                        if (this.professions.Contains(18))
                            return 18;
                        if (this.professions.Contains(19))
                            return 19;
                        break;
                    case 4:
                        if (this.professions.Contains(24))
                            return 24;
                        if (this.professions.Contains(25))
                            return 25;
                        break;
                }
            }
            else if (skillLevel == 10)
            {
                switch (skillType)
                {
                    case 0:
                        if (this.professions.Contains(1))
                        {
                            if (this.professions.Contains(4))
                                return 4;
                            if (this.professions.Contains(5))
                                return 5;
                            break;
                        }
                        if (this.professions.Contains(2))
                            return 2;
                        if (this.professions.Contains(3))
                            return 3;
                        break;
                    case 1:
                        if (this.professions.Contains(6))
                        {
                            if (this.professions.Contains(8))
                                return 8;
                            if (this.professions.Contains(9))
                                return 9;
                            break;
                        }
                        if (this.professions.Contains(10))
                            return 10;
                        if (this.professions.Contains(11))
                            return 11;
                        break;
                    case 2:
                        if (this.professions.Contains(12))
                        {
                            if (this.professions.Contains(14))
                                return 14;
                            if (this.professions.Contains(15))
                                return 15;
                            break;
                        }
                        if (this.professions.Contains(16))
                            return 16;
                        if (this.professions.Contains(17))
                            return 17;
                        break;
                    case 3:
                        if (this.professions.Contains(18))
                        {
                            if (this.professions.Contains(20))
                                return 20;
                            if (this.professions.Contains(21))
                                return 21;
                            break;
                        }
                        if (this.professions.Contains(23))
                            return 23;
                        if (this.professions.Contains(22))
                            return 22;
                        break;
                    case 4:
                        if (this.professions.Contains(24))
                        {
                            if (this.professions.Contains(26))
                                return 26;
                            if (this.professions.Contains(27))
                                return 27;
                            break;
                        }
                        if (this.professions.Contains(28))
                            return 28;
                        if (this.professions.Contains(29))
                            return 29;
                        break;
                }
            }
            return -1;
        }

       
        public void setRunning(bool isRunning, bool force = false)
        {

        }

        public int CompareTo(object obj)
        {
            throw new NotImplementedException();
        }
    }
}
