using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject Enemy;
    public GameObject Health;
    public GameObject spawnContainer;
    public int enemyCount = 0;
    public int healthCount = 0;
    void Start()
    {
        StartCoroutine(SpawnHealth());
        StartCoroutine(SpawnEnemys());
    }
    IEnumerator SpawnEnemys()
    {
        while (enemyCount >= 0 && enemyCount < 10)
        {
            int xRandom = Random.Range(100, 600);
            int zRandom = Random.Range(100, 600);
            Vector3 randomPos = new Vector3(xRandom, 5, zRandom);
            GameObject newEnemy =  Instantiate(Enemy, randomPos, Quaternion.identity);
            newEnemy.transform.parent = spawnContainer.transform;
            enemyCount++;
            yield return new WaitForSeconds(0.01f);
        }
        Destroy(this.Enemy);

    }
    IEnumerator SpawnHealth()
    {
        while (healthCount >= 0 && healthCount <= 16)
        {
            int xRandom = Random.Range(200, 600);
            int zRandom = Random.Range(300, 600);
            Vector3 randomPos = new Vector3(xRandom, 5, zRandom);
            GameObject newHealth=  Instantiate(Health, randomPos, Quaternion.identity);
            newHealth.transform.parent = spawnContainer.transform;
            healthCount++;
            yield return new WaitForSeconds(0.01f);
        }
        Destroy(this.Health);
    }
}
