using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MeleeAttack : MonoBehaviour
{
    public static bool ArmaSpawn = false;

    public GameObject Spada;
    public GameObject Ascia;

    private GameObject ArmaEquipaggiata; //Variabile che tiene conto dell'arma attualmente equipaggiata
    
    private float timer; //Variabile che controlla la cadenza di attacco
    public float MaxTimer; //Variabile che controlla la cadenza massima di attacco
    public float TimerDespawn; //Variabile che controlla il timer di despawn dell'arma

    public float TimerPerSwitchArma; //Variabile che controlla se possiblile lo switch dell'arma

    void Start()
    {
        timer = MaxTimer;
        ArmaEquipaggiata = Spada;
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
        ArmaEquipaggiata.SetActive(false);
        ArmaSpawn = false;
    }

    //Funzione dell'arma in stato di riposo
    void NoHit()
    {
        ArmaEquipaggiata.SetActive(false);
        ArmaSpawn = false;
    }

    //Funzione dell'arma in stato di attacco
    void Hit()
    {
        ArmaEquipaggiata.SetActive(true);
        ArmaSpawn = true;
    } 

    void OnTriggerEnter(Collider col)
    {
        if(col.gameObject.CompareTag("BauleArma"))
        {
            ArmaEquipaggiata = Ascia;
            Destroy(Spada);
        }
    }  
}
