using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MOVIMIENTOS : MonoBehaviour
{
public float velocidadMovimiento = 5.0f;
    public float velocidadRotacion = 3.0f;

    private void Update()
    {
        // Movimiento del objeto con las teclas WASD
        float movimientoHorizontal = Input.GetAxis("Horizontal");
        float movimientoVertical = Input.GetAxis("Vertical");

        Vector3 movimiento = new Vector3(movimientoHorizontal, 0.0f, movimientoVertical) * velocidadMovimiento * Time.deltaTime;
        transform.Translate(movimiento);

        // Rotación de la cámara con el movimiento del ratón
        float mouseX = Input.GetAxis("Mouse X") * velocidadRotacion;
        transform.Rotate(Vector3.up, mouseX);
    }
}
