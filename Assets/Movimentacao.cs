using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movimentacao : MonoBehaviour
{

    public Rigidbody rb; //aqui você coloca o que vai entrar como rigdbody
    public float vel;
    public float pulo;
    private bool pode = true;



    void FixedUpdate()
    {
        //Vector 3 Para poder colocar no move position
        Vector3 input = new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical"));

        //Movimentação
        rb.MovePosition(transform.position + input * Time.deltaTime * vel);

        
    }
    void Update(){
        //Pulo
        if (Input.GetButton("Jump") && pode){
            
            rb.AddForce(transform.up * pulo);
            pode = false;
          

        }

        if (Input.GetKeyUp("space"))
        {
            pode = true;
           
        }
    }
}

