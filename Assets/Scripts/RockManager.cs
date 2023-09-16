using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RockManager : MonoBehaviour
{
    IEnumerator WaitForDestruction()
    {
        yield return new WaitForSeconds (1);
        Destroy(gameObject);
    }
    void OnCollisionEnter(Collision otherObj)
    {
        if (otherObj.gameObject.tag == "Player")
        {
            StartCoroutine("WaitForDestruction");
        }
    }
}
