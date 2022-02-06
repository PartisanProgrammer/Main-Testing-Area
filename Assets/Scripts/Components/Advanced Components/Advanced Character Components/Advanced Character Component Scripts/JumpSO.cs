using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[CreateAssetMenu(fileName = "New Jump Data", menuName = "Character/Advanced Character/Jump Data")]
public class JumpSO : AdvancedCharacterComponentSO{
    [Header("In Game Values")]
    [SerializeField] public float minJumpHeight;
    [SerializeField] public float maxJumpHeight;
    [SerializeField] public float jumpChargeTime;
    [SerializeField] public float jumpCharge;
    public float jumpHeight;
    

    [Header("Reset Values")] 
    [SerializeField] float baseMinJumpHeight;
    [SerializeField] float baseMaxJumpHeight;
    [SerializeField] float baseJumpChargeTime;

    void OnEnable(){
        jumpHeight = 0f;
        minJumpHeight = baseMinJumpHeight;
        maxJumpHeight = baseMaxJumpHeight;
        jumpChargeTime = baseJumpChargeTime;
        jumpCharge = 0;
        
    }
}
