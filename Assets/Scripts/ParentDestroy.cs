using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.SceneManagement;

public class ParentDestroy : MonoBehaviour
{

    private void OnCollisionEnter(Collision other)
    {
        FindObjectOfType<PlayEnemyDie>().PlaySound();

        string currentSceneName = SceneManager.GetActiveScene().name;
        if (currentSceneName == "MainScene")
        {
            FindObjectOfType<GameOver>().IncKillCount();
        }
        else if (currentSceneName == "Level2")
        {
            FindObjectOfType<GameOverLvl2>().IncKillCount();
        }


        if (gameObject.transform.parent.gameObject != null)
        {
            Destroy(gameObject.transform.parent.gameObject);
        }
  
    }
}
