using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoleculeMouseHandler : MonoBehaviour {

    public GameObject _MoleculeType;
    private PlusMinusHandler _PMHandler;

    private void Start()
    {
        _PMHandler = FindObjectOfType<PlusMinusHandler>();
    }

    void Update ()
    {
        Vector3 mpos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        mpos.z = 0f;
        transform.position = mpos;

        if (_MoleculeType != null)
        {
            _PMHandler._M = _MoleculeType.GetComponent<Molecule>();
        }

        if (Input.GetKeyUp(KeyCode.Q))
        {
            _MoleculeType = null;
        }
	}
}
