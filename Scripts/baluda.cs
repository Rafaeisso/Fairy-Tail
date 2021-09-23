using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class baluda : MonoBehaviour
{
    private Quaternion rotacao;

    float moveSpeed = 6f;

    Rigidbody2D rb;

    GameObject target;
    Vector2 moveDirection;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        target = GameObject.Find("Jogador");
        Destroy(gameObject, 4f);
    }

    void Update()
    {
        rotacao = Quaternion.LookRotation(transform.position - target.transform.position, transform.forward);
        rotacao.x = 0;
        rotacao.y = 0;
        transform.root.rotation = rotacao;
        transform.root.Translate(Vector2.up * moveSpeed * Time.deltaTime);
    }

    void OnTriggerEnter2D (Collider2D col)
    {
        if (col.gameObject.name.Equals("Jogador"))
        {            
            Destroy(gameObject);
        }
    }
}
