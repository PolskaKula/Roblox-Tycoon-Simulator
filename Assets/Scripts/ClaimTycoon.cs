using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class ClaimTycoon : MonoBehaviour
{
    public MeshRenderer Mesh;
    public Material Transparent;
    public Collider Kolizja;
    public TMP_Text TycoonClaimed;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            Mesh.material = Transparent;
            Kolizja.enabled = false;
            TycoonClaimed.text = "Player1's Tycoon";
            GameManager.GM.isTycoonClaimed = true;
        }
    }
}
