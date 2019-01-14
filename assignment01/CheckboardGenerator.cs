/* 
UVic CSC 305, 2019 Spring
Assignment 01

This is a template class we provide.
GenCheckboard method can generate a chechboard pattern to a Texture2D object.
*/

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Assignment01
{
    public class CheckboardGenerator
    {
        string name;
        public CheckboardGenerator()
        {
            this.name = "CheckboardGenerator";
        }

        public Texture2D GenCheckboard(int width, int height)
        {
            Texture2D checkboardResult = new Texture2D(width, height);
            #region Generate a black and white checker pattern
            // in frame coordinates
            // x axis grow from left to right
            // y axis grow from lower to upper
            for (int y = 0; y < height; ++y)
            {
                for (int x = 0; x < width; ++x)
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
    }
}
