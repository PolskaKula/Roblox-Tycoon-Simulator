using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BeginWorking : MonoBehaviour
{
    [SerializeField] private int Cost;
    public bool bought;
    [SerializeField] private AudioSource Body;
    [SerializeField] private AudioClip Cash, Beep;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            if (GameManager.GM.Money >= Cost)
            {
                GameManager.GM.Money -= Cost;
                GameManager.GM.NumberOfUpgrades++;
                bought = true;
                Body.clip = Cash;
                Body.Play();
            }
            else
            {
                Body.clip = Beep;
                Body.Play();
            }
        }
    }
}
