using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class DialoqueManager : MonoBehaviour
{
    [SerializeField]
    private TextMeshProUGUI _NameText, _DText;

    [SerializeField]
    private Animator _Anim;

    private Queue<string> _Sentences;
    private PuzzleTrigger DGO;
    private Button _Button;

    public GameObject TGO;

    void Start ()
    {
        _Sentences = new Queue<string>();
	}

    public void StartDialogue(Dialogue D, GameObject T)
    {
        _Sentences.Clear();
        _NameText.text = D._Name;
        TGO = T;
        _Anim.SetBool("IsOpen", true);

        foreach (string sentence in D._Sentences)
        {
            _Sentences.Enqueue(sentence);
        }

        DisplayNextSentence();
    }

    public void DisplayNextSentence()
    {
        if (_Sentences.Count <= 0)
        {
            EndDialogue(TGO);
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

    private void EndDialogue(GameObject T)
    {
        if (T.GetComponent<PuzzleTrigger>()._DestroyOnEnd)
        {
            Destroy(T);
        }
        else if (T.GetComponent<PuzzleTrigger>()._FinishText)
        {
            int NSI = SceneManager.GetActiveScene().buildIndex + 1;
            SceneManager.LoadScene(NSI);
        }
        _Anim.SetBool("IsOpen", false);
    }
}
