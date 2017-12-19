using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoleculeButton : MonoBehaviour {

    [SerializeField]
    private GameObject _Molecule, _ButtonPlus, _ButtonMinus;

    private MoleculeMouseHandler _MoleculeMouseHandler;

    private void Start()
    {
        _MoleculeMouseHandler = FindObjectOfType<MoleculeMouseHandler>();
    }

    private void LateUpdate()
    {
        if (_MoleculeMouseHandler._MoleculeType == _Molecule)
        {
            _ButtonMinus.SetActive(true);
            _ButtonPlus.SetActive(true);
        }
        else
        {
            _ButtonMinus.SetActive(false);
            _ButtonPlus.SetActive(false);
        }
    }

    public void OnActivate()
    {
        if (_Molecule != _MoleculeMouseHandler._MoleculeType)
        {
            _MoleculeMouseHandler._MoleculeType = _Molecule;
            _MoleculeMouseHandler._MoleculeAmount = 0;
        }
    }
}
