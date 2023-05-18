using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CaravanSpawner : MonoBehaviour
{
    public GameObject Caravan;
    void Start()
    {
        StartCoroutine(SpawnCaravan());
    }
    IEnumerator SpawnCaravan()
    {
        int xRandom = Random.Range(-20, 20);
        int zRandom = Random.Range(-20, 20);
        Vector3 randomPos = new Vector3(xRandom, 5, zRandom);
        Instantiate(Caravan, randomPos, Quaternion.identity);
        Destroy(this.Caravan);
        yield return new WaitForSeconds(1f);
    }
}
