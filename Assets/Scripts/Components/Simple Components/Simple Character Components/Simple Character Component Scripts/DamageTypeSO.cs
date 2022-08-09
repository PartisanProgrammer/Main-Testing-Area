using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[CreateAssetMenu(fileName = "New Damage Type", menuName = "Character/Damage Type")]
public class DamageTypeSO : ScriptableObject{
    public Color32 color;
    public float effectiveDamageTypeModifier;
}
