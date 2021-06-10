using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


public class pontos : MonoBehaviour
{
    public Text score; 
    public float ponto;
    public int contador;
    public int velocidade;
    public object SceneMananger { get; private set; }
    void Start()
    {
        contador = 0;
        ponto = 0;
        Debug.Log("Pontos: " + ponto);
    }



    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "ponto")
        {
            contador++;
            ponto += 1;
            Debug.Log("Pontos: " + ponto);
            other.gameObject.SetActive(false);
            atualizarTextoScore();
        }
        if (other.gameObject.tag == "tirarPontos")
        {
            contador++;
            ponto -= 1;
            Debug.Log("Pontos: " + ponto);
            other.gameObject.SetActive(false);
            atualizarTextoScore();
        }

    }

    void atualizarTextoScore()
    {
        score.text = "SCORE: " + ponto;
    }

    void Update(){
        if (ponto == -1){
            Destroy(gameObject);
        if (transform.position.y < -2)
        {
            SceneManager.LoadScene(0);
        }
}

        }
    }


 



