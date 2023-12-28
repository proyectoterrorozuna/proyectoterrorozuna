using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BOTON : MonoBehaviour
{
public Light luz; // Referencia a la luz que quieres encender y apagar

    // Detectar cuando el objeto es presionado
    private void OnMouseDown()
    {
        // Encender o apagar la luz
        luz.enabled = !luz.enabled; // Cambiar el estado de la luz (encendida/apagada)
    }
}
