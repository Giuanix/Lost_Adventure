using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BauleTesoro : MonoBehaviour
{
    public GameObject Baule;

    void OnTriggerEnter(Collider col)
    {
        if(col.gameObject.tag == "Player")
        {
            col.gameObject.SendMessage("AperturaBaule");
            Baule.GetComponent<Animator>().Play("BauleAperto");
        }
    }
}
