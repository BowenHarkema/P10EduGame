using System.Collections;
using System.Collections.Generic;
using UnityEngine;

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
