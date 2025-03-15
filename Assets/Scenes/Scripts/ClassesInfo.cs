using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
using UnityEngine.UI;

public class ClassesInfo : MonoBehaviour
{
    Dictionary<string, string> barbarian = new Dictionary<string, string>()
     {
        {"description", "A fierce warrior of primitive background who can enter a battle rage"},
        {"hDie","1d12"},
        {"maxHit","12"},
        {"Primary Ability","Strength"},
        {"Saves","Strength & Constitution"},
        {"Armor","Light armor, medium armor, shields"},
        {"Weapons", "Simple weapons, martial weapons"},
        {"Skills", "Animal Handling, Athletics, Intimidation, Nature, Perception, Survival" }
    };

    Dictionary<string, string> cleric = new Dictionary<string, string>()
     {
        {"description", "A priestly champion who wields divine magic in service of a higher power"},
        {"hDie","1d8"},
        {"maxHit","8"},
        {"Primary Ability","Wisdom"},
        {"Saves","Wisdom & Charisma"},
        {"Armor","Light armor, medium armor, shields"},
        {"Weapons", "Simple weapons"},
        {"Skills", "History, Insight, Medicine, Persuasion, Religion"}
    };

    Dictionary<string, string> sorcerer = new Dictionary<string, string>()
     {
        {"description", "A priestly champion who wields divine magic in service of a higher power"},
        {"hDie","d6"},
        {"maxHit","8"},
        {"Primary Ability","Charisma"},
        {"Saves","Constitution & Charisma"},
        {"Armor","None"},
        {"Weapons", "Daggers, darts, slings, quarterstaffs, light crossbows"},
        {"Skills", "Arcana, Deception, Insight, Intimidation, Persuasion, Religion"}
    };

    public Dropdown classes;
    public Dropdown skill1;
    public Dropdown skill2;

    public Text classNametxt;
    public Text description;
    public Text hDie;
    public Text maxHit;
    public Text pAbilities;
    public Text saves;
    public Text armor;
    public Text weapons;
    public Text skillList;

    public void setDetails()
    {
        string className = classes.options[classes.value].text;

        if (className.Equals("Barbarian"))
        {
            classNametxt.text = "Barbarian";
            //Description
            description.text = barbarian["description"];
            hDie.text = barbarian["hDie"];
            maxHit.text = barbarian["maxHit"];
            pAbilities.text = barbarian["Primary Ability"];
            saves.text = barbarian["Saves"];
            armor.text = barbarian["Armor"];
            weapons.text = barbarian["Weapons"];
            skillList.text = barbarian["Skills"];
            //Skills
            string list = barbarian["Skills"];
            List<string> skills = new List<string>(list.Split(','));

            skill1.ClearOptions();
            skill2.ClearOptions();
            skill1.AddOptions(skills);
            skill2.AddOptions(skills);
        }

        if (className.Equals("Cleric"))
        {
            classNametxt.text = "Cleric";
            //Description
            description.text = cleric["description"];
            hDie.text = cleric["hDie"];
            maxHit.text = cleric["maxHit"];
            pAbilities.text = cleric["Primary Ability"];
            saves.text = cleric["Saves"];
            armor.text = cleric["Armor"];
            weapons.text = cleric["Weapons"];
            skillList.text = cleric["Skills"];
            //Skills
            string list = cleric["Skills"];
            List<string> skills = new List<string>(list.Split(','));

            skill1.ClearOptions();
            skill2.ClearOptions();
            skill1.AddOptions(skills);
            skill2.AddOptions(skills);
        }

        if (className.Equals("Sorcerer"))
        {
            classNametxt.text = "Sorcerer";
            //Description
            description.text = sorcerer["description"];
            hDie.text = sorcerer["hDie"];
            maxHit.text = sorcerer["maxHit"];
            pAbilities.text = sorcerer["Primary Ability"];
            saves.text = sorcerer["Saves"];
            armor.text = sorcerer["Armor"];
            skillList.text = sorcerer["Skills"];
            weapons.text = sorcerer["Weapons"];
            //Skills
            string list = sorcerer["Skills"];
            List<string> skills = new List<string>(list.Split(','));

            skill1.ClearOptions();
            skill2.ClearOptions();
            skill1.AddOptions(skills);
            skill2.AddOptions(skills);
        }
    }
}
