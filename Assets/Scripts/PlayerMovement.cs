using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float velocidad = 50f;
    public float horizontalSpeed = 20f;

    private void Update()
    {
        MovimientoDelJugador();
        RotacionDelJugador();
    }

    private void RotacionDelJugador()
    {
        float horizontal = transform.localEulerAngles.y + Input.GetAxis("Mouse X");
        transform.localEulerAngles = new Vector3(0, horizontal, 0);
    }
    private void MovimientoDelJugador()
    {
        float movimientoHorizontal = Input.GetAxis("Horizontal");
        float movimientoVertical = Input.GetAxis("Vertical");
        Vector3 movimiento = new Vector3(movimientoHorizontal, 0, movimientoVertical);
        transform.position += movimiento * velocidad * Time.deltaTime;
    }
}
