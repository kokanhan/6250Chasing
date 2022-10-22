using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControlRoomMove : MonoBehaviour
{
    public GameObject cameraM;

    // Update is called once per frame
    void Update()
    {
        transform.rotation = Quaternion.Euler(0, cameraM.GetComponent<TankCam>().yRotation-90, 0);
    }
}
