using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

[CustomEditor(typeof(Molecule))]
public class UpdateNameEditor : Editor
{
    public override void OnInspectorGUI()
    {
        DrawDefaultInspector();

        Molecule MScript = (Molecule)target;
        if (GUILayout.Button("Rename object"))
        {
            MScript.UpdateName();
        }     
    }
}
