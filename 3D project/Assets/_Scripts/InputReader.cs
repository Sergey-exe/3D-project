using System;
using UnityEngine;

public class InputReader : MonoBehaviour
{
    private const string Horizontal = nameof(Horizontal);
    private const string Vertical = nameof(Vertical);

    public float InputMoveHorizontalAxis()
    {
        return InputAxis(Horizontal);
    }

    public float InputMoveVerticalAxis()
    {
        return InputAxis(Vertical);
    }

    private bool IsDownButton(KeyCode[] keyCodes)
    {
        foreach (KeyCode keyCode in keyCodes)
            if (Input.GetKeyDown(keyCode))
                return true;

        return false;
    }

    private float InputAxis(string axis)
    {
        return Input.GetAxis(axis);
    }
}