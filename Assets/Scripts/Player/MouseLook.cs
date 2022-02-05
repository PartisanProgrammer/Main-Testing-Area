using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseLook : MonoBehaviour{
    [SerializeField] FloatVariableSO mouseSensitivity;

    [SerializeField] Transform playerTransform;

    float xRotation = 0f;

    void Start(){
        Cursor.lockState = CursorLockMode.Locked;
    }

    void Update(){
        float mouseX = Input.GetAxis("Mouse X") * mouseSensitivity.RuntimeValue * Time.deltaTime;
        float mouseY = Input.GetAxis("Mouse Y") * mouseSensitivity.RuntimeValue * Time.deltaTime;
        xRotation -= mouseY;
        xRotation = Mathf.Clamp(xRotation, -90f, 90f);
        transform.localRotation = Quaternion.Euler(xRotation, 0f, 0f);
        playerTransform.Rotate(Vector3.up * mouseX);
        
    }
}
