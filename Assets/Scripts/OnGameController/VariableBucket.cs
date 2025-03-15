using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
//On GameController
public class VariableBucket : MonoBehaviour
{
    [SerializeField] Text sumText;
    public int dieAdd = 0;
    // Start is called before the first frame update


    // Update is called once per frame
    public int AddToSum(int addNum) {
        dieAdd += addNum;
        return dieAdd;
    }
    public void setSumText(int sum) {
        sumText.text = "Sum: " + sum;
    }
}
