using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimeManagerScript : MonoBehaviour
{
    public GameObject rightHandReference;
    public float moveThreshold = 0.1f;
    public float minScale = 0.2f;
    public float smoothSpeed = 2f;
    public float maxScale = 1.0f;

    // Start is called before the first frame update

    Vector3 prev_position = new Vector3(0, 0, 0);
    // Update is called once per frame
    void Update()
    {
        float new_scale;
        Vector3 current_position = rightHandReference.transform.position;

        
        float distance = Vector3.Distance(current_position, prev_position);
        new_scale = Mathf.Clamp(moveThreshold + (distance * 100f), moveThreshold, 1.0f);
        //if (distance < moveThreshold)
        //{
        //    new_scale = 0.1f;
        //}
        //else
        //{
        //    new_scale = Mathf.Clamp(moveThreshold + (distance * 100f), moveThreshold, 1.0f);
        //}

        Time.timeScale = Mathf.Lerp(Time.timeScale, new_scale, Time.deltaTime * smoothSpeed);
        

        prev_position = current_position;
        //Time.fixedDeltaTime = 0.2f * Time.timeScale;

    }
}
