using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[CreateAssetMenu(fileName = "New Health Object",menuName = "Character/Health")]
public class HealthSO : ScriptableObject{
    [Header("In Game Values")]
    [Min(0)] public int currentHealth;
    [Min(0)] public int maxHealth;
    
    [Header("Reset Values")]
    [Min(0)][SerializeField] int baseMaxHealth;


    void OnEnable(){
        currentHealth = baseMaxHealth;
        maxHealth = baseMaxHealth;
    }
}
