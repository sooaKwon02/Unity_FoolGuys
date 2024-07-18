using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SlideWheelController : MonoBehaviour
{
    private readonly float rotationSpeed = 50.0f;

    public bool reverse = false;

    private void Update()
    {
        if (reverse == false)
        {
            transform.Rotate(new Vector3(0, rotationSpeed * Time.deltaTime, 0));
        }

        else
        {
            transform.Rotate(new Vector3(0, -rotationSpeed * Time.deltaTime, 0));
        }
    }
}