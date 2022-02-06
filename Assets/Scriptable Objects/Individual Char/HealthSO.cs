using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[CreateAssetMenu(fileName = "New Health Object",menuName = "Character/Individual Character/Health")]
public class HealthSO : BaseHealthSO{
    [Header("In Game Values")]
    [Min(0)] public int currentHealth;
   
    void OnEnable(){
        currentHealth = baseMaxHealth;
        
    }
}
