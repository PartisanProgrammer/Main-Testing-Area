using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[CreateAssetMenu(fileName = "New Movement Speed Object", menuName = "Character/Advanced Character/Movement Speed")]
public class MovementSpeedSO : AdvancedCharacterComponentSO{
    [Header("In Game Values")]
    [SerializeField] public float currentSpeed;
    [SerializeField] public float maxSpeed;
    [SerializeField] public float sprintSpeed;
    [SerializeField] public Vector3 velocity;
    
    [Header("Reset Values")]
    [SerializeField] public float baseSpeed;
    [SerializeField] public float baseMaxSpeed;
    [SerializeField] public float baseSprintSpeed;

    void OnEnable(){
        currentSpeed = baseSpeed;
        maxSpeed = baseMaxSpeed;
        velocity = Vector3.zero;
        sprintSpeed = baseSprintSpeed;
    }
}
