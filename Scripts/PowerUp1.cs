using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerUp1 : MonoBehaviour
{
    public GameObject Po;
    public GameObject PU;    

    void OnTriggerEnter2D(Collider2D other)
    {
        if(other.gameObject.tag == "Player")
        {
            Po.SetActive(true);            
            PU.SetActive(false);                   
        }
        
    }
    
}
