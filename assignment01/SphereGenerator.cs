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
    public class SphereGenerator
    {
        string name;

        public SphereGenerator()
        {
            //you can define the sphere center and radius in the constructor.
            this.name = "SphereGenerator";
        }

        public Texture2D GenSphere(int width, int height)
        {
            /*
            implement ray-sphere intersection and render a sphere with ambient, diffuse and specular lighting.

            int width - width of the returned texture
            int height - height of the return texture
            return:
                Texture2D - Texture2D object which contains the rendered result
            */
            throw new NotImplementedException();
        }
        private bool IntersectSphere(Vector3 origin,
                                        Vector3 direction,
                                        Vector3 sphereCenter,
                                        float sphereRadius,
                                        out float t,
                                        out Vector3 intersectNormal)
        {
            /*
            Vector3 origin - origin point of the ray
            Vector3 direction - the direction of the ray
            Vector3 sphereCenter - center of target sphere
            float sphereRadius - radius of target sphere
            out float t - distance the ray travelled to hit a point
            out Vector3 intersectNormal - normal of the hit point
            return:
                bool - indicating hit or not
            */
            throw new NotImplementedException();
        }
    }
}
