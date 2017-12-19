using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MoleculeMouseHandler : MonoBehaviour {

    public GameObject _MoleculeType;
    public int _MoleculeAmount;

    [SerializeField]
    private List<Sprite> _MoleculeSprites;

    void Update ()
    {
        MoveGO();

        if (Input.GetMouseButtonUp(1))
        {
            _MoleculeType = null;
            _MoleculeAmount = 0;
        }

        if (_MoleculeType != null)
        {
            SetSprite();
        }
	}

    void SetSprite()
    {
        for (int i = 0; i < _MoleculeSprites.Count; i++)
        {
            if (i == _MoleculeType.GetComponent<Molecule>()._MoleculeNumber && GetComponent<Image>().sprite != _MoleculeSprites[i])
            {
                GetComponent<Image>().sprite = _MoleculeSprites[i];
                return;
            }
        }
    }

    void MoveGO()
    {
        Vector3 mpos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        mpos.z = 0f;
        transform.position = mpos;
    }
}
