using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JoystickPlayerExample : MonoBehaviour
{
    [SerializeField]

    public float speed;
    public VariableJoystick variableJoystick;
    public Rigidbody2D rigidbody;
    public Vector2 move;

    public void FixedUpdate()
    {
        move.x = variableJoystick.Horizontal;
        move.y = variableJoystick.Vertical;


        rigidbody.position = (rigidbody.position + move * speed * Time.deltaTime);

    }
}