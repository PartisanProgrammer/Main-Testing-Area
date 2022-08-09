using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class TrackableT<T> : ScriptableObject
{

    [SerializeField] protected T _value;
    [HideInInspector] public UnityEvent<T> CallbackOnValueChangedEvent;

    public T Value
    {
        get
        {
            return _value;
        }
        set
        {
            _value = value;
            CallbackOnValueChangedEvent.Invoke(_value);
        }
    }

    void OnEnable(){
        CallbackOnValueChangedEvent = new UnityEvent<T>();
    }
}
