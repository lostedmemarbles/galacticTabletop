using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
using UnityEngine.UI;

public class DATA_STORAGE : MonoBehaviour
{
    Dictionary<string, Dictionary<string, string>> characters = new Dictionary<string, Dictionary<string, string>>();
    List<string> names = new List<string>();
 
    public InputField charName;
    public Dropdown race;
    public Dropdown subrace;
    public Dropdown char_class;
    public Dropdown alignment;
    public Dropdown lifestyle;
    public InputField faith;
    public InputField backstory;
    public InputField hair;
    public InputField skin;
    public InputField eyes;
    public InputField height;
    public InputField weight;
    public InputField age; 
    public InputField gender;

    //class
    public Text hdice;
    public Text maxHit;
    public Text pAbility;
    public Text armor;
    public Text weapons;
    public Dropdown skill1;
    public Dropdown skill2;
    public Text saves;

    //abilities
    public Text strength;
    public Text dexterity;
    public Text constitution;
    public Text intelligence;
    public Text wisdom;
    public Text charisma;

    //display
    public Dropdown currentCharacters;
    
    public void addCharacter()
    {
        Dictionary<string, string> character = new Dictionary<string, string>();
        //name
        character.Add("name", charName.text);
        //race
        character.Add("race", race.options[race.value].text);
        character.Add("subrace", subrace.options[subrace.value].text);
        //class
        character.Add("className", char_class.options[char_class.value].text);
        character.Add("hdice", hdice.text);
        character.Add("maxHit", maxHit.text);
        character.Add("pAbility", pAbility.text);
        character.Add("armor", armor.text);
        character.Add("weapons", weapons.text);
        character.Add("skill1", skill1.options[skill1.value].text);
        character.Add("skill2", skill2.options[skill2.value].text);
        character.Add("saves", saves.text);
        //abilities
        character.Add("strength", strength.text);
        character.Add("dexterity", dexterity.text);
        character.Add("constitution", constitution.text);
        character.Add("intelligence", intelligence.text);
        character.Add("wisdom", wisdom.text);
        character.Add("charisma", charisma.text);
        //description
        character.Add("alignment", alignment.options[alignment.value].text);
        character.Add("lifestyle", lifestyle.options[lifestyle.value].text);
        //characteristics
        character.Add("hair", hair.text);
        character.Add("skin", skin.text);
        character.Add("eyes", eyes.text);
        character.Add("height", height.text);
        character.Add("weight", weight.text);
        character.Add("age", age.text);
        character.Add("gender", gender.text);

        characters.Add(charName.text, character);
        names.Add(charName.text);
        displayList();
    }

    public void deleteCharacter(Text name)
    {
        characters.Remove(name.text);
        names.Remove(name.text);
    }

    public void displayList()
    {
        if (names.Count > 0)
        {
            currentCharacters.ClearOptions();
            currentCharacters.AddOptions(names);
        }
    }

}
