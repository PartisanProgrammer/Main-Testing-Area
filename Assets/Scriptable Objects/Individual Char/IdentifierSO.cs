using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[CreateAssetMenu(fileName = "New Identifier", menuName = "Global Variables/Identifier")]
public class IdentifierSO : ScriptableObject
{
    //This class will be used simply to tell other objects what this object is, AKA a Player or Blue Worm etc
    [SerializeField] string name;
}
