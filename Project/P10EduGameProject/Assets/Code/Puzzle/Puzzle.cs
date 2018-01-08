using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class Puzzle
{
    public PuzzlePart[] _PuzzleParts;
    public string PuzzleAnswer;
    public string MadeSolution;

    public void CreateSolution()
    {
        for (int i = 0; i < _PuzzleParts.Length; i++)
        {
            MadeSolution += _PuzzleParts[i].PuzzlePartString;
        }
    }
}
