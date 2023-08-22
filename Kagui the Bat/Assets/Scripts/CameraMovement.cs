using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovement : MonoBehaviour
{
    public float camerSpeed;

    // Update is called once per frame
    void Update()
    {
        // Move the camera automatically in every frame
        transform.position += new Vector3 (camerSpeed * Time.deltaTime, 0, 0);
    }
}
