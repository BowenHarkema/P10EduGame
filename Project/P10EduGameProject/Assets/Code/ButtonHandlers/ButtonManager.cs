using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonManager : MonoBehaviour
{
    private MoleculeMouseHandler _MMH;

    private void Start()
    {
        _MMH = FindObjectOfType<MoleculeMouseHandler>();
    }

    public void Minusone()
    {
        if (_MMH._MoleculeAmount >= 1)
        {
            _MMH._MoleculeAmount -= 1;
        }
    }

    public void Addone()
    {
        _MMH._MoleculeAmount += 1;
    }
}
