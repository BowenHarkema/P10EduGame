using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PuzzleTrigger : MonoBehaviour
{
    public bool _DestroyOnEnd;

    [SerializeField]
    private GameObject _Player;

    [SerializeField]
    private DialoqueManager _DManager;

    [SerializeField]
    private DialogueTrigger _DTrigger;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            _DManager.StartDialogue(_DTrigger._Dialogue, gameObject);
            _Player.GetComponent<PlayerMovement>().enabled = false;
        }
    }
}
