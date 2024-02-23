using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField] private Rigidbody rb;
    [SerializeField] private float Speed;

    private Vector3 PlayerMovementInput;

    public GameObject Modello;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //Richiamo della Funzione di movimento del player
        PlayerMovementInput = new Vector3(Input.GetAxis("Horizontal"), 0f, Input.GetAxis("Vertical"));
        MovePlayer(); 

        //Gestione rotazione del player con il mouse
        Ray ray=Camera.main.ScreenPointToRay(Input.mousePosition);             
        Plane plane=new Plane(Vector3.up, Vector3.zero);             
        float distance;   

        if(plane.Raycast(ray, out distance))
        {                 
            Vector3 target = ray.GetPoint(distance);               
            Vector3 direction = target - transform.position;                 
            float rotation = Mathf.Atan2(direction.x, direction.z)*Mathf.Rad2Deg;                 
            Modello.transform.rotation = Quaternion.Euler(0, rotation, 0);
        }
    }

    //Funzione di gestione del movimento del player
    private void MovePlayer()
    {
        Vector3 MoveVector = transform.TransformDirection(PlayerMovementInput) * Speed;
        rb.velocity = new Vector3(MoveVector.x, rb.velocity.y, MoveVector.z);
    }
}
