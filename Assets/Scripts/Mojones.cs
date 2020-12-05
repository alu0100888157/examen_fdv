using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mojones : MonoBehaviour
{
    private bool activado = false;
    public PlayerMovement jugador;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.name == "Jugador" && !activado)
        {
            jugador.mojones += 1;
            activado = true;
            
        }
    }
}
