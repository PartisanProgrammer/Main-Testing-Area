using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour{
    [SerializeField] AdvancedCharacterSO characterSo;

    CharacterController _characterController;

    GroundedSO _groundedSo;
    MovementSpeedSO _movementSpeedSo;
    GravitySO _gravitySo;
    
    void Awake(){
        _characterController = GetComponent<CharacterController>();
        _groundedSo = characterSo.GetComponent<GroundedSO>();
        _movementSpeedSo = characterSo.GetComponent<MovementSpeedSO>();
        _gravitySo = characterSo.GetComponent<GravitySO>();
    }

    void Update(){

        if (_groundedSo.isGrounded && _movementSpeedSo.velocity.y < 0){
            _movementSpeedSo.velocity.y = -2f;
        }
        
        float x = Input.GetAxis("Horizontal");
        float z = Input.GetAxis("Vertical");

        Vector3 move = transform.right*x + transform.forward * z;
        if (move.magnitude > 1){
            move /= move.magnitude;
        }
        _characterController.Move(move * _movementSpeedSo.currentSpeed * Time.deltaTime);

        _movementSpeedSo.velocity.y += _gravitySo.gravity * Time.deltaTime;
        _characterController.Move(_movementSpeedSo.velocity * Time.deltaTime);

    }
}
