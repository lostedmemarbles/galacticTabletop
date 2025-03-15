using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
using UnityEngine.UI;

public class SubRaces : MonoBehaviour
{
    public Dropdown raceOpt;
    public Dropdown subOpt;
    public Text rt_List;
    public Text rt_description;
    public Text race_description;
    public Text rb_str;
    public Text rb_dex;
    public Text rb_con;
    public Text rb_int;
    public Text rb_wis;
    public Text rb_cha;

    List<string> noSub = new List<string>{ "No Subraces" };
    List<string> elfs = new List<string>{"Eladrin", "High", "Wood"};
    List<string> dwarfs = new List<string>{ "Hill", "Mountain"};
    Dictionary<string, string> elevesRT = new Dictionary<string, string>()
     {
        {"Eladrin","+2 Dexterity,Darkvision,Keen Senses,Fey Ancestry,Trance,Fey Step"},
        {"High","+2 Dexterity,Darkvision,Keen Senses,Fey Ancestry,Trance,Cantrip"},
        {"Wood","+2 Dexterity,Darkvision,Keen Senses,Fey Ancestry,Trance,Mask of the Wild"}
    };

    Dictionary<string, string> racialTraits = new Dictionary<string, string>()
    {
        { "Darkvision","Accustomed to twilit forests and the night sky, you have superior vision in dark and dim conditions. You can see in dim light within 60 feet of you as if it were bright light, and in darkness as if it were dim light. You can’t discern color in darkness, only shades of gray."},
        { "Keen Senses","You have proficiency in the Perception skill."},
        { "Fey Ancestry","You have advantage on saving throws against being charmed, and magic can’t put you to sleep."},
        { "Trance","Elves don’t need to sleep. Instead, they meditate deeply, remaining semiconscious, for 4 hours a day. (The Common word for such meditation is “trance.”) While meditating, you can dream after a fashion; such dreams are actually mental exercises that have become reflexive through years of practice. After resting in this way, you gain the same benefit that a human does from 8 hours of sleep."},
        { "Fey Step","You can cast the misty step spell once using this trait. You regain the ability to do so when you finish a short or long rest."},
        { "Cantrip","You know one cantrip of your choice from the wizard spell list. Intelligence is your spellcasting ability for it."},
        { "Mask of the Wild","You can attempt to hide even when you are only lightly obscured by foliage, heavy rain, falling snow, mist, and other natural phenomena."}
    };

    Dictionary<string, string> descriptions = new Dictionary<string, string>()
    {
        {"Eladrin","This version of the eladrin originally appeared in the Dungeon Master's Guide as an example for creating your own subraces.\nCreatures of magic with strong ties to nature, eladrin live in the twilight realm of the Feywild. Their cities sometimes cross over to the Material Plane, appearing briefly in mountain valleys or deep forest glades before fading back into the Feywild."},
        {"Wood","As a wood elf, you have keen senses and intuition, and your fleet feet carry you quickly and stealthily through your native forests. This category includes the wild elves (grugach) of Greyhawk and the Kagonesti of Dragonlance, as well as the races called wood elves in Greyhawk and the Forgotten Realms. In Faerûn, wood elves (also called wild elves, green elves, or forest elves) are reclusive and distrusting of non-elves." },
        {"High","As a high elf, you have a keen mind and a mastery of at least the basics of magic. In many of the worlds of D&D, there are two kinds of high elves. One type (which includes the gray elves and valley elves of Greyhawk, the Silvanesti of Dragonlance, and the sun elves of the Forgotten Realms) is haughty and reclusive, believing themselves to be superior to non-elves and even other elves. The other type (including the high elves of Greyhawk, the Qualinesti of Dragonlance, and the moon elves of the Forgotten Realms) are more common and more friendly, and often encountered among humans and other races."}
    };

    public void addSubRaces()
    {
        if(raceOpt.value == 2)
        {
            subOpt.ClearOptions();
            subOpt.AddOptions(dwarfs);
        }else if (raceOpt.value == 3)
        {
            subOpt.ClearOptions();
            subOpt.AddOptions(elfs);
        }
        else
        {
            subOpt.ClearOptions();
            subOpt.AddOptions(noSub);
        }
    }

    public void display()
    {
        string race = raceOpt.options[raceOpt.value].text;
        if ( race.Equals("Elf"))
        {
            string subrace = subOpt.options[subOpt.value].text;
            if(subrace != null && !subrace.Equals(""))
            {
                race_description.text = descriptions[subrace];

                string list = elevesRT[subrace];
                rt_List.text = list;
                List<string> rtList = new List<string>(list.Split(','));
                rtList.Remove("+2 Dexterity");
                
                string rt = "";
                foreach(var r in rtList)
                {
                    rt = rt + r + " - " + racialTraits[r] + "\n";
                }

                rt_description.text = rt;
                rb_dex.text = "2"; //racial bonus
            }
        }
    }
}
