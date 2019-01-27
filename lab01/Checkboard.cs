/* 
UVic CSC 305, 2019 Spring
Lab 01

This is code for lab 01
Generate a checkboard pattern with Unity
*/

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace lab01
{
    //MonoBehaviour is the base class from which every Unity script derives.
    public class Checkboard : MonoBehaviour
    {

        Texture2D checkboardResult;

        // Start is called before the first frame update
        void Start()
        {
            Debug.Log("Here is the Start of class Ckechboard");
            Camera thisCamera = gameObject.GetComponent<Camera>();
            Debug.Assert(thisCamera);
            int canvasWidth = thisCamera.pixelWidth;
            int canvasHeight = thisCamera.pixelHeight;
            checkboardResult = new Texture2D(canvasWidth, canvasHeight);
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
                        (xblock + yblock) % 2 == 0 ? new Color(1,0,0) : Color.white);
                    //if(y < canvasHeight / 2)
                        //checkboardResult.SetPixel(x, y, Color.black);
                }
            }
            
            checkboardResult.Apply();
            #endregion
        }

        // Update is called once per frame
        void Update()
        {
            
        }

        //OnRenderImage is called after all rendering is complete to render image.
        private void OnRenderImage(RenderTexture source, RenderTexture destination)
        {
            //Debug.Log("Here is the OnRenderImage of class Ckechboard");
            Graphics.Blit(checkboardResult, destination);
        }

    }
}
