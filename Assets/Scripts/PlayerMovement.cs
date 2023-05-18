using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float velocidad = 30;
    void FixedUpdate()
    {
        MovimientoDelJugador();
    }

    private void MovimientoDelJugador()
    {
        float movimientoHorizontal = Input.GetAxis("Horizontal");
        float movimientoVertical = Input.GetAxis("Vertical");
        Vector3 movimiento = new Vector3(movimientoHorizontal, 0, movimientoVertical);
        transform.position += movimiento * velocidad * Time.deltaTime;
    }
}
