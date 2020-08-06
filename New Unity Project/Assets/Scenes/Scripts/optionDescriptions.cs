using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class optionDescriptions : MonoBehaviour
{

    public Dropdown opt;
    public Text txt;

 /*   Lawful Good 1
    Neutral Good 2
    Chaotic Good 3
    Lawful Neutral 4
    Neutral 5
    Chaotic Neutral 6
    Lawful Evil 7
    Neutral Evil 8
    Chaotic Evil 9
    */

    public void TextChange()
    {
        if (opt.value == 1)
        {
            txt.text = "Lawful Good characters always do the right thing as expected by society. They always follow the rules, tell the truth and help people out. They like order, trust and believe in people with social authority, and they aim to be an upstanding citizen.";
        }else if (opt.value == 2)
        {
            txt.text = "Neutral Good characters do their best to help others, but they do it because they want to, not because they have been told to by a person in authority or by society’s laws.";
        }
        else if (opt.value == 3)
        {
            txt.text = "Chaotic Good characters do what their conscience tells them to for the greater good. They do not care about following society’s rules, they care about doing what’s right.";
        }
        else if (opt.value == 4)
        {
            txt.text = "Lawful Neutral character behaves in a way that matches the organization, authority or tradition they follow. They live by this code and uphold it above all else, taking actions that are sometimes considered Good and sometimes considered Evil by others.";
        }
        else if (opt.value == 5)
        {
            txt.text = "True Neutral (sometimes called Neutral Neutral) characters don’t like to take sides. They are pragmatic rather than emotional in their actions, choosing the response which makes the most sense for them in each situation.";
        }
        else if (opt.value == 6)
        {
            txt.text = "Chaotic Neutral characters are free spirits. They do what they want but don’t seek to disrupt the usual norms and laws of society.";
        }
        else if (opt.value == 7)
        {
            txt.text = "Lawful Evil characters operate within a strict code of laws and traditions. Upholding these values and living by these is more important than anything, even the lives of others. They may not consider themselves to be Evil, they may believe what they are doing is right.";
        }
        else if (opt.value == 8)
        {
            txt.text = "Neutral Evil characters are selfish. Their actions are driven by their own wants whether that’s power, greed, attention, or something else. They will follow laws if they happen to align with their ambitions, but they will not hesitate to break them if they don’t.";
        }
        else if (opt.value == 9)
        {
            txt.text = "Chaotic Evil characters care only for themselves with a complete disregard for all law and order and for the welfare and freedom of others. They harm others out of anger or just for fun.";
        }
        else
        {
            txt.text = "";
        }
    }
}
