using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(CharacterController))]
public class CharacterMover : Mover
{
    [SerializeField] private CharacterController _characterController;

    public override void Move()
    {
        Vector3 playerSpeed = GetVectorSpeed();

        if (_characterController.isGrounded)
        {
            _characterController.Move(playerSpeed + Physics.gravity);
        }
        else
        {
            _characterController.Move(_characterController.velocity + Physics.gravity * Time.deltaTime);
        }
    }

    public override Vector3 GetVectorSpeed()
    {
        Vector3 playerSpeed = new Vector3(InputReader.InputMoveHorizontalAxis(), 0, InputReader.InputMoveVerticalAxis());
        playerSpeed *= Time.deltaTime * Speed;

        return playerSpeed;
    }
}
