using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[CreateAssetMenu(fileName = "New Gun",menuName = "Weapon/Gun")]
public class GunSO : WeaponSO{
    [Header("Base Gun Stats")] 
    [SerializeField] public float fireRate;
    [SerializeField] public int currentAmmo;
    [SerializeField] public int maxAmmo;
    
    [Header("Reset Values")] 
    [SerializeField] public float baseFireRate;
    [SerializeField] public int baseMaxAmmo;

    void OnEnable(){
        fireRate = baseFireRate;
        currentAmmo = baseMaxAmmo;
        maxAmmo = baseMaxAmmo;
    }
}
