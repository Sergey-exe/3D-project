using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UIElements;

[RequireComponent(typeof(Rigidbody))]
public class RigidbodyMover : Mover
{
    [SerializeField] private float _stopDistance;
    [SerializeField] private Transform _target;
    [SerializeField] private Rigidbody _rigidbody;

    public override void Move()
    {
        float distance = Vector3.Distance(transform.position, _target.position);

        if(distance > _stopDistance) 
            _rigidbody.MovePosition(transform.position + GetVectorSpeed());
    }

    public override Vector3 GetVectorSpeed()
    {
        Vector3 playerSpeed = (_target.position - transform.position).normalized;
        playerSpeed *= Speed * Time.fixedDeltaTime;

        return playerSpeed;
    }
}
