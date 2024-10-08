using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HitScript : MonoBehaviour
{
    private void OnCollisionEnter(Collision other)
    {
        FindObjectOfType<TargetHitSound>().PlaySound();
        Destroy(gameObject);
        Debug.Log("Target " + gameObject.name + " hit!");
    }
}