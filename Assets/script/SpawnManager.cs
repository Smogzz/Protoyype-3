using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
        public GameObject BombPrefab;
        private Vector3 spawnPos = new Vector3(20,9,1);
        private float startDelay = 2;
        private float repeatRate = 2;
        private PlayerControls playerControllerScript;
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnObstacle", startDelay, repeatRate);
        playerControllerScript = GameObject.Find("Player(1)").GetComponent<PlayerControls>();
    }

    // Update is called once per frame
    void SpawnObstacle()
    {
     if (playerControllerScript.gameOver == false)
    {
        Instantiate(BombPrefab, spawnPos, BombPrefab.transform.rotation);
    }
    }
}
