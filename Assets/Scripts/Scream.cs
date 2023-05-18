using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scream : MonoBehaviour
{
    void Update()
    {
        Screaming();
    }
    private void Screaming()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Debug.Log("AHHHHHHHH");
        }
    }
}
