using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[CreateAssetMenu(fileName = "New Grounded Object", menuName = "Character/Advanced Character/Grounded")]
public class GroundedSO : AdvancedCharacterComponentSO{ 
    [SerializeField] public float maxTimeSinceGrounded; 
    public bool isGrounded;
    [Min(0f)]public float timeSinceGrounded;

    void OnEnable(){
        timeSinceGrounded = 0;
        isGrounded = false;
    }
}
