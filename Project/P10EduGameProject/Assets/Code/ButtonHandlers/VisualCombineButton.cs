using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VisualCombineButton : MonoBehaviour
{
    public int _PuzzleLength;

    public string[] _MType;
    public int[] _MAmount;

    private void Start()
    {
        _MType = new string[_PuzzleLength];
        _MAmount = new int[_PuzzleLength];
    }

    public void MIntake()
    {
        int i = 0;

        if (i < _PuzzleLength)
        {
            i++;
        }
    }
}
