using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerSprint : MonoBehaviour{

    [SerializeField] AdvancedCharacterSO characterSo;
    MovementSpeedSO movementSpeedSo;
    void Awake(){
        movementSpeedSo = characterSo.GetComponent<MovementSpeedSO>();
    }

    void Update(){
        if (Input.GetKey(KeyCode.LeftShift)){
            movementSpeedSo.currentSpeed = movementSpeedSo.sprintSpeed;
        }
        else{
            movementSpeedSo.currentSpeed = movementSpeedSo.baseSpeed;
        }
    }
}
