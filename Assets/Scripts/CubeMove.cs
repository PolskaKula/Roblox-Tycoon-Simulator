using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeMove : MonoBehaviour
{
    [SerializeField] private float ConveyorSpeed = 5f;
    [SerializeField] private Vector3 direction;
    [SerializeField] List<GameObject> onBelt;

    void FixedUpdate()
    {
        for (int i = 0; i <= onBelt.Count - 1; i++)
        {
            if (onBelt[i] != null) onBelt[i].GetComponent<Rigidbody>().AddForce(ConveyorSpeed * direction);
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        onBelt.Add(collision.gameObject);
    }

    private void OnCollisionExit(Collision collision)
    {
        onBelt.Remove(collision.gameObject);
    }
}
