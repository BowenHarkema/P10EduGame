using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlusMinusHandler : MonoBehaviour
{
    public Molecule _M;

    public void Addone()
    {
        _M._MAmount += 1;
    }

    public void Minusone()
    {
        if (_M._MAmount >= 1)
        {
            _M._MAmount -= 1;
        }
    }
}
