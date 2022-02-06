using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[CreateAssetMenu(fileName = "New Non Individual Character", menuName = "Character/Non Individual Character")]
public class GenericCharacterSO : ScriptableObject
{
    [Header("Basics")]
    //Identifier Object - Name, ID
    [SerializeField] public IdentifierSO identifierSo;
    
    //Gravity Object
    [SerializeField] public GravitySO gravitySo;
    
}
