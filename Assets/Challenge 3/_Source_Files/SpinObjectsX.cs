using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpinObjectsX : MonoBehaviour
{
    public float spinSpeed = -250;

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(Vector3.up, spinSpeed * Time.deltaTime);
    }
}
