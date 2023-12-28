using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Luz : MonoBehaviour
{
public Light luz; // Referencia a la luz que quieres encender y apagar

    void Update()
    {
        // Encender o apagar la luz al presionar la tecla "E"
        if (Input.GetKeyDown(KeyCode.E))
        {
            luz.enabled = !luz.enabled; // Cambiar el estado de la luz (encendida/apagada)
        }
    }
}
