using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonHandler : MonoBehaviour {

    [SerializeField]
    private GameObject _Molecule;

    private MoleculeMouseHandler _MoleculeMouseHandler;

    private void Start()
    {
        _MoleculeMouseHandler = FindObjectOfType<MoleculeMouseHandler>();
    }

    public void OnActivate()
    {
        _MoleculeMouseHandler._MoleculeType = _Molecule;
    }
}
