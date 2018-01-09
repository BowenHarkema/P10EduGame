using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PuzzlePart : MonoBehaviour {

    public string PuzzlePartString;
    public int _PuzzlePartAmount;

    private Text _Text;
    private MoleculeMouseHandler _MMH;

    private void Awake()
    {
        _MMH = FindObjectOfType<MoleculeMouseHandler>();
        _Text = gameObject.GetComponentInChildren<Text>();
    }

    public void Selected()
    {
        FindObjectOfType<Core>()._PPart = this;
    }

    private void LateUpdate()
    {
        _Text.text = PuzzlePartString;
    }

}
