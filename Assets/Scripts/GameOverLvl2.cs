using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOverLvl2 : MonoBehaviour
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
        Debug.Log(count);
        if (count >= 5)
        {
            SceneManager.LoadScene("Scenes/WinScene");
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
