using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PuzzleManager : MonoBehaviour {

    public string _Answer1;

    [SerializeField]
    private GameObject[] _Puzzleparts;

    private bool _IsCorrect = false;

    [SerializeField]
    private Puzzle _PuzzleS;

    private void Start()
    {
        GetButtons();
    }

    private void GetButtons()
    {
        int length = _PuzzleS._PuzzleParts.Length;
        Debug.Log(length);
        for (int i = 0; i < length; i++)
        {
            _Puzzleparts[i] = _PuzzleS._PuzzleParts[i].gameObject;
        }
    }

    public void PuzzleCheck()
    {
        if (!_IsCorrect)
        {
            _PuzzleS.CreateSolution();

            _Answer1 = _PuzzleS.MadeSolution;
        }
        Check();
    }

    public void Check()
    {
        if (_Answer1 == _PuzzleS.PuzzleAnswer)
        {
            Debug.Log($"Winner winner chicken dinner");
            _IsCorrect = true;
        }
    }
}
