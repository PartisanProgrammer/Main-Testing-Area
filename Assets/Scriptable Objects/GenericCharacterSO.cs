using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[CreateAssetMenu(fileName = "New Generic Character", menuName = "Character/Generic Character")]
public class GenericCharacterSO : ScriptableObject
{
    //Identifier Object - Name, ID
    [SerializeField] public IdentifierSO identifierSo;
    
}
