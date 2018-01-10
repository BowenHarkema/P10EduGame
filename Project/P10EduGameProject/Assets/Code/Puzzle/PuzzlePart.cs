using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PuzzlePart : MonoBehaviour {

    public string PuzzlePartString;
    public int _PuzzlePartAmount;

    private MoleculeMouseHandler _MMH;
    private Core _C;
    private Text _AmountText;

    public Sprite _PPartImage;

    private void Awake()
    {
        _MMH = FindObjectOfType<MoleculeMouseHandler>();
        _AmountText = GetComponentInChildren<Text>();
    }

    public void Selected()
    {
        FindObjectOfType<Core>()._PPart = this;
    }

    private void LateUpdate()
    {
        gameObject.GetComponent<Image>().sprite = _PPartImage;
        _AmountText.text = _PuzzlePartAmount.ToString();
    }

}
