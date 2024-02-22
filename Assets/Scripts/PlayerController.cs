using System.Threading.Tasks;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private CharacterController characterController;
    [SerializeField] private float speed = 5f;
    public Vector3 velocity;

    [SerializeField] private bool groundedPlayer;
    [SerializeField] private float jumpHeight = 2.0f;
    [SerializeField] private float sprint = 1f;
    [SerializeField] private float fallingSpeed = 19.62f;

    [SerializeField] private GameObject ArmL;
    [SerializeField] private GameObject ArmR;
    [SerializeField] private GameObject LegL;
    [SerializeField] private GameObject LegR;

    [SerializeField] private Transform groundCheck;
    [SerializeField] private LayerMask groundMask;

    [SerializeField] private AudioSource OOF;

    void Start()
    {
        characterController = GetComponent<CharacterController>();
    }

    void Update()
    {
        PlayerMove();
        isSprinting();
        IntoTheVoid();
    }

    void PlayerMove()
    {
        RaycastHit hit;
        groundedPlayer = Physics.Raycast(groundCheck.position, transform.TransformDirection(Vector3.down), out hit, 0.2f, groundMask);

        float x = Input.GetAxis("Horizontal");
        float y = Input.GetAxis("Vertical");

        Vector3 move = transform.right * x + transform.forward * y;
        characterController.Move(move * sprint * speed * Time.deltaTime);

        if (groundedPlayer)
        {
            if (velocity.y < 0)
            {
                velocity.y = 0f;
            }

            if (Input.GetButtonDown("Jump"))
            {
                velocity.y += Mathf.Sqrt(jumpHeight * -3.0f * -fallingSpeed);
            }
        }

        velocity.y += -fallingSpeed * Time.deltaTime;
        characterController.Move(velocity * Time.deltaTime);
    }

    void isSprinting()
    {
        if (Input.GetKey(KeyCode.LeftShift)) sprint = 2f; else sprint = 1f;
    }

    void IntoTheVoid()
    {
        if (transform.position.y < -5)
        {
            transform.position = new Vector3(0, 2, 0);
            OOF.Play();
        }
    }
}