using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class P_3_GetKey_Movement : MonoBehaviour
{
    public float velocidad = 10;

    Vector3 mov, rot;



    [SerializeField]
    float ejemplo = 5;
    float angulo = 90f;
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
            Quaternion origen = transform.rotation;
            Quaternion destino = Quaternion.Euler(new Vector3(0, angulo * -1f, 0));
            transform.transform.rotation = Quaternion.Slerp(origen, destino, 0.5f * Time.deltaTime);
        }

        if (Input.GetKey(KeyCode.S))
        {
            transform.Translate(transform.forward * -1 * 10f * Time.deltaTime);
        }

        if (Input.GetKey(KeyCode.D))
        {
            Quaternion origen = transform.rotation;
            Quaternion destino = Quaternion.Euler(new Vector3(0, angulo, 0));
            transform.transform.rotation = Quaternion.Slerp(origen, destino, 0.5f * Time.deltaTime);
        }
    }
}
