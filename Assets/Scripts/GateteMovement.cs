using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GateteMovement : MonoBehaviour
{
    public Animator animator;
    public Rigidbody2D rb;
    private float velocidadvert = 0;
    private float velocidadhor = 2;
    private PlayerMovement jugador;
    private bool derecha = true;
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("ChangePosition", 10, 10);
    }

    // Update is called once per frame
    void Update()
    {
        //velocidadhor = Input.GetAxisRaw("Vertical") * speed + 1;
        //velocidadvert = Input.GetAxisRaw("Vertical") * speed;
        Vector2 movement = new Vector2(velocidadhor, velocidadvert);
        movement *= Time.deltaTime;
        rb.MovePosition(movement + rb.position);
    }
    void ChangePosition()
    {

        if (derecha)
        {
            velocidadhor = 2;
            animator.SetBool("Right", true);
            derecha = false;
        }
        else
        {
            velocidadhor = -2;
            animator.SetBool("Right", false);
            derecha = true;
        }
    }
    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.name == "Jugador")
        {

            jugador.poder += 1;
        }
    }
}
