using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GizmosScript : MonoBehaviour
{
    public Transform referencia;
    public float radio = 1f;
    public Color colorGizmo = Color.blue;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnDrawGizmos()
    {
        if (referencia != null)
        {
            Gizmos.color = colorGizmo;

            Gizmos.DrawSphere(referencia.position, radio);

            Vector3 direccion = referencia.position - transform.position;
            Gizmos.DrawRay(transform.position, direccion);
        }
    }
}
