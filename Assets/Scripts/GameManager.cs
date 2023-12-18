using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public GameObject cactus;
    public Transform spawnPosition;
    public float spawnTime;
    float timer;

    public GameObject GameOverScence;

    // Start is called before the first frame update
    void Start()
    {
        Time.timeScale = 1;
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

    public void GameOver()
    {
        Time.timeScale = 0;
        GameOverScence.SetActive(true);
    }

    public void Restart()
    {
        SceneManager.LoadScene("Lv1");
    }
}
