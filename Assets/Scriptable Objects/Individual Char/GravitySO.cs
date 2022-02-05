using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[CreateAssetMenu(fileName = "New Gravity Object", menuName = "Global Variables/Gravity")]
public class GravitySO : ScriptableObject{
    [SerializeField] public float gravity;
    [SerializeField] float baseGravity;

    void OnEnable(){
        gravity = baseGravity;
    }
}
