using UnityEngine;

public class EnemySpawnPoint : MonoBehaviour
{
    [SerializeField] private EnemyMovement _prefab;
    [SerializeField] private GameObject _target;

    public void Create()
    {
        EnemyMovement enemy = Instantiate(_prefab, transform.position, Quaternion.identity);
        enemy.Init(_target);
    }
}