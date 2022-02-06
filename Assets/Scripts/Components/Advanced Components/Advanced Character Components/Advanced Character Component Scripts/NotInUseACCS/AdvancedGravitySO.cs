using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AdvancedGravitySO : AdvancedCharacterComponentSO
{
    [SerializeField] public float gravity;
    [SerializeField] float baseGravity;

    void OnEnable(){
        gravity = baseGravity;
    }
}
