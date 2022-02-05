using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerSprint : MonoBehaviour{

    [SerializeField] IndividualCharacterSO characterSo;
    MovementSpeedSO movementSpeedSo;
    void Awake(){
         movementSpeedSo = characterSo.movementSpeedSo;
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
