using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject EnemyPrefab;

    public void SpawnEnemy()
    {
        Vector2 spawnPostion = new Vector2(Random.Range(-5f, 5f), Random.Range(-5f, 5f));
        Instantiate(EnemyPrefab, spawnPostion, Quaternion.identity);
    }
}