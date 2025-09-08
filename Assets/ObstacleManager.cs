using System.Collections;
using UnityEngine;

public class ObstacleManager : MonoBehaviour
{
    [SerializeField] GameObject obstaclePrefab;
    [SerializeField] float minDelay = 1f;
    [SerializeField] float maxDelay = 2f;
    void Start()
    {
        StartCoroutine(SpawnLoop());
    }

    IEnumerator SpawnLoop()
    {
        while (true)
        {
            SpawnObstacle();
            yield return new WaitForSeconds(Random.Range(minDelay, maxDelay));
        }
    }
    
    void SpawnObstacle()
    {
        float x = Random.Range(-8f, 8f);
        float y = Random.Range(-4f, 4f);
        Vector3 spawnPos = new Vector3(x, y, 0f);
        Instantiate(obstaclePrefab, spawnPos, Quaternion.identity);
    }
}
