using System;
using UnityEngine;

public class InputReader : MonoBehaviour
{
    [SerializeField] private KeyCode[] _keysForce;
    [SerializeField] private KeyCode[] _keysShoot;
    [SerializeField] private KeyCode[] _keysReload;

    public bool IsDownButtonForce()
    {
        return IsDownButton(_keysForce);
    }

    public bool IsDownButtonShoot()
    {
        return IsDownButton(_keysShoot);
    }

    public bool IsDownButtonReload()
    {
        return IsDownButton(_keysReload);
    }

    private bool IsDownButton(KeyCode[] keyCodes)
    {
        foreach (KeyCode keyCode in keyCodes)
            if (Input.GetKeyDown(keyCode))
                return true;

        return false;
    }
}