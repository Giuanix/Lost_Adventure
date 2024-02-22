using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MeleeAttack : MonoBehaviour
{
    public static bool ArmaSpawn = false;

    public GameObject Spada;

    private float timer;

    private float timerDespawn;

    public float MaxTimer;

    public float MaxTimerDespawn;
    
    

    void Start()
    {
        timer = MaxTimer;
        timerDespawn = MaxTimerDespawn;
    }
    
    void Update()
    {
        if (timer <= 0f && Input.GetKey(KeyCode.Mouse0))
        {
            if(ArmaSpawn) 
            {
                NoHit();
                timerDespawn = MaxTimerDespawn;
            }
            else 
            {
                Hit();
                timer = MaxTimer;
                timerDespawn -= Time.deltaTime;
            }
        }
        else 
        {
            timer -= Time.deltaTime;
        }

        if (timerDespawn <= 0f)
        {
            Spada.SetActive(false);
            ArmaSpawn = false;
        }
        
    }

    void NoHit()
    {
        Spada.SetActive(false);
        ArmaSpawn = false;
    }

    void Hit()
    {
        Spada.SetActive(true);
        ArmaSpawn= true;
    }   
}
