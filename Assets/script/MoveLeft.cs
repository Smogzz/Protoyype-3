using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveLeft : MonoBehaviour
{
    private float speed = 16;
    private PlayerControls playerControllerXScript;
    private float leftBound = -15;
    // Start is called before the first frame update
    void Start()
    {
       playerControllerXScript = GameObject.Find("Player(1)").GetComponent<PlayerControls>();
    }

    // Update is called once per frame
    void Update()
    { 
        if (playerControllerXScript.gameOver == false)
        {
            transform.Translate(Vector3.left * speed * Time.deltaTime);
        }
        
        if (transform.position.x < leftBound && gameObject.CompareTag("Bomb"))
        {
            Destroy(gameObject);
        }
    }
}
