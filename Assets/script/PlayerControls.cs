using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControls : MonoBehaviour
{
    private Rigidbody playerRb;
    public float gravityModifier = 2.0f;
    public float jumpForce = 20.0f;
    public bool isOnGround = true;
    // Start is called before the first frame update
    void Start()
    {
        playerRb = GetComponent<Rigidbody>();
        Physics.gravity *= gravityModifier;

    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey(KeyCode.Space) && isOnGround == true)
        {
            playerRb.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
            isOnGround = false;
        }
    }

    void onCollisionEnter(Collision other)
    {
        isOnGround = true;
    }
}
