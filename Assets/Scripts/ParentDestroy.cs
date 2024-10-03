using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParentDestroy : MonoBehaviour
{

    private void OnCollisionEnter(Collision other)
    {

        if (gameObject.transform.parent.gameObject != null)
        {
            Destroy(gameObject.transform.parent.gameObject);
        }
  
    }
}
