using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Combination : MonoBehaviour
{
    [SerializeField] GameObject _atom1 = null;
    [SerializeField] float _Atom1_Amount = 0;
    [SerializeField] GameObject _atom2 = null;
    [SerializeField] float _atom2_Amount = 0;

    public void GetMolecules(List<GameObject> mlist)
    {
        for (int i = 0; i < mlist.Count; i++)
        {
            if (_atom1 == null && _Atom1_Amount == 0)
            {
                _atom1 = mlist[i];
                _Atom1_Amount += 1;
            }
            else if (_atom2 == null && _atom2_Amount == 0 && mlist[i].name != _atom1.name)
            {
                _atom2 = mlist[i];
                _atom2_Amount += 1;
            }
            else
            {
                if (_atom1 != null)
                {
                    if (mlist[i].name.Equals(_atom1.name))
                    {
                        _Atom1_Amount += 1;

                    }
                }

                if(_atom2 != null)
                {
                    if (mlist[i].name.Equals(_atom2.name))
                    {
                        _atom2_Amount += 1;
                    }
                }
            }
        }
        CheckList(_atom1, _Atom1_Amount, _atom2, _atom2_Amount);
        //Reset();
    }

    public void Reset()
    {
        _atom1 = null;
        _Atom1_Amount = 0;
        _atom2 = null;
        _atom2_Amount = 0;
    }

    public void CheckList(GameObject a1, float a1a, GameObject a2, float a2a)
    {
        //Combine with himself
        if(a1a == 2)
        {
            if (a1.name == "Molecule_H(Clone)")
            {
                Debug.Log(a1.name + a1a);
            }

            if (a1.name == "Molecule_N(Clone)")
            {
                Debug.Log(a1.name + a1a);
            }

            if (a1.name == "Molecule_O(Clone)")
            {
                Debug.Log(a1.name + a1a);
            }

            if (a1.name == "Molecule_Br(Clone)")
            {
                Debug.Log(a1.name + a1a);
            }

            if (a1.name == "Molecule_Cl(Clone)")
            {
                Debug.Log(a1.name + a1a);
            }
        }

        //ombine with one other
        else if (a1a == 1 && a2a == 1)
        {
            if (a1.name == "Molecule_O(Clone)" && a2.name == "Molecule_N(Clone)" || a2.name == "Molecule_O(Clone)" && a1.name == "Molecule_N(Clone)")
            {
                Debug.Log(a1.name + a2.name);
            }
            if (a1.name == "Molecule_K(Clone)" && a2.name == "Molecule_Cl(Clone)" || a2.name == "Molecule_K(Clone)" && a1.name == "Molecule_Cl(Clone)")
            {
                Debug.Log(a1.name + a2.name);
            }

            if (a1.name == "Molecule_Zn(Clone)" && a2.name == "Molecule_O(Clone)" || a2.name == "Molecule_Zn(Clone)" && a1.name == "Molecule_O(Clone)")
            {
                Debug.Log(a1.name + a2.name);
            }

            if (a1.name == "Molecule_C(Clone)" && a2.name == "Molecule_O(Clone)" || a2.name == "Molecule_C(Clone)" && a1.name == "Molecule_O(Clone)")
            {
                Debug.Log(a1.name + a2.name);
            }

            if (a1.name == "Molecule_Na(Clone)" && a2.name == "Molecule_H(Clone)" || a2.name == "Molecule_Na(Clone)" && a1.name == "Molecule_H(Clone)")
            {
                Debug.Log(a1.name + a2.name);
            }

            if (a1.name == "Molecule_Cu(Clone)" && a2.name == "Molecule_O(Clone)" || a2.name == "Molecule_Cu(Clone)" && a1.name == "Molecule_O(Clone)")
            {
                Debug.Log(a1.name + a2.name);
            }

            if (a1.name == "Molecule_Br(Clone)" && a2.name == "Molecule_H(Clone)" || a2.name == "Molecule_Br(Clone)" && a1.name == "Molecule_H(Clone)")
            {
                Debug.Log(a1.name + a2.name);
            }
        }
    }
}
