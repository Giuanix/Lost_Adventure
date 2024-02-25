using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MagicalAttack : MonoBehaviour
{
    public Transform BulletSpawnPoint;
    public GameObject Bullet;
    public float BulletSpeed;
    public float TimerDespawn;

    private float timer;
    public float MaxTimer;

    void Update()
    {
        if(timer <= 0f && Input.GetKeyDown(KeyCode.Mouse1))
        {
            var bullet = Instantiate(Bullet,BulletSpawnPoint.position, BulletSpawnPoint.rotation);
            bullet.GetComponent<Rigidbody>().velocity = BulletSpawnPoint.forward * BulletSpeed;
            Destroy(bullet, TimerDespawn);
            timer = MaxTimer;
        }
        else
        {
            timer -= Time.deltaTime;
        }
    }
}
