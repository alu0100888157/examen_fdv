using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public Animator animator;
    public Rigidbody2D rb;
    public int vidas = 0;
    public int mojones = 0;
    public float poder = 0f;
    private float velocidadvert;
    private float velocidadhor;
    private float speed = 7f;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        velocidadhor = Input.GetAxisRaw("Horizontal") * speed;
        velocidadvert = Input.GetAxisRaw("Vertical") * speed;
        Vector2 movement = new Vector2(velocidadhor, velocidadvert);
        movement *= Time.deltaTime;
        rb.MovePosition(movement + rb.position);
        //transform.Translate(movement);

        if (Input.GetButtonDown("Horizontal"))
        {
            Debug.Log(velocidadhor);
            if (velocidadhor > 0)
            {
                
                animator.SetBool("Left", false);
                animator.SetBool("Right", true);
                animator.SetBool("Up", false);
            }
            else
            {
                
                animator.SetBool("Left", true);
                animator.SetBool("Right", false);
                animator.SetBool("Up", false);
            }

        }


        if (Input.GetButtonDown("Vertical"))
        {
            Debug.Log(velocidadvert);
            if (velocidadvert > 0)
            {
                
                animator.SetBool("Left", false);
                animator.SetBool("Right", false);
                animator.SetBool("Up", true);
            }
            else
            {
                
                animator.SetBool("Left", false);
                animator.SetBool("Right", false);
                animator.SetBool("Up", false);
            }
        }
        if(mojones == 3)
        {
            vidas = 1;
        }
    }
}
