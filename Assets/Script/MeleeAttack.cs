using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MeleeAttack : MonoBehaviour
{
    public static bool ArmaSpawn = false;
    public GameObject Spada;
    
    private float timer;
    public float MaxTimer;
    public float TimerDespawn;
    
    void Start()
    {
        timer = MaxTimer;
    }
    
    void Update()
    {
        //Gestione dell'attacco melee
        if (timer <= 0f && Input.GetKey(KeyCode.Mouse0))
        {
            if(ArmaSpawn) 
            {
                NoHit();
            }
            else 
            {
                Hit();
                timer = MaxTimer;
                Invoke("DespawnSpada",TimerDespawn);
            }
        }
        else 
        {
            timer -= Time.deltaTime;
        } 
    }

    //Funzione della scomparsa dell'arma post attacco
    void DespawnSpada()
    {
        Spada.SetActive(false);
        ArmaSpawn = false;
    }

    //Funzione dell'arma in stato di riposo
    void NoHit()
    {
        Spada.SetActive(false);
        ArmaSpawn = false;
    }

    //Funzione dell'arma in stato di attacco
    void Hit()
    {
        Spada.SetActive(true);
        ArmaSpawn= true;
    }   
}
