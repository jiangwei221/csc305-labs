/* 
UVic CSC 305, 2019 Spring
Assignment 01
Name:
UVic ID:

This is the skeleton code we provided.
Please fill your name and uvic id.
*/

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NaiveRayTracer : MonoBehaviour
{
    //feel free to add any member variables or functions that you need
    //feel free to modify the pre-defined function header if you need
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

        //following if-else statement helps graders to grade your assignment
        string renderMethod = "checkboard";
        if (renderMethod == "checkboard")
            renderedResult = GenCheckboard(canvasWidth, canvasHeight);
        else if (renderMethod == "sphere")
            renderedResult = GenSphere(canvasWidth, canvasHeight);
        else if (renderMethod == "barycentric")
            renderedResult = GenBarycentricVis(canvasWidth, canvasHeight);
        else if (renderMethod == "uvmapping")
            renderedResult = GenUVMapping(canvasWidth, canvasHeight);
        else
            throw new NotImplementedException();
        renderedResult.Apply();
    }

    private Texture2D GenCheckboard(int width, int height)
    {
        /*
        generate a checkboard pattern on a texture
        and return the texture.

        int width - width of the returned texture
        int height - height of the return texture
        return:
            Texture2D - Texture2D object which contains the rendered result
        */
        Texture2D checkboardResult = new Texture2D(width, height);
        #region Generate a black and white checker pattern
        // in frame coordinates
        // x axis grow from left to right
        // y axis grow from lower to upper
        for (int y = 0; y < canvasHeight; ++y)
        {
            for (int x = 0; x < canvasWidth; ++x)
            {
                int blockSize = 100;
                int xblock = x / blockSize;
                int yblock = y / blockSize;
                checkboardResult.SetPixel(x, y,
                    (xblock + yblock) % 2 == 0 ? new Color(255, 0, 0) : Color.white);
            }
        }
        checkboardResult.Apply();
        #endregion

        return checkboardResult;
    }

    private Texture2D GenSphere(int width, int height)
    {
        /*
        implement ray-sphere intersection and render a sphere with ambient, diffuse and specular lighting.
        you can define the sphere center and radius in this function.

        int width - width of the returned texture
        int height - height of the return texture
        return:
            Texture2D - Texture2D object which contains the rendered result
        */
        throw new NotImplementedException();
    }

    private Texture2D GenBarycentricVis(int width, int height)
    {
        /*
        implement ray-triangle intersection and 
        visualize the barycentric coordinate on each of the triangles of a cube, 
        with Red, Green and Blue for each coordinate.
        you can define your cube vertices and indices in this function.

        int width - width of the returned texture
        int height - height of the return texture
        return:
            Texture2D - Texture2D object which contains the rendered result
        */
        throw new NotImplementedException();
    }

    private Texture2D GenUVMapping(int width, int height)
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
