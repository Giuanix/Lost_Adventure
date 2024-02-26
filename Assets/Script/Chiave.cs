using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Chiave : MonoBehaviour
{
    public float rotationSpeed = 100.0f;
    // Update is called once per frame
    void Update()
    {
        transform.Rotate(new Vector3(0, rotationSpeed * Time.deltaTime,0));
    }

    void OnTriggerEnter(Collider col)
    {
        if(col.gameObject.tag == "Player")
        {
            col.gameObject.SendMessage("IncrementoChiavi");
            Destroy(gameObject);
        }
    }
}
