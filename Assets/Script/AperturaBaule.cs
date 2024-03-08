using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AperturaBaule : MonoBehaviour
{
    public GameObject Baule;
    
    public void ApriBaule()
    {
        Baule.GetComponent<Animator>().Play("BauleAperto");
    }
}
