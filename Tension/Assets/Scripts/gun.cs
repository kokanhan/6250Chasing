using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gun : MonoBehaviour
{
    public Transform bulletSpawnPoint;
    public GameObject bulletPrefab;
    public float bulletSpeed = 10f;
    

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(1))//right mouse is clicked
        {
            var bullet = Instantiate(bulletPrefab,
                                     bulletSpawnPoint.position,
                                     bulletSpawnPoint.rotation);
            bullet.GetComponent<Rigidbody>().velocity = bulletSpawnPoint.forward * bulletSpeed;

        }
    }
}
