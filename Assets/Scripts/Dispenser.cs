using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using UnityEngine;

public class Dispenser : MonoBehaviour
{
    [SerializeField] private GameObject cube;
    [SerializeField] private Vector3 spawn;
    [SerializeField] private bool isCooldown = true;
    [SerializeField] private int cooldown = 750;
    [SerializeField] private int CubeValue;

    async void Update()
    {
        if (isCooldown)
        {
            GameObject kjub = Instantiate(cube, spawn, Quaternion.identity);
            kjub.GetComponent<ValueSet>().value = CubeValue;
            isCooldown = false;
            await Task.Delay(cooldown);
            isCooldown = true;
        }
    }
}
