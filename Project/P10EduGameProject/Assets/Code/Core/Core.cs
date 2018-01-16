using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Core : MonoBehaviour {

    public PuzzlePart _PPart;

    public List<GameObject> _MIC;

    private MoleculeMouseHandler _MMH;
    private PuzzleManager _PuzzleM;
    public PuzzleTrigger _DTrigger;
    public PuzzleTrigger _PTrigger;

    private void Start()
    {
        _MMH = FindObjectOfType<MoleculeMouseHandler>();
        _PuzzleM = FindObjectOfType<PuzzleManager>();
    }

    public void AddMolecule()
    {
        GameObject IM = Instantiate(_MMH._MoleculeType, gameObject.transform);
        IM.AddComponent<Image>();
        IM.AddComponent<CircleCollider2D>();
        IM.GetComponent<CircleCollider2D>().radius = 50;
        IM.AddComponent<Rigidbody2D>();
        IM.GetComponent<Rigidbody2D>().gravityScale = Random.RandomRange(-0.3F, 0.3F);
        IM.GetComponent<Rigidbody2D>().freezeRotation = true;
        IM.GetComponent<Rigidbody2D>().AddForce(Vector2.left * 20, ForceMode2D.Impulse);
        IM.GetComponent<Image>().sprite = _MMH.GetComponent<Image>().sprite;
        _MIC.Add(IM);
    }

    public void CheckAndUpload()
    {
        if (_PPart == null)
        {
            _PTrigger.Trigger();
            ResetCore();
        }

        for (int i = 0; i < _MIC.Count; i++)
        {
            if (_MIC[i].name != _MIC[0].name)
            {
                _DTrigger.Trigger();
                ResetCore();
            }
        }
        _PPart.PuzzlePartString = _MIC[0].GetComponent<Molecule>()._MoleculeN;
        _PPart._PuzzlePartAmount = _MIC.Count;
        _PPart._PPartImage = _MIC[0].GetComponent<Image>().sprite;
        _PuzzleM.PuzzleCheck();

        ResetCore();
    }

    public void ResetCore()
    {
        _PPart = null;
        for (int i = 0; i < _MIC.Count; i++)
        {
            Destroy(_MIC[i]);
        }
        _MIC.Clear();
    }
}
