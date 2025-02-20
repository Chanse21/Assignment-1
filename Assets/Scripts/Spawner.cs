using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject EnemyPrefab;
    public Transform [] spawnLocation;
    public void SpawnEnemy()
    {
        Vector2 spawnLocation = new Vector2(Random.Range(-1f, 36f), Random.Range(-1f, 36f));
        Instantiate(EnemyPrefab, spawnLocation, Quaternion.identity);
    }
}