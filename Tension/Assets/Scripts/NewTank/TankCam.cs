using System.Collections;
using System.Collections.Generic;

using UnityEngine;

public class TankCam : MonoBehaviour
{

    public float sensX;
    public float sensY;

    public Transform oreintation;

    float xRotation;
    [Header("do not touch")]
    public float yRotation;
    // Start is called before the first frame update


    //empty objects tracking the direction that player is facing
    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
    }

    // Update is called once per frame
    void Update()
    {
        //*****************************************************************************
        // It's confusing, but this is how unity tells user to handle the rotation.
        // I will figure out later.
        float mouseX = Input.GetAxisRaw("Mouse X") * Time.deltaTime * sensX;
        float mouseY = Input.GetAxisRaw("Mouse Y") * Time.deltaTime * sensY;

        yRotation += mouseX;
        xRotation -= mouseY;
        //xRotation = Mathf.Clamp(xRotation, -90f, 90f);// totally you can rotate 180 degrees
        xRotation = Mathf.Clamp(xRotation, -90f, 45f);

        // Rotate cam and orientation
        transform.rotation = Quaternion.Euler(xRotation, yRotation, 0);
        oreintation.rotation = Quaternion.Euler(0, yRotation, 0);
        //*****************************************************************************
    }
}
