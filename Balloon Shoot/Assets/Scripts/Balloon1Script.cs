using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Balloon1Script : MonoBehaviour
{
    void Update()
    {
        transform.Translate(Vector3.up * Time.deltaTime * 0.6f);
        transform.Translate(Vector3.right * Time.deltaTime * 0.3f);
    }
}
