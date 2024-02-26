using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SnowMovement : MonoBehaviour
{
    Rigidbody2D rb;
    [SerializeField] float TorqueAmount = 6f;
    SurfaceEffector2D sfeffector;
    [SerializeField] float Torque_speed = 40;
    [SerializeField] float Torque_Base = 20;
    bool canMove = true;

    // Start is called before the first frame update
    void Start()
    {

        sfeffector = GetComponent<SurfaceEffector2D>();
        rb = GetComponent<Rigidbody2D>();
        sfeffector = FindObjectOfType<SurfaceEffector2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (canMove)
        {
            Movement();
            RespondToBoost();
        }
    }

    private void RespondToBoost()
    {
        if (Input.GetKey(KeyCode.D)) 
        {
            sfeffector.speed = Torque_speed;
        }
        else { sfeffector.speed = Torque_Base; }
    }
    public void MovementStopped()
    {
            canMove = false;
    }

    private void Movement()
    {
        if (Input.GetKey(KeyCode.D))
        {
            rb.AddTorque(-TorqueAmount);
            Debug.Log("torque");
        }
        else if (Input.GetKey(KeyCode.A))
        {
            rb.AddTorque(TorqueAmount);
            Debug.Log("negative torque");
        }
    }
}


