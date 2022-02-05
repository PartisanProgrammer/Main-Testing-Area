using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class TrackableT<T> : ScriptableObject
{

    [SerializeField] protected T _value;
    [HideInInspector] public UnityEvent<T> CallbackOnValueChanged;

    public T Value
    {
        get
        {
            return _value;
        }
        set
        {
            _value = value;
            CallbackOnValueChanged.Invoke(_value);
        }
    }
}
