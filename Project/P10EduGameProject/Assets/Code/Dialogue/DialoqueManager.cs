using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DialoqueManager : MonoBehaviour {

    [SerializeField]
    private Text _NameText, _DText;

    [SerializeField]
    private Animator _Anim;

    private Queue<string> _Sentences;

	void Start ()
    {
        _Sentences = new Queue<string>();
	}

    public void StartDialogue(Dialogue D)
    {
        _Sentences.Clear();
        _NameText.text = D._Name;

        _Anim.SetBool("IsOpen", true);

        foreach (string sentence in D._Sentences)
        {
            _Sentences.Enqueue(sentence);
        }

        DisplayNextSentence();
    }

    public void DisplayNextSentence()
    {
        if (_Sentences.Count == 0)
        {
            EndDialogue();
            return;
        }

        string s = _Sentences.Dequeue();
        StopAllCoroutines();
        StartCoroutine(TypeSentence(s));
    }

    IEnumerator TypeSentence(string sentence)
    {
        _DText.text = "";

        foreach (char letter in sentence.ToCharArray())
        {
            _DText.text += letter;
            yield return null;
        }
    }

    private void EndDialogue()
    {
        _Anim.SetBool("IsOpen", false);
    }
}
