using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Core : MonoBehaviour {

    public PuzzlePart _PPart;

    public List<GameObject> _MIC;

    public bool _Combineing;
    private MoleculeMouseHandler _MMH;
    private PuzzleManager _PuzzleM;
    public PuzzleTrigger _DTrigger;
    public PuzzleTrigger _PTrigger;
    [SerializeField] private Combination _Comb;

    private void Start()
    {
        _MMH = FindObjectOfType<MoleculeMouseHandler>();
        _PuzzleM = FindObjectOfType<PuzzleManager>();
    }

    public void AddMolecule()
    {
        if (_MIC.Count <= 20)
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
    }

    public void CheckAndUpload()
    {
        if (_Combineing)
        {
            _Comb.GetMolecules(_MIC);
        }

        if (_PPart == null)
        {
            _PTrigger.Trigger();
            ResetCore();
            return;
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
