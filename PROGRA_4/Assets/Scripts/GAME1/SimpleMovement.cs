using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SimpleMovement : MonoBehaviour
{
    public float speed = 1;
    public float frequency = 1;
    public float lenght = 1;


    public enum PlatformType { Vertical, Horizontal, Circular }
    public PlatformType platformType;
    enum Days { Lunes, Martes, Miercoles, Jueves, Viernes }


    void Start()
    {

    }

    void Update()
    {
        Debug.Log(Time.fixedTime);
        float step = Time.deltaTime * speed;

        if (platformType == PlatformType.Vertical)
            transform.position = new Vector3(transform.position.x, Mathf.Sin(Time.fixedTime * frequency) * lenght, transform.position.z);


        else if (platformType == PlatformType.Horizontal)
            transform.position = new Vector3(Mathf.Sin(Time.fixedTime * frequency) * lenght, transform.position.y, transform.position.z);

        else if (platformType == PlatformType.Circular)
            transform.position = new Vector3(Mathf.Cos(Time.fixedTime * frequency) * lenght, Mathf.Sin(Time.fixedTime * frequency) * lenght, transform.position.z);

    }
}