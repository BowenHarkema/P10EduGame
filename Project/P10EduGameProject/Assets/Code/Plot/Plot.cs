using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class Plot
{
    public string _MoleculeType;
    public bool _Useable;

    [Space]

    public int _Stage = 0;
    //public GameObject[] _UseStages;
    public GameObject[] _FlowerStages;
}
