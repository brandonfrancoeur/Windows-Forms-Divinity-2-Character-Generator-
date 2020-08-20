using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Divinity_2_Character_Generator
{
    public partial class DivinityCharGen : Form
    {
        Data charData;
        public DivinityCharGen()
        {
            InitializeComponent();
        }

       
        private void generate_Click(object sender, EventArgs e)
        {
            charData = new Data();
            String inst = getRand(charData.instruments);
            charData.instrument = inst;
            getOrigin(charData);

            if (presetBox.Checked)
            {
                presetClass(charData);
                generateTags(charData);
                skillOneBox.Text = charData.skill1;
                skillTwoBox.Text = charData.skill2;
                skillThreeBox.Text = charData.skill3;
                classBox.Text = charData.preset;
            }
            else
            {
                distributeAtts(charData);
                generateCivils(charData);
                generateTags(charData);
                generateTalent(charData);
                generateSkills(charData);
                skillOneBox.Text = charData.skills[0];
                skillTwoBox.Text = charData.skills[1];
                skillThreeBox.Text = charData.skills[2];
            }
            strengthBox.Text = charData.strength.ToString();
            finesseBox.Text = charData.finesse.ToString();
            intelligenceBox.Text = charData.intelligence.ToString();
            constBox.Text = charData.constitution.ToString();
            memoryBox.Text = charData.memory.ToString();
            witsBox.Text = charData.wits.ToString();
            originBox.Text = charData.origin;
            tag1Box.Text = charData.tag1;
            tag2Box.Text = charData.tag2;
            dualBox.Text = charData.dual_wielding.ToString();
            rangedBox.Text = charData.ranged.ToString();
            singleBox.Text = charData.single_handed.ToString();
            twoHBox.Text = charData.two_handed.ToString();
            perseveranceBox.Text = charData.perseverance.ToString();
            retBox.Text = charData.retribution.ToString();
            warfareBox.Text = charData.warfare.ToString();
            huntsmanBox.Text = charData.huntsman.ToString();
            scoundrelBox.Text = charData.scoundrel.ToString();
            pyroBox.Text = charData.pyrokinetic.ToString();
            aeroBox.Text = charData.aerothurge.ToString();
            geoBox.Text = charData.geomancer.ToString();
            necroBox.Text = charData.necromancer.ToString();
            sumBox.Text = charData.summoning.ToString();
            polyBox.Text = charData.polymorph.ToString();
            barterBox.Text = charData.bartering.ToString();
            luckyCharmBox.Text = charData.lucky_charm.ToString();
            loremasterBox.Text = charData.loremaster.ToString();
            teleBox.Text = charData.telekinesis.ToString();
            sneakBox.Text = charData.sneaking.ToString();
            thieveryBox.Text = charData.thievery.ToString();
            instrumentBox.Text = charData.instrument;
            talentOneBox.Text = charData.Talent1;
            talentTwoBox.Text = charData.Talent2;
            talentThreeBox.Text = charData.Talent3;
        }
        public String getRand(String[] myArray)
        {
            Random r = new Random();
            int rInt = r.Next(0, myArray.Length);
            return myArray[rInt];
        }
        public void presetClass(Data charData)
        {
            String preset = getRand(charData.preset_classes);
            switch (preset)
            {
                case "battlemage":
                    charData.preset = "Battlemage";
                    charData.Talent3 = "Comeback Kid";

                    charData.strength++;
                    charData.intelligence++;
                    charData.constitution++;
                    charData.aerothurge++;
                    charData.warfare++;
                    charData.persuasion++;

                    charData.skill1 = "Blinding Radiance";
                    charData.skill2 = "Shocking Touch";
                    charData.skill3 = "Battering Ram";
                    break;


                case "Cleric":
                    charData.preset = "Cleric";
                    charData.Talent3 = "Hothead";

                    charData.strength++;
                    charData.intelligence++;
                    charData.constitution++;
                    charData.hydrosophist++;
                    charData.necromancer++;
                    charData.bartering++;

                    charData.skill1 = "Decaying Touch";
                    charData.skill2 = "Restoration";
                    charData.skill3 = "Blood Sucker";
                    break;

                case "Conjurer":
                    charData.preset = "Conjurer";
                    charData.Talent3 = "Pet Pal";

                    charData.intelligence++;
                    charData.constitution = charData.constitution + 2;
                    charData.summoning++;
                    charData.loremaster++;
                    charData.leadership++;

                    charData.skill1 = "Conjure Incarnate";
                    charData.skill2 = "Dimensional Bolt";
                    charData.skill3 = "Elemental Totem";
                    break;


                case "Enchanter":
                    charData.preset = "Enchanter";
                    charData.Talent3 = "Far Out Man";

                    charData.intelligence = charData.intelligence + 2;
                    charData.constitution++;
                    charData.hydrosophist++;
                    charData.aerothurge++;
                    charData.loremaster++;

                    charData.skill1 = "Electric Discharge";
                    charData.skill2 = "Hail Strike";
                    charData.skill3 = "Rain";
                    break;

                case "Fighter":
                    charData.preset = "Fighter";
                    charData.Talent3 = "Opportunist";

                    charData.strength++;
                    charData.constitution = charData.constitution + 2;
                    charData.warfare++;
                    charData.geomancer++;
                    charData.bartering++;

                    charData.skill1 = "Battle Stomp";
                    charData.skill2 = "Bouncing Shield";
                    charData.skill3 = "Fortify";
                    break;

                case "Inquisitor":
                    charData.preset = "Inquisitor";
                    charData.Talent3 = "Executioner";

                    charData.strength++;
                    charData.intelligence++;
                    charData.constitution++;
                    charData.warfare++;
                    charData.necromancer++;
                    charData.telekinesis++;

                    charData.skill1 = "Blood Sucker";
                    charData.skill2 = "Battering Ram";
                    charData.skill3 = "Mosquito Swarm";
                    break;

                case "Knight":
                    charData.preset = "Knight";
                    charData.Talent3 = "Opportunist";

                    charData.strength = charData.strength + 2;
                    charData.constitution++;
                    charData.warfare++;
                    charData.two_handed++;
                    charData.bartering++;

                    charData.skill1 = "Battering Ram";
                    charData.skill2 = "Crippling Blow";
                    charData.skill3 = "Battle Stomp";
                    break;

                case "Metamorph":
                    charData.preset = "Metamorph";
                    charData.Talent3 = "Opportunist";

                    charData.strength = charData.strength + 2;
                    charData.finesse = charData.finesse + 2;
                    charData.two_handed++;
                    charData.polymorph++;
                    charData.persuasion++;

                    charData.skill1 = "Tentacle Lash";
                    charData.skill2 = "Chiclen Claw";
                    charData.skill3 = "Bull Horns";
                    break;

                case "Ranger":
                    charData.preset = "Ranger";
                    charData.Talent3 = "Arrow Recovery";

                    charData.finesse = charData.finesse + 2;
                    charData.wits++;
                    charData.huntsman++;
                    charData.pyrokinetic++;
                    charData.lucky_charm++;

                    charData.skill1 = "Richochet";
                    charData.skill2 = "Peace of Mind";
                    charData.skill3 = "Elemental Arrowheads";
                    break;

                case "Rogue":
                    charData.preset = "Rogue";
                    charData.Talent3 = "The Pawn";

                    charData.finesse = charData.finesse + 2;
                    charData.constitution++;
                    charData.scoundrel++;
                    charData.sneaking++;
                    charData.dual_wielding++;

                    charData.skill1 = "Throwing Knife";
                    charData.skill2 = "Backlash";
                    charData.skill3 = "Adrenaline";
                    break;

                case "Shadowblade":
                    charData.preset = "Shadowblade";
                    charData.Talent3 = "Guerilla";

                    charData.finesse = charData.finesse + 2;
                    charData.wits = charData.wits + 2;
                    charData.scoundrel++;
                    charData.polymorph++;
                    charData.thievery++;

                    charData.skill1 = "Chameleon Cloak";
                    charData.skill2 = "Backlash";
                    charData.skill3 = "Chicken Claw";
                    break;

                case "Wayfarer":
                    charData.preset = "Wayfarer";
                    charData.Talent3 = "Pet Pal";

                    charData.finesse = charData.finesse + 2;
                    charData.intelligence++;
                    charData.huntsman++;
                    charData.geomancer++;
                    charData.bartering++;

                    charData.skill1 = "Pin Down";
                    charData.skill2 = "Fossil Strike";
                    charData.skill3 = "Elemental Arrowheads";
                    break;

                case "Witch":
                    charData.preset = "Witch";
                    charData.Talent3 = "Leech";

                    charData.finesse++;
                    charData.intelligence++;
                    charData.constitution++;
                    charData.scoundrel++;
                    charData.necromancer++;
                    charData.persuasion++;

                    charData.skill1 = "Raise Bloated Corpse";
                    charData.skill2 = "Chloroform";
                    charData.skill3 = "Mosquito Swarm";
                    break;

                case "Wizard":
                    charData.preset = "Wizard";
                    charData.Talent3 = "Far Out Man";

                    charData.intelligence = charData.intelligence + 2;
                    charData.constitution++;
                    charData.pyrokinetic++;
                    charData.loremaster++;

                    charData.skill1 = "Searing Daggers";
                    charData.skill2 = "Fossil Strike";
                    charData.skill3 = "Ignition";
                    break;
            }
        }
        public  void generateTags(Data charData)
        {
            charData.tag1 = getRand(charData.tags);
            charData.tags = removeElement(charData.tags, charData.tag1);
            charData.tag2 = getRand(charData.tags);
        }
        public void getOrigin(Data charData)
        {
            String ori = getRand(charData.origins);

            switch (ori)
            {
                case "The Red Prince":
                    charData.Talent1 = "Spellsong";
                    charData.Talent2 = "Sophisticated";

                    charData.origin = "The Red Prince";
                    break;


                case "Sebille":
                    charData.Talent1 = "Corpse Eater";
                    charData.Talent2 = "Ancestral Knowledge";
                    charData.origin = "Sebille";
                    break;

                case "Ifan":
                    charData.Talent1 = "Ingenious";
                    charData.Talent2 = "Thrifty";
                    charData.origin = "Ifan";
                    break;

                case "Lohse":
                    charData.Talent1 = "Ingenious";
                    charData.Talent2 = "Thrifty";
                    charData.origin = "Lohse";
                    break;

                case "Beast":
                    charData.Talent1 = "Sturdy";
                    charData.Talent2 = "Dwarven Guile";
                    charData.origin = "Beast";
                    break;

                case "Fane":
                    charData.Talent1 = "Ingenious";
                    charData.Talent2 = "Undead";
                    charData.origin = "Fane";
                    break;

                case "Dwarf":
                    charData.Talent1 = "Sturdy";
                    charData.Talent2 = "Dwarven Guile";
                    charData.origin = "Dwarf";
                    break;

                case "Human":
                    charData.Talent1 = "Ingenious";
                    charData.Talent2 = "Thrifty";
                    charData.origin = "Human";
                    break;

                case "Elf":
                    charData.Talent1 = "Corpse Eater";
                    charData.Talent2 = "Ancestral Knowledge";
                    charData.origin = "Elf";
                    break;

                case "Lizard":
                    charData.Talent1 = "Spellsong";
                    charData.Talent2 = "Sophisticated";
                    charData.origin = "Lizard";
                    break;

                case "Undead Dwarf":
                    charData.Talent1 = "Sturdy";
                    charData.Talent2 = "Undead";
                    charData.origin = "Undead Dwarf";
                    break;

                case "Undead Human":
                    charData.Talent1 = "Ingenious";
                    charData.Talent2 = "Undead";
                    charData.origin = "Undead Human";
                    break;

                case "Undead Elf":
                    charData.Talent1 = "Corpse Eater";
                    charData.Talent2 = "Undead";
                    charData.origin = "Undead Elf";
                    break;

                case "Undead Lizard":
                    charData.Talent1 = "Sophisticated";
                    charData.Talent2 = "Undead";
                    charData.origin = "Undead Lizard";
                    break;

            }
        }
        public static String[] removeElement(String[] array, String element)
        {
            String[] newArr= null;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] == element)
                {
                    newArr = new String[array.Length - 1];
                    for (int index = 0; index < i; index++)
                    {
                        newArr[index] = array[index];
                    }
                    for (int j = i; j < array.Length - 1; j++)
                    {
                        newArr[j] = array[j + 1];
                    }
                    break;
                }
            }

            return newArr;
        }
        public static String[] arrayMerge(String[] array1, String[] array2)
        {
            int size = array1.Length + array2.Length;
            String[] result = new String[size];

            for (int i = 0; i < array1.Length; i++)
            {
                result[i] = array1[i];
            }

            for (int i = 0, k = array1.Length; k < size && i < array2.Length; i++, k++)
            {
                result[k] = array2[i];
            }
            return result;
        }
        public String[] selectSkills(String[] skillArray)
        {
            String[] skillSet = new String[3];

            for (int i = 0; i < 3; i++)
            {
                String skill = getRand(skillArray);
                skillArray = removeElement(skillArray, skill);
                skillSet[i] = skill;
            }

            return skillSet;
        }
        public void distributeAtts(Data charData)
        {
            for (int i = 0; i < 3; i++)
            {
                String attribute = getRand(charData.attributes);
                switch (attribute)
                {

                    case "Strength":
                        charData.strength++;
                        break;


                    case "Finesse":
                        charData.finesse++;
                        break;

                    case "Intelligence":
                        charData.intelligence++;
                        break;

                    case "Constitution":
                        charData.constitution++;
                        break;

                    case "Memory":
                        charData.memory++;
                        break;

                    case "Wits":
                        charData.wits++;
                        break;

                }
            }

            //select 2 random combat abilities
            for (int i = 0; i < 2; i++)
            {
                String ability = getRand(charData.combat_abilities);
                switch (ability)
                {
                    case "Warfare":
                        charData.warfare++;
                        break;

                    case "Huntsman":
                        charData.huntsman++;
                        break;

                    case "Scoundrel":
                        charData.scoundrel++;
                        break;

                    case "Pyrokinetic":
                        charData.pyrokinetic++;
                        break;

                    case "Hydrosophist":
                        charData.hydrosophist++;
                        break;

                    case "Aerothurge":
                        charData.aerothurge++;
                        break;

                    case "Geomancer":
                        charData.geomancer++;
                        break;

                    case "Necromancer":
                        charData.necromancer++;
                        break;

                    case "Summoning":
                        charData.summoning++;
                        break;

                    case "Polymorph":
                        charData.polymorph++;
                        break;

                }
            }
        }
        public void generateTalent(Data charData)
        {
            String cont = "false";
            
            String talent = null;
            while (cont == "false")
            {
                talent = getRand(charData.talents);
                
                if (talent == "Demon")
                {
                    if (charData.pyrokinetic >= 1)
                    {
                        cont = "true";
                    }
                }
                if (talent == "Duck Duck Goose")
                {
                    if (charData.huntsman >= 1)
                        cont = "true";
                }
                if (talent == "Elemental Ranger")
                {
                    if (charData.huntsman >= 1)
                        cont = "true";
                }
                if (talent == "Executioner")
                {
                    if (charData.warfare >= 1)
                        cont = "true";
                }
                if (talent == "Guerilla")
                {
                    if (charData.sneaking >= 1)
                        cont = "true";
                }
                if (talent == "Ice King")
                {
                    if (charData.hydrosophist >= 1)
                        cont = "true";
                }
                if (talent == "Picture of Health")
                {
                    if (charData.warfare >= 1)
                        cont = "true";
                }
                if (talent == "The Pawn")
                {
                    if (charData.scoundrel >= 1)
                        cont = "true";
                }
                else
                {
                    cont = "true";
                }
               
            }
            charData.Talent3 = talent;
        }
        public void generateSkills(Data charData)
        {
            String[] array1 = null;
            String[] array2 = null;



            for (int i = 0; i < 2; i++)
            {
                //each if statement checks which attriutes need to be added to the list of possible skills
                if (charData.warfare > 0)
                {


                    if (array1 == null)
                    {
                        array1 = charData.warfare_skills;
                    }
                    //If the attribute is leveled to 2, then only one skill array is needed
                    else if (array2 == null && array1 != null && charData.warfare < 2)
                    {
                        array2 = charData.warfare_skills;
                    }
                }
                if (charData.scoundrel > 0)
                {
                    if (array1 == null)
                    {
                        array1 = charData.scoundrel_skills;
                    }
                    else if (array2 == null && array1 != null && charData.scoundrel < 2)
                    {
                        array2 = charData.scoundrel_skills;
                    }
                }
                if (charData.huntsman > 0)
                {
                    if (array1 == null)
                    {
                        array1 = charData.huntsman_skills;
                    }
                    else if (array2 == null && array1 != null && charData.huntsman < 2)
                    {
                        array2 = charData.huntsman_skills;
                    }
                }
                if (charData.pyrokinetic > 0)
                {
                    if (array1 == null)
                    {
                        array1 = charData.pyrokinetic_skills;
                    }
                    else if (array2 == null && array1 != null && charData.pyrokinetic < 2)
                    {
                        array2 = charData.pyrokinetic_skills;
                    }
                }
                if (charData.hydrosophist > 0)
                {
                    if (array1 == null)
                    {
                        array1 = charData.hydro_skills;
                    }
                    else if (array2 == null && array1 != null && charData.hydrosophist < 2)
                    {
                        array2 = charData.hydro_skills;
                    }
                }
                if (charData.aerothurge > 0)
                {
                    if (array1 == null)
                    {
                        array1 = charData.aero_skills;
                    }
                    else if (array2 == null && array1 != null && charData.aerothurge < 2)
                    {
                        array2 = charData.aero_skills;
                    }
                }
                if (charData.geomancer > 0)
                {
                    if (array1 == null)
                    {
                        array1 = charData.geo_skills;
                    }
                    else if (array2 == null && array1 != null && charData.geomancer < 2)
                    {
                        array2 = charData.geo_skills;
                    }
                }
                if (charData.necromancer > 0)
                {
                    if (array1 == null)
                    {
                        array1 = charData.necro_skills;
                    }
                    else if (array2 == null && array1 != null && charData.necromancer < 2)
                    {
                        array2 = charData.necro_skills;
                    }
                }
                if (charData.summoning > 0)
                {
                    if (array1 == null)
                    {
                        array1 = charData.summ_skills;
                    }
                    else if (array2 == null && array1 != null && charData.summoning < 2)
                    {
                        array2 = charData.summ_skills;
                    }
                }
                if (charData.polymorph > 0)
                {
                    if (array1 == null)
                    {
                        array1 = charData.poly_skills;
                    }
                    else if (array2 == null && array1 != null && charData.polymorph < 2)
                    {
                        array2 = charData.poly_skills;
                    }
                }
            }

            //if more than 1 stat is above 0, an array merge is required
            if (array1 != null && array2 != null)
            {
                String[] newArray = arrayMerge(array1, array2);
                charData.skills = selectSkills(newArray);
            }
            else if (array1 != null && array2 == null)
            {
                charData.skills = selectSkills(array1);
            }
        }
        public void generateCivils(Data charData)
        {
            String civil = getRand(charData.civil_abilities);
        
            switch (civil)
            {
                case "Bartering":
                    charData.bartering++;
                    break;

                case "Lucky Charm":
                    charData.lucky_charm++;
                    break;

                case "Persuasion":
                    charData.persuasion++;
                    break;

                case "Loremaster":
                    charData.loremaster++;
                    break;

                case "Telekinesis":
                    charData.telekinesis++;
                    break;

                case "Sneaking":
                    charData.sneaking++;
                    break;

                case "Thievery":
                    charData.thievery++;
                    break;
            }
        }


    }

    public class Data
    {
        public String[] origins = {"The Red Prince", "Sebille", "Ifan", "Lohse",
        "Beast", "Fane", "Dwarf", "Human",
        "Elf", "Lizard", "Undead Dwarf", "Undead Human",
        "Undead Elf", "Undead Lizard"};

        //Prebuilt classes
        public String[] preset_classes = {"Battlemage", "Cleric", "Conjurer", "Enchanter", "Fighter",
        "Inquisitor", "Knight", "Metamorph", "Ranger", "Rogue",
        "Shadowblade", "Wayfarer", "Witch", "Wizard" };

        public String[] talents = {"Ambidextrous", "Arrow Recovery", "Comeback Kid", "Demon", "Duck Duck Goose", "Elemental Affinity", "Elemental Ranger",
        "Escapist", "Executioner", "Far Out Man", "Five-Star Diner", "Glass Cannon", "Guerilla",
        "Hothead", "Ice King", "Leech", "Living Armour", "Lone Wolf", "Mnemonic", "Morning Person",
        "Opportunist", "Parry Master", "Pet Pal", "Picture of Health", "Savage Sortilege",
        "Slingshot", "Stench", "The Pawn", "Torturer", "Unstable", "Walk it Off", "What a Rush"};

        //Store the list of possible skills for each Combat Ability
        public String[] warfare_skills = { "Bouncing Shield", "Battle Stomp", "Battering Ram", "Crippling Blow" };
        public String[] huntsman_skills = { "Elemental Arrowheads", "Pin Down", "Richochet", "First Aid" };
        public String[] scoundrel_skills = { "Chloroform", "Throwing Knife", "Backlash", "Adrenaline" };
        public String[] pyrokinetic_skills = { "Ignition", "Peace of Mind", "Searing Daggers", "Haste" };
        public String[] hydro_skills = { "Amour of Frost", "Hail Strike", "Restoration", "Rain" };
        public String[] aero_skills = { "Blinding Radiance", "Electric Discharge", "Favourable Wind", "Shocking Touch" };
        public String[] geo_skills = { "Contamination", "Fortify", "Fossil Strike", "Poison Dart" };
        public String[] necro_skills = { "Raise Bloated Corpse", "Blood Sucker", "Mosquito Swarm", "Decaying Touch" };
        public String[] summ_skills = { "Elemental Totem", "Summon Incarnate", "Dimensional Bolt", "Farsight Infusion" };
        public String[] poly_skills = { "Chicken Claw", "Tentacle Lash", "Chameleon Cloak", "Bull Horns" };

        public String[] attributes = { "Strength", "Finesse", "Intelligence", "Constitution", "Memory", "Wits" };

        public String[] combat_abilities = {"Warfare", "Huntsman", "Scoundrel", "Pyrokinetic",
        "Hydrosophist", "Aerothurge", "Geomancer", "Necromancer", "Summoning", "Polymorph"};

        public String[] civil_abilities = { "Bartering", "Lucky Charm", "Persuasion", "Loremaster", "Telekinesis", "Sneaking", "Thievery" };

        public String[] tags = { "Barbarian", "Jester", "Mystic", "Noble", "Outlaw", "Scholar", "Soldier", "No Tag" };

        public String[] instruments = { "Bansuri", "Tambura", "Oud", "Cello" };

        public String instrument;
        //store the talents
        public String Talent1;
        public String Talent2;
        public String Talent3;

        //store the skills
        public String skill1;
        public String skill2;
        public String skill3;

        public String tag1;
        public String tag2;

        //store the preset class if necessary
        public String preset;

        public String origin;

        //store the character's attributes
        public int strength = 10;
        public int finesse = 10;
        public int intelligence = 10;
        public int constitution = 10;
        public int memory = 10;
        public int wits = 10;

        //combat abilities
        public int dual_wielding = 0;
        public int ranged = 0;
        public int single_handed = 0;
        public int two_handed = 0;
        public int leadership = 0;
        public int perseverance = 0;
        public int retribution = 0;

        public int warfare = 0;
        public int huntsman = 0;
        public int scoundrel = 0;
        public int pyrokinetic = 0;
        public int hydrosophist = 0;
        public int aerothurge = 0;
        public int geomancer = 0;
        public int necromancer = 0;
        public int summoning = 0;
        public int polymorph = 0;

        //civil abilities
        public int bartering = 0;
        public int lucky_charm = 0;
        public int persuasion = 0;
        public int loremaster = 0;
        public int telekinesis = 0;
        public int sneaking = 0;
        public int thievery = 0;

        public String arrayType = null;
        public String[] skills = null;
    }
}
