using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Mover : MonoBehaviour
{
    [field: SerializeField] protected float Speed { get; private set; }

    [field: SerializeField] protected InputReader InputReader { get; private set; }

    private void Update()
    {
        Move();
    }

    public abstract void Move();

    public abstract Vector3 GetVectorSpeed();
}
