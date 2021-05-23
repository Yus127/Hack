using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movimientopersonaje : MonoBehaviour
{

    public float velocidad = 5f;
    public Rigidbody2D rb;
    public Animator animator;

    Vector2 movimiento;

    // Update is called once per frame
    void Update()
    {
        //Input
        movimiento.x = Input.GetAxisRaw("Horizontal");
        movimiento.y = Input.GetAxisRaw("Vertical");
        animator.SetFloat("Horizontal", movimiento.x);
        animator.SetFloat("Vertical", movimiento.y);
        animator.SetFloat("Velocidad", movimiento.sqrMagnitude);
    }
    void FixedUpdate()
    {
        // Movimiento
        rb.MovePosition(rb.position + movimiento*velocidad * Time.fixedDeltaTime);

    }


    void OnCollisionEnter2D(Collision2D collision){
        
        if (collision.gameObject.tag == "Estante" )
        {
            print("hola");

        }

        
    }
}
