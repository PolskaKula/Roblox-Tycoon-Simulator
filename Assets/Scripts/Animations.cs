using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using UnityEngine;

public class Animations : MonoBehaviour
{
    [SerializeField] private Animator Larm;
    [SerializeField] private Animator Rarm;
    [SerializeField] private Animator Lleg;
    [SerializeField] private Animator Rleg;

    private bool isWalking;
    private bool isWalking2;
    private bool isJumping;

    async void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            if (!isJumping)
            {
                StartJumping();
                await Task.Delay(800);
                StopJumping();
            }
        }
        if (Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.S) || Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.UpArrow) || Input.GetKey(KeyCode.DownArrow) || Input.GetKey(KeyCode.LeftArrow) || Input.GetKey(KeyCode.RightArrow))
        {
            if (!isWalking)
            {
                StartWalking();
            }
        }
        else
        {
            if (isWalking)
            {
                StopWalking();
            }
        }
    }

    void StartWalking()
    {
        Larm.SetTrigger("Walking");
        Rarm.SetTrigger("Walk");
        Lleg.SetTrigger("Walk");
        Rleg.SetTrigger("Walk");
        isWalking = true;
        isWalking2 = true;
    }

    void StopWalking()
    {
        Larm.SetTrigger("Idle");
        Rarm.SetTrigger("Idle");
        Lleg.SetTrigger("Idle");
        Rleg.SetTrigger("Idle");
        isWalking = false;
        isWalking2 = false;
    }

    void StartJumping()
    {
        Larm.SetTrigger("Jump");
        Rarm.SetTrigger("Jump");
        isJumping = true;
        isWalking2 = false;
    }

    void StopJumping()
    {
        Larm.SetTrigger("Fall");
        Rarm.SetTrigger("Fall");
        isJumping = false;
        isWalking2 = false;
    }
}
