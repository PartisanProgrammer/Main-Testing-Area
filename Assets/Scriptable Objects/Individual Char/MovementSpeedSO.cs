using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[CreateAssetMenu(fileName = "New Movement Speed Object", menuName = "Character/Movement Speed")]
public class MovementSpeedSO : ScriptableObject{
    [Header("In Game Values")]
    [SerializeField] public float currentSpeed;
    [SerializeField] public float maxSpeed;
    
    [Header("Reset Values")]
    [SerializeField] public float baseSpeed;
    [SerializeField] public float baseMaxSpeed;

    void OnEnable(){
        currentSpeed = baseSpeed;
        maxSpeed = baseMaxSpeed;
    }
}
