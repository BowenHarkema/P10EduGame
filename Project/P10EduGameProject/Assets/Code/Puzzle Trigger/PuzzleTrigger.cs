using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PuzzleTrigger : MonoBehaviour
{
    public bool _DestroyOnEnd;

    [SerializeField]
    private DialoqueManager _DManager;

    [SerializeField]
    private DialogueTrigger _DTrigger;

    public void Trigger()
    {
        _DManager.StartDialogue(_DTrigger._Dialogue, gameObject);
    }
}
