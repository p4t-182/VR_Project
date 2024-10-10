using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOver : MonoBehaviour
{
    public static int count = 0;
    void Start()
    {
        count = 0;
    }
    public void IncKillCount()
    {
        count++;
    }
    void Update()
    {
        if (count >= 3)
        {
            SceneManager.LoadScene("Scenes/Level2");
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "EnemyHitBox" || other.gameObject.tag == "EnemyBullet")
        {
            count = 0;
            string currentSceneName = SceneManager.GetActiveScene().name;
            SceneManager.LoadScene(currentSceneName);
        }
    }
}
