using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GuardiaHealthSystem : MonoBehaviour
{
    public float Life; //variabile per stabilire la vita

    public float MaxInvincibilita; //Variabile che setta il timer massimo di invincibilità

    private float Invincibilita; //Variabile che contiene il tempo di invincibilità

    void Update()
    {
        if(Invincibilita > 0)
        {
            Invincibilita -= Time.deltaTime;
        }
    }

    public void DannoSubito(float value) //metodo per la gestione in game del nemico
    {
        Life -= value;
        if (Life <= 0) Destroy(gameObject);
    }

    void OnTriggerEnter(Collider col)
    {
        if(col.CompareTag("Spada"))
        {
            if (Invincibilita <= 0)
            {
                Life -= 3;
                Invincibilita = MaxInvincibilita;
                if (Life <= 0) Destroy(gameObject);
            }
        }
        else if(col.CompareTag("Ascia"))
        {
            if (Invincibilita <= 0)
            {
                Life -= 4;
                Invincibilita = MaxInvincibilita;
                if (Life <= 0) Destroy(gameObject);
            }
        }
    }
}
