using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Molecule : MonoBehaviour
{
    public MoleculeIdentifier _MoleculeID;
    public int _MoleculeNumber;

    public void UpdateName()
    {
        gameObject.name = $"Molecule_{_MoleculeID._MoleculeType}";
    }
}
