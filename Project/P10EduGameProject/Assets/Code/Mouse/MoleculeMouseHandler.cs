using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoleculeMouseHandler : MonoBehaviour {

    public GameObject _MoleculeType;

	void Update ()
    {
        Vector3 mpos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        mpos.z = 0f;
        transform.position = mpos;

        if (Input.GetKeyUp(KeyCode.Escape))
        {
            _MoleculeType = null;
        }
	}
}
