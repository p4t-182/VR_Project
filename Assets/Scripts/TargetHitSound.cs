using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TargetHitSound : MonoBehaviour
{
    public AudioClip targetExplode;


    public void PlaySound()
    {
        GetComponent<AudioSource>().PlayOneShot(targetExplode);
    }

}
