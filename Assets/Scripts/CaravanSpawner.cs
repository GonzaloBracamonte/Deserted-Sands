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
        int xRandom = Random.Range(140, 160);
        int zRandom = Random.Range(750, 770);
        Vector3 randomPos = new Vector3(xRandom, 4, zRandom);
        Instantiate(Caravan, randomPos, Quaternion.identity);
        Destroy(this.Caravan);
        yield return new WaitForSeconds(1f);
    }
}
