using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

[CreateAssetMenu(fileName = "New Damage Data",menuName = "Character/Damage")]
public class DamageSO : ScriptableObject{
    [Header("In Game Values")]
    [Min(0)][SerializeField] public int minDamage;
    [Min(0)][SerializeField] public int maxDamage;
    
    [Header("Reset Values")]
    [Min(0)][SerializeField] public int baseMinDamage;
    [Min(0)][SerializeField] public int baseMaxDamage;
    [SerializeField] List<DamageTypeSO> damageTypes;
    
    [Min(0)]int damage;

    int Damage{
        get{ return damage = Random.Range(minDamage, maxDamage+1); }
    }

    void OnEnable(){
        minDamage = baseMinDamage;
        maxDamage = baseMaxDamage;
    }
}
