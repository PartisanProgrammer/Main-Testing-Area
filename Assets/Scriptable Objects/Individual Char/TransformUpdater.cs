using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[DisallowMultipleComponent]
public class TransformUpdater : MonoBehaviour{
    [SerializeField] TransformSO transformSo;
    
    
    void Update()
    {
        transformSo.position = transform.position;
        transformSo.rotation = transform.rotation;
        transformSo.localScale = transform.localScale;
        transformSo.lossyScale = transform.lossyScale;

    }
}
