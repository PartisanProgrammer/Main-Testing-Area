using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerJump : MonoBehaviour{
    [SerializeField] AdvancedCharacterSO characterSo;

    JumpSO _jumpSo;
    GroundedSO _groundedSo;
    MovementSpeedSO _movementSpeedSo;
    GravitySO _gravitySo;

    void Awake(){
        _jumpSo = characterSo.GetComponent<JumpSO>();
        _groundedSo = characterSo.GetComponent<GroundedSO>();
        _movementSpeedSo = characterSo.GetComponent<MovementSpeedSO>();
        _gravitySo = characterSo.GetComponent<GravitySO>();
    }

    void Update(){
        if (Input.GetButton("Jump") ){
            _jumpSo.jumpCharge += Time.deltaTime / _jumpSo.jumpChargeTime;
            if (_groundedSo.timeSinceGrounded < _groundedSo.maxTimeSinceGrounded){
                _jumpSo.jumpHeight = Mathf.Lerp(_jumpSo.minJumpHeight, _jumpSo.maxJumpHeight, _jumpSo.jumpCharge);
                _movementSpeedSo.velocity.y = Mathf.Sqrt(_jumpSo.jumpHeight * -2 * _gravitySo.gravity);
            }

            _jumpSo.jumpCharge = 0f;

        }
    }
}
