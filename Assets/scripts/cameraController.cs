using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cameraController : MonoBehaviour
{
    [SerializeField]
    float mouseSensifity = 100f;
    Transform playerBody;
    float xRotation = 0f;

    private void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
        playerBody = transform.parent;
    }

    private void Update()
    {
        CameraRotation();
    }

    private void CameraRotation()
    {
        float mouseX = Input.GetAxis("Mouse X") * mouseSensifity * Time.deltaTime;
        float mouseY = Input.GetAxis("Mouse Y") * mouseSensifity * Time.deltaTime;
        xRotation -= mouseY;
        xRotation = Mathf.Clamp(xRotation, -90f, 80f);
        transform.localRotation = Quaternion.Euler(xRotation, 0f, 0f);

        playerBody.Rotate(Vector3.up * mouseX);
    }
}
