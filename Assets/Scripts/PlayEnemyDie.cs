using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class PlayEnemyDie : MonoBehaviour

{
    public AudioClip enemyExplode;


    public void PlaySound()
    {
        GetComponent<AudioSource>().PlayOneShot(enemyExplode);
    }

}
