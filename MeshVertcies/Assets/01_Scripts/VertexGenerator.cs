using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VertexGenerator : MonoBehaviour
{
    [SerializeField] private Vector2 _size;

    [SerializeField] private MeshFilter _filter;
    private Mesh _mesh;

    private List<Vector3> _verctices = new List<Vector3>();
    private List<int> _triangles = new List<int>();

    private void Awake()
    {
        _filter = GetComponent<MeshFilter>();
        _mesh = new Mesh();
        _filter.mesh = _mesh;
    }

    private void Update()
    {
        GenerateVertex();
        AssignMesh();
    }

    public void GenerateVertex()
    {
        _mesh = new Mesh();
        _filter.mesh = _mesh;

        _verctices = new List<Vector3>();
        _triangles = new List<int>();
        
        _verctices.Add(new Vector3(-1, 0));
        _verctices.Add(new Vector3(0, 2));
        _verctices.Add(new Vector3(1, 0));
        
        _triangles.Add(0);
        _triangles.Add(1);
        _triangles.Add(2);
    }

    public void AssignMesh()
    {
        _mesh.Clear();
        _mesh.vertices = _verctices.ToArray();
        _mesh.triangles = _triangles.ToArray();
    }

    public void ClearVertex()
    {
        _mesh.Clear();
        AssignMesh();
        _filter.mesh = null;
    }
}
