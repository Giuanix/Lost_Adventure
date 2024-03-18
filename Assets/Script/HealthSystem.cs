using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthSystem : MonoBehaviour
{
    public GameObject[] Gemma; //Contenitore per le icone della vita

    public GameObject Checkpoint; //Variabile contenente il punto di respawn del checkpoint

    public GameObject CheckpointImage; //Variabile che contine l'immagine del checkpoint

    Vector3 SpawnPoint; //Variabile che contiene la posizione vettoriale del punto di spawn del checkpoint

    public float MaxInvincibilita; //Variabile che setta il timer massimo di invincibilità

    private float Invincibilita; //Variabile che contiene il tempo di invincibilità

    int Life; //Variabile che contiene la quantità di vita del PG

    public int MaxLife; //Variabile che contiene la quantità massima di vita del PG

    public float MaxTimerCheckpoint; //Variabile che contiene la quantita massima del tempo di visione della dicitura "Checkpoint raggiunto" 

    private float TimerCheckpoint; //Variabile che contiene la quantita di tempo di visione della dicitura "Checkpoint raggiunto" 

    void Start()
    {
        Life = MaxLife;
        SpawnPoint = gameObject.transform.position;
    }
    // Update is called once per frame
    void Update()
    {
        if(Invincibilita > 0)
        {
            Invincibilita -= Time.deltaTime;
        }

        if(TimerCheckpoint > 0)
        {
            TimerCheckpoint -= Time.deltaTime;
        }
        else
        {
            CheckpointImage.gameObject.SetActive(false);
        }

        if(Life < 1)
        {
            gameObject.transform.position = SpawnPoint;
            Life = MaxLife;

            Gemma[1].gameObject.SetActive(true);
            Gemma[2].gameObject.SetActive(true);
            Gemma[3].gameObject.SetActive(true);
            Gemma[4].gameObject.SetActive(true);
            Gemma[5].gameObject.SetActive(true);
            Gemma[6].gameObject.SetActive(true);
            Gemma[7].gameObject.SetActive(true);
        }
        else if(Life < 2)
        {
            Gemma[1].gameObject.SetActive(false);
        }
        else if (Life < 3)
        {
            Gemma[2].gameObject.SetActive(false);
        }
        else if (Life < 4)
        {           
            Gemma[3].gameObject.SetActive(false);
        }
        else if (Life < 5)
        {
            Gemma[4].gameObject.SetActive(false);
        }
        else if (Life < 6)
        {
            Gemma[5].gameObject.SetActive(false);
        }
        else if (Life < 7)
        {
            Gemma[6].gameObject.SetActive(false);
        }
        else if (Life < 8)
        {
            Gemma[7].gameObject.SetActive(false);
        }
    }

    void OnTriggerEnter(Collider col)
    {
        if(col.CompareTag("Trappola"))
        {
            if (Invincibilita <= 0)
            {
                Life -= 1;
                Invincibilita = MaxInvincibilita;
            }
        }

        if(col.gameObject.CompareTag("Chiave"))
        {
            if(TimerCheckpoint <= 0)
            {
                CheckpointImage.gameObject.SetActive(true);
                TimerCheckpoint = MaxTimerCheckpoint;
            }
            
            SpawnPoint = Checkpoint.transform.position;
        }
    }
}
