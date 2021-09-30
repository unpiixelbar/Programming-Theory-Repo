using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// INHERITANCE
public class Car : Vehicel
{
    // POLYMORPHISM
    protected override void OnMove()
    {
        float xRotation = XInput * 100 * Time.deltaTime;
        transform.Rotate(new Vector3(0, xRotation, 0), Space.Self);
    }
}
