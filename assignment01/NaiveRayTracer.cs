/* 
UVic CSC 305, 2019 Spring
Assignment 01
Name:
UVic ID:

This is the script attached to the camera object.
Feel free to add any member variables or functions that you need.
Feel free to modify the pre-defined function header if you need.
Please fill your name and uvic id.
*/

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Assignment01
{
    public class NaiveRayTracer : MonoBehaviour
    {
        Texture2D renderedResult;
        public Texture2D textureOnCube;
        int canvasWidth;
        int canvasHeight;

        // Start is called before the first frame update
        void Start()
        {
            Debug.Log("Here is the Start function of class NaiveRayTracer");
            Camera thisCamera = gameObject.GetComponent<Camera>();
            Debug.Assert(thisCamera);
            canvasWidth = thisCamera.pixelWidth;
            canvasHeight = thisCamera.pixelHeight;
            Debug.Log("canvasWidth: " + canvasWidth);
            Debug.Log("canvasHeight: " + canvasHeight);
            renderedResult = new Texture2D(canvasWidth, canvasHeight);

            //following if-else statement helps graders to grade your assignment.
            //change the renderMethod to test your implementation.
            string renderMethod = "checkboard";
            if (renderMethod == "checkboard")
            {
                CheckboardGenerator myRenderer = new CheckboardGenerator();
                renderedResult = myRenderer.GenCheckboard(canvasWidth, canvasHeight);
            }
            else if (renderMethod == "sphere")
            {
                SphereGenerator myRenderer = new SphereGenerator();
                renderedResult = myRenderer.GenSphere(canvasWidth, canvasHeight);
            }
            else if (renderMethod == "barycentric")
            {
                CubeGenerator myRenderer = new CubeGenerator();
                renderedResult = myRenderer.GenBarycentricVis(canvasWidth, canvasHeight);
            }
            else if (renderMethod == "uvmapping")
            {
                CubeGenerator myRenderer = new CubeGenerator();
                renderedResult = myRenderer.GenUVMapping(canvasWidth, canvasHeight, textureOnCube);
            }
            else
                throw new NotImplementedException();
            renderedResult.Apply();
        }

        // Update is called once per frame
        void Update()
        {

        }

        //OnRenderImage is called after all rendering is complete to render image.
        private void OnRenderImage(RenderTexture source, RenderTexture destination)
        {
            //Debug.Log("Here is the OnRenderImage of class NaiveRayTracer");
            Graphics.Blit(renderedResult, destination);
        }
    }
}