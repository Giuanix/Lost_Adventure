using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DardoPotenziato : MonoBehaviour
{
    public float Danno; //variabile per stabilire il danno

    private void OnCollisionEnter(Collision collision) //metodo per la gestione del proiettile e di come esso interagisce con l'ambiente
    {
        Destroy(gameObject);

       if (collision.transform.CompareTag("Guardia"))
        {
            collision.transform.GetComponent<GuardiaHealthSystem>().DannoSubito(Danno);
        }
        /*else if(collision.transform.CompareTag("Torretta"))
        {
            collision.transform.GetComponent<TorrettaHealthSystem>().DannoSubito(Danno);
        }
        else if(collision.transform.CompareTag("Boss"))
        {
            collision.transform.GetComponent<BossHealthSystem>().DannoSubito(Danno);
        }*/
    }
}
