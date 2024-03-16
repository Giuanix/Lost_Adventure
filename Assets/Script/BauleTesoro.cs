using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BauleTesoro : MonoBehaviour
{
    public GameObject Baule;
    
    void OnTriggerEnter(Collider col)
    {
        if(col.gameObject.CompareTag("Arma"))
        {
            Baule.GetComponent<Animator>().Play("BauleAperto");
        }

        if(col.gameObject.CompareTag("Player"))
        {
            Baule.GetComponent<Animator>().Play("BauleAperto");
        }
    }
}
