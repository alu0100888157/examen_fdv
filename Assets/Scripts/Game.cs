using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Game : MonoBehaviour
{

    public GameObject prefab1;
    public GameObject prefab2;
    public static Game SharedInstance;
    public List<GameObject> pool_objetos;
    public GameObject objeto_repetir;
    private int cantidad = 1;
    public int contador = 0;
    public int index;


    private void Awake()
    {
        prefab1.SetActive(true);
        prefab2.SetActive(true);
        SharedInstance = this;
    }
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("Resetear", 20, 20);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void Resetear()
    {
        
        Destroy(prefab1);
        Destroy(prefab2);
        Instantiate(prefab1);
        Instantiate(prefab2);
        Instantiate(this.gameObject);
       //'this.gameObject.SetActive(true);
        //this.gameObject.transform.position = new Vector3(3, , 0);
        contador++;

    }
}
