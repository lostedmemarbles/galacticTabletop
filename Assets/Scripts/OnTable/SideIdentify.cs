using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
//put on surface that dice will be thrown on
public class SideIdentify : MonoBehaviour
{
    [SerializeField] GameObject gameController;
    private int addNum = 0;
    private int sumRecent = 0;
    private List<Collider> colliders = new List<Collider>();
    private void OnTriggerEnter(Collider coll) {
        addNum = Convert.ToInt32(coll.GetComponent<Collider>().name);
        DieVariables dv = coll.gameObject.transform.parent.GetComponent<DieVariables>();
        dv.setValue(addNum);
    }
}
