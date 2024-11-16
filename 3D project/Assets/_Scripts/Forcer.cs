using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Forcer : MonoBehaviour
{
    [SerializeField] private float _impactForce;
    [SerializeField] private Rigidbody _swing;
    [SerializeField] private InputReader _inputReader;

    private void Update()
    {
        AddForce();
    }

    private void AddForce()
    {
        if (_inputReader.IsDownButtonForce())
            _swing.AddForce(Vector3.left * _impactForce, ForceMode.Force);
    }
}
