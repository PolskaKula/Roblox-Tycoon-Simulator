using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public bool isTycoonClaimed;
    public int Money;
    public int NumberOfUpgrades;
    public TMP_Text Counter1, Counter2;
    public BeginWorking MineScript, Dropper1Script, Dropper2Script, Dropper3Script, Dropper4Script, MegaDropperScript, UpgraderScript;
    public GameObject BeginButton, Dropper1Button, Dropper2Button, Dropper3Button, Dropper4Button, MegaDropperButton, UpgraderButton;
    public GameObject Mine, Dropper1, Dropper2, Dropper3, Dropper4, MegaDropper, Upgrader;
    public GameObject Conveyor;

    public static GameManager GM;

    void Start()
    {
        if (GM == null) GM = this;
    }

    void Update()
    {
        SetCounter();
        ifIsClaimed();
    }

    void SetCounter()
    {
        Counter1.text = "Money \n" + Money;
        Counter2.text = Money.ToString();
    }

    void ifIsClaimed()
    {
        if (isTycoonClaimed)
        {
            Conveyor.SetActive(true);
            if (!MineScript.bought) BeginButton.SetActive(true); else BeginButton.SetActive(false);
            if (MineScript.bought) Mine.SetActive(true); else Mine.SetActive(false);
            if (!Dropper1Script.bought && MineScript.bought) Dropper1Button.SetActive(true); else Dropper1Button.SetActive(false);
            if (Dropper1Script.bought) Dropper1.SetActive(true); else Dropper1.SetActive(false);
            if (!Dropper2Script.bought && Dropper1Script.bought) Dropper2Button.SetActive(true); else Dropper2Button.SetActive(false);
            if (Dropper2Script.bought) Dropper2.SetActive(true); else Dropper2.SetActive(false);
            if (!Dropper3Script.bought && Dropper2Script.bought) Dropper3Button.SetActive(true); else Dropper3Button.SetActive(false);
            if (Dropper3Script.bought) Dropper3.SetActive(true); else Dropper3.SetActive(false);
            if (!Dropper4Script.bought && Dropper3Script.bought) Dropper4Button.SetActive(true); else Dropper4Button.SetActive(false);
            if (Dropper4Script.bought) Dropper4.SetActive(true); else Dropper4.SetActive(false);
            if (!MegaDropperScript.bought && Dropper4Script.bought) MegaDropperButton.SetActive(true); else MegaDropperButton.SetActive(false);
            if (MegaDropperScript.bought) MegaDropper.SetActive(true); else MegaDropper.SetActive(false);
            if (!UpgraderScript.bought && MegaDropperScript.bought) UpgraderButton.SetActive(true); else UpgraderButton.SetActive(false);
            if (UpgraderScript.bought) Upgrader.SetActive(true); else Upgrader.SetActive(false);
        }
        else
        {
            Conveyor.SetActive(false);
            BeginButton.SetActive(false);
            Mine.SetActive(false);
            Dropper1Button.SetActive(false);
            Dropper1.SetActive(false);
            Dropper2Button.SetActive(false);
            Dropper2.SetActive(false);
            Dropper3Button.SetActive(false);
            Dropper3.SetActive(false);
            Dropper4Button.SetActive(false);
            Dropper4.SetActive(false);
            MegaDropperButton.SetActive(false);
            MegaDropper.SetActive(false);
            UpgraderButton.SetActive(false);
            Upgrader.SetActive(false);
        }
    }
}
