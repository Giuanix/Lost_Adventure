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
    }
    
    void Update()
    {
        if (timer <= 0f && Input.GetKey(KeyCode.Mouse0))
        {
            if(ArmaSpawn) 
            {
                NoHit();
            }
            else 
            {
                Hit();
                
                timerDespawn += Time.deltaTime;
                if (timerDespawn > MaxTimerDespawn)
                {
                    Spada.SetActive(false);
                    ArmaSpawn = false;
                }

                timer = MaxTimer;
            }
        }
        else 
        {
            timer -= Time.deltaTime;
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
