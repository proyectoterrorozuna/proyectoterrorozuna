using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CAMBIOCOLOR : MonoBehaviour
{
public GameObject objetoACambiarColor; // Referencia al objeto cuyo color cambiará
    public Color colorOriginal = Color.white; // Color original del objeto
    public Color nuevoColor = Color.red; // Nuevo color al presionar el botón

    private Renderer objetoRenderer; // Referencia al renderer del objeto
    private bool estadoAlternado = false; // Estado actual del botón (alternado o no)

    private void Start()
    {
        objetoRenderer = objetoACambiarColor.GetComponent<Renderer>();
        objetoRenderer.material.color = colorOriginal; // Establecer el color original al iniciar
    }

    private void OnMouseDown()
    {
        estadoAlternado = !estadoAlternado; // Alternar entre los estados

        if (estadoAlternado)
        {
            objetoRenderer.material.color = nuevoColor; // Cambiar al nuevo color
        }
        else
        {
            objetoRenderer.material.color = colorOriginal; // Volver al color original
        }
    }
}
