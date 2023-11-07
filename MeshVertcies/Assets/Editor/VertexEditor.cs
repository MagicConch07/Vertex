using System;
using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

[CustomEditor(typeof(VertexGenerator), true)]
public class VertexEditor : Editor
{
    private VertexGenerator _generator;

    private void Awake()
    {
        _generator = target as VertexGenerator;
    }

    public override void OnInspectorGUI()
    {
        base.OnInspectorGUI();

        if (GUILayout.Button("Generate"))
        {
            _generator.GenerateVertex();
            _generator.AssignMesh();
        }

        if (GUILayout.Button("Clear"))
        {
            _generator.ClearVertex();
        }
    }
}
