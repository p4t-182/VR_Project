using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class ParentDestroy : MonoBehaviour
{

    private void OnCollisionEnter(Collision other)
    {
        FindObjectOfType<PlayEnemyDie>().PlaySound();

        if (gameObject.transform.parent.gameObject != null)
        {
            Destroy(gameObject.transform.parent.gameObject);
        }
  
    }
}
