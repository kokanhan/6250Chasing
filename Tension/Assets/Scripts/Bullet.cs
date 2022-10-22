using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{

    public float life = 3.0f;

    private EnemyFollow enemyfollow;
    private void Awake()
    {
        //get enemy hp here
        enemyfollow = GameObject.Find("Enemy").GetComponent<EnemyFollow>();
        Destroy(gameObject, life);
    }
    // Start is called before the first frame update
    void Start()
    {
        if (!enemyfollow)
        {
            Debug.Log("What hell");
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        //minus enemy's blood, call TakeHits()
        if (collision.gameObject.tag == "Enemy")//if enemy hit the closed door
        {
            Debug.Log("Hey,I hit!");
            enemyfollow.TakeHits();
            Destroy(gameObject);
        }
    }
}
