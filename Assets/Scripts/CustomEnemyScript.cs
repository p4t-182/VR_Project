using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CustomEnemyScript : MonoBehaviour
{
    [SerializeField]
    private float speed = 10f;
    [SerializeField]
    private float bulletSpeed = 1f;
    [SerializeField]
    private float interval = 2f;

    public GameObject bullet_template;

    private GameObject playerTarget;
    private float timeTillNextShot = 0f;

    // When the player enters the trigger, assign it as a target
    private void OnTriggerEnter(Collider other)
    {
        playerTarget = other.gameObject;
    }

    private void Shoot()
    {
        
        GameObject newBullet = Instantiate(bullet_template, transform.position, transform.rotation);
        //Vector3 directionToPlayer = (player_target.transform.position - newBullet.transform.position).normalized;
        newBullet.GetComponent<Rigidbody>().AddForce(transform.forward * bulletSpeed);
    }

    // Update is called once per frame
    void Update()
    {
        // Only move forward if there is a player target
        if (playerTarget != null)
        {
            transform.LookAt(playerTarget.transform.position);
            transform.position += transform.forward * Time.deltaTime * speed;

            if(Time.time >= timeTillNextShot)
            {
                Shoot();
                timeTillNextShot = Time.time + interval;
            }
        }

    }

}
