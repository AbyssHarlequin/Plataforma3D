using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public Transform target;
    public float vel;
    private float velFixa;
    private bool move = false;

    void Update()
    {
        velFixa = vel * Time.deltaTime;

        transform.LookAt(target);

        if(move){

            transform.position = Vector3.MoveTowards(transform.position, target.position, velFixa);

        }
        
    }

    void OnTriggerEnter(Collider colisao)
    {
        if (colisao.gameObject.tag == "Player"){
            move = true;
        }
    }

    void OnTriggerExit(Collider colisao)
    {
        if (colisao.gameObject.tag == "Player"){
            move = false;
        }
    }


}
