using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerJump : MonoBehaviour{
    [SerializeField] IndividualCharacterSO characterSo;

    JumpSO _jumpSo;

    void Awake(){
        _jumpSo = characterSo.jumpSo;
    }

    void Update(){
        if (Input.GetButton("Jump") ){
            _jumpSo.jumpCharge += Time.deltaTime / _jumpSo.jumpChargeTime;
            if (characterSo.groundedSo.timeSinceGrounded < characterSo.groundedSo.maxTimeSinceGrounded){
                _jumpSo.jumpHeight = Mathf.Lerp(_jumpSo.minJumpHeight, _jumpSo.maxJumpHeight, _jumpSo.jumpCharge);
                characterSo.movementSpeedSo.velocity.y = Mathf.Sqrt(characterSo.jumpSo.jumpHeight * -2 * characterSo.gravitySo.gravity);
            }

            _jumpSo.jumpCharge = 0f;

        }
    }
}
