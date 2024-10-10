using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class HitScript : MonoBehaviour
{
    private void OnCollisionEnter(Collision other)
    {
        
        string currentSceneName = SceneManager.GetActiveScene().name;
        if (currentSceneName == "WinScene")
        {
            Destroy(gameObject);
            SceneManager.LoadScene("Scenes/MainScene");
        }
        else
        {
            FindObjectOfType<TargetHitSound>().PlaySound();
            Destroy(gameObject);
        }

            
        Debug.Log("Target " + gameObject.name + " hit!");
    }
}