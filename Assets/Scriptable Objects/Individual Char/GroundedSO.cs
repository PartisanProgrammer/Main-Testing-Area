using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[CreateAssetMenu(fileName = "New Grounded Object", menuName = "Character/Individual Character/Grounded")]
public class GroundedSO : ScriptableObject{ 
    [SerializeField] public float maxTimeSinceGrounded; 
    public bool isGrounded;
    [Min(0f)]public float timeSinceGrounded;

    void OnEnable(){
        timeSinceGrounded = 0;
        isGrounded = false;
    }
}
