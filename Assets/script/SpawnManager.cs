using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
        public GameObject Barrel_02Prefab;
        private Vector3 spawnPos = new Vector3(8,0,0);
        private float startDelay = 2;
        private float repeatRate = 2;
        private PlayerControls playerControllerScript;
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnObstacle", startDelay, repeatRate);
        playerControllerScript = GameObject.Find("Player").GetComponent<PlayerControls>();
    }

    // Update is called once per frame
    void SpawnObstacle()
    {
     if (playerControllerScript.gameOver == false)
    {
        Instantiate(Barrel_02Prefab, spawnPos, Barrel_02Prefab.transform.rotation);
    }
    }
}
