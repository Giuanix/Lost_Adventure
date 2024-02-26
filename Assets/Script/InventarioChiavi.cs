using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InventarioChiavi : MonoBehaviour
{
    public int NumeroChiavi = 0;
    public GameObject Porta;
    // Start is called before the first frame update
    void Start()
    {
        NumeroChiavi = 0;
    }
    
    void IncrementoChiavi()
    {
        NumeroChiavi++;
    }

    void update()
    {
        if(NumeroChiavi==4)
        {
            Destroy(Porta);
        }
    }
}
