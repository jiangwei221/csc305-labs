/* 
UVic CSC 305, 2019 Spring
Assignment 01
Name:
UVic ID:

This is skeleton code we provided.
Feel free to add any member variables or functions that you need.
Feel free to modify the pre-defined function header or constructor if you need.
Please fill your name and uvic id.
*/

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Assignment01
{
    public class CubeGenerator
    {
        string name;
        public CubeGenerator()
        {
            //you can define your cube vertices and indices in the constructor.
            name = "CubeGenerator";
        }

        public Texture2D GenBarycentricVis(int width, int height)
        {
            /*
            implement ray-triangle intersection and 
            visualize the barycentric coordinate on each of the triangles of a cube, 
            with Red, Green and Blue for each coordinate.

            int width - width of the returned texture
            int height - height of the return texture
            return:
                Texture2D - Texture2D object which contains the rendered result
            */
            throw new NotImplementedException();
        }

        public Texture2D GenUVMapping(int width, int height, Texture2D inputTexture)
        {
            /*
            implement UV mapping with the calculated barycentric coordinate in the previous step, 
            and visualize a texture image on each face of the cube.
            (choose any texture you like)
            we have declared textureOnCube as a public variable,
            you can attach texture to it from Unity.
            you can define your cube vertices and indices in this function.

            int width - width of the returned texture
            int height - height of the return texture
            Texture2D inputTexture - the texture you need to sample from
            return:
                Texture2D - Texture2D object which contains the rendered result
            */
            throw new NotImplementedException();
        }

        private bool IntersectTriangle(Vector3 origin,
                                        Vector3 direction,
                                        Vector3 vA,
                                        Vector3 vB,
                                        Vector3 vC,
                                        out float t,
                                        out Vector3 barycentricCoordinate)
        {
            /*
            Vector3 origin - origin point of the ray
            Vector3 direction - the direction of the ray
            vA, vB, vC - 3 vertices of the target triangle
            out float t - distance the ray travelled to hit a point
            out Vector3 barycentricCoordinate - you should know what this is
            return:
                bool - indicating hit or not
            */
            throw new NotImplementedException();
        }
    }
}
