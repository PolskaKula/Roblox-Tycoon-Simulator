using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyCube : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Block"))
        { 
            Destroy(collision.gameObject);
            GameManager.GM.Money += collision.gameObject.GetComponent<ValueSet>().value;
        }
    }
}
