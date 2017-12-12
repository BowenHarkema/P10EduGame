using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Molecule : MonoBehaviour
{
    public MoleculeIdentifier _MoleculeID;

    public void UpdateName()
    {
        gameObject.name = $"Molecule{_MoleculeID._MoleculeType}";
    }
}
