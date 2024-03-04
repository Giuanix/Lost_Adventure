using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AperturaBaule : MonoBehaviour
{
    public GameObject Baule;
    
    void ApriBaule()
    {
        Baule.GetComponent<Animator>().Play("BauleAperto");
    }
}
