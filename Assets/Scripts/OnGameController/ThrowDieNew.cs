using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using UnityEngine.UI;
//On GameController object

public class ThrowDieNew : MonoBehaviour
{   
    [SerializeField] GameObject Die4Prefab;
    [SerializeField] GameObject Die6Prefab;
    [SerializeField] GameObject Die8Prefab;
    [SerializeField] GameObject Die10Prefab;
    [SerializeField] GameObject Died10Prefab;
    [SerializeField] GameObject Die12Prefab;
    [SerializeField] GameObject Die20Prefab;
    [SerializeField] Text sumText;
    [SerializeField] InputField input;
    Dictionary<string, int> diceOnBoard = new Dictionary<string, int>();
    private void Start() {
        input.text = "1";
    }
    public void send20(){
        Throw(Die20Prefab);
    }
    public void send12(){
        Throw(Die12Prefab);
    }
    public void sendD10(){
        Throw(Died10Prefab);
    }
    public void send10(){
        Throw(Die10Prefab);
    }
    public void send8(){
        Throw(Die8Prefab);
    }
    public void send6(){
        Throw(Die6Prefab);
    }
    public void send4(){
        Throw(Die4Prefab);
    }
    public void raiseCount() {
        if(Convert.ToInt32(input.text) < 100)
            input.text = "" + (Convert.ToInt32(input.text) + 1);
    }
    public void lowerCount() {
        if(Convert.ToInt32(input.text) > 1)
            input.text = "" + (Convert.ToInt32(input.text) - 1);
    }
    public void Throw(GameObject prefab) {
        for(int i = 0; i < Convert.ToInt32(input.text); i++) {
            Quaternion quat = Quaternion.identity;
            Vector3 rot = new Vector3(UnityEngine.Random.Range(-180f, 180f), UnityEngine.Random.Range(-180f, 180f), UnityEngine.Random.Range(-180f, 180f));
            Vector3 place = new Vector3(UnityEngine.Random.Range(-2f, 2f), UnityEngine.Random.Range(-2f, 2f), UnityEngine.Random.Range(-2f, 2f));
            quat.eulerAngles = rot;
            GameObject die = Instantiate(prefab, transform.position + place, quat);
            float veloc = UnityEngine.Random.Range(900f, 2000f);
            die.GetComponent<Rigidbody>().AddForce(transform.right * veloc * -1);
            Physics.IgnoreLayerCollision(8,8);
            die.transform.SetParent(transform);
            die.name += diceOnBoard.Count;
            diceOnBoard.Add(die.name, 0);
        }
    }
    public void clearDice() {
        foreach(KeyValuePair<string, int> entry in diceOnBoard) {
            Transform delete = gameObject.transform.Find(entry.Key);
            Debug.Log(delete.name);
            Destroy(delete.gameObject);
        }
        diceOnBoard.Clear();
        updateSum("clear", 0);
    }
    public void updateSum(string name, int num) {
        if(name == "clear") {
            sumText.text = "Sum: 0";
            return;
        }
        diceOnBoard[name] = num;
        int sum = 0;
        foreach(KeyValuePair<string, int> entry in diceOnBoard) {
            sum += entry.Value;
        }
        sumText.text = "Sum: " + sum;
    }
    private void Update() {
        if(input.text == "" || input.text == "-")
            return;
        if(Convert.ToInt32(input.text) > 100)
            input.text = "100";
        if(Convert.ToInt32(input.text) < 1)
            input.text = "1";
    }
}

