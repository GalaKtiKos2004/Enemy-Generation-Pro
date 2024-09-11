using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    [SerializeField] private float _delay = 2f;
    [SerializeField] private List<EnemySpawnPoint> _spawnPoints;

    private void Start()
    {
        StartCoroutine(CountSpawnDelay(_delay));
    }

    private IEnumerator CountSpawnDelay(float delay)
    {
        var wait = new WaitForSeconds(delay);

        while (enabled)
        {
            GetSpawnPoint().Create();
            yield return wait;
        }
    }

    private EnemySpawnPoint GetSpawnPoint()
    {
        return _spawnPoints[Random.Range(0 , _spawnPoints.Count)];
    }
}
