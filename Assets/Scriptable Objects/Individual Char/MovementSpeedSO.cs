using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[CreateAssetMenu(fileName = "New Movement Speed Object", menuName = "Character/Individual Character/Movement Speed")]
public class MovementSpeedSO : ScriptableObject{
    [Header("In Game Values")]
    [SerializeField] public float currentSpeed;
    [SerializeField] public float maxSpeed;
    [SerializeField] public Vector3 velocity;
    
    [Header("Reset Values")]
    [SerializeField] public float baseSpeed;
    [SerializeField] public float baseMaxSpeed;

    void OnEnable(){
        currentSpeed = baseSpeed;
        maxSpeed = baseMaxSpeed;
        velocity = Vector3.zero;
    }
}
