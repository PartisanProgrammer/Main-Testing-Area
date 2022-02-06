using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[CreateAssetMenu(fileName = "New Base Health Object",menuName = "Character/Simple Character/Base Health")]
public class BaseHealthSO : SimpleCharacterComponentSO
{
    [Header("Basic Values")]
    [Min(0)] [SerializeField] public int maxHealth;
    
    [Header("Reset Values")]
    [Min(0)][SerializeField] protected int baseMaxHealth;


    void OnEnable(){
        maxHealth = baseMaxHealth;
    }

}
