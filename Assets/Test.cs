using UnityEngine;
using System.Collections;
using LibNoise.Unity.Generator;

public class Test : MonoBehaviour {

	// Use this for initialization
	void Start () {
		Perlin noise = new Perlin();
		Mesh mesh = GetComponent<MeshFilter>().mesh;
		Vector3[] vertices = mesh.vertices;
		
		var i=0;
		
		while (i < vertices.Length) {
			float y = (float)noise.GetValue(0, i*1.3f, 0);
			vertices[i] += new Vector3(0, y, 0) * 2.0f;
			i++;
		}
		mesh.vertices = vertices;
		mesh.RecalculateNormals();
		mesh.RecalculateBounds(); 
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
