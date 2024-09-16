using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Espacio : MonoBehaviour
{
    public Transform puntoA;
    public Transform puntoB;
    public Color colorLinea = Color.red;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (puntoA != null && puntoB != null)
        {
            Debug.DrawLine(puntoA.position, puntoB.position, colorLinea);
        }
    }
}


