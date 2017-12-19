using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoleculeMouseHandler : MonoBehaviour {

    public GameObject _MoleculeType;
    public int _MoleculeAmount;

    void Update ()
    {
        MoveGO();

        if (Input.GetKeyUp(KeyCode.Q))
        {
            _MoleculeType = null;
        }
	}

    void MoveGO()
    {
        Vector3 mpos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        mpos.z = 0f;
        transform.position = mpos;
    }
}
