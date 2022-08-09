using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IDamageable{
    public void TakeDamage(int amount);
}

public interface IHealable{
    public void Heal(int amount);
}
public class Health : MonoBehaviour, IDamageable, IHealable{

    [SerializeField] BaseHealthSO baseHealthSo;

    int currentHealth;
    bool isAlive = true;

    public bool IsAlive{
        get => isAlive;
        private set{
            CheckIfDead();
        }
    }

    public int CurrentHealth{
        get => currentHealth;
        private set{
            currentHealth = Mathf.Clamp(value, 0, baseHealthSo.maxHealth);
        }
    }

    void Awake(){
        CurrentHealth = baseHealthSo.maxHealth;
    }

    public void TakeDamage(int damage){
        CurrentHealth -= damage;
        if (CurrentHealth == 0){
            IsAlive = false;
        }
        Debug.Log(transform.name + CurrentHealth);
    }

    // int CalculateDamage(int amount, DamageTypeSO damageTypeSo){
    //     foreach (var VARIABLE in COLLECTION){
    //         
    //     }
    //     //Foreach damageTypeSo in Vulnerabilities List
    //     //if damageTypeSo == damageTypeSo
    //     //amount *= effectiveDamageTypeModifier;
    //     return amount;
    // }

    public void Heal(int amount){
        CurrentHealth += amount;
       
    }
    
    void CheckIfDead(){
        if (CurrentHealth == 0){
            isAlive = false;
            this.gameObject.SetActive(false);
        }
    }
}
