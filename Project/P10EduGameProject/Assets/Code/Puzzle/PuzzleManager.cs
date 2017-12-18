using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PuzzleManager : MonoBehaviour {

    private string _Puzzle;
    private string _Answer1;
    
	void Start ()
    {
		
	}
	
	void Update ()
    {
		
	}

    public void MergeAndCheck()
    {
        if (_Answer1 == _Puzzle)
        {
            Debug.Log($"Winner winner chicken dinner");
        }
    }
}
