using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public GameObject cactus;
    public Transform spawnPosition;
    public float spawnTime;
    float timer;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;

        if (timer >= spawnTime)
        {
            Instantiate(cactus, spawnPosition);
            timer = 0;
        }
    }
}
