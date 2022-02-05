using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[CreateAssetMenu(fileName = "New Transform", menuName = "Global Variables/Transform")]
public class TransformSO : ScriptableObject{

    [SerializeField] public Vector3 position;
    [SerializeField] public Vector3 localScale;
    [SerializeField] public Vector3 lossyScale;
    [SerializeField] public Quaternion rotation;
}
