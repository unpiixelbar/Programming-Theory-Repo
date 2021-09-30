using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// INHERITANCE
public class Plane : Vehicel
{
    // POLYMORPHISM
    protected override void OnMove()
    {
        float xRotation = XInput * 100 * Time.deltaTime;
        float yRotation = YInput * 100 * Time.deltaTime;
        transform.Rotate(new Vector3(yRotation, xRotation, xRotation), Space.Self);
    }
}
