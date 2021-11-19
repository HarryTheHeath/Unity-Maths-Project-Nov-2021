using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Transform player;
    public float CameraHeightOffset = 0.06f;
    public float CameraPositionOffset = 1;
    public GameObject target;
    
    void Update()
    {
        if (target != null)
        {
            var cameraCoordinates = transform.position;
            var targetCoordinates = target.transform.position;
            var newCameraCoordinates = Vector3.Lerp(cameraCoordinates, targetCoordinates, 0.01f);
            transform.position = new Vector3(newCameraCoordinates.x, newCameraCoordinates.y + CameraHeightOffset, newCameraCoordinates.z);
        }
    }
}
