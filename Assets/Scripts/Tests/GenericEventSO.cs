using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class GenericEventSO<T> : ScriptableObject{
    [SerializeField] UnityEvent<T> genericEvent;

    void OnEnable(){
        if (genericEvent == null){
            genericEvent = new UnityEvent<T>();
        }
    }
}
