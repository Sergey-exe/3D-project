using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SphereSpawner : MonoBehaviour
{
    [SerializeField] private GameObject _prefab;
    [SerializeField] private Shooter _shooter;
    [SerializeField] private Transform _spawnPoint;

    private void OnEnable()
    {
        _shooter.Reloaded += Spawn;
    }

    private void OnDisable()
    {
        _shooter.Reloaded -= Spawn;
    }

    private void Spawn()
    {
        Instantiate(_prefab, _spawnPoint.position, _spawnPoint.rotation);
    }
}
