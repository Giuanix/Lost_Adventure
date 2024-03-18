using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MagicalAttack : MonoBehaviour
{
    public Transform ProiettileSpawnPoint;

    private GameObject ProiettileEquipaggiato;

    public GameObject ProiettileBase;
    public GameObject ProiettilePotenziato;

    public float BulletSpeed;
    public float TimerDespawn;

    private float timer;
    public float MaxTimer;

    void Start()
    {
        ProiettileEquipaggiato = ProiettileBase;
    }

    void Update()
    {
        if(timer <= 0f && Input.GetKeyDown(KeyCode.Mouse1))
        {
            var bullet = Instantiate(ProiettileEquipaggiato,ProiettileSpawnPoint.position, ProiettileSpawnPoint.rotation);
            bullet.GetComponent<Rigidbody>().velocity = ProiettileSpawnPoint.forward * BulletSpeed;
            Destroy(bullet, TimerDespawn);
            timer = MaxTimer;
        }
        else
        {
            timer -= Time.deltaTime;
        }
    }

    void OnTriggerEnter(Collider col)
    {
        if(col.gameObject.CompareTag("BauleMagia"))
        {
            ProiettileEquipaggiato = ProiettilePotenziato;
        }
    }  
}
