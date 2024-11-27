using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovimientoJugador : MonoBehaviour
{
    [SerializeField]
    float movimientoEjeX;
    [SerializeField]
    float movimientoEjeY;
    [SerializeField]
    float movimientoEjeZ;
    [SerializeField]
    float velocidadMovimiento = 1f;
    void Update()
    {
        movimientoEjeX = Input.GetAxis("Horizontal") * Time.deltaTime * velocidadMovimiento;
        movimientoEjeZ = Input.GetAxis("Vertical") * Time.deltaTime * velocidadMovimiento;
        transform.Translate(movimientoEjeX, movimientoEjeY, movimientoEjeZ);
    }
}
