using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField] private Rigidbody rb;
    [SerializeField] private float Speed;

    private Vector3 PlayerMovementInput;
    private Vector3 PosizioneMouse;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        PlayerMovementInput = new Vector3(Input.GetAxis("Horizontal"), 0f, Input.GetAxis("Vertical"));
        MovePlayer(); 

        Vector3 PosizioneMouse = Input.mousePosition;
        PosizioneMouse = Camera.main.ScreenToWorldPoint(PosizioneMouse);

        Vector2 Direzione = new Vector2(PosizioneMouse.x - transform.position.x, PosizioneMouse.y - transform.position.y);
        transform.forward = Direzione;
    }

    private void MovePlayer()
    {
        Vector3 MoveVector = transform.TransformDirection(PlayerMovementInput) * Speed;
        rb.velocity = new Vector3(MoveVector.x, rb.velocity.y, MoveVector.z);
    }
}
