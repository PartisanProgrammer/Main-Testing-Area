using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[CreateAssetMenu(fileName = "New Float Variable", menuName = "Global Variables/Float Variable")]
public class FloatVariableSO : ScriptableObject{
    [SerializeField] float initialValue;

    [NonSerialized] public float RuntimeValue;


    void OnEnable(){
        RuntimeValue = initialValue;
    }
}
