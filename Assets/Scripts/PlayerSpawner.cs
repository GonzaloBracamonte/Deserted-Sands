using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerSpawner : MonoBehaviour
{
    public GameObject Player;
    void Start()
    {
        StartCoroutine(SpawnPlayer());
    }

    // Update is called once per frame
    IEnumerator SpawnPlayer()
    {
        int xRandom = Random.Range(-10, 10);
        int zRandom = Random.Range(-10, 10);
        Vector3 randomPos = new Vector3(xRandom, 5, zRandom);
        Instantiate(Player, randomPos, Quaternion.identity);
        Destroy(this.Player);
        yield return new WaitForSeconds(1f);
    }
}
