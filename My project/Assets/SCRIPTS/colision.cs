using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class colision : MonoBehaviour
{
void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Piso"))
        {
            Debug.Log("El personaje ha colisionado con el piso.");
            // Agrega aquí cualquier lógica que desees realizar cuando el personaje colisiona con el piso.
        }
    }
}
