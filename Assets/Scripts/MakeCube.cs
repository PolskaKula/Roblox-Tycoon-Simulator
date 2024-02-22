using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using UnityEngine;

public class MakeCube : MonoBehaviour
{
    [SerializeField] private LayerMask Button;
    [SerializeField] private GameObject cube;
    [SerializeField] private Vector3 spawn;
    [SerializeField] private bool Cooldown = true;
    [SerializeField] private int CubeValue;

    void Update()
    {
        MakeaCube();
    }

    async void MakeaCube()
    {
        RaycastHit hit;
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);

        if (Physics.Raycast(ray, out hit, Button))
        {
            if (Input.GetMouseButtonDown(0) && Cooldown)
            {
                GameObject kjub = Instantiate(cube, spawn, Quaternion.identity);
                kjub.GetComponent<ValueSet>().value = CubeValue;
                Cooldown = false;
                await Task.Delay(250);
                Cooldown = true;
            }
        }
    }
}
