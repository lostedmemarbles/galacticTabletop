using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DieVariables : MonoBehaviour
{
    private int value = 0;

    public int getValue()
    {
        return value;
    }
    public void setValue(int val)
    {
        value = val;
        ThrowDieNew th = transform.parent.gameObject.GetComponent<ThrowDieNew>();
        Debug.Log(gameObject.name);
        th.updateSum(gameObject.name, value);
    }
}
