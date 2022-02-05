using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour{
    [SerializeField] IndividualCharacterSO characterSo;

    CharacterController _characterController;

    void Awake(){
        _characterController = GetComponent<CharacterController>();
    }

    void Update(){
        float x = Input.GetAxis("Horizontal");
        float z = Input.GetAxis("Vertical");

        Vector3 move = transform.right*x + transform.forward * z;
        _characterController.Move(move * characterSo.movementSpeedSo.currentSpeed * Time.deltaTime);

        characterSo.movementSpeedSo.velocity.y += characterSo.gravitySo.gravity * Time.deltaTime;
        _characterController.Move(characterSo.movementSpeedSo.velocity * Time.deltaTime);

    }
}
