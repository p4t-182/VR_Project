using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.Audio;

public class PlayerShoot : MonoBehaviour
{
    public GameObject BulletTemplate;
    public float shootPower = 500f;

    public InputActionReference trigger;
    public AudioClip gunShotSFX;

    // Start is called before the first frame update
    void Start()
    {
        trigger.action.performed += Shoot;
    }

    // Update is called once per frame
    void Shoot(InputAction.CallbackContext _)
    {
        GameObject newBullet = Instantiate(BulletTemplate, transform.position, transform.rotation);
        newBullet.GetComponent<Rigidbody>().AddForce(transform.forward * shootPower);

        GetComponent<AudioSource>().PlayOneShot(gunShotSFX);
    }
}