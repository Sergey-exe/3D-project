using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Shooter : MonoBehaviour
{
    private const string Attack = nameof(Attack);
    private const string Back = nameof(Back);

    [SerializeField] private Animator _animator;
    [SerializeField] private InputReader _inputReader;

    public event UnityAction Reloaded;

    private void Update()
    {
        if (_inputReader.IsDownButtonShoot())
            Shoot();
        else if (_inputReader.IsDownButtonReload())
            Reload();
    }

    private void Shoot()
    {
        _animator.SetTrigger(Attack);
    }

    private void Reload()
    {
        _animator.SetTrigger(Back);
        Reloaded?.Invoke();
    }
}
