using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SolarSystem : MonoBehaviour
{
    public Vector3 puntoCentro;
    public float velocidadRotacionSol;

    public Transform satelite1;
    public float velocidadRotacionSatelite1;
    public float distanciaSatelite1;

    public Transform satelite2;
    public float velocidadRotacionSatelite2;
    public float distanciaSatelite2;

    void Update()
    {
        transform.RotateAround(puntoCentro, Vector3.up, velocidadRotacionSol * Time.deltaTime);

        Vector3 direccionAbertura = puntoCentro - transform.position;
        transform.rotation = Quaternion.LookRotation(direccionAbertura, Vector3.up);

        if (satelite1 != null)
        {
            satelite1.RotateAround(transform.position, Vector3.up, velocidadRotacionSatelite1 * Time.deltaTime);
        }

        if (satelite2 != null && satelite1 != null)
        {
            float angulo = velocidadRotacionSatelite2 * Time.time;
            Vector3 offset = new Vector3(Mathf.Cos(angulo), Mathf.Sin(angulo), 0) * distanciaSatelite2;
            satelite2.position = satelite1.position + offset;

            satelite2.LookAt(satelite1);
        }
    }

    private void OnDrawGizmos()
    {
        if (satelite1 != null && satelite2 != null)
        {
            Gizmos.color = Color.red;
            Gizmos.DrawLine(transform.position, puntoCentro);

            Gizmos.color = Color.green;
            Gizmos.DrawLine(transform.position, satelite1.position);

            Gizmos.color = Color.blue;
            Gizmos.DrawLine(transform.position, satelite2.position);

            Gizmos.color = Color.yellow;
            Gizmos.DrawLine(satelite1.position, satelite2.position);
        }
    }
}