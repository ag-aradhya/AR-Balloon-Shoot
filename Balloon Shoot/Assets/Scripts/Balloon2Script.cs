using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Balloon2Script : MonoBehaviour
{
    void Update()
    {
        transform.Translate(Vector3.up * Time.deltaTime * 0.6f);
        transform.Translate(Vector3.left * Time.deltaTime * 0.3f);
    }
}