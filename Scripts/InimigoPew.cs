using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InimigoPew : MonoBehaviour
{

    [SerializeField]
    GameObject bala;
    [SerializeField]
    GameObject Vida1;
    [SerializeField]
    GameObject Vida2;
    [SerializeField]
    GameObject Vida3;
    [SerializeField]
    GameObject Win;

    float fireRate;
    float nextFire;

    public int Life = 3;

    // Start is called before the first frame update
    void Start()
    {
        fireRate = 1.5f;
        nextFire = Time.time;
    }

    // Update is called once per frame
    void Update()
    {
        CheckIfTimeToFire();
        CheckLife();
    }

    void CheckLife()
    {
        if (Life == 2)
        {
            Destroy(Vida1);
        }

        if (Life == 1)
        {
            Destroy(Vida2);
        }

        if (Life <= 0)
        {
            Destroy(Vida3);
            Destroy(gameObject);
            Win.SetActive(true);
        }
    }

    void OnTriggerEnter2D(Collider2D Col)
    {
        if (Col.tag == "Player")
        {
            Debug.Log("Bateu");
            Life--;
        }
    }

    void CheckIfTimeToFire()
    {
        if(Time.time > nextFire)
        {
            Instantiate(bala, transform.position, Quaternion.identity);
            nextFire = Time.time + fireRate;
        }
    }

    
}
