using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[CreateAssetMenu(fileName = "New Health Object",menuName = "Character/Advanced Character/Health")]
public class HealthSO : AdvancedCharacterComponentSO{
    [Header("In Game Values")]
    [Min(0)] public int maxHealth;
    [Min(0)] public int currentHealth;
    
    [Header("Reset Values")]
    [Min(0)][SerializeField] protected int baseMaxHealth;
   
    void OnEnable(){
        currentHealth = baseMaxHealth;
        maxHealth = baseMaxHealth;
    }
}
