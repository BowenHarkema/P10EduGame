using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PuzzlePart : MonoBehaviour {

    public string PuzzlePartString;
    private Text _Text;
    private MoleculeMouseHandler _MMH;

    private void Awake()
    {
        _MMH = FindObjectOfType<MoleculeMouseHandler>();
        _Text = gameObject.GetComponentInChildren<Text>();
    }

    public void Selected()
    {
        PuzzlePartString = _MMH._MoleculeN;

        _Text.text = PuzzlePartString;
    }

}
