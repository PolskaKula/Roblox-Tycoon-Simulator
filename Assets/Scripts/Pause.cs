using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Pause : MonoBehaviour
{
    void Start()
    {
        Button pause = GetComponent<Button>();
        pause.onClick.AddListener(Pauz);
    }

    void Pauz()
    {
        Application.Quit();
    }
}
