using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class HealthSystem : MonoBehaviour
{
    public GameObject[] Gemma;

    int Life;

    public int MaxLife;
    // Start is called before the first frame update
    void Start()
    {
        Life = MaxLife;
    }
    // Update is called once per frame
    void Update()
    {
        if(Life < 1)
        {
            //SceneManager.LoadScene(GameOver);
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
            Life-=1;
        }
    }
}
