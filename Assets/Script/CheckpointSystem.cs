using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckpointSystem : MonoBehaviour
{
    public GameObject Checkpoint;
    Vector3 SpawnPoint;

    // Start is called before the first frame update
    void Start()
    {
        SpawnPoint = gameObject.transform.position;
        
    }

    // Update is called once per frame
    void Update()
    {
        if(gameObject.transform.position.y < -20f)
        {
            gameObject.transform.position = SpawnPoint;
        }
    }

    void OnTriggerEnter (Collider other)
    {
        if(other.gameObject.CompareTag("Chiave"))
        {
            SpawnPoint = Checkpoint.transform.position;
        }
    }
}
