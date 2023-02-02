using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movimiento : MonoBehaviour
{

    //Ajustar velocidad
    public float speed = 1.0f;

    //Posición del cilindro
    private Transform target;

    // Start is called before the first frame update
    void Start()
    {
        //Posición original del cubo
        transform.position = new Vector3(0.0f, 0.0f, 0.0f);

        //Posición del cilindro
        var cylinder = GameObject.CreatePrimitive(PrimitiveType.Cylinder);
        cylinder.transform.localScale = new Vector3(0.15f, 1.0f, 0.15f);

        //Poner valores del cilindro en el target
        target = cylinder.transform;
        target.transform.position = new Vector3(0.8f, 0.0f, 0.8f);

        //Posición del suelo
        GameObject floor = GameObject.CreatePrimitive(PrimitiveType.Plane);
        floor.transform.position = new Vector3(0.0f, -1.0f, 0.0f);
    }

    
    void Update()
    {
        {
        // Mover posición al target
        var step =  speed * Time.deltaTime; // calculate distance to move
        transform.position = Vector3.MoveTowards(transform.position, target.position, step);

        //Comprobar si la distancia entre los cubos es equitativa
        if (Vector3.Distance(transform.position, target.position) < 0.001f)
        {
            //Cambiar posición del cilindro
            target.position *= -1.0f;
        }
    }
    }
}
