using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[DisallowMultipleComponent]
public class TransformUpdater : MonoBehaviour{

    [SerializeField] AdvancedCharacterSO characterSo;
    TransformSO transformSo;

     void Awake(){
         transformSo = characterSo.GetComponent<TransformSO>();
     }

     void Update()
    {
        transformSo.position = transform.position;
        transformSo.rotation = transform.rotation;
        transformSo.localScale = transform.localScale;
        transformSo.lossyScale = transform.lossyScale;

    }
}
