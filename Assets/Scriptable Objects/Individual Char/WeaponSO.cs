using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;


public abstract class WeaponSO : ScriptableObject{
    [Header("Base Weapon Stats")]
    [SerializeField] public int minDamage;
    [SerializeField] public int maxDamage;
    [SerializeField] public float range;
    [SerializeField] public DamageTypeSO damageTypeSo;
    

    public int Damage{
        get{
            return Random.Range(minDamage, maxDamage + 1);
        }
    }
    
    [Header("Reset Values")]
    [SerializeField] public int baseMinDamage;
    [SerializeField] public int baseMaxDamage;
    [SerializeField] public float baseRange;

    void OnEnable(){
        minDamage = baseMinDamage;
        maxDamage = baseMaxDamage;
        range = baseRange;
    }
}
