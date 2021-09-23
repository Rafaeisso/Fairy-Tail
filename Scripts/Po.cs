using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Po : MonoBehaviour
{
    public GameObject Powder;
    public GameObject textoPonto;
    public GameObject Winn;

    public static int ponto;

    public GameObject Jugador;

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Player")
        {
            ponto++;
            Powder.SetActive(false);  
            
        }

        if (ponto >= 5)
        {
            Winn.SetActive(true);
        }
    }

    void Update()
    {
        textoPonto.GetComponent<Text>().text = "Pontos: " + ponto;

    }

    void OnBecameInvisible()
    {
        if(Jugador == false)
        {
            ponto = 0;
        }

    }

    



}
