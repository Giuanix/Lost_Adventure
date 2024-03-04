using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ContatoreHUD : MonoBehaviour
{
    public int TotaleChiavi = 0; //variabile che contiene lo score totalizzato

    public TMP_Text text; //variabile di tipo testo

    void Update() //metodo per implementare lo score e stamparlo nella GUI di gioco
    {
        text.text = "x " + TotaleChiavi.ToString();
    }
}
