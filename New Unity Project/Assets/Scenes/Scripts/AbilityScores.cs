using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;
using UnityEngine.UI;

public class AbilityScores : MonoBehaviour
{
    public Dropdown active;
    public Dropdown dd1;
    public Dropdown dd2;
    public Dropdown dd3;
    public Dropdown dd4;
    public Dropdown dd5;

    public Text totalScore;
    public Text modifer;
    public Text baseScore;
    public Text racialBonus;
    public Text improvement;
    public Text miscBonus;
    public Text setScore;

    public string pre; //hold previous selection

    public void changeTxt()
    {
        string str = racialBonus.text;
        
        if (str != null && !str.Equals("--"))
        {
            string sum = active.options[active.value].text;
            int num = int.Parse(str);
            int total = int.Parse(sum) + num;
            totalScore.text = "" + total;
        }
        else
        {
            totalScore.text = active.options[active.value].text;
        }
        
    }

    public void changeList()
    {
        string d = active.options[active.value].text;

        if (pre != null && !pre.Equals("") && !pre.Equals("--"))
        {
            UnityEngine.Debug.Log("Before " + pre);
            insertInOrder(dd1);
            insertInOrder(dd2);
            insertInOrder(dd3);
            insertInOrder(dd4);
            insertInOrder(dd5);
        }

        if (!d.Equals("--"))
        {
            Dropdown.OptionData option1 = dd1.options.Find(o => string.Equals(o.text, d));
            Dropdown.OptionData option2 = dd2.options.Find(o => string.Equals(o.text, d));
            Dropdown.OptionData option3 = dd3.options.Find(o => string.Equals(o.text, d));
            Dropdown.OptionData option4 = dd4.options.Find(o => string.Equals(o.text, d));
            Dropdown.OptionData option5 = dd5.options.Find(o => string.Equals(o.text, d));

            dd1.options.Remove(option1);
            dd2.options.Remove(option2);
            dd3.options.Remove(option3);
            dd4.options.Remove(option4);
            dd5.options.Remove(option5);

            pre = d;
            UnityEngine.Debug.Log("After " + pre);
        }

        pre = d;
        UnityEngine.Debug.Log("After " + pre);
    }

    public void insertInOrder(Dropdown d)
    {
        int ct = 0;
        foreach (Dropdown.OptionData op in d.options)
        {
            string tmp = op.text;
            if (!tmp.Equals("--"))
            {
                UnityEngine.Debug.Log("tmp: " + tmp);
                int num = int.Parse(tmp);
                int pNum = int.Parse(pre);
                if (pNum < num)
                {
                    d.options.Insert(ct, new Dropdown.OptionData(pre));
                    break;
                }
                if(d.options.Count == (ct + 1))
                {
                    d.options.Add(new Dropdown.OptionData(pre));
                    break;
                }
            }
            ct++;
        }
    }

}
