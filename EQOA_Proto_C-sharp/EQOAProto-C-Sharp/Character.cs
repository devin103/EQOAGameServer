

using System;
using System.Collections.Generic;

namespace Characters
{
	public class Character
	{
		//List to hold gear values for model, color, and equip location
		public List<Tuple<uint, uint, byte>> GearList = new List<Tuple<uint, uint, byte>>();
		//Attributes a character may have
		public string CharName { get; set; }
		public int ServerID { get; set; }
		public long ModelID { get; set; }
		public int TClass { get; set; }
		public int Race { get; set; }
		public String HumType { get; set; }
		public int Level { get; set; }
		public int HairColor { get; set; }
		public int HairLength { get; set; }
		public int HairStyle { get; set; }
		public int FaceOption { get; set; }
		public int ClassIcon { get; set; }
		public int TotalXP { get; set; }
		public int Debt { get; set; }
		public int Breath { get; set; }
		public int Tunar { get; set; }
		public int BankTunar { get; set; }
		public int UnusedTP { get; set; }
		public int TotalTP { get; set; }
		public float XCoord { get; set; }
		public float YCoord { get; set; }
		public float Facing { get; set; }
		public int Strength { get; set; }
		public int Stamina { get; set; }
		public int Agility { get; set; }
		public int Dexterity { get; set; }
		public int Wisdom { get; set; }
		public int Intelligence { get; set; }
		public int Charisma { get; set; }
		public int CurrentHP { get; set; }
		public int MaxHP { get; set; }
		public int CurrentPower { get; set; }
		public int MaxPower { get; set; }
		public float ZCoord { get; set; }
		public int HealOT { get; set; }
		public int PowerOT { get; set; }
		public int Ac { get; set; }
		public int PoisonResist { get; set; }
		public int DiseaseResist { get; set; }
		public int FireResist { get; set; }
		public int ColdResist { get; set; }
		public int LightningResist { get; set; }
		public int ArcaneResist { get; set; }
		public int Fishing { get; set; }
		public int BaseStrength { get; set; }
		public int BaseStamina { get; set; }
		public int BaseAgility { get; set; }
		public int BaseDexterity { get; set; }
		public int BaseWisdom { get; set; }
		public int BaseIntelligence { get; set; }
		public int BaseCharisma { get; set; }
		public int CurrentHP2 { get; set; }
		public int BaseHP { get; set; }
		public int CurrentPower2 { get; set; }
		public int BasePower { get; set; }
		public int HealOT2 { get; set; }
		public int PowerOT2 { get; set; }

		///Armor
		public byte Helm = 0;
		public byte Chest = 0;
		public byte Gloves = 0;
		public byte Bracer = 0;
		public byte Legs = 0;
		public byte Boots = 0;
		public uint Robe = 0xFFFFFFFF;
		public uint Primary = 0;
		public uint Secondary = 0;
		public uint Shield = 0;

		///Armor color
		public uint HelmColor = 0xFFFFFFFF;
		public uint ChestColor = 0xFFFFFFFF;
		public uint GlovesColor = 0xFFFFFFFF;
		public uint BracerColor = 0xFFFFFFFF;
		public uint LegsColor = 0xFFFFFFFF;
		public uint BootsColor = 0xFFFFFFFF;
		public uint RobeColor = 0xFFFFFFFF;

		//Dictionary mapping the client value to the string value expected in the DB
		//Eastern Human = 1, Western Human = 2, All non humans = 0
		public readonly Dictionary<int, string> HumTypeDict = new Dictionary<int, string>
		{
			{0, "Other" },
			{1, "Freeport" },
			{2, "Qeynos" }
		};

		//Dictionary mapping the client value to the string value expected in the DB for Player Class
		public readonly Dictionary<int, string> CharClassDict = new Dictionary<int, string>
		{
			{0, "WAR" },  {1, "RAN" }, {2, "PAL" }, {3, "SK" }, {4, "MNK" },{5, "BRD" }, {6, "RGE" },
			{7, "DRD" }, {8, "SHA" }, {9, "CL" }, {10, "MAG" }, {11, "NEC" },{12, "ENC" }, {13, "WIZ" }, {14, "ALC" }
		};

		//Dictionary mapping the client value to the string value expected in the DB for Player Race
		public readonly Dictionary<int, string> CharRaceDict = new Dictionary<int, string>
		{
			{0, "HUM" }, {1, "ELF" }, {2, "DELF" }, {3, "GNO" }, {4, "DWF" }, {5, "TRL" }, {6, "BAR" }, {7, "HLF" },
			{8, "ERU" }, {9, "OGR" }
		};

		//Dictionary mapping the client value to the string value expected in the DB for Player Gender
		public readonly Dictionary<int, string> CharSexDict = new Dictionary<int, string>
		{
			{0, "Male" }, {1, "Female"}
		};


		/* These are all values for character creation, likely don't need to be attributes of the character object at all*/
		public string TestCharName { get; set; }
		public int StartingClass { get; set; }
		public int Gender { get; set; }
		//Note this is for holding the HumType from the client that is an int and base Character has a string HumType
		public int HumTypeNum { get; set; }
		//Addxxxx attributes of the class are to hold a new characters initial allocated stat points in each category
		public int AddStrength { get; set; }
		public int AddStamina { get; set; }
		public int AddAgility { get; set; }
		public int AddDexterity { get; set; }
		public int AddWisdom { get; set; }
		public int AddIntelligence { get; set; }
		public int AddCharisma { get; set; }
		//Defaultxxx attributes of the class pulled from the defaultClass table in the DB for new character creation
		public int DefaultStrength { get; set; }
		public int DefaultStamina { get; set; }
		public int DefaultAgility { get; set; }
		public int DefaultDexterity { get; set; }
		public int DefaultWisdom { get; set; }
		public int DefaultIntelligence { get; set; }
		public int DefaultCharisma { get; set; }

		//Overwrite to ToString Method to allow for direct enumeration of the object for characterName. Could be expanded for additional attributes.
		public override string ToString()
		{
			return "Character Data: " + CharName;
		}

	}
}