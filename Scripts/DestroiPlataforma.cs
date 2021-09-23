using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroiPlataforma : MonoBehaviour
{

    public GameObject plataformas;
        
    void OnTriggerEnter2D (Collider2D other)
    {

        if(other.gameObject.tag == "Player")
        {
            Destroy(plataformas, 0.75f);
        }
              
    }
}
