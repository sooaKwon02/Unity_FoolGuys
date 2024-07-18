using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuCharater : MonoBehaviour
{
    public float rotationSpeed;
    private void Update()
    {
        if (Input.GetKey(KeyCode.RightArrow))
        { transform.Rotate(new Vector3(0, 1, 0) * -rotationSpeed * Time.deltaTime); }
        if (Input.GetKey(KeyCode.LeftArrow))
        { transform.Rotate(new Vector3(0, 1, 0) * rotationSpeed * Time.deltaTime); }
    }
    
}
