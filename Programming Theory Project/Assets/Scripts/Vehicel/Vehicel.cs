using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//[RequireComponent(typeof(PlayerInput))]
public abstract class Vehicel : MonoBehaviour
{
    // ENCAPSULATION
    private float xInput;
    public float XInput { get => xInput; private set => xInput = value; }

    private float yInput;
    public float YInput { get => yInput; private set => yInput = value; }

    [SerializeField] private float speed = 50;
    public float Speed { get => speed; private set => speed = value; }

    [SerializeField] VehicleType vehicleType;
    protected void Start()
    {
        if (GameManager.Instance.ChoosenVehicle != vehicleType)
        {
            gameObject.SetActive(false);
        }
    }

    protected void Update()
    {
        getInputAxis();
        OnMove();

        transform.position += transform.forward * Time.deltaTime * Speed;
    }

    private void getInputAxis()
    {
        XInput = Input.GetAxis("Horizontal");
        YInput = Input.GetAxis("Vertical");
    }

    // ABSTRACTION
    protected abstract void OnMove();

    public enum VehicleType
    {
        CAR = 0, 
        PLANE = 1
    }
}
