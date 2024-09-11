using UnityEngine;

public class EnemySpawnPoint : MonoBehaviour
{
    [SerializeField] private EnemyMover _prefab;
    [SerializeField] private PlayerMover _target;

    public void Create()
    {
        EnemyMover enemy = Instantiate(_prefab, transform.position, Quaternion.identity);
        enemy.Init(_target);
    }
}