/*
UVic CSC 305, 2019 Spring

Helping lab for assignment03
*/

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CircleMovement : MonoBehaviour
{
    void Start()
    {
        gameObject.transform.position = new Vector3(0.0f, 5.0f, 5.0f);
    }

    // Update is called once per frame
    void Update()
    {
        gameObject.transform.RotateAround(Vector3.zero, Vector3.up, 20 * Time.deltaTime);
    }
}
