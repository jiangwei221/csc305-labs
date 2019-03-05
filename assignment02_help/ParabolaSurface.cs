/*
UVic CSC 305, 2019 Spring

Helping lab for assignment02
 */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParabolaSurface : MonoBehaviour {

    public Material simpleMaterial;

	// Use this for initialization
	void Start () {
        MeshRenderer renderer = gameObject.GetComponent<MeshRenderer>();
        //renderer.material = simpleMaterial;
        GenerateParabolaSurface();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    void GenerateParabolaSurface()
    {
        Mesh mesh = gameObject.GetComponent<MeshFilter>().mesh;
        Vector3[] vertices = mesh.vertices;
        int[] indices = mesh.triangles;
        Vector2[] uvs = mesh.uv;

        mesh.Clear();

        //subdivision = how many squares per row/col
        int subdivision = 100;
        int stride = subdivision + 1;
        int num_vert = stride * stride;
        int num_tri = subdivision * subdivision * 2;

        indices = new int[num_tri * 3];
        int index_ptr = 0;
        for (int i = 0; i < subdivision; i++)
        {
            for (int j = 0; j < subdivision; j++)
            {
                int quad_corner = i * stride + j;
                indices[index_ptr] = quad_corner;
                indices[index_ptr+1] = quad_corner+stride;
                indices[index_ptr+2] = quad_corner+stride+1;
                indices[index_ptr+3] = quad_corner;
                indices[index_ptr+4] = quad_corner+stride+1;
                indices[index_ptr+5] = quad_corner+1;
                index_ptr += 6;
            }
        }

        Debug.Assert(index_ptr == indices.Length);

        const float xz_start = -5;
        const float xz_end = 5;
        float step = (xz_end - xz_start) / (float)(subdivision);
        vertices = new Vector3[num_vert];
        uvs = new Vector2[num_vert];

        for (int i = 0; i < stride; i++)
        {
            for (int j = 0; j < stride; j++)
            {
                // notice the bahavior here
                bool show_backface = false;
                float cur_x;
                float cur_z;
                //i don't know how this happened(showing back faces)
                if (show_backface)
                {
                    cur_x = xz_start + i * step;
                    cur_z = xz_start + j * step;
                }
                else
                {
                    cur_x = xz_start + j * step;
                    cur_z = xz_start + i * step;
                }
                float cur_y = (-(cur_x * cur_x + cur_z * cur_z) / (float)10.0)+5;
                vertices[i * stride + j] = new Vector3(cur_x, cur_y, cur_z);
            }
        }

        mesh.vertices = vertices;
        mesh.uv = uvs;
        mesh.triangles = indices;
        mesh.RecalculateNormals();
    }
}
