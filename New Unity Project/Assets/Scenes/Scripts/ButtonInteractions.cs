using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonInteractions : MonoBehaviour
{
    public Button activeBtn;
    public Button btn1;
    public Button btn2;
    public Button btn3;
    public Button btn4;
    public Button btn5;
    public GameObject activePanel;
    public GameObject Panel;
    public GameObject Pane2;
    public GameObject Pane3;
    public GameObject Pane4;
    public GameObject Pane5;

    public void DisableSelf()
    {
        activeBtn.interactable = false;
        btn1.interactable = true;
        btn2.interactable = true;
        btn3.interactable = true;
        btn4.interactable = true;
        btn5.interactable = true;
        activePanel.SetActive(true);
        Panel.SetActive(false);
        Pane2.SetActive(false);
        Pane3.SetActive(false);
        Pane4.SetActive(false);
        Pane5.SetActive(false);
    }

}
