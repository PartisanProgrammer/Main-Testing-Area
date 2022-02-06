using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[CreateAssetMenu(fileName = "New Gravity Object", menuName = "Character/Simple Character/Global Variables/Gravity")]
public class GravitySO : SimpleCharacterComponentSO{
    [SerializeField] public float gravity;
    [SerializeField] float baseGravity;

    void OnEnable(){
        gravity = baseGravity;
    }
}
