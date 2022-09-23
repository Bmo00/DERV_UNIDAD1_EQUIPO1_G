using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class P_4_Rotacion : MonoBehaviour
{
    public float velocidad = 10;
    
    Vector3 mov, rot;

    [SerializeField]
    float ejemplo = 5;
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Codigo ejecutado una vez");
    }

    // Update is called once per frame
    void Update()
    {
        

        mov = transform.forward; //relacion al personaje

        mov = Vector3.forward; //relacion a la escena
        mov = Vector3.back;

        mov = new Vector3(10, 10, 10f); //x y z

        

        if (Input.GetKey(KeyCode.W))
        {
            transform.Translate(transform.forward * 10f * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.A))
        {
            Debug.Log("A");

        }
        if (Input.GetKey(KeyCode.S))
        {
            transform.Translate(transform.forward * -1 * 10f * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.D))
        {
            Debug.Log("D");
        }
    }
}
