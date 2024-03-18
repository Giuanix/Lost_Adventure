using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spada : MonoBehaviour
{
    public float MaxInvincibilita; //Variabile che setta il timer massimo di invincibilità

    private float Invincibilita; //Variabile che contiene il tempo di invincibilità

    public float Danno; //variabile per stabilire il danno
    
    void OnTriggerEnter(Collider col)
    {
        if(col.transform.CompareTag("Guardia"))
        {
            if (Invincibilita <= 0)
            {
                col.transform.GetComponent<GuardiaHealthSystem>().DannoSubito(Danno);
                Invincibilita = MaxInvincibilita;
            }
        }
    }
}
