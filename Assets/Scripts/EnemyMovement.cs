using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovement : MonoBehaviour
{
    public float x = 0;
    public float y = 0;
    public Animator animator;
    public Rigidbody2D rb;
    private float velocidadvert = 0;
    private float velocidadhor = 2;
    //private float speed = 3f;
    private bool derecha = true;
    private PlayerMovement jugador;
    public static EnemyMovement SharedInstance;
    public List<GameObject> pool_objetos;
    public GameObject objeto_repetir;
    private int cantidad = 3;
    public int contador = 0;
    public int index;
    public GameObject enemigo1;
    public GameObject enemigo2;
    private bool first_time=true;
    private void Awake()
    {

        SharedInstance = this;
    }
    // Start is called before the first frame update
    void Start()
    {
        if (this.gameObject.name == "Enemigo1")
        {
            x = -39.5f;
            y = 5.42f;
        }
        else
        {
            x = 13.18f;
            y = 0.7f;
        }
        index = 0;
        pool_objetos = new List<GameObject>();
        for (int i = 0; i < cantidad; i++)
        {
            GameObject obj = (GameObject)Instantiate(objeto_repetir);
            pool_objetos.Add(obj);
            obj.SetActive(false);
        }
        InvokeRepeating("ChangePosition", 10, 10);
        InvokeRepeating("Resetear", 30, 30);
        
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
    void Resetear()
    {
        GameObject Enemigo = GetPooledObjects();
        if (!All_inactive())
        {
            pool_objetos[index].SetActive(false);
            index++;
            if (index >= pool_objetos.Count)
            {
                index = 0;
            }
        }
        if (Enemigo != null)
        {
            Enemigo.SetActive(true);
            Enemigo.transform.position = new Vector3(x, y, 0);
            contador++;
            Debug.Log("Entra");
        }
        enemigo1.SetActive(false);
        enemigo2.SetActive(false);
        if (first_time)
        {
            index--;
            first_time = false;
        }
        //Enemigo.GetComponentInParent<GameObject>.
        //Destroy(this.gameObject);
        //    Instantiate(this.gameObject);
        //    this.gameObject.SetActive(true);
        //    this.gameObject.transform.position = new Vector3(3, y, 0);
        //    contador++;
        //    //Debug.Log("Entra");
        
    }

    public GameObject GetPooledObjects()
    {
        for (int i = 0; i < pool_objetos.Count; i++)
        {
            if (!pool_objetos[i].activeInHierarchy)
            {
                return pool_objetos[i];
            }
        }
        return null;
    }
    public bool All_inactive()
    {
        bool inactivos = true;
        for (int i = 0; i < pool_objetos.Count; i++)
        {
            if (pool_objetos[i].activeInHierarchy)
            {
                inactivos = false;
            }
        }
        return inactivos;
    }
    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.name == "Jugador")
        {
            if(jugador.vidas > 0)
            {
                jugador.vidas -= 1;
                
            }
            else
            {
                jugador.poder = 0;
            }
            
            
        }
    }
}
